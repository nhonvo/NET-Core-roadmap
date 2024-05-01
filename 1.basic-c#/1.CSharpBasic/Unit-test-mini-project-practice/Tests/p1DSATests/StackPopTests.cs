namespace P1StackDataStructureTests
{
    public class StackPopTests
    {
        [Fact]
        public void StackPop_ShouldThrowNullReferenceException_WhenStackIsNull()
        {
            // Arrange
            P1StackDataStructure.Stack<int> stack = null;

            // Act And Assert
            Assert.Throws<NullReferenceException>(() => stack.Pop());
        }

        [Fact]
        public void StackPop_ShouldThrowInvalidOperationException_WhenStackIsEmpty()
        {
            // Arrange
            var stack = new P1StackDataStructure.Stack<int>(3);

            // Act And Assert
            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Fact]
        public void StackPop_ShouldReturnCorrectData_WhenStackHas1Item()
        {
            // Arrange
            var stack = new P1StackDataStructure.Stack<string>(3);
            string expectedItem = "String 1";
            stack.Push(expectedItem);
            int expectedCount = 0;

            // Act
            string actualItem = stack.Pop();
            int actualCount = stack.Count;

            // Assert
            Assert.Equal(expectedItem, actualItem);
            Assert.Equal(expectedCount, actualCount);
        }

        [Fact]
        public void StackPop_ShouldReturnCorrectData_WhenStackHasMultipleItems()
        {
            // Arrange
            var stack = new P1StackDataStructure.Stack<string>(3);
            string expectedItem = "String 3";
            stack.Push("String 1");
            stack.Push("String 2");
            stack.Push(expectedItem);
            int expectedCount = 2;

            // Act
            string actualItem = stack.Pop();
            int actualCount = stack.Count;

            // Assert
            Assert.Equal(expectedItem, actualItem);
            Assert.Equal(expectedCount, actualCount);
        }
    }
}
