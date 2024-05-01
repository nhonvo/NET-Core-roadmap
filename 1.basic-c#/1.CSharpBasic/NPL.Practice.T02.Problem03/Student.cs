class Student : IGraduate
{
    private int _Id;
    private string _Name;
    private DateTime _StartDate;
    private decimal _SqlMark;
    private decimal _CsharpMark;
    private decimal _DsaMark;
    private decimal _GPA;
    private GraduateLevel _GraduateLevel;
    public Student(int id, string name, DateTime startDate, decimal sqlMark, decimal csharpMark, decimal dsaMark)
    {
        _Id = id;
        _Name = name;
        _StartDate = startDate;
        _SqlMark = sqlMark;
        _CsharpMark = csharpMark;
        _DsaMark = dsaMark;
    }
    public GraduateLevel ConvertMarkToGraduateLevel(decimal gpa)
    {
        switch (gpa)
        {
            case >= 9:
                return GraduateLevel.Excellent;
            case >= 8 and < 9:
                return GraduateLevel.VeryGood;
            case >= 7 and < 8:
                return GraduateLevel.Good;
            case >= 5 and < 7:
                return GraduateLevel.Average;
            case < 5:
                return GraduateLevel.Failed;
        }
    }
    /// <summary>
    /// set gpa by average (_SqlMark + _CsharpMark + _DsaMark) 
    /// and   set graduate level from gpa
    /// </summary>
    public void Graduate()
    {
        _GPA = Math.Round((_SqlMark + _CsharpMark + _DsaMark) / 3m, 2);
        _GraduateLevel = ConvertMarkToGraduateLevel(_GPA);
    }
    public string GetCertificate()
        => $"Name: {_Name}, SqlMark: {_SqlMark}, CsharpMark: {_CsharpMark}, " +
        $"DsaMark: {_DsaMark}, GPA: {_GPA}, Graduate Level: {_GraduateLevel}";

}
