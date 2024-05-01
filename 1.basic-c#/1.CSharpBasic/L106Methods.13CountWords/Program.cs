class Program
{
    /// <summary>
    /// count the word in the sentence
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public static int CountWord(string text)
    {
        bool flag = true;
        int i = 0;
        int count = 0;
        while (i < text.Length)
        {
            if (text[i] == ' ')
                flag = false;

            else if (!flag)
            {
                flag = true;
                count++;
            }
            i++;
        }
        return count;
    }

    public static void Main(string[] args)
    {
        string text = " The quick     brown fox jumps over the lazy dog.";
        Console.WriteLine(CountWord(text));
    }
}