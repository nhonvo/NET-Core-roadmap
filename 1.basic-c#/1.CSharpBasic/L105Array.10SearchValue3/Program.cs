class Program
{

    public static void Search(int value, int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (value == array[i])
            {
                System.Console.WriteLine("found");
                return;
            }
        }
        System.Console.WriteLine("not found");
    }
    public static void Main(string[] args)
    {
        int[] array = new int[5] { 1, 4, 3, 2, 5 };
        int value = 3;
        Search(value, array);
    }
}