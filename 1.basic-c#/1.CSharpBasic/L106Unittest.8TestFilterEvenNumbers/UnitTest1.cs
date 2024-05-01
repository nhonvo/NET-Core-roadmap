namespace L106Unittest._8TestFilterEvenNumbers;

public class UnitTest1
{
    /// <summary>
    /// filter even number in the list
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public static List<int> FilterEvenNumbers(List<int> numbers)
    {
        List<int> evenNumbers = new List<int>();
        foreach (int num in numbers)
        {
            if (num % 2 == 0)
            {
                evenNumbers.Add(num);
            }
        }
        return evenNumbers;
    }

    [Fact]
    public void TestFilterEvenNumbers()
    {
        List<int> myNumbers = new List<int> { 1, 2, 3, 4, 5, 6 };
        List<int> evenNumbers = FilterEvenNumbers(myNumbers);
        List<int> result = new List<int>() { 2, 4, 6 };
        CollectionAssert.Equal(evenNumbers, result);


    }
}