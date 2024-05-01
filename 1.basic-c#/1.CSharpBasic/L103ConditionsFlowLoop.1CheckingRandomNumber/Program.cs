class Program
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static int GenerateRandomNumber()
    {
        Random rand = new Random();
        int value = rand.Next(1, 100);
        return value;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    public static bool CheckNumberGreaterThan50(int value)
    {
        if (value > 50)
            return true;
        return false;
    }
    private static void Main(string[] args)
    {
        int value;
        value = GenerateRandomNumber();
        bool flag = CheckNumberGreaterThan50(value);
        if (flag)
            Console.WriteLine("This number greater than 50");
        Console.WriteLine("This number less than 50");

    }
}