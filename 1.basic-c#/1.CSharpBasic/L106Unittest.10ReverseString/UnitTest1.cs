namespace L106Unittest._10ReverseString;
public class UnitTest1
{
    /// <summary>
    /// reverse string by convert it to char array and reverse the array 
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    [Fact]
    public void TestReverseString()
    {
        string input = "abc";
        string output = "cba";
        string result = ReverseString(input);
        Assert.Equal(output, result);
    }
}