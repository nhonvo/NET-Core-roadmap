public class Program
{
    

    public static int FindMaximumElement(int[] number, int Length)
    {
        if (Length == 1)
            return number[0];

        return Math.Max(number[Length - 1], FindMaximumElement(number, Length - 1));
    }
    private static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };
        Console.WriteLine(FindMaximumElement(array, array.Length));
    }
}
