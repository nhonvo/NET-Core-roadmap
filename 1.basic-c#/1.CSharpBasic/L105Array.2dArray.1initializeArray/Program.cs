class Program
{
    public static void InitializeArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("{0} ", array[i, j]);
            }
        }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        int[,] array = new int[3, 3]
{
     { 1, 2, 3 },{ 4, 5, 6 }, {7, 8, 9 }
};
        InitializeArray(array);
    }
}
