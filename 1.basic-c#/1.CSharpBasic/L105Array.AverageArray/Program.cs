class Program
{
    public static double AverageArray(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += (array[i]);
        }
        return Convert.ToDouble(sum) / Convert.ToDouble(array.Length);

    }
    public static void Main(string[] args)
    {
        int[] array = new int[5] { 1, 2, 3, 4, 5 };
        System.Console.WriteLine(AverageArray(array));
    }
}