class Program
{
    public static bool CheckingContainsSubstring(string text)
    {
        return text.Contains("Hello");
    }
    public static void Main(string[] args)
    {
        string text = "Hello,world!";
        System.Console.WriteLine(CheckingContainsSubstring(text) ? "true" : "false");
    }
}
