class Program
{
    /// <summary>
    /// swap by tuple
    /// </summary>
    /// <param name="First"></param>
    /// <param name="Second"></param>
    public static void Swap(ref string First, ref string Second)
    {
        (Second, First) = (First, Second);
    }
    public static void Print(string First, string Second)
    {
        Console.WriteLine("{0} {1}", First, Second);
    }
    public static void Main(string[] args)
    {
        string first = "first";
        string second = "second";
        Print(first, second);
        Swap(ref first, ref second);
        Print(first, second);
    }
}