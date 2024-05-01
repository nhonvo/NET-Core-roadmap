using StudentManagement.ConsoleApp.Repository;
using StudentManagement.ConsoleApp.Models.CourseViewModel;

namespace StudentManagement.ConsoleApp.LogicTier
{
    public class CourseLogicTier
    {
        CourseRepository _courseRepository = new CourseRepository();
        public CourseDTO Input()
        {

            Console.Write("Enter course name: ");
            string courseName = Console.ReadLine();

            Console.Write("Enter course description (optional): ");
            string courseDescription = Console.ReadLine();
            CourseDTO courseDTO = new CourseDTO
            {
                Name = courseName,
                Description = courseDescription
            };
            return courseDTO;
        }
        public async Task Add(CourseDTO courseDTO)
        {
            Course course = new Course
            {
                Name = courseDTO.Name,
                Description = courseDTO.Description
            };

            await _courseRepository.AddAsync(course);
            await _courseRepository.CommitAsync();
        }
        public async Task Delete(int courseId)
        {
            try
            {
                _courseRepository.Delete(courseId);
                await _courseRepository.CommitAsync();
                Console.WriteLine($"Course with Id {courseId} deleted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting course with Id {courseId}: {ex.Message}");
            }
        }
        public async Task Update(int courseId, CourseDTO courseDTO)
        {
            try
            {
                var course = await _courseRepository.GetByIdAsync(courseId);
                if (course == null)
                {
                    Console.WriteLine($"Course with Id {courseId} not found.");
                    return;
                }

                course.Name = courseDTO.Name;
                course.Description = courseDTO.Description;

                _courseRepository.Update(course);
                await _courseRepository.CommitAsync();

                Console.WriteLine($"Course with Id {courseId} updated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating course with Id {courseId}: {ex.Message}");
            }
        }

        public async Task<IEnumerable<Course>> Get()
        {
            try
            {
                var courses = await _courseRepository.GetListAsync();
                if (courses.Count() == 0)
                {
                    Console.WriteLine("No courses found.");
                }
                else
                {
                    Console.WriteLine("All courses:");
                    foreach (var course in courses)
                    {
                        Console.WriteLine($"Id: {course.Id}, Name: {course.Name}, Description: {course.Description}");
                    }
                }
                return courses;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving courses: {ex.Message}");
                return new List<Course>();
            }
        }

        public async Task<Course> Get(int courseId)
        {
            try
            {
                var course = await _courseRepository.GetByIdAsync(courseId);
                if (course == null)
                {
                    Console.WriteLine($"Course with Id {courseId} not found.");
                }
                else
                {
                    Console.WriteLine($"Course with Id {courseId}: Name = {course.Name}, Description = {course.Description}");
                }
                return course;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving course with Id {courseId}: {ex.Message}");
                return null;
            }
        }
    }
}