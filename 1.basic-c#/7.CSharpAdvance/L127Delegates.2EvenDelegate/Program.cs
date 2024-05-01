class Program
{
    public delegate bool IsEvenDelegate(int number);
    public static bool IsEven(int number) => number % 2 == 0;
    public static void Main()
    {
        IsEvenDelegate isEven = IsEven;
        int number = 5;
        System.Console.WriteLine(isEven(number) ? "Even" : "Not Even");

    }
}