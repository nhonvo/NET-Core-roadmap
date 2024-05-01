class Program
{
    public static void PrintString(string text) { Console.WriteLine($"{text}"); }
    public static void Main()
    {
        Action<string> action = PrintString;
        string text = "abc";
        PrintString(text);
    }
}