class Program
{
    public static int CalculateFactorial(int number)
    {
        if (number == 0)
        {
            return 1;
        }
        return number * CalculateFactorial(number - 1);
    }
    public static void Main(string[] args)
    {
        int number = 5;
        System.Console.WriteLine(CalculateFactorial(number));
    }
}