class Program
{
    public static string ReverseString(string str)
    {
        string str1 = "";
        for (int i = str.Length - 1; i >= 0; i--)
        {
            str1 += str[i];
        }
        return str1;
    }
    private static void Main(string[] args)
    {
        string text = "Hello";
        ReverseString(text);
    }
}