namespace _5.Querying.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }

        public IList<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}