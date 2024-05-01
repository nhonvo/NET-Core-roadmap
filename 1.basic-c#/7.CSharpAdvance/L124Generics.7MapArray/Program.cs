class Program
{
    public static TResult[] MapArray<T, TResult>(T[] array, Func<T, TResult> mappingFunction)
    {
        TResult[] result = new TResult[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            result[i] = mappingFunction(array[i]);
        }
        return result;
    }
    public static int MappingFunction(int number) => number - 2;

    public static void Main()
    {
        int[] array = { 1, 2, 3 };
        int[] result = MapArray(array, MappingFunction);
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(result[i]);
        }
    }

}