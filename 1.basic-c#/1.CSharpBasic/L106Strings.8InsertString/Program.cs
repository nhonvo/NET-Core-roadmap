class Program
{
    public static string InsertString(string text)
    {
        return text.Insert(7, "world");
    }
    public static void Main(string[] args)
    {
        string text = "Hello, !";
        System.Console.WriteLine(InsertString(text));
    }
}