class Program
{
    public static int CountLenghString(string text) => text.Length;
    public static void Main()
    {
        Func<string, int> CountLenghStringAction = CountLenghString;
        string text = "truong nhon";
        System.Console.WriteLine(CountLenghStringAction(text));

    }
}