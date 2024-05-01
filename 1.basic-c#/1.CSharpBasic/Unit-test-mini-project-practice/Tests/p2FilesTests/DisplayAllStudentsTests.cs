namespace p2WorkingWithFileTests;

public class DisplayAllStudentsTests
{
    /// <summary>
    /// students empty
    /// </summary>
    [Fact]
    public void DisplayAllStudents_ShouldDisplayCorrectMessage_WhenStudentRecordsIsEmpty()
    {
        // Create a test directory with two student records
        Directory.CreateDirectory(StudentManagementSystem.DirectoryPath);

        // Redirect the console output to a StringWriter
        StringWriter swr = new();
        Console.SetOut(swr);

        // Call the DisplayAllStudents method
        StudentManagementSystem.DisplayAllStudents();

        // Get the console output as a string
        string consoleOutput = swr.ToString();

        Console.WriteLine(consoleOutput);

        // Assert that the output contains the names and roll numbers of both students
        Assert.Contains("No student record found", consoleOutput);

        // Clean up the test directory
        Directory.Delete(StudentManagementSystem.DirectoryPath, true);
    }

    /// <summary>
    /// students 1
    /// </summary>
    [Fact]
    public void DisplayAllStudents_ShouldDisplayCorrectMessage_WhenStudentRecordsHas1Item()
    {
        // Create a test directory with two student records
        Directory.CreateDirectory(StudentManagementSystem.DirectoryPath);

        // Create a test student record file
        string testFilePath1 = Path.Combine(StudentManagementSystem.DirectoryPath, "123.txt");
        using (StreamWriter sw = new(testFilePath1))
        {
            sw.WriteLine("John Doe");
            sw.WriteLine("123");
            sw.WriteLine("Maths:80");
            sw.WriteLine("Science:70");
            sw.WriteLine("English:90");
        }

        // Redirect the console output to a StringWriter
        StringWriter swr = new();
        Console.SetOut(swr);

        // Call the DisplayAllStudents method
        StudentManagementSystem.DisplayAllStudents();

        // Get the console output as a string
        string consoleOutput = swr.ToString();

        Console.WriteLine(consoleOutput);

        // Assert that the output contains the names and roll numbers of both students
        Assert.Contains("John Doe", consoleOutput);
        Assert.Contains("123", consoleOutput);
        Assert.Contains("Maths: 80", consoleOutput);
        Assert.Contains("Science: 70", consoleOutput);
        Assert.Contains("English: 90", consoleOutput);

        // Clean up the test directory
        Directory.Delete(StudentManagementSystem.DirectoryPath, true);
    }

    /// <summary>
    /// students multiple
    /// </summary>
    [Fact]
    public void DisplayAllStudents_ShouldDisplayCorrectMessage_WhenStudentRecordsHasMultipleItems()
    {
        // Create a test directory with two student records
        Directory.CreateDirectory(StudentManagementSystem.DirectoryPath);

        // Create a test student record file
        string testFilePath1 = Path.Combine(StudentManagementSystem.DirectoryPath, "123.txt");
        using (StreamWriter sw = new(testFilePath1))
        {
            sw.WriteLine("John Doe");
            sw.WriteLine("123");
            sw.WriteLine("Maths:80");
            sw.WriteLine("Science:70");
            sw.WriteLine("English:90");
        }

        // Create another test student record file
        string testFilePath2 = Path.Combine(StudentManagementSystem.DirectoryPath, "456.txt");
        using (StreamWriter sw = new(testFilePath2))
        {
            sw.WriteLine("Jane Smith");
            sw.WriteLine("456");
            sw.WriteLine("Maths:75");
            sw.WriteLine("Science:85");
            sw.WriteLine("English:95");
        }

        // Redirect the console output to a StringWriter
        StringWriter swr = new();
        Console.SetOut(swr);

        // Call the DisplayAllStudents method
        StudentManagementSystem.DisplayAllStudents();

        // Get the console output as a string
        string consoleOutput = swr.ToString();

        Console.WriteLine(consoleOutput);

        // Assert that the output contains the names and roll numbers of both students
        Assert.Contains("John Doe", consoleOutput);
        Assert.Contains("123", consoleOutput);
        Assert.Contains("Maths: 80", consoleOutput);
        Assert.Contains("Science: 70", consoleOutput);
        Assert.Contains("English: 90", consoleOutput);

        Assert.Contains("Jane Smith", consoleOutput);
        Assert.Contains("456", consoleOutput);
        Assert.Contains("Maths: 75", consoleOutput);
        Assert.Contains("Science: 85", consoleOutput);
        Assert.Contains("English: 95", consoleOutput);

        // Clean up the test directory
        Directory.Delete(StudentManagementSystem.DirectoryPath, true);
    }
}