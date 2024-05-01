
using StudentManageList.Core.Models.GradeViewModel;
using StudentManageList.Core.Models.StudentAddressViewModel;
using StudentManageList.Core.Models.StudentCourseViewModel;

namespace StudentManageList.Core.Models.StudentViewModel
{
    public interface IEntity
    {
        int Id { get; set; }
    }

    public class Student : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GradeId { get; set; }
        public Grade Grade { get; set; }
        public StudentAddress Address { get; set; }
        public IList<StudentCourse> StudentCourses { get; set; }
    }
}
