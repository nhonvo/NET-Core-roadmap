class Program
{

    public delegate bool CheckPrimePredicate(int number);
    public static bool CheckPrime(int number)
    {
        int count = 0;
        if (number < 2) return false;
        for (int i = 1; i < Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                count++;
        }
        if (count == 1) return true;
        return false;
    }
    public static void Main()
    {
        CheckPrimePredicate checkPrime = CheckPrime;
        int number = 3;
        System.Console.WriteLine(CheckPrime(number) ? "true" : "false");

    }

}