class Program
{
    public static bool IsPositive(int number) => number > 0 ? true: false;
    public static void Main()
    {
        Predicate<int> isPositivePredicate = IsPositive;
        int number = 5;
        System.Console.WriteLine(isPositivePredicate(number) ? "true" : "false");

    }
}