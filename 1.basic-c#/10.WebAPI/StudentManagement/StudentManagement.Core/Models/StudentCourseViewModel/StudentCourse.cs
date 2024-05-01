using StudentManagement.Core.Models.CourseViewModel;
using StudentManagement.Core.Models.StudentViewModel;

namespace StudentManagement.Core.Models.StudentCourseViewModel
{
    public class StudentCourse
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}