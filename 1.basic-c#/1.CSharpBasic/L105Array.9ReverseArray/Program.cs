class Program
{

    public static void Print(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            System.Console.Write("{0} ", array[i]);
        }
    }
    public static int[] ReverseArray(int[] array)
    {
        int[] reversedArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            reversedArray[i] = array[array.Length - i - 1];
        }
        return reversedArray;
    }
    public static void Main(string[] args)
    {
        int[] array = new int[5] { 1, 2, 3, 4, 5 };
        int[] reverserArray = ReverseArray(array);
        Print(reverserArray);

    }
}