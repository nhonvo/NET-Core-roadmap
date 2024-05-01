namespace p4LinQTests;

public class AveragePriceByCategoryTests
{
    [Fact]
    public void AveragePriceByCategory_ShouldThrowArgumentNullException_WhenParamIsNull()
    {
        // Arrange
        List<Product> param = null;

        // And And Assert
        Assert.Throws<ArgumentNullException>(() => Test.AveragePriceByCategory(param));
    }

    [Fact]
    public void AveragePriceByCategory_ShouldReturnCorrectData_WhenParamIsEmptyList()
    {
        // Arrange
        var param = new List<Product>();
        var expected = new Dictionary<string, decimal>();

        // Act
        var actual = Test.AveragePriceByCategory(param);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void AveragePriceByCategory_ShouldReturnCorrectData_WhenParamHas1Item()
    {
        // Arrange
        var param = new List<Product>
        {
            new Product { Category = "Category 1", Price = 10.0m }
        };

        var expected = new Dictionary<string, decimal>
        {
            { "Category 1", 10.0m }
        };

        // Act
        var actual = Test.AveragePriceByCategory(param);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void AveragePriceByCategory_ShouldReturnCorrectData_WhenParamHasMultipleItems()
    {
        // Arrange
        var param = new List<Product>
        {
            new Product { Category = "Category 1", Price = 10.0m },
            new Product { Category = "Category 1", Price = 20.0m },
            new Product { Category = "Category 2", Price = 30.0m },
            new Product { Category = "Category 2", Price = 40.0m },
            new Product { Category = "Category 2", Price = 50.0m }
        };

        var expected = new Dictionary<string, decimal>
        {
            { "Category 1", 15.0m },
            { "Category 2", 40.0m }
        };

        // Act
        var actual = Test.AveragePriceByCategory(param);

        // Assert
        Assert.Equal(expected, actual);
    }
}
