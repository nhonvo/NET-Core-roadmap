class Program
{
    public static int FindLengthString(string text)
    {
       return text.Length;
    }
    public static void Main(string[] args)
    {
        string text = "Hello, world!";
        System.Console.WriteLine(FindLengthString(text));
    }
}