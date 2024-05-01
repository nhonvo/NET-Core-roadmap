class Program
{

    public static void Swap(ref int First, ref int Second)
    {
        int tmp = First;
        First = Second;
        Second = tmp;
    }
    public static void Sort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {

                if (array[i] > array[j])
                {
                    Swap(ref array[i], ref array[j]);
                }
            }
        }
    }
    public static void Print(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            System.Console.Write("{0} ", array[i]);
        }
    }
    public static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };
        Sort(array);
        Print(array);
    }
}