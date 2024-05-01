class Program
{
    public static bool CheckingEndSubstring(string text)
    {
        return text.EndsWith("Hello");
    }
    public static void Main(string[] args)
    {
        string text = "Hello,world!";
        System.Console.WriteLine(CheckingEndSubstring(text) ? "true" : "false");
    }
}
