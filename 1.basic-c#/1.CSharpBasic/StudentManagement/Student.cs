public class Student
{
    public string Name { get; set; }
    public int RollNumber { get; set; }
    public Dictionary<string, int> MarksObtained { get; set; }
    public Student(string name, int rollNumber, Dictionary<string, int> marksObtained)
    {
        Name = name;
        RollNumber = rollNumber;
        MarksObtained = marksObtained;
    }
}
