using StudentManagement.Core.Models.StudentCourseViewModel;

namespace StudentManagement.Core.Models.CourseViewModel
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public IList<StudentCourse>? StudentCourses { get; set; }
    }
}
