using StudentManagement.ConsoleApp.Models.StudentCourseViewModel;

namespace StudentManagement.ConsoleApp.Models.CourseViewModel
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public IList<StudentCourse>? StudentCourses { get; set; }
    }
}
