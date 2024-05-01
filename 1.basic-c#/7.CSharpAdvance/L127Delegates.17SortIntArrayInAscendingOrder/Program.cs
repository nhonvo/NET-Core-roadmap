class Program
{
    public delegate void SortArrayDelegate(int[] array);

    public static void SortArray(int[] array)
    {
        Array.Sort(array);
    }

    public static void Main(string[] args)
    {
        SortArrayDelegate sortArray = SortArray;
        int[] array = { 1, 5, 3 };
        SortArray(array);

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}