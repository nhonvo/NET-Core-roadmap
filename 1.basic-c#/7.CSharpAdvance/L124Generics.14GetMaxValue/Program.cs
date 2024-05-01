class Program
{
    public static T GetMaxValue<T>(T[] array, Func<T, T, int> comparer)
    {

        T max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (comparer(max, array[i]) < 0)
            {
                max = array[i];
            }
        }

        return max;
    }

    public static void Main(string[] args)
    {
        int[] array = new int[] { 1, 2, 3 };
        Func<int, int, int> CompareTwoValue = (x, y) => x - y;
        Console.WriteLine(GetMaxValue(array, CompareTwoValue));
    }

}