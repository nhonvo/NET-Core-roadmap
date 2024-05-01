using StudentManageList.Core.Models.CourseViewModel;
using StudentManageList.Core.Models.StudentViewModel;

namespace StudentManageList.Core.Models.StudentCourseViewModel
{
    public class StudentCourse
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}