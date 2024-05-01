class Program
{
    public static void InitializeRandomArray(int[,] array)
    {
        Random rand = new Random();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                array[i, j] = rand.Next(1, 100);
                Console.Write("{0} ", array[i, j]);
            }
        }
    }
    private static void Main(string[] args)
    {
        int[,] array = new int[3, 3];
        InitializeRandomArray(array);
    }
}
