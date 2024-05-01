using System.Text;

class Program
{
    /// <summary>
    /// use string builder when append string the memory not delete 
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public static string Concatenate(string[] array)
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < array.Length; i++)
        {
            result.Append(array[i]).Append(' ');
        }
        return result.ToString();
    }

    public static void Main(string[] args)
    {
        string[] array = new string[5] { "apple", "banana", "cherry", "date", "elderberry" };
        System.Console.WriteLine(Concatenate(array));


    }
}