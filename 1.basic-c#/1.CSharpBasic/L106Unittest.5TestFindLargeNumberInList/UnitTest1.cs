namespace L106Unittest._5TestFindLargeNumberInList;

public class TestLargestNumberInList
{
    public int FindLargestNumberInList(List<int> number)
    {
        int max = number[0];
        foreach (var item in number)
        {
            if (max < item)
                max = item;

        }
        return max;
    }
    [Fact]
    public void TestFindLargestNumberInList()
    {
        var number = new List<int>() { 1, 2, 3, 4 };
        int max = 4;
        int output = FindLargestNumberInList(number);
        Assert.Equal(max, output);
    }
}