class Program
{
    public static string TrimWhitespace(string text)
    {
        return text.Trim(' ');
    }
    public static void Main(string[] args)
    {
        string text = " Hello, world! ";
        System.Console.WriteLine(TrimWhitespace(text));
    }
}