class Program
{

    public static int FindMax(int[] array)
    {
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }

    private static void Main(string[] args)
    {
        int[] array = { 2, 5, 1, 7, 3 };
        FindMax(array);
    }
}