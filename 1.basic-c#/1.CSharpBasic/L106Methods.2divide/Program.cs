class Program
{
    /// <summary>
    /// divide two integer number
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static int Divide(int a, int b) => a / b;
    /// <summary>
    /// divide three integer number
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    /// <returns></returns>
    public static int Divide(int a, int b, int c) => a / b / c;

    public static void Main(string[] args)
    {
        int a = 1; int b = 2; int c = 3;
        Console.WriteLine(Divide(a, b));
        Console.WriteLine(Divide(a, b, c));
    }
}