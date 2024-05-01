using NPL.Practice.T02.Problem01;
public class ArticleSummaryTests
{
    [Fact]
    public void GetArticleSummary_ReturnsEmptyString_WhenContentIsNull()
    {
        // Arrange
        string content = null;
        int maxLength = 100;

        // Act
        string summary = Program.GetArticleSummary(content, maxLength);

        // Assert
        Assert.Equal("", summary);
    }

    [Fact]
    public void GetArticleSummary_ReturnsEmptyString_WhenContentIsEmpty()
    {
        // Arrange
        string content = "";
        int maxLength = 100;

        // Act
        string summary = Program.GetArticleSummary(content, maxLength);

        // Assert
        Assert.Equal("", summary);
    }

    [Fact]
    public void GetArticleSummary_ReturnsContent_WhenContentIsShorterThanMaxLength()
    {
        // Arrange
        string content = "This is a short article.";
        int maxLength = 50;

        // Act
        string summary = Program.GetArticleSummary(content, maxLength);

        // Assert
        Assert.Equal(content, summary);
    }

    [Fact]
    public void GetArticleSummary_ReturnsSummary_WhenContentIsLongerThanMaxLength()
    {
        // Arrange
        string content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
        int maxLength = 21;
        string expected = "Lorem ipsum dolor sit...";

        // Act
        string actual = Program.GetArticleSummary(content, maxLength);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetArticleSummary_ReturnsSummary_WhenCuttingPointIsInsideWord()
    {
        // Arrange
        string content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
        int maxLength = 20;
        string expected = "Lorem ipsum dolor...";

        // Act
        string actual = Program.GetArticleSummary(content, maxLength);

        // Assert
        Assert.Equal(expected, actual);
    }
}
