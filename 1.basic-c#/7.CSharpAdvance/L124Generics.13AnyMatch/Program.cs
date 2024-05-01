class Program
{
    public static bool CheckGeneric<T>(T[] array, Predicate<T> predicate)
    {
        foreach (T item in array)
        {
            if (predicate(item))
            {
                return true;
            }
        }
        return false;
    }
    public static bool CheckNegative(int number)
    {
        if(number <0)
            return true;
        return false;
    }
    public static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4 };
        Predicate<int> checkValueHasSpecifiedCondition = CheckNegative;

        Console.WriteLine(CheckGeneric(array, CheckNegative));
    }

}