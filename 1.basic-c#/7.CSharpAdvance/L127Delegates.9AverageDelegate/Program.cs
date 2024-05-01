class Program
{
    public delegate double CalculateAverageDelegate(double[] array);

    public static double CalculateAverage(double[] array)
    {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return Math.Round(sum / array.Length, 4);
    }
    public static void Main()
    {
        double[] array = { 2.2, 3, 4.5 };
        CalculateAverageDelegate calculateAverage = CalculateAverage;
        Console.WriteLine(calculateAverage(array));
    }

}