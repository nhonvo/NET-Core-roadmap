namespace p4LinQTests;

public class DistinctRepeatedWordsTest
{
    [Fact]
    public void DistinctRepeatedWords_ShouldThrowArgumentNullException_WhenParamIsNull()
    {
        // Arrange
        List<string> param = null;

        // Act And Assert
        Assert.Throws<ArgumentNullException>(() => Test.DistinctRepeatedWords(param));
    }

    [Fact]
    public void DistinctRepeatedWords_ShouldReturnCorrectData_WhenParamIsEmptyList()
    {
        // Arrange
        var param = new List<string>();

        // Act
        var actual = Test.DistinctRepeatedWords(param);

        // Assert
        Assert.Empty(actual);
    }

    [Fact]
    public void DistinctRepeatedWords_ShouldReturnCorrectData_WhenParamHas1Item()
    {
        // Arrange
        var param = new List<string>() { "aaa" };

        // Act
        var actual = Test.DistinctRepeatedWords(param);

        // Assert
        Assert.Empty(actual);
    }

    [Fact]
    public void DistinctRepeatedWords_ShouldReturnCorrectData_WhenParamHasMultipleItems()
    {
        // Arrange
        var param = new List<string>() { "aaa", "bb", "ccc", "bb" };
        var expected = new List<string>() { "bb" };

        // Act
        var actual = Test.DistinctRepeatedWords(param);

        // Assert
        Assert.Equal(expected, actual);
    }
}