class Program
{
    public static bool IsPalindrome(string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            if (!text[i].Equals(text[text.Length - i -1]))
                return false;
        }
        return true;
    }
    private static void Main(string[] args)
    {
        string text = "racezcar";
        System.Console.WriteLine(IsPalindrome(text) == true ? "true" : "false");
    }
}