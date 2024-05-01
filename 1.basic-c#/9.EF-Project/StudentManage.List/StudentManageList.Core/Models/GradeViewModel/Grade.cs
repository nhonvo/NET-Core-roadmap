using StudentManageList.Core.Models.StudentViewModel;

namespace StudentManageList.Core.Models.GradeViewModel
{
    public class Grade
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Section { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
