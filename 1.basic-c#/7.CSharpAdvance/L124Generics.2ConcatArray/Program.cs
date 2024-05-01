class Program
{
    /// <summary>
    /// concatenates 2 array, create new result array and copy 2 array to result use
    /// static method copyto()
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="firstArray"></param>
    /// <param name="secondArray"></param>
    /// <returns></returns>
    public static T[] ConcatArrays<T>(T[] firstArray, T[] secondArray)
    {
        T[] result = new T[firstArray.Length + secondArray.Length];
        firstArray.CopyTo(result, 0);
        secondArray.CopyTo(result, firstArray.Length);
        return result;
    }

    public static void Main(string[] args)
    {
        int[] integerArray1 = { 1, 2, 3, 4, 5 };
        int[] integerArray2 = { 6, 7, 8, 9, 10, 11, 12, 13 };
        int[] result = ConcatArrays(integerArray1, integerArray2);
        foreach (int i in result)
        {
            Console.WriteLine(i);
        }
    }
}