class Program
{
    public static int Average(int a, int b) => Average(a,b);
    public static int Average(int a, int b, int c) => Average(a, b, c);

    public static void Main(string[] args)
    {
        int a = 1; int b = 2; int c = 3;
        Console.WriteLine(Average(a, b));
        Console.WriteLine(Average(a, b, c));
    }
}