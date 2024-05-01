using NPL.Practice.T02.Problem02;
namespace TrainingExamTests
{
    public class FindMaxSubarrayTests
    {
        [Fact]
        public void FindMaxSubarray_ReturnsMaxSumOfSubarray()
        {
            // Arrange
            int[] inputArray = new int[] { 2, -1, 3, 4, -2 };
            int subArrayLength = 3;
            int expectedMaxSum = 6;

            // Act
            int actualMaxSum = Program.FindMaxSubArray(inputArray, subArrayLength);

            // Assert
            Assert.Equal(expectedMaxSum, actualMaxSum);
        }

        [Fact]
        public void FindMaxSubarray_ReturnsMaxSumOfSubarray_WhenSubArrayLengthEqualsInputLength()
        {
            // Arrange
            int[] inputArray = new int[] { -2, 4, -1, 7, -8 };
            int subArrayLength = inputArray.Length;
            int expectedMaxSum = 0;

            // Act
            int actualMaxSum = Program.FindMaxSubArray(inputArray, subArrayLength);

            // Assert
            Assert.Equal(expectedMaxSum, actualMaxSum);
        }


        [Fact]
        public void FindMaxSubarray_ReturnsZeroForInvalidInput2()
        {
            // Arrange
            int[] inputArray = null;
            int subArrayLength = 0;
            int expectedMaxSum = 0;

            // Act
            int actualMaxSum = Program.FindMaxSubArray(inputArray, subArrayLength);

            // Assert
            Assert.Equal(expectedMaxSum, actualMaxSum);
        }

        [Fact]
        public void FindMaxSubarray_ReturnsZeroForInvalidInput()
        {
            // Arrange
            int[] inputArray = new int[1];
            int subArrayLength = 0;
            int expectedMaxSum = 0;

            // Act
            int actualMaxSum = Program.FindMaxSubArray(inputArray, subArrayLength);

            // Assert
            Assert.Equal(expectedMaxSum, actualMaxSum);
        }
    }
}
