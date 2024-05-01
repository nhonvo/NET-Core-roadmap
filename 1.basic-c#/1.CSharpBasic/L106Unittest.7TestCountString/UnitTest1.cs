namespace L106Unittest._7TestCountString;

public class UnitTest1
{
    /// <summary>
    /// count number of string contains "test" in list string
    /// </summary>
    /// <param name="strings"></param>
    /// <returns></returns>
    public static int CountStrings(string[] strings)
    {
        int count = 0;
        foreach (string s in strings)
        {
            if (s.Contains("test"))
            {
                count++;
            }
        }
        return count;
    }

    [Fact]
    public void TestCountStrings()
    {
        string[] myStrings = { "this is a test", "test string", "not a test", "another test" };
        int count = CountStrings(myStrings);
        int number = 4;

        int output = CountStrings(myStrings);
        Assert.Equal(number, output);
    }
}