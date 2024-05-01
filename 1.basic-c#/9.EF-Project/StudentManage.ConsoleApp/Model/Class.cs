public class Class
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<Student> Students { get; set; }
}
