class Program
{
    /// <summary>
    /// tranveser a array and compare with the max value to get 
    /// the largest number
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public static int GetLargestNumber(int[] array)
    {
        int largestNumber = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > largestNumber)
            {
                largestNumber = array[i];
            }
        }
        return largestNumber;
    }



    public static void Main(string[] args)
    {
        int[] array = { 3, 6, 9, 12 };
        Console.WriteLine(GetLargestNumber(array));
    }
}