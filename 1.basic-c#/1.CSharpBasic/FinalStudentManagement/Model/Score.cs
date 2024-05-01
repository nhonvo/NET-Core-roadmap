public class Score
{
    public Score()
    {
        
    }

    public Score(int iD, int studentID, int subjectID, decimal scoreValue)
    {
        ID = iD;
        StudentID = studentID;
        SubjectID = subjectID;
        ScoreValue = scoreValue;
    }

    public int ID { get; set; }
    public int StudentID { get; set; }
    public int SubjectID { get; set; }
    public decimal ScoreValue { get; set; }
}
