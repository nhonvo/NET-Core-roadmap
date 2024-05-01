class Program
{
    /// <summary>
    /// count number  of  occurence and use compareTo() in Icomparable class
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="array"></param>
    /// <param name="number"></param>
    /// <returns></returns>
    public static int CountOccurences<T>(T[] array, T number) where T : IComparable<T>
    {
        int count = 0;
        foreach (var item in array)
        {
            if (item.CompareTo(number) == 0)
                count++;
        }
        return count;
    }
    public static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 1 };
        int number = 1;
        Console.WriteLine(CountOccurences(array, number));
    }

}