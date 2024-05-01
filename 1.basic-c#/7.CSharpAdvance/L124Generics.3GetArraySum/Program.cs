class Program
{
    public static T GetArraySum<T>(T[] array)
    {
        dynamic sum = 0;
        foreach (T item in array)
        {
            sum += item;
        }
        return sum;
    }

    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.WriteLine(GetArraySum(arr));

    }

}