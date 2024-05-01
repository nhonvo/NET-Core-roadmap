class Program
{
    delegate double GetSquareRoot(double num);

    public static void Main()
    {
        GetSquareRoot sqrt = Math.Sqrt;
        double number = 4d;
        double result = sqrt(number);   
        Console.WriteLine($"Result: {result}");
    }

}