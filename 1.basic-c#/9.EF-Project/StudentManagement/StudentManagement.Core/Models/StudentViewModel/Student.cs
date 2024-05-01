
using StudentManagement.Core.Models.GradeViewModel;
using StudentManagement.Core.Models.StudentAddressViewModel;
using StudentManagement.Core.Models.StudentCourseViewModel;

namespace StudentManagement.Core.Models.StudentViewModel
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GradeId { get; set; }
        public Grade Grade { get; set; }
        public StudentAddress Address { get; set; }
        public IList<StudentCourse> StudentCourses { get; set; }
    }
}
