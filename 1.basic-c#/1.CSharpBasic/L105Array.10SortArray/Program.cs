class Program
{
    public static void Random(int[,] array)
    {
        Random rand = new Random();
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = rand.Next(1, 100);
            }
        }
    }
    public static void Swap(ref int x, ref int y)
    {
        int tmp = x;
        x = y;
        y = tmp;
    }
    public static void Sort(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(1) - j - 1; k++)
                {

                    if (array[i, k] > array[i, k + 1])
                    {
                        Swap(ref array[i, k], ref array[i, k + 1]);
                    }
                }
            }
        }
    }

    public static void Print(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("{0} ", array[i, j]);
            }
            System.Console.WriteLine();
        }
    }


    public static void Main(string[] args)
    {
        int[,] array = new int[3, 3];
        Random(array);
        Sort(array);
        Print(array);

    }

}
