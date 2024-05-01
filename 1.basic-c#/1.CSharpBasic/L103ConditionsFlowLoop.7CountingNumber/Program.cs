class Program
{
    /// <summary>
    /// enter value and print the decrease value to console
    /// </summary>
    /// <param name="value"></param>
    public static void CountNumber(int value)
    {
        while (value != 0)
        {
            Console.WriteLine("{0}", value);
            value--;
        }
    }
    private static void Main(string[] args)
    {
        int value = 10;
        CountNumber(value);
    }
}