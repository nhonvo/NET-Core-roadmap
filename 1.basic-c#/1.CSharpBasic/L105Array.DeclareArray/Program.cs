class Program
{
    public static void Print(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
    }
    private static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };
        Print(array);
    }
}