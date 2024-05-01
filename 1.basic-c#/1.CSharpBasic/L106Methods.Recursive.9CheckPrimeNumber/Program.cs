class Program
{
    public static bool CheckingPrimeNumber(int number, int i)
    {

        if (number <= 2)
            return (number == 2) ? true : false;
        if (number % i == 0)
            return false;
        if (i * i > number)
            return true;

        return CheckingPrimeNumber(number, i + 1);
    }
    public static void Main(string[] args)
    {
        int number = 5;
        System.Console.WriteLine(CheckingPrimeNumber(number, 2) ? "true" : "false");
    }
}