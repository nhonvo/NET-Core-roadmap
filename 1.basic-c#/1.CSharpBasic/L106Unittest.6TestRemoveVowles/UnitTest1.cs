namespace L106Unittest._6TestRemoveVowles;

public class UnitTest1
{
    /// <summary>
    /// remove all character is vowles like A,E,I,O,U
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public string RemoveVowels(string text) => text.ToUpper().Replace("A", "").Replace("E", "").Replace("I", "").Replace("O", "").Replace("U", "");

    [Fact]
    public void TestRemoveVowels()
    {
        string text = "aeioukkkk";
        string removeText = "kkkk";
        string output = RemoveVowels(text);
        Assert.Equal(removeText.ToLower(), output.ToLower());
    }
}