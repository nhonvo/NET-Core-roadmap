using StudentManagement.ConsoleApp.Models.StudentViewModel;
using StudentManagement.ConsoleApp.Repository;

namespace StudentManagement.ConsoleApp.LogicTier
{
    public class StudentLogicTier
    {

        StudentRepository _studentRepository = new StudentRepository();

        public async Task<StudentDTO> InputStudent()
        {
            Console.Write("Enter student name: ");
            string studentName = Console.ReadLine();

            Console.Write("Enter grade Id: ");
            int gradeId = int.Parse(Console.ReadLine());

            StudentDTO studentDTO = new StudentDTO
            {
                Name = studentName,
                GradeId = gradeId
            };

            return studentDTO;
        }

        public async Task Add(StudentDTO studentDTO)
        {
            Student student = new Student
            {
                Name = studentDTO.Name,
                GradeId = studentDTO.GradeId
            };

            await _studentRepository.AddAsync(student);
            await _studentRepository.CommitAsync();
        }

        public async Task DeleteStudent(int studentId)
        {
            try
            {
                _studentRepository.Delete(studentId);
                await _studentRepository.CommitAsync();
                Console.WriteLine($"Student with Id {studentId} deleted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting student with Id {studentId}: {ex.Message}");
            }
        }

        public async Task UpdateStudent(int studentId, StudentDTO studentDTO)
        {
            try
            {
                var student = await _studentRepository.GetByIdAsync(studentId);
                if (student == null)
                {
                    Console.WriteLine($"Student with Id {studentId} not found.");
                    return;
                }

                student.Name = studentDTO.Name;
                student.GradeId = studentDTO.GradeId;

                _studentRepository.Update(student);
                await _studentRepository.CommitAsync();

                Console.WriteLine($"Student with Id {studentId} updated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating student with Id {studentId}: {ex.Message}");
            }
        }

        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            try
            {
                var students = await _studentRepository.GetListAsync(includeProperties: "Grade, Address, StudentCourses.Course");
                if (students.Count() == 0)
                {
                    Console.WriteLine("No students found.");
                }
                else
                {
                    Console.WriteLine("All students:");
                    foreach (var student in students)
                    {
                        Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Grade: {student.Grade.Name}, Address: {student.Address?.ToString() ?? "N/A"}");
                        Console.WriteLine("Courses:");
                        foreach (var studentCourse in student.StudentCourses)
                        {
                            Console.WriteLine($"\t{studentCourse.Course.Name}");
                        }
                    }
                }
                return students;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving students: {ex.Message}");
                return new List<Student>();
            }
        }

        public async Task<Student> GetStudentById(int studentId)
        {
            try
            {
                var student = await _studentRepository.GetByIdAsync(studentId);
                if (student == null)
                {
                    Console.WriteLine($"Student with Id {studentId} not found.");
                }
                else
                {
                    Console.WriteLine($"Student with Id {studentId}: Name = {student.Name}, Grade = {student.Grade.Name}, Address = {student.Address?.ToString() ?? "N/A"}");
                    Console.WriteLine("Courses:");
                    foreach (var studentCourse in student.StudentCourses)
                    {
                        Console.WriteLine($"\t{studentCourse.Course.Name}");
                    }
                }
                return student;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving student with Id {studentId}: {ex.Message}");
                return null;
            }
        }
    }
}