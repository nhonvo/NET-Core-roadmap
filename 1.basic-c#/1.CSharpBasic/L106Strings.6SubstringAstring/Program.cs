class Program
{
    public static string SubstringTheString(string text)
    {
        return text.Substring(7);
    }
    public static void Main(string[] args)
    {
        string text = "Hello, world!";
        System.Console.WriteLine(SubstringTheString(text));
    }
}