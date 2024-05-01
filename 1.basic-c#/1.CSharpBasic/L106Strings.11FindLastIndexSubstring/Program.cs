class Program
{
    public static int FindIndexLastSubstring(string text)
    {
        return text.LastIndexOf("l");
    }
    public static void Main(string[] args)
    {
        string text = "Hello,world!";
        System.Console.WriteLine(FindIndexLastSubstring(text));
    }
}