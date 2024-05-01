class Program
{
    public static void Main(string[] args)
    {
        Student student = new Student(1, "Nhon", DateTime.Now, 9, 7, 8);
        student.Graduate();
        string text  = student.GetCertificate();
        Console.WriteLine(text);

        Student failStudent = new Student(2, "Hoa", DateTime.Now, 0, 0, 0);
        failStudent.Graduate();
        string  failText = failStudent.GetCertificate();
        Console.WriteLine(failText);

        Student goodStudent = new Student(3, "Mai", DateTime.Now, 8, 8, 7);
        goodStudent.Graduate();
        string goodText = goodStudent.GetCertificate();
        Console.WriteLine(goodText);



    }
}