class Program
{
    public static void CatchFileException()
    {
        try
        {
            string fileContent = File.ReadAllText("data.txt");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found");
        }
    }
    public static void Main(string[] args)
    {
        CatchFileException();
    }   
}
