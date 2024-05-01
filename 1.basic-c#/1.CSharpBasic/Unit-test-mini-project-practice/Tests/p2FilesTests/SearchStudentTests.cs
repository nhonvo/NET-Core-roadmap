namespace p2WorkingWithFileTests;

public class SearchStudentTests
{
    [Fact]
    public void SearchStudent_ShouldReturnCorrectData_WhenExistingRecord()
    {
        // Arrange
        string rollNumber = "12345";
        string name = "John Doe";

        string[] lines = new
        {
            name,
            rollNumber,
            "Math:8",
            "English:9",
            "Science:8"
        };
        string fileName = StudentManagementSystem.DirectoryPath + rollNumber + ".txt";
        File.WriteAllLines(fileName, lines);

        // Act
        var consoleOutput = new StringWriter();
        Console.SetOut(consoleOutput);
        StudentManagementSystem.SearchStudent(rollNumber);

        // Assert
        string expectedOutput = string.Format("Name: {0}\nRoll Number: {1}\nMarks Obtained:\nMath: 85\nEnglish: 90\nScience: 80\n\n",
            name, rollNumber);
        Assert.Equal(expectedOutput, consoleOutput.ToString());

        // Cleanup
        File.Delete(fileName);
    }

    [Fact]
    public void SearchStudent_ShouldReturnCorrectData_WhenNonExistingRecord()
    {
        // Arrange
        string rollNumber = "12345";

        // Act
        var consoleOutput = new StringWriter();
        Console.SetOut(consoleOutput);
        StudentManagementSystem.SearchStudent(rollNumber);

        // Assert
        string expectedOutput = string.Format("Student with Roll Number {0} not found.\n\n", rollNumber);
        Assert.Equal(expectedOutput, consoleOutput.ToString());
    }

    [Fact]
    public void SearchStudent_ShouldReturnCorrectData_WhenInvalidInput()
    {
        // Arrange
        string invalidInput = "abc";

        // Act
        var consoleOutput = new StringWriter();
        Console.SetOut(consoleOutput);
        StudentManagementSystem.SearchStudent(invalidInput);

        // Assert
        string expectedOutput = "Invalid input\n";
        Assert.Equal(expectedOutput, consoleOutput.ToString());
    }
}
