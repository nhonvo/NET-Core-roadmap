class Program
{
    public static int SumArray(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;

    }
    public static void Main(string[] args)
    {
        int[] array = new int[5] { 1, 2, 3, 4, 5 };
        int sum = SumArray(array);
        System.Console.WriteLine(sum);
    }
}