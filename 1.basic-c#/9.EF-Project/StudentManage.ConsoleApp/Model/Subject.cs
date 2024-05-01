public class Subject
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<Score> Scores { get; set; }
}
