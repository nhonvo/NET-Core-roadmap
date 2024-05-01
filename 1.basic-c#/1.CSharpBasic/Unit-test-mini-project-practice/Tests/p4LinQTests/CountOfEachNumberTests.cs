namespace p4LinQTests;

public class CountOfEachNumberTests
{
    [Fact]
    public void CountOfEachNumber_ShouldThrowArgumentNullException_WhenParamIsNull()
    {
        // Arrange
        List<int> param = null;

        // Act And Assert
        Assert.Throws<ArgumentNullException>(() => Test.CountOfEachNumber(param));
    }

    [Fact]
    public void CountOfEachNumber_ShouldReturnCorrectData_WhenParamIsEmptyList()
    {
        // Arrange
        var param = new List<int>();
        var expected = new Dictionary<int, int>();

        // Act
        Dictionary<int, int> actual = Test.CountOfEachNumber(param);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CountOfEachNumber_ShouldReturnCorrectData_WhenParamHas1Item()
    {
        // Arrange
        var param = new List<int> { 3 };
        var expected = new Dictionary<int, int>
            {
                { 3, 1 }
            };

        // Act
        var actual = Test.CountOfEachNumber(param);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CountOfEachNumber_ShouldReturnCorrectData_WhenParamHasMultipleItems()
    {
        // Arrange
        var param = new List<int> { 1, 2, 3, 2, 1, 1, 4, 5, 5 };
        var expected = new Dictionary<int, int>
            {
                { 1, 3 },
                { 2, 2 },
                { 3, 1 },
                { 4, 1 },
                { 5, 2 }
            };

        // Act
        var actual = Test.CountOfEachNumber(param);

        // Assert
        Assert.Equal(expected, actual);
    }
}
