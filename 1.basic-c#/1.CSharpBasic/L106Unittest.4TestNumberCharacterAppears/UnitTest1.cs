namespace L106Unittest._4TestNumberCharacterAppears;

public class TestNumberCharacterAppear
{
    /// <summary>
    /// count the number character appear in string
    /// </summary>
    /// <param name="text"></param>
    /// <param name="character"></param>
    /// <returns></returns>
    public int CountCharacterAppear(string text, char character)
    {
        int count = 0;
        foreach (char c in text)
        {
            if (character.ToString().ToUpper() == c.ToString().ToUpper())
                count++;
        }
        return count;
    }
    [Fact]
    public void TestCountCharacterAppear()
    {
        int count = 2;
        string name = "TruOng Nhon";
        char character = 'o';
        int output = CountCharacterAppear(name, character);

        Assert.Equal(count, output);
    }
}