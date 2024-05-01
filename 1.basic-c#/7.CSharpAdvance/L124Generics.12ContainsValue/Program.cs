class Program
{
    public static bool Contains<T>(T[] array, T value) where T : IComparable
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].CompareTo(value) == 0)
                return true;
        }
        return false;
    }
    public static void Main(string[] args)
    {
        int[] array = { 1, 2, 3 };
        int value = 3;
        Console.WriteLine(Contains(array, value) ? "true" : "false");
    }

}