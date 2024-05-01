class Program
{
    /// <summary>
    /// intersect two array get the element appear in two array
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="first"></param>
    /// <param name="second"></param>
    /// <returns></returns>
    public static T[] GetElementsAppear<T>(T[] first, T[] second) 
        => first.Intersect(second).ToArray();

    public static void Main(string[] args)
    {
        double[] firstArray = { 1, 2, 3 };
        double[] secondArray = { 1, 2, 3, 4, 5, 6 };
        double[] result = GetElementsAppear(firstArray, secondArray);

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }
    }
}