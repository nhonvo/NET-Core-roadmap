class Program
{
    public delegate int SumDelegate(int x, int y);
    public static int Sum(int x, int y) => x + y;
    public static void Main()
    {
        SumDelegate sum = Sum;
        int a = 10, b = 20;
        int result = sum(a,b);
        Console.WriteLine(result);
    }
}