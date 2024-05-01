class Program
{
    /// <summary>
    /// Count Occurrence the number by substring 1 each loop and compare with input character
    /// </summary>
    /// <param name="text"></param>
    /// <param name="character"></param>
    /// <returns></returns>
    public static int CountOccurrence(string text , char character)
    {
       if ( text.Length == 0 )
            return 0;
        int count = 0;
        //
        if (text[0] == character) count++;

        count  += CountOccurrence(text.Substring(1), character);
        return count;
    }
    public static void Main(string[] args)
    {
        string text = "abcdefa";
        char character = 'a';
        Console.WriteLine(CountOccurrence(text, character));
    }
}