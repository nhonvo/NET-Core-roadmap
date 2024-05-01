class Program
{
    public static T GetFirstElement<T>(T[] array) => array[0];
    public static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };
        string[] strings = { "a", "b", "c", "d" };
        GetFirstElement(array);
        GetFirstElement(strings);
    }
}