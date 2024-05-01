class Program
{
    public static void WriteStringToFile(string text, string path)
    {
        File.WriteAllText(path, text);
    }
    public static void Main()
    {
        Action<string, string> writeStringToFileAction = WriteStringToFile;
        string text = "truong nhon";
        string path = @"E:\6.Csharp\CsharpPratice\L127Delegates.13WriteStringToFile\data.txt";
        writeStringToFileAction(text, path);

    }
}