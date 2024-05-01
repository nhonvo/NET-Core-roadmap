using StudentManagement.ConsoleApp.Models.StudentViewModel;

namespace StudentManagement.ConsoleApp.Models.GradeViewModel
{
    public class Grade
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Section { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
