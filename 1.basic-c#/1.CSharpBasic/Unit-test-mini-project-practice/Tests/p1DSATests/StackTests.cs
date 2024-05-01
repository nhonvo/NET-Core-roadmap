namespace P1StackDataStructureTests;

public class StackTests
{
    [Fact]
    public void StackConstructor_ShouldReturnCorrectItemCount_WhenInitialInstance()
    {
        // Arrange
        var numberItemInStack = 0;

        // Act
        var medoStack = new P1StackDataStructure.Stack<int>(100);

        // Assert
        Assert.Equal(numberItemInStack, medoStack.Count);
    }
}
