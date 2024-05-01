
class Program
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="character"></param>
    /// <param name="integer"></param>
    /// <param name="boolenValue"></param>
    public static void ConvertDataType(char character, int integer, bool boolenValue)
    {
        Console.WriteLine("{0}", Convert.ToInt16(character));
        Console.WriteLine("{0}", Convert.ToChar(integer));
        Console.WriteLine("{0}", Convert.ToBoolean(boolenValue));
        Console.WriteLine("{0}", Convert.ToDecimal(boolenValue));
        Console.WriteLine("{0}", Convert.ToDouble(boolenValue));
    }
    private static void Main(string[] args)
    {

        char character = 'c';
        int integer = 100;
        bool boolenValue = true;
        ConvertDataType(character, integer, boolenValue);
    }
}