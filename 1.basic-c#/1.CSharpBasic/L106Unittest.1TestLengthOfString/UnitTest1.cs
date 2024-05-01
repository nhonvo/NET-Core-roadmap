namespace L106Unittest._1TestLengthOfString;

public class TestStringLength
{
    public int CaculateStringLength(string text) => text.Length;
    [Fact]
    public void TestCaculateStringLength_5()
    {
        string text = "hello";
        int text_size = 5;

        int output = CaculateStringLength(text);
        Assert.Equal(text_size, output);
    }
    [Fact]
    public void TestCaculateStringLength_11()
    {
        string text = "hello world";
        int text_size = 11;

        int output = CaculateStringLength(text);
        Assert.Equal(text_size, output);
    }
}