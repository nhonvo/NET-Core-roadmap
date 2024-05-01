class Program
{
    public static void FormatException()
    {
        string text = "abc";
        try
        {
            int number = Convert.ToInt32(text);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input");
        }
    }
    public static void Main(string[] args)
    {
        FormatException();
    }
}
