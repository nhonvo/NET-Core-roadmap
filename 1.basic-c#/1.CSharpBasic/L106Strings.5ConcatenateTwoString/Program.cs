class Program
{
    public static string ConcatenateTwoString(string First, string Second)
    {
        return First + " " + Second;
    }
    public static void Main(string[] args)
    {
        string First = "Hello,";
        string Second = "world!";
        System.Console.WriteLine(ConcatenateTwoString(First, Second));
    }
}