
class Program
{
    public static void OverflowException()
    {
        int num1 = int.MaxValue;
        int num2 = 2;

        try
        {
            int result = checked(num1 + num2);
            Console.WriteLine(result);
        }
        catch (OverflowException)
        {
            Console.WriteLine("Result too large");
        }

    }
    public static void Main(string[] args)
    {
        OverflowException();
    }
}
