class Program
{

    delegate bool CompareStrings(string str1, string str2);
    public static void Main()
    {
        CompareStrings compare = string.Equals;
        bool result = compare("hello", "hello");
        Console.WriteLine(result ? "true" : "false");
    }

}