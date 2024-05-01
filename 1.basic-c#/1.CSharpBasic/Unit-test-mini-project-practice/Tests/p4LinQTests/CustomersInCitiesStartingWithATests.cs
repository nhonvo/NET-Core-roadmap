namespace p4LinQTests;

public class CustomersInCitiesStartingWithATests
{
    /// <summary>
    /// test case list null
    /// </summary>
    [Fact]
    public void CustomersInCitiesStartingWithA_ShouldThrowArgumentNullException_WhenParamIsNull()
    {
        // Arrange
        List<Customer> param = null;

        // Act And Assert
        Assert.Throws<ArgumentNullException>(() => Test.CustomersInCitiesStartingWithA(param));
    }

    /// <summary>
    /// Test case list empty
    /// </summary>
    [Fact]
    public void CustomersInCitiesStartingWithA_ShouldReturnCorrectData_WhenParamIsEmptyList()
    {
        // Arrange
        var param = new List<Customer>();

        // Act
        var actual = Test.CustomersInCitiesStartingWithA(param);

        // Assert
        Assert.Empty(actual);
    }

    /// <summary>
    /// Test case list 1 item
    /// </summary>
    [Fact]
    public void CustomersInCitiesStartingWithA_ShouldReturnCorrectData_WhenParamHas1Item()
    {
        // Arrange
        var param = new List<Customer>();
        var item = new Customer() { Name = "Bob", City = "Berlin" };
        param.Add(item);

        // Act
        var actual = Test.CustomersInCitiesStartingWithA(param);

        // Assert
        Assert.Empty(actual);
    }

    /// <summary>
    /// Test case list multi
    /// </summary>
    [Fact]
    public void CustomersInCitiesStartingWithA_ShouldReturnCorrectData_WhenParamHasMultipleItems()
    {
        // Arrange
        List<Customer> param = new()
            {
                new Customer(){ Name = "Alice", City = "Amsterdam"},
                new Customer(){ Name = "Bob", City = "Berlin"},
                new Customer(){ Name = "Charlie", City = "Athens"},
                new Customer(){ Name = "Dave", City = ""},
                new Customer(){ Name = "Eve", City = "Antwerp"},
            };
        var expected = new List<string> { "Alice", "Charlie", "Eve" };

        // Act
        var actual = Test.CustomersInCitiesStartingWithA(param);

        // Assert
        Assert.Equal(expected, actual);
    }
}
