class Program
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="FirstValue"></param>
    /// <param name="SecondValue"></param>
    public static void LogicalOperator(int FirstValue, int SecondValue)
    {
       
        Console.WriteLine("{0}", FirstValue = SecondValue);
        Console.WriteLine("{0}", FirstValue += SecondValue);
        Console.WriteLine("{0}", FirstValue -= SecondValue);
        Console.WriteLine("{0}", FirstValue *= SecondValue);
        Console.WriteLine("{0}", FirstValue /= SecondValue);
        Console.WriteLine("{0}", FirstValue %= SecondValue);
    }
    private static void Main(string[] args)
    {
        int FirstValue = 4;
        int SecondValue = 6;
        LogicalOperator(FirstValue, SecondValue);
    }
}