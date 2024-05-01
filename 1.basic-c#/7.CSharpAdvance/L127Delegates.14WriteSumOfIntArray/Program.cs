class Program
{

    public delegate void WriteSumOfArrayDelegate(int[] array);

    public static void WriteSumOfArray(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        Console.WriteLine(sum);
    }

    public static void Main(string[] args)
    {
        int[] array = new int[] { 1, 2, 3, 4, 5 };
        WriteSumOfArrayDelegate writeSumOfArray = WriteSumOfArray;
        WriteSumOfArray(array);
    }

}