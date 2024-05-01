class Program
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="grades"></param>
    public static void CheckingStudentGrade(int grades)
    {

        if (grades >= 90) 
            Console.WriteLine("Excellent work!");
        else if (grades > 80 && grades < 89) 
            Console.WriteLine("Good job!");
        else if (grades > 70 && grades > 79) 
            Console.WriteLine("Nice try!");
        else 
            Console.WriteLine("You need more practice!");
    }
    private static void Main(string[] args)
    {
        int grades = 83;

        CheckingStudentGrade(grades);
    }
}