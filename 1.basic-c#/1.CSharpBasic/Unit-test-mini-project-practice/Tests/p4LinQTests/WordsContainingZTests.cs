namespace p4LinQTests;

public class WordsContainingZTests
{
    [Fact]
    public void WordsContainingZ_ShouldThrowArgumentNullException_WhenParamIsNull()
    {
        // Arrange
        List<string> param = null;

        // Act And Assert
        Assert.Throws<ArgumentNullException>(() => Test.WordsContainingZ(param));
    }

    [Fact]
    public void WordsContainingZ_ShouldReturnCorrectData_WhenParamIsEmptyList()
    {
        // Arrange
        var param = new List<string>();

        // Act
        List<string> actual = Test.WordsContainingZ(param);

        // Assert
        Assert.Empty(actual);
    }

    [Fact]
    public void WordsContainingZ_ShouldReturnCorrectData_WhenParamHasNoZWord()
    {
        // Arrange
        var param = new List<string> { "apple", "banana", "cherry" };

        // Act
        var actual = Test.WordsContainingZ(param);

        // Assert
        Assert.Empty(actual);
    }

    [Fact]
    public void WordsContainingZ_ShouldReturnCorrectData_WhenParamHas1ZWord()
    {
        // Arrange
        var param = new List<string> { "zebra", "cat", "dog" };
        var expected = new List<string> { "zebra" };

        // Act
        var actual = Test.WordsContainingZ(param);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void WordsContainingZ_ShouldReturnCorrectData_WhenParamHasMultipleZWords()
    {
        // Arrange
        var param = new List<string> { "zebra", "dazzle", "puzzle", "fizzle" };
        var expected = new List<string> { "zebra", "dazzle", "puzzle", "fizzle" };

        // Act
        var actual = Test.WordsContainingZ(param);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void WordsContainingZ_ShouldReturnCorrectData_WhenParamHasUpperAndLowercaseZWords()
    {
        // Arrange
        var param = new List<string> { "Zoo", "BuzZ", "Zombie" };
        var expected = new List<string> { "Zoo", "BuzZ", "Zombie" };

        // Act
        var actual = Test.WordsContainingZ(param);

        // Assert
        Assert.Equal(expected, actual);
    }
}