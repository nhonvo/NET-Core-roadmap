
using StudentManagement.ConsoleApp.Models.GradeViewModel;
using StudentManagement.ConsoleApp.Models.StudentAddressViewModel;
using StudentManagement.ConsoleApp.Models.StudentCourseViewModel;

namespace StudentManagement.ConsoleApp.Models.StudentViewModel
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
