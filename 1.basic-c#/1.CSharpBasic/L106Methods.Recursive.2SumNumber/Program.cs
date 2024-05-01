class Program
{
    public static int SumNumber(int number)
    {
        if (number == 0)
        {
            return 0;
        }
        return number + SumNumber(number - 1);
    }
    public static void Main(string[] args)
    {
        int number = 6;
        System.Console.WriteLine(SumNumber(number));
    }
}