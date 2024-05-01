
using System.Text.RegularExpressions;

class Program
{

    // path : E:\\6.Csharp\\CsharpPratice\\data.txt
    public static void Main(string[] args)
    {

        /*string test = "There is a cat, my friend. How are you?\r\n";
        test = test.Replace("\r", "").Replace("\n", "").Replace("\t", "");
        string[] words = test.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        int count = 0;
        foreach (string word in words)
        {
            count += word.Length;
        }
        Console.Write("word: {0} ", words.Length);
        Console.WriteLine("character non:{0}", count);
        Console.WriteLine("character :{0}", test.Length);*/

        FileAnalysis analysis = new FileAnalysis();
        Console.WriteLine("Welcome to the File Analysis Application!");
        string path = "";
        string text = analysis.ReadFile(path);

        Console.WriteLine("File analysis complete.");

        Console.WriteLine("Statistics: ");
        int totalCharacter = analysis.CountTotalCharacter(text);
        int totalCharacterNonWhiteSpace = analysis.CountTotalCharacterWithoutWhiteSpace(text);
        int totalLine = analysis.CountTotalLine(text);
        int totalWord = analysis.CountTotalWord(text);
        Console.WriteLine("Total characters: {0}", totalCharacter);
        Console.WriteLine("Total lines: {0}", totalLine);
        Console.WriteLine("Total words: {0}", totalWord);
        Console.WriteLine("Average word Length: {0}", analysis.AverageWordLength(totalCharacterNonWhiteSpace, totalWord));

    }
}


