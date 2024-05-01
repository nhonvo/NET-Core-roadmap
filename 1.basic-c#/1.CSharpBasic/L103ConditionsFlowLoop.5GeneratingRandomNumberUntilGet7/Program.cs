class Program
{
    public static void GeneratNumberUntilGet7()
    {
        Random random = new Random();
        int value2 = 0;
        while (value2 != 7)
        {
            value2 = random.Next(1, 10);
            Console.WriteLine("Value{0}", value2);
        }
    }
    private static void Main(string[] args)
    {
        GeneratNumberUntilGet7();
    }
}