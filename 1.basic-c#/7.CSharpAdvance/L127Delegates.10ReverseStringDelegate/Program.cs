class Program
{

    public delegate string ReverseStringDelegate(string x);

    public static string ReverseSrting(string text)
    {
        string newText = "";
        for (int i = text.Length - 1; i >= 0; i--)
        {
            newText += text[i];
        }
        return newText;
    }
    public static void Main(string[] args)
    {
        ReverseStringDelegate reverseString = ReverseSrting;

        Console.WriteLine(reverseString("abcd"));
    }
}