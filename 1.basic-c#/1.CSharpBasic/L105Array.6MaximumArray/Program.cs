class Program
{
    public static int MinimumArray(int[] array)
    {
        int min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (min > array[i])
            {
                min = array[i];
            }
        }
        return min;
    }
    public static void Main(string[] args)
    {
        int[] array = new int[5] { 1, 2, 3, 4, 5 };
        System.Console.WriteLine(MinimumArray(array));
    }
}