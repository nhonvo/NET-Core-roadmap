class Program
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="FirstValue"></param>
    /// <param name="SecondValue"></param>
    public static void ComparisonOperators(bool FirstValue, bool SecondValue)
    {
        if (!FirstValue)
            Console.WriteLine("true");
        else if (FirstValue && SecondValue)
            Console.WriteLine("true");
        else if (SecondValue || FirstValue)
            Console.WriteLine("true");
    }
    private static void Main(string[] args)
    {
        bool FirstValue = true;
        bool SecondValue = false;
        ComparisonOperators(FirstValue, SecondValue);
    }
}