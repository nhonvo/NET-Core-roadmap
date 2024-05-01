class Program
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    public static void CheckUntilGetValidNumber(int value)
    {
        do
        {
            Console.WriteLine("Enter a number between 1 and 100:");
            value = Convert.ToInt32(Console.ReadLine());
        } while (value < 0 || value > 1);
    }
    private static void Main(string[] args)
    {
        int value = 1000;

        CheckUntilGetValidNumber(value);
    }
}