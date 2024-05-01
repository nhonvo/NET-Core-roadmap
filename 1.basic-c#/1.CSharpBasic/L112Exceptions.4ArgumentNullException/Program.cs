class Program
{
    public static void ArgumentNullException()
    {
        string? number = "";
        number = Console.ReadLine();
        try
        {
            if (String.IsNullOrEmpty(number))
                throw new Exception("Input cannot be empty");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Input cannot be empty");
        }
    }
    public static void Main(string[] args)
    {
        ArgumentNullException();
    }
}
