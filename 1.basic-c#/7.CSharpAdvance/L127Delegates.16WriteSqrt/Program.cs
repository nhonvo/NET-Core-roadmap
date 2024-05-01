class Program
{
    public static void WriteSqrt(int number)
    {
        Console.WriteLine(Math.Sqrt(number));
    }
    public static void Main()
    {
        Action<int> action = WriteSqrt;
        int number = 9;
        WriteSqrt(number);
    }
}
