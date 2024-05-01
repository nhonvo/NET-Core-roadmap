class Program
{
    public static void PrintInteger(int number) { Console.WriteLine($"{number}"); }
    public static void Main()
    {
        Action<int> action = PrintInteger;
        int number = 0;
        PrintInteger(number);
    }
}