class Program
{
    
    public static int AddNumbers(int[] array)
    {
        int sum = 0;
        foreach (int number in array)
        {
            sum += number;
        }
        return sum;
    }


    public static void Main(string[] args)
    {
        int[] array = { 1, 2, 3 };
        Console.WriteLine(AddNumbers(array));
    }
}