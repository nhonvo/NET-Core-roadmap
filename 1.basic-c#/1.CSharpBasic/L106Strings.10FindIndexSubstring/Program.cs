class Program
{
    public static int FindIndexSubstring(string text)
    {
        return text.IndexOf("world");
    }
    public static void Main(string[] args)
    {
        string text = "Hello, world!";
        System.Console.WriteLine(FindIndexSubstring(text));
    }
}