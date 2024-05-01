public interface IFileAnalysis
{
    public bool CheckIfFileExist(string path);
    public string ReadFile(string path);
    public int CountTotalCharacter(string file);
    public int CountTotalLine(string file);
    public int CountTotalWord(string file);
    public decimal AverageWordLength(int totalCharacters, int totalWords);
    public int CountTotalCharacterWithoutWhiteSpace(string text);
    public string[] StringToArray(string text);
}


