class Program
{
    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }



    public static void Main(string[] args)
    {
        int number = 8;
        System.Console.WriteLine(IsEven(number) ? "true" : "false");
    }
}