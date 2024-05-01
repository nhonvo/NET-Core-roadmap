class Program
{

    public delegate int CalculateDifferenceDelegate(int a, int b);

    public static int CalculateDifference(int a, int b)
    {
        return Math.Abs(a - b);
    }
    public static void Main(string[] args)
    {
        int a = 5, b = 10;
        CalculateDifferenceDelegate calculateDifference = CalculateDifference;
        Console.WriteLine(calculateDifference(a, b));
    }


}