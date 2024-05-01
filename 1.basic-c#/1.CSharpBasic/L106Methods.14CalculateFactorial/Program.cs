class Program
{

    public static double CalculateFactorial(int number)
    {
        double factorialNumber = 1;
        for (int i = 1; i <= number; i++)
        {
            factorialNumber *= i ;
        }
        return factorialNumber;
    }



    public static void Main(string[] args)
    {
        int number = 5;
        System.Console.WriteLine(CalculateFactorial(number));
    }
}