class Program
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    public static bool CheckEvenOrOdd(int value)
    {

        if (value % 2 == 0)
            return true;
        return false;

    }
    private static void Main(string[] args)
    {
        int value = 50;
        bool flag = CheckEvenOrOdd(value);
        if (flag)
            Console.WriteLine("The number is even");
        Console.WriteLine("The number is odd");
    }
}