class Program
{
    public static bool AreArrayEqual<T>(T[] firstArray, T[] secondArray) where T : IComparable
    {
        if (firstArray.Length != secondArray.Length) return false;
        Array.Sort(firstArray);
        Array.Sort(secondArray);
        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i].CompareTo(secondArray[i]) != 0) return false;
        }
        return true;
    }
    public static void Main(string[] args)
    {
        int[] firstArray = { 1, 2, 3, 4, 5, 6, 7 };
        int[] secondArray = { 1, 2, 3, 4, 5, 6, 7 };
        Console.WriteLine(AreArrayEqual(firstArray, secondArray) ? "true" : "false");
    }

}