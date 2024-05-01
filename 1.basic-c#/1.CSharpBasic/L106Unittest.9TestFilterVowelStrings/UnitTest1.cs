namespace L106Unittest._9TestFilterVowelStrings;

public class UnitTest1
{
    /// <summary>
    /// find the string has vowel in the begin in the list string
    /// </summary>
    /// <param name="strings"></param>
    /// <returns></returns>
    public List<string> FilterVowelStrings(List<string> strings)
    {
        List<string> vowelStrings = new List<string>();
        foreach (string s in strings)
        {
            if (s.Length > 0 && "aeiouAEIOU".Contains(s[0]))
            {
                vowelStrings.Add(s);
            }
        }
        return vowelStrings;
    }
    public static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    [Fact]
    public void TestFilterVowelStrings()
    {
        List<string> vowelStrings = new List<string> { "abc", "cba", "bac" };
        List<string> result = new List<string> { "abc" };
        List<string> output = FilterVowelStrings(vowelStrings);
        CollectionAssert.Equal(result, output);
    }
}