class Program
{
    public static bool IsEven(int number) => number % 2 == 0;
    public static void Main()
    {
        Func<int, bool> isEvenFunc = IsEven;
        int number = 5;
        System.Console.WriteLine(isEvenFunc(number) ? "Even" : "Not Even");

    }
}