public class ArrayTests
{
    [Fact]
    public void GetSecondLargestIndex_WithNullArray_ReturnsMinusOne()
    {
        // Arrange
        int[] arr = null;

        // Act
        int index = Program.GetSecondLargestIndex(arr);

        // Assert
        Assert.Equal(-1, index);
    }

    [Fact]
    public void GetSecondLargestIndex_WithEmptyArray_ReturnsMinusOne()
    {
        // Arrange
        int[] arr = { };

        // Act
        int index = Program.GetSecondLargestIndex(arr);

        // Assert
        Assert.Equal(-1, index);
    }

    [Fact]
    public void GetSecondLargestIndex_WithOneElement_ReturnsMinusOne()
    {
        // Arrange
        int[] arr = { 5 };

        // Act
        int index = Program.GetSecondLargestIndex(arr);

        // Assert
        Assert.Equal(-1, index);
    }

    [Fact]
    public void GetSecondLargestIndex_WithTwoEqualElements_ReturnsTheSecound()
    {
        // Arrange
        int[] arr = { 5, 5 };

        // Act
        int index = Program.GetSecondLargestIndex(arr);

        // Assert
        Assert.Equal(-1, index);
    }

    [Fact]
    public void GetSecondLargestIndex_WithTwoEqualElements_ReturnsTheSecoundLargest()
    {
        // Arrange
        int[] arr = { 50, 50 };

        // Act
        int index = Program.GetSecondLargestIndex(arr);

        // Assert
        Assert.Equal(-1, index);
    }

    [Fact]
    public void GetSecondLargestIndex_WithTwoDistinctElements_ReturnsSecond()
    {
        // Arrange
        int[] arr = { 5, 1 };

        // Act
        int index = Program.GetSecondLargestIndex(arr);

        // Assert
        Assert.Equal(1, index);
    }

    [Fact]
    public void GetSecondLargestIndex_WithTwoDistinctElements_ReturnsFirst()
    {
        // Arrange
        int[] arr = { 1, 5 };

        // Act
        int index = Program.GetSecondLargestIndex(arr);

        // Assert
        Assert.Equal(0, index);
    }

    [Fact]
    public void GetSecondLargestIndex_WithTwoDistinctElements_ReturnsSecond2()
    {
        // Arrange
        int[] arr = { 50, 10 };

        // Act
        int index = Program.GetSecondLargestIndex(arr);

        // Assert
        Assert.Equal(1, index);
    }

    [Fact]
    public void GetSecondLargestIndex_WithTwoDistinctElements_ReturnsFirst2()
    {
        // Arrange
        int[] arr = { 10, 50 };

        // Act
        int index = Program.GetSecondLargestIndex(arr);

        // Assert
        Assert.Equal(0, index);
    }

    [Fact]
    public void GetSecondLargestIndex_WithThreeEqualElements_ReturnsSecondLargest()
    {
        // Arrange
        int[] arr = { 5, 5, 5 };

        // Act
        int index = Program.GetSecondLargestIndex(arr);

        // Assert
        Assert.Equal(-1, index);
    }

    [Fact]
    public void GetSecondLargestIndex_WithThreeEqualElements_ReturnsSecondLargest2()
    {
        // Arrange
        int[] arr = { 50, 50, 50 };

        // Act
        int index = Program.GetSecondLargestIndex(arr);

        // Assert
        Assert.Equal(-1, index);
    }

    [Fact]
    public void GetSecondLargestIndex_With2EqualElements_ReturnsSecondLargest()
    {
        // Arrange
        int[] arr = { 5, 4, 4 };

        // Act
        int index = Program.GetSecondLargestIndex(arr);

        // Assert
        Assert.Equal(1, index);
    }

    [Fact]
    public void GetSecondLargestIndex_With2EqualElements_ReturnsSecondLargest2()
    {
        // Arrange
        int[] arr = { 40, 50, 40 };

        // Act
        int index = Program.GetSecondLargestIndex(arr);

        // Assert
        Assert.Equal(0, index);
    }

    [Fact]
    public void GetSecondLargestIndex_WithThreeDistinctElements_ReturnsOne()
    {
        // Arrange
        int[] arr = { 5, 1, 3 };

        // Act
        int index = Program.GetSecondLargestIndex(arr);

        // Assert
        Assert.Equal(2, index);
    }

    [Fact]
    public void GetSecondLargestIndex_WithThreeDistinctElements_ReturnsOne2()
    {
        // Arrange
        int[] arr = { 5, 3, 1 };

        // Act
        int index = Program.GetSecondLargestIndex(arr);

        // Assert
        Assert.Equal(1, index);
    }

    [Fact]
    public void GetSecondLargestIndex_WithThreeDistinctElements_ReturnsOne3()
    {
        // Arrange
        int[] arr = { 3, 5, 1 };

        // Act
        int index = Program.GetSecondLargestIndex(arr);

        // Assert
        Assert.Equal(0, index);
    }


    [Fact]
    public void GetSecondLargestIndex_WithThreeDistinctElements_ReturnsOne4()
    {
        // Arrange
        int[] arr = { 3, 1, 5 };

        // Act
        int index = Program.GetSecondLargestIndex(arr);

        // Assert
        Assert.Equal(0, index);
    }

    [Fact]
    public void GetSecondLargestIndex_WithMultipleDistinctElements_ReturnsCorrectIndex()
    {
        // Arrange
        int[] arr = { 1, 5, 2, 9, 5 };

        // Act
        int index = Program.GetSecondLargestIndex(arr);

        // Assert
        Assert.Equal(1, index);
    }

    [Fact]
    public void GetSecondLargestIndex_WithMultipleDistinctElements_ReturnsCorrectIndex2()
    {
        // Arrange
        int[] arr = { 1, 3, 2, 9, 5 };

        // Act
        int index = Program.GetSecondLargestIndex(arr);

        // Assert
        Assert.Equal(4, index);
    }

    [Fact]
    public void GetSecondLargestIndex_WithMultipleDistinctElements_ReturnsCorrectIndex3()
    {
        // Arrange
        int[] arr = { 9, 3, 2, 1, 5 };

        // Act
        int index = Program.GetSecondLargestIndex(arr);

        // Assert
        Assert.Equal(4, index);
    }


    [Fact]
    public void GetSecondLargestIndex_WithMultipleDistinctElements_ReturnsCorrectIndex4()
    {
        // Arrange
        int[] arr = { 9, 3, 2, 1, 6 };

        // Act
        int index = Program.GetSecondLargestIndex(arr);

        // Assert
        Assert.Equal(4, index);
    }

    [Fact]
    public void GetSecondLargestIndex_WithMultipleDistinctElements_ReturnsCorrectIndex5()
    {
        // Arrange
        int[] arr = { 9, 3, 2, 1, 7 };

        // Act
        int index = Program.GetSecondLargestIndex(arr);

        // Assert
        Assert.Equal(4, index);
    }


    [Fact]
    public void GetSecondLargestIndex_WithMultipleDistinctElements_ReturnsCorrectIndex6()
    {
        // Arrange
        int[] arr = { 0, 3, 9, 1, 7 };

        // Act
        int index = Program.GetSecondLargestIndex(arr);

        // Assert
        Assert.Equal(4, index);
    }
}



