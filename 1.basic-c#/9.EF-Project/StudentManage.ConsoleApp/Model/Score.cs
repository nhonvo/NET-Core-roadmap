public class Score
{
    public int ID { get; set; }
    public int StudentID { get; set; }
    public Student Student { get; set; }
    public int SubjectID { get; set; }
    public Subject Subject { get; set; }
    public decimal ScoreValue { get; set; }
}
