class Program
{
    public static bool CheckingStartSubstring(string text)
    {
        return text.StartsWith("Hello");
    }
    public static void Main(string[] args)
    {
        string text = "Hello,world!";
        System.Console.WriteLine(CheckingStartSubstring(text)?  "true": "false");
    }
}
