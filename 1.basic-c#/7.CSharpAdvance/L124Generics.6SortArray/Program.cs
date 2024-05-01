class Program
{
    public static void Sort<T>(T[] array, Comparison<T> comparison) 
        => Array.Sort(array, comparison);
    public static void Main(string[] args)
    {
        int[] array = { 1, 4, 3, 2, 5 };
        Comparison<int> compareTwoNumber = (x, y) => x.CompareTo(y);
        Sort<int>(array, compareTwoNumber);
        foreach (int i in array)
            Console.WriteLine(i);
    }

}