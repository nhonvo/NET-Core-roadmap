namespace AdoSql
{
    class Score
    {
        public Score(int iD, int studentID, int subjectID, double scoreValue)
        {
            ID = iD;
            StudentID = studentID;
            SubjectID = subjectID;
            ScoreValue = scoreValue;
        }

        public int ID { get; set; }
        public int StudentID { get; set; }
        public int SubjectID { get; set; }
        public double ScoreValue { get; set; }
    }
}