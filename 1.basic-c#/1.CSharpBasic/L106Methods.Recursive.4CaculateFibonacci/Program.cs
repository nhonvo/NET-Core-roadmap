class Program
{
    public static int CalculateFibonacci(int number)
    {
        if (number < 2)
        {
            return number;
        }
        return CalculateFibonacci(number - 2) + CalculateFibonacci(number - 1);
    }
    public static void Main(string[] args)
    {
        int number = 6;
        System.Console.WriteLine(CalculateFibonacci(number));
    }
}