class Program
{
    public static bool CompareTwoVaule<T>(T x, T y) where T : IComparable
        => x.CompareTo(y) == 0;

    public static void Main(string[] args)
    {
        Console.WriteLine(CompareTwoVaule(1, 1) ? "true" : "false");
    }

}