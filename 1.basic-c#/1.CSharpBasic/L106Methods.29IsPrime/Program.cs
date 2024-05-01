class Program
{
    public static bool IsPrime(int num)
    {
        if (num < 2)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    public static void Main(string[] args)
    {
        int number = 3;
        Console.WriteLine(IsPrime(number) ? "Prime" : "NotPrime");
    }
}