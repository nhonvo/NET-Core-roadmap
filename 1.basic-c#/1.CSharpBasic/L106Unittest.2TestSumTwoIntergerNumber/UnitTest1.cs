namespace L106Unittest._2TestSumTwoIntergerNumber;

public class TestSumArray
{
    public int SumArray(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }
    [Fact]
    public void TestCaculateSumArray()
    {
        int[] array = new int[] { 1, 2, 3, 4 };
        int sum = 10;

        int output = SumArray(array);

        Assert.Equal(sum, output);
    }
}