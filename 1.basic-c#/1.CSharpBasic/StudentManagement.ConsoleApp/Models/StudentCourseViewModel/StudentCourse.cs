using StudentManagement.ConsoleApp.Models.CourseViewModel;
using StudentManagement.ConsoleApp.Models.StudentViewModel;

namespace StudentManagement.ConsoleApp.Models.StudentCourseViewModel
{
    public class StudentCourse
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}