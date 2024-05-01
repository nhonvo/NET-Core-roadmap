using StudentManagement.Core.Models.StudentViewModel;

namespace StudentManagement.Core.Models.GradeViewModel
{
    public class Grade
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Section { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
