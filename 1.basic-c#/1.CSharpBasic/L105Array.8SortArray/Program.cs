class Program
{
    /// <summary>
    /// swap two interger reference values
    /// </summary>
    /// <param name="First"></param>
    /// <param name="Second"></param>
    public static void Swap(ref int First, ref int Second)
    {
        int tmp = First;
        First = Second;
        Second = tmp;
    }
    /// <summary>
    /// sort array by Selection sort alogorithm
    /// </summary>
    /// <param name="array"></param>
    public static void Sort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {

                if (array[i] > array[j])
                {
                    Swap(ref array[i],ref array[j]);
                }
            }
        }
    }
    /// <summary>
    /// print array
    /// </summary>
    /// <param name="array"></param>
    public static void Print(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            System.Console.Write("{0} ", array[i]);
        }
    }
    public static void Main(string[] args)
    {
        int[] array = new int[5] { 1, 4, 3, 2, 5 };
        Sort(array);
        Print(array);
    }
}