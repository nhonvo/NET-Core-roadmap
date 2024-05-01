class Program
{
    public static double Average<T>(T[] array, Func<T, double> mapper)
    {

        double sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += mapper(array[i]);
        }

        return Math.Round(sum / array.Length, 2);
    }
    
    public static double MappingFunction(double number) => number + 2;
    public static void Main(string[] args)
    {
        double[] array = { 1, 2, 3 };
        Func<double, double> mapper = MappingFunction;

        Console.WriteLine(Average(array, mapper));
    }

}