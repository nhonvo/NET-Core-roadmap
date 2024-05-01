namespace P1StackDataStructureTests
{
    public class StackCountTests
    {
        [Fact]
        public void StackCount_ShouldThrowNullReferenceException_WhenStackIsNull()
        {
            // Arrange
            P1StackDataStructure.Stack<int> stack = null;

            // And And Assert
            Assert.Throws<NullReferenceException>(() => stack.Count);
        }

        [Fact]
        public void StackCount_ShouldReturnCorrectData_WhenStackIsEmpty()
        {
            // Arrange
            var stack = new P1StackDataStructure.Stack<int>(5);
            int expected = 0;

            // Act
            int actual = stack.Count;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StackCount_ShouldReturnCorrectData_WhenStackHas1Item()
        {
            // Arrange
            var stack = new P1StackDataStructure.Stack<string>(5);
            stack.Push("Binh");
            int expected = 1;

            // Act
            int actual = stack.Count;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StackCount_ShouldReturnCorrectData_WhenStackHasMultipleItems()
        {
            // Arrange
            var stack = new P1StackDataStructure.Stack<string>(5);
            stack.Push("Binh");
            stack.Push("Dep");
            stack.Push("Trai");
            int expected = 3;

            // Act
            int actual = stack.Count;

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
