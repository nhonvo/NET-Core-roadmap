class Program
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="FistValue"></param>
    /// <param name="SecondValue"></param>
    public static void ArithmeticOperators(int FistValue, int SecondValue)
    {
        
        Console.WriteLine("Plus: {0}", FistValue + SecondValue);
        Console.WriteLine("Minus: {0}", FistValue - SecondValue);
        Console.WriteLine("Multiply: {0}", FistValue * SecondValue);
        Console.WriteLine("Divide: {0}", FistValue / SecondValue);
        Console.WriteLine("Modulo: {0}", FistValue % SecondValue);
        Console.WriteLine();
        Console.WriteLine("Before: {0}", FistValue);
        Console.WriteLine("After minus: {0}", FistValue--);
        Console.WriteLine("After plus: {0}", FistValue++);
        Console.WriteLine();
    }
    private static void Main(string[] args)
    {
        int FistValue = 10;
        int SecondValue = 5;
        ArithmeticOperators(FistValue, SecondValue);
    }
}
