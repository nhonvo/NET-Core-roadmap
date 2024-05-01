public class FileAnalysis : IFileAnalysis
{
    public bool CheckIfFileExist(string path)
    {
        if (File.Exists(path)) return true; return false;
    }
    /// <summary>
    /// Read file and check if path null must to enter again
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    public string ReadFile(string? path)
    {
        string text = "";
        try
        {
            do
            {
                Console.Write("Please enter the path to the file you would like to analyze: ");
                path = Console.ReadLine();
                if (String.IsNullOrEmpty(path))
                {
                    Console.WriteLine("Please enter the path!!!");
                }

            } while (String.IsNullOrEmpty(path));
            if (CheckIfFileExist(path))
            {
                text = File.ReadAllText(path);
            }
            else
            {
                Console.WriteLine("File not exist!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception: " + ex.ToString());
        }
        return text;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public int CountTotalCharacter(string text) => text.Length;
    /// <summary>
    /// 
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public int CountTotalLine(string text)
    {
        int count = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '\n')
                count++;
        }
        return count;

    }
    /// <summary>
    /// replace all \r \n \t symbol and split to []words by white space 
    /// ignore array elements containing empty strings from the result.
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public string[] StringToArray(string text)
    {
        text = text.Replace("\r", "").Replace("\n", "").Replace("\t", "");
        string[] words = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        return words;
    }
    /// <summary>
    /// return total word equal length of array split
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public int CountTotalWord(string text) => StringToArray(text).Length;
    /// <summary>
    /// sum all element size in array is total character
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public int CountTotalCharacterWithoutWhiteSpace(string text)
    {
        string[] words = StringToArray(text);
        int sum = 0;
        foreach (var item in words)
        {
            sum += item.Length;
        }
        return sum;
    }
    /// <summary>
    /// count average of word length by get total characters without whitespace
    /// divide into total words and get 2 element behind dot
    /// </summary>
    /// <param name="totalCharacters"></param>
    /// <param name="totalWords"></param>
    /// <returns></returns>
    public decimal AverageWordLength(int totalCharacters, int totalWords)
        => Math.Round((decimal)totalCharacters / totalWords, 2);

}