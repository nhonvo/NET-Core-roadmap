public class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public int ClassID { get; set; }
    public Class Class { get; set; }
    public ICollection<Score> Scores { get; set; }
}
