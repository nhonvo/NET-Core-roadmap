class Program
{
    public static void SplitString(string text)
    {
        string []array = text.Split(',');
        Console.WriteLine("Array: " + string.Join(", ", array));

    }
    public static void Main(string[] args)
    {
        string text = "Hello, world!";
        SplitString(text);
    }
}
