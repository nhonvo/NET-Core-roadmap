namespace P1StackDataStructureTests
{
    public class StackPushTests
    {
        [Fact]
        public void StackPush_ShouldAddItem_WhenStackIsEmpty()
        {
            // Arrange
            var stack = new P1StackDataStructure.Stack<int>(5);
            int expectedItem = 2;
            int expectedCount = 1;

            // Act
            stack.Push(expectedItem);
            int actualItem = stack.Peek();
            int actualCount = stack.Count;

            // Assert
            Assert.Equal(expectedItem, actualItem);
            Assert.Equal(expectedCount, actualCount);
        }

        [Fact]
        public void StackPush_ShouldAddItem_WhenStackHas1Item()
        {
            // Arrange
            var stack = new P1StackDataStructure.Stack<int>(5);
            int expectedItem = 10;
            int expectedCount = 2;
            stack.Push(5);

            // Act
            stack.Push(expectedItem);
            int actualItem = stack.Peek();
            int actualCount = stack.Count;

            // Assert
            Assert.Equal(expectedItem, actualItem);
            Assert.Equal(expectedCount, actualCount);
        }

        [Fact]
        public void StackPush_ShouldThrowStackOverflowException_WhenPushOverMaxSize()
        {
            // Arrange
            var stack = new P1StackDataStructure.Stack<int>(1);

            // Act
            stack.Push(1);

            // Assert
            Assert.Throws<StackOverflowException>(() => stack.Push(2));
        }
    }
}
