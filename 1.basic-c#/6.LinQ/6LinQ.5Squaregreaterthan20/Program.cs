class Program
{

    public static void Main()
    {
        List<int> Numbers = new List<int> { 3, 9, 2, 4, 6, 5, 7 };

        var SelectedNumbers = Numbers.Where(x => x * x > 20);

        foreach (var s in SelectedNumbers)
        {
            Console.Write($"{s} - {s * s}, ");
        }
    }

}
