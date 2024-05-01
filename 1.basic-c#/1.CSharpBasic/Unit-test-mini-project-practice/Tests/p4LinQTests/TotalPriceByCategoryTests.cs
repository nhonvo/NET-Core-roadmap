namespace p4LinQTests;

public class TotalPriceByCategoryTests
{
    [Fact]
    public void TotalPriceByCategory_ShouldThrowArgumentNullException_WhenParamIsNull()
    {
        // Arrange
        List<Product> param = null;

        // Act And Assert
        Assert.Throws<ArgumentNullException>(() => Test.TotalPriceByCategory(param));
    }

    [Fact]
    public void TotalPriceByCategory_ShouldReturnCorrectData_WhenParamIsEmptyList()
    {
        // Arrange
        var param = new List<Product>();
        var expected = new Dictionary<string, decimal>();

        // Act
        var actual = Test.TotalPriceByCategory(param);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TotalPriceByCategory_ShouldReturnCorrectData_WhenParamHas1Item()
    {
        // Arrange
        var param = new List<Product>()
            {
                new Product() { Category = "A", Price = 100 }
            };
        var expected = new Dictionary<string, decimal>()
            {
                { "A", 100 }
            };

        // Act
        var actual = Test.TotalPriceByCategory(param);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TotalPriceByCategory_ShouldReturnCorrectData_WhenParamHasMultipleItems()
    {
        // Arrange
        var param = new List<Product>()
            {
                new Product() { Category = "A", Price = 100 },
                new Product() { Category = "B", Price = 200 },
                new Product() { Category = "C", Price = 200 },
                new Product() { Category = "B", Price = 50 },
                new Product() { Category = "A", Price = 200 }
            };

        var expected = new Dictionary<string, decimal>()
            {
                { "A", 300 },
                { "B", 250 },
                { "C", 200 }
            };

        // Act
        var actual = Test.TotalPriceByCategory(param);

        // Assert
        Assert.Equal(expected, actual);
    }
}
