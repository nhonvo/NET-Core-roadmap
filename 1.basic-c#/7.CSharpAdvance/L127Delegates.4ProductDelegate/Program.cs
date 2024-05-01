class Program
{
    public delegate int ProductIntArrayDelegate(int[] array);
    public static int ProductIntArray(int[] array)
    {
        int product = 1;
        for (int i = 0; i < array.Length - 1; i++)
        {
            product = array[i] * array[i + 1];
        }
        return product;
    }
    public static void Main()
    {
        ProductIntArrayDelegate productIntArray = ProductIntArray;
        int[] array = { 1, 2, 3, 4, 5 };
        System.Console.WriteLine(ProductIntArray(array));

    }
}