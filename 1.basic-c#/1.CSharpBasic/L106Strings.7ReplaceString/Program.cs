class Program
{
    public static string ReplaceString(string text)
    {
        return text.Replace("world", "you"); 
    }
    public static void Main(string[] args)
    {
        string text = "Hello, world!";
        System.Console.WriteLine(ReplaceString(text));
    }
}