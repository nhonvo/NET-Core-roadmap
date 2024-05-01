class Program
{
public static bool IsPositive(int number)
{
    return number > 0;
}

    private static void Main(string[] args)
    {
        int number = -3;
        IsPositive(number);
    }
}