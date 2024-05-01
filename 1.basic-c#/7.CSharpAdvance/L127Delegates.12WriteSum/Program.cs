class Program
{
    public static void WriteSum(int first, int second) { System.Console.WriteLine($"{first + second}"); }
    public static void Main()
    {
        Action<int, int> writeSumAction = WriteSum;
        int first = 4, second = 5;
        writeSumAction(first, second);

    }
}