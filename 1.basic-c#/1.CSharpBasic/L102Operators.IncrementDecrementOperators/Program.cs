class Program
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="FirstValue"></param>
    /// <param name="SecondValue"></param>
    public static void IncrementDecrementOperators(int FirstValue, int SecondValue)
    {
        if (FirstValue == SecondValue)
            Console.WriteLine("Equal");
        else if (FirstValue > SecondValue)
            Console.WriteLine("Bigger");
        else if (FirstValue < SecondValue)
            Console.WriteLine("Smaller");
        else if (FirstValue >= SecondValue)
            Console.WriteLine("Bigger or equal");
        else if (FirstValue <= SecondValue)
            Console.WriteLine("Smaller or equal");
        else if (FirstValue != SecondValue)
            Console.WriteLine("Different");
        Console.WriteLine();
    }
    private static void Main(string[] args)
    {
        int FirstValue = 10;
        int SecondValue = 5;
        IncrementDecrementOperators(FirstValue, SecondValue);
    }
}