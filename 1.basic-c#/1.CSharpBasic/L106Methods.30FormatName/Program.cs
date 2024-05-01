class Program
{
    public static string FormatName(string firstName, string lastName)
    {
        return $"{lastName}, {firstName}";
    }

    public static void Main(string[] args)
    {
        string firstName = "Nhon";
        string lastName = "Truong";
        Console.WriteLine(FormatName(firstName, lastName));
    }
}