class Program
{
    public static string LowercaseString(string text)
    {
        return text.ToLower();
    }
    public static void Main(string[] args)
    {
        string text = "Hello, world!";
        System.Console.WriteLine(LowercaseString(text));
    }
}