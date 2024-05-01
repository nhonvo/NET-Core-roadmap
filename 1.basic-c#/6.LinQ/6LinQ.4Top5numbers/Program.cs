class Program
{

    public static void Main()
    {
        int[] intergerArray = { 6, 7, 8, 9, 10, 11, 1, 2, 3, -54, 5 };
        var selectedArray = intergerArray.OrderDescending().Take(5).ToArray();
        foreach ( var i in selectedArray )
            Console.WriteLine("{0}", i);
    }

}
