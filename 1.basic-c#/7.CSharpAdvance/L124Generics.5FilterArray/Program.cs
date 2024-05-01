class Program
{
    public static T[] Filter<T>(T[] input, Func<T, bool> predicate)
    {
        List<T> result = new List<T>();
        foreach (var item in input)
        {
            if (predicate(item))
            {
                result.Add(item);
            }
        }
        return result.ToArray();
    }
    public static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, -4, -5 };
        Func<int, bool> CheckNegative = x => x > 0;
        int[] result = Filter(array, CheckNegative);
        foreach (var item in result)
        {
            Console.WriteLine($"{item} ");
        }
    }

}