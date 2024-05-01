public class Program
{
    private static void Main(string[] args)
    {
        Student student = new Student();
        student.SetName("Nhon");
        student.SetGPA(10);
        Console.WriteLine(student.GetName() + " " + student.GetGPA());
    }

}