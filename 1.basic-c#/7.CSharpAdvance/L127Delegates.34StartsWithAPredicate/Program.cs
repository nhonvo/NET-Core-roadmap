using Microsoft.VisualBasic;

class Program
{

    public delegate bool StartWithAPredicate(string[] text);
    public static bool StartWithA(string[] text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i].StartsWith('a'))
            {
                return true;
            }
        }
        return false;
    }
    public static void Main()
    {
        StartWithAPredicate startWithA = StartWithA;
        string[] array = { "array", "bray"};
        System.Console.WriteLine(StartWithA(array));

    }

}