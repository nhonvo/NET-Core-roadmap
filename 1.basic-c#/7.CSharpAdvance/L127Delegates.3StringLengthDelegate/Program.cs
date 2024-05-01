class Program
{
    public delegate int CountLenghStringDelegate(string text);
    public static int CountLenghString(string text) => text.Length;
    public static void Main()
    {
        CountLenghStringDelegate countLenghString = CountLenghString;
        string text = "truong nhon";
        System.Console.WriteLine(CountLenghString(text));

    }
}