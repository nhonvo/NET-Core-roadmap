class Program
{
    public static string GetFirstLetters(string[] array)
    {
        string text="";
        foreach (string str in array)
        {
            text += str[0];
        }
        return text;
    }

    public static void Main(string[] args)
    {
        string[] array = { "banana", "apple", "tomato" };
        System.Console.WriteLine(GetFirstLetters(array));
    }
}