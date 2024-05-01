class Program
{

    public static void Main()
    {
        Random random = new Random();
        int[] numbers = { 38, 24, 8, 0, -1, -17, -33, -100 };
        var selected = numbers.OrderBy(x => x = random.Next()).ToList();
        foreach ( var item in selected )
            Console.WriteLine(item);
    }

}
