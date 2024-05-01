class Program
{
    public static void DivideByZeroException()
    {
        int number1 = 10, number2 = 0;
        try
        {
            System.Console.WriteLine(number1 / number2);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
    }
    public static void Main(string[] args)
    {
        DivideByZeroException();
    }
}
