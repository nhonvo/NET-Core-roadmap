class Program
{
    /// <summary>
    /// swap by tuple
    /// </summary>
    /// <param name="First"></param>
    /// <param name="Second"></param>
    public static void Swap(ref int First, ref int Second)
    {
        (Second, First) = (First, Second);
    }
    public static void Print(int First, int Second)
    {
        Console.WriteLine("{0} {1}", First, Second);
    }
    public static void Main(string[] args)
    {
        int first = 0;
        int second = 1;
        Print(first, second);
        Swap(ref first, ref second);
        Print(first, second);
    }
}