namespace TrainningExam
{
    public class FindMaxSubarray
    {
        public static int MaxSubarray(int[] inputArray, int subArrayLength)
        {
            if (inputArray == null || inputArray.Length == 0 || subArrayLength <= 0 || subArrayLength > inputArray.Length)
            {
                return 0; // return 0 if input is invalid
            }

            int maxSum = int.MinValue;
            for (int i = 0; i <= inputArray.Length - subArrayLength; i++)
            {
                int currentSum = 0;
                for (int j = i; j < i + subArrayLength; j++)
                {
                    currentSum += inputArray[j];
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
            return maxSum;
        }
    }
}
