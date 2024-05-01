namespace P1StackDataStructureTests
{
    public class StackClearTests
    {
        [Fact]
        public void StackClear_ShouldThrowNullReferenceException_WhenStackIsNull()
        {
            // Arrange
            P1StackDataStructure.Stack<int> stack = null;

            // Act And Assert
            Assert.Throws<NullReferenceException>(() => stack.Clear());
        }

        [Fact]
        public void StackClear_ShouldClearAllItems_WhenStackIsEmpty()
        {
            // Arrange
            var stack = new P1StackDataStructure.Stack<int>(5);
            int expectedCount = 0;

            // Act
            stack.Clear();
            int actualCount = stack.Count;

            // Assert
            Assert.Equal(expectedCount, actualCount);
        }

        [Fact]
        public void StackClear_ShouldClearAllItems_WhenStackHas1Item()
        {
            // Arrange
            var actualStack = new P1StackDataStructure.Stack<int>(5);
            actualStack.Push(1);
            int expectedCount = 0;

            // Act
            actualStack.Clear();
            int actualCount = actualStack.Count;

            // Assert
            Assert.Equal(expectedCount, actualCount);
        }

        [Fact]
        public void StackClear_ShouldClearAllItems_WhenStackHasMultipleItems()
        {
            // Arrange
            var stack = new P1StackDataStructure.Stack<int>(5);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            int expectedCount = 0;

            // Act
            stack.Clear();
            int actualCount = stack.Count;

            // Assert
            Assert.Equal(expectedCount, actualCount);
        }
    }
}
