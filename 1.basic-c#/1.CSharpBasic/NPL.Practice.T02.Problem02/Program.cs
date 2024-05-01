class Program
{
    /// <summary>
    /// find max sum in sub arrray 
    /// first  loop through all subarray  
    /// calculate  sum in the subarray 
    /// compare sum with max and assign max if sum greatear
    /// continue  with another subarray
    /// </summary>
    /// <param name="inputArray"></param>
    /// <param name="subLength"></param>
    /// <returns></returns>
    static public int FindMaxSubArray(int[] inputArray, int subLength)
    {
        int max = 0;
        for (int i = 0; i <= inputArray.Length - subLength; i++)
        {
            int sum = 0;
            
            for (int j = i; j < i + subLength; j++)
                sum += inputArray[j];
            
            if (sum > max)
                max = sum;
        }
        return max;
    }

    private static void Main(string[] args)
    {
        // test case
        // 1. normal
        int[] inputArray = { 1, 2, 5, -4, 3 };
        int subLength = 3;
        int result = FindMaxSubArray(inputArray, subLength);
        Console.WriteLine(result);

        // 2. one
        int[] oneinputArray = { 1, 2, 5, -4, 3 };
        int oneSubLength = 1;
        int oneresult = FindMaxSubArray(oneinputArray, oneSubLength);
        Console.WriteLine(oneresult);

        // 3. empty
        int[] emptyinputArray = { };
        int emptySubLength = 1;
        int emptyresult = FindMaxSubArray(emptyinputArray, emptySubLength);
        Console.WriteLine(emptyresult);

    }

}
