class Program
{
    public static string UppercaseString(string text)
    {
        return text.ToUpper();
    }
    public static void Main(string[] args)
    {
        string text = "Hello, world!";
        System.Console.WriteLine(UppercaseString(text));
    }
}