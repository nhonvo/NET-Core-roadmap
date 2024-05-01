class Program
{
    /// <summary>
    /// multiply two integer nuber
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static int Multiply(int a, int b) => a * b;
    /// <summary>
    /// multiply three integer nuber
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    /// <returns></returns>
    public static int Multiply(int a, int b, int c) => a * b * c;

    public static void Main(string[] args)
    {
        int a = 1; int b = 2; int c = 3;
        Console.WriteLine(Multiply(a, b));
        Console.WriteLine(Multiply(a, b, c));
    }
}