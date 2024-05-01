class Program
{
    /// <summary>
    /// checking charater from outside to inside
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public static bool CheckPalindrome(string text)
    {
        if (text.Length <= 1) 
            return true;
        else
        {

            if (text[0] != text[text.Length - 1])
                return false;
            else
                return CheckPalindrome(text.Substring(1, text.Length - 2));
        }
    }
    public static void Main(string[] args)
    {
        string text = "abcba";
        System.Console.WriteLine(CheckPalindrome(text) ? "true" : "false");
    }
}