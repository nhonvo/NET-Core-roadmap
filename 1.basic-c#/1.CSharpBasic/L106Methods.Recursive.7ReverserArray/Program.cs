class Program
{
    /// <summary>
    /// swap two T type value
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="First"></param>
    /// <param name="Second"></param>
    public static void Swap<T>(ref T First, ref T Second)
    {
        T tmp = First;
        First = Second;
        Second = tmp;
    }
    /// <summary>
    /// reversive array by recursive
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="array"></param>
    /// <param name="start"></param>
    /// <param name="end"></param>
    public static void Reversive<T>(T[] array, int start, int end)
    {
        if (start >= end)
        {
            return;
        }
       
        Swap(ref array[start], ref array[end]);

        Reversive(array, start + 1, end - 1);
    }
    /// <summary>
    /// Print T value 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="array"></param>
    public static void Print<T>(T[] array)
    {
        foreach (T t in array)
        {
            Console.Write("{0} ", t);
        }
    }
    public static void Main(string[] args)
    {
        char[] array = { 'a', 'b', 'c' };
        Reversive(array, 0, array.Length - 1);

        Print(array);
    }
}