class Program
{


    public static int GetMax(int[] array)
    {
        int max = array[0];
        foreach (int number in array)
        {
            if (number > max)
            {
                max = number;
            }
        }
        return max;
    }



    public static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };
        Console.WriteLine(GetMax(array));
    }
}