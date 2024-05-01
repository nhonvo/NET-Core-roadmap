class Program
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="array"></param>
    public static void Print(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="array"></param>
    public static void Add2InArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++) 
        {
            array[i] += 2;
        }
    }
    private static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };
        Add2InArray(array);
        Print(array);
    }
}