namespace p4LinQTests;

public class SumOfOddNumbersTests
{
    [Fact]
    public void SumOfOddNumbers_ShouldThrowArgumentNullException_WhenParamIsNull()
    {
        // Arrange
        List<int> param = null;

        // Act And Assert
        Assert.Throws<ArgumentNullException>(() => Test.SumOfOddNumbers(param));
    }

    [Fact]
    public void SumOfOddNumbers_ShouldReturnCorrectData_WhenParamIsEmptyList()
    {
        // Arrange
        var param = new List<int>();
        var expected = 0;

        // Act
        var actual = Test.SumOfOddNumbers(param);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SumOfOddNumbers_ShouldReturnCorrectData_WhenParamHas1Item()
    {
        // Arrange
        var param = new List<int> { 1 };
        var expected = 1;

        // Act
        var actual = Test.SumOfOddNumbers(param);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SumOfOddNumbers_ShouldReturnCorrectData_WhenParamHasMultipleItems()
    {
        // Arrange
        var param = new List<int> { 1, 2, 3, 4 };
        var expected = 4;

        // Act
        var actual = Test.SumOfOddNumbers(param);

        // Assert
        Assert.Equal(expected, actual);
    }
}