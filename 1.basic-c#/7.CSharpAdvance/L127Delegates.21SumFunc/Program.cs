class Program
{
    public static int SumTwoInteger(int a, int b) => a +b;
    public static void Main()
    {
        Func<int, int, int> sumTwoIntegerFunc = SumTwoInteger;
        int a = 5, b = 3;
        System.Console.WriteLine(sumTwoIntegerFunc(a,b));

    }
}