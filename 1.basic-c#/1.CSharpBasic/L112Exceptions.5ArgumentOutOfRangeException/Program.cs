class Program
{
    public static void ArgumentNullException()
    {
        try
        {
            int number = -4;
            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            int[] array = new int[number];

        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Array size must be positive");
        }
    }
    public static void Main(string[] args)
    {
        ArgumentNullException();
    }
}
