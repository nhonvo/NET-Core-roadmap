
class Program
{
    public static void IOException()
    {
        try
        {
            string path = @"E:\6.Csharp\CsharpPratice\L112Exceptions.6IOException\test.tx";
            string fileContent = File.ReadAllText(path);
            string upperCaseContent = fileContent.ToUpper();
            Console.WriteLine(upperCaseContent);
        }
        catch (IOException)
        {
            Console.WriteLine("Cannot read file");
        }
    }

    public static void Main(string[] args)
    {
        IOException();
    }
}
