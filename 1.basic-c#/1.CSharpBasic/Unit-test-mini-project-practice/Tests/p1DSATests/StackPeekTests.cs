
namespace P1StackDataStructureTests
{
    public class StackPeekTests
    {
        [Fact]
        public void StackPeek_ShouldThrowNullReferenceException_WhenStackIsNull()
        {
            // Arrange
            P1StackDataStructure.Stack<int> stack = null;

            // Act And Assert
            Assert.Throws<NullReferenceException>(() => stack.Peek());
        }

        [Fact]
        public void StackPeek_ShouldThrowInvalidOperationException_WhenStackIsEmpty()
        {
            // Arrange
            var stack = new P1StackDataStructure.Stack<int>(1);

            // Act And Assert
            Assert.Throws<InvalidOperationException>(() => stack.Peek());
        }

        [Fact]
        public void StackPeek_ShouldReturnCorrectData_WhenStackHas1Item()
        {
            // Arrange
            var stack = new P1StackDataStructure.Stack<string>(3);
            string expectedItem = "String peek";
            stack.Push(expectedItem);
            int expectedCount = 1;

            // Act
            string actualItem = stack.Peek();
            int actualCount = stack.Count;

            // Assert
            Assert.Equal(expectedItem, actualItem);
            Assert.Equal(expectedCount, actualCount);
        }

        [Fact]
        public void StackPeek_ShouldReturnCorrectData_WhenStackHasMultipleItems()
        {
            // Arrange
            var stack = new P1StackDataStructure.Stack<string>(3);
            stack.Push("String 1");
            stack.Push("String 2");
            string expectedItem = "String peek";
            stack.Push(expectedItem);
            int expectedCount = 3;

            // Act
            string actualElement = stack.Peek();
            int actualCount = stack.Count;

            // Assert
            Assert.Equal(expectedItem, actualElement);
            Assert.Equal(expectedCount, actualCount);
        }
    }
}
