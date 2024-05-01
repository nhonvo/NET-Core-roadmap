class Program
{
    public delegate void CalculateAverageDelegate(double[] x);

    public static void CalculateAverage(double[] x)
    {
        double sum = 0;
        for (int i = 0; i < x.Length; i++)
        {
            sum += x[i];
        }
        Console.WriteLine(Math.Round(sum / x.Length, 2));
    }

    public static void Main(string[] args)
    {
        double[] testValue = new double[] { 1.2, 1.5, 16, 20 };
        CalculateAverageDelegate calculateAverage = CalculateAverage;
        calculateAverage(testValue);
    }

}