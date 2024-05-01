namespace L106Unittest._2TestSumArrayInterger;

public class TestSumTwoIntergerNumber
{
    public int SumTwoIntergerNumber(int a, int b) => a + b;
    [Fact]
    public void TestCaculateSumTwoIntergerNumber()
    {
        int sum = 10;
        int a = 5; int b = 5;
        int result = SumTwoIntergerNumber(a, b);
        Assert.Equal(sum, result);
    }
}