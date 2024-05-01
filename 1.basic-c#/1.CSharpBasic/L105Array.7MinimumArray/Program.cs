class Program
{
    public static int MaximumArray(int[] array)
    {
        int max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
            }
        }
        return max;
    }
    public static void Main(string[] args)
    {
        int[] array = new int[5] { 1, 2, 3, 4, 5 };
        System.Console.WriteLine(MaximumArray(array));
    }
}