class StudentManagementSystem
{
    private const string FilePath = @"..\..\..\Mark data\";
    /// <summary>
    /// Get student obj and write it to file which name is filepath + rollNumber
    /// </summary>
    /// <param name="student"></param>
    public void WriteToFile(Student student)
    {
        string fileName = FilePath + student.RollNumber.ToString() + ".txt";
        try
        {
            using (StreamWriter sw = File.CreateText(fileName))
            {
                sw.WriteLine(student.Name);
                sw.WriteLine(student.RollNumber);
                foreach (KeyValuePair<string, int> kvp in student.MarksObtained)
                {
                    sw.WriteLine(kvp.Key + ":" + kvp.Value);
                }
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine("Can not write the file. Some thing went wrong" + ex.Message);
            throw;
        }
    }
    /// <summary>
    /// print student property to screen from student object
    /// use key value pair to iterate dictionary
    /// </summary>
    /// <param name="student"></param>
    public void Print(string Name, int RollNumber, Dictionary<string, int> MarksObtained)
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Roll Number: " + RollNumber);
        Console.WriteLine("Marks Obtained:");
        foreach (KeyValuePair<string, int> kvp in MarksObtained)
        {
            Console.WriteLine(kvp.Key + ":" + kvp.Value);
        }
        Console.WriteLine();
    }
    /// <summary>
    /// enter filename and read the ifle by streamreader
    /// read name in line 1, rollnumber in line 2 and from 3 to null to read mark obtained
    /// split string by ':' to separate name subject and mark
    /// </summary>
    /// <param name="fileName"></param>
    /// <returns></returns>
    public Student ReadFile(string fileName)
    {
        StreamReader reader = File.OpenText(fileName);

        string name = reader.ReadLine()!;
        int rollNum = Convert.ToInt32(reader.ReadLine());
        Dictionary<string, int> marksObtained = new Dictionary<string, int>();

        string line;
        while ((line = reader.ReadLine()!) != null)
        {
            string[] data = line.Split(':');
            marksObtained.Add(data[0], Convert.ToInt32(data[1]));
        }
        reader.Close();
        return new Student(name, rollNum, marksObtained);
    }
    /// <summary>
    /// Enter student information and write to the file
    /// </summary>
    public void AddStudent()
    {
        try
        {
            Console.WriteLine("Enter student name:");
            string name = Console.ReadLine()!;

            Console.WriteLine("Enter studetn Rollnumber:");
            int rollNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter MarksObtained in different subjects:");
            Dictionary<string, int> marksObtained = new Dictionary<string, int>();

            Console.WriteLine("Enter number of subjects:");
            int numSubjects = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numSubjects; i++)
            {
                Console.WriteLine("Enter subject name:");
                string subjectName = Console.ReadLine()!;
                Console.WriteLine("Enter marks obtained:");
                int marks = Convert.ToInt32(Console.ReadLine());
                marksObtained.Add(subjectName, marks);
            }
            Student student = new Student(name, rollNumber, marksObtained);
            WriteToFile(student);

            Console.WriteLine("Student record added successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Can not add student something went wrong" + ex.Message);
        }
    }

    /// <summary>
    /// search student follow roll number
    /// set file name read file and print to screen
    /// </summary>
    public void SearchStudent()
    {
        Console.WriteLine("Enter roll number:");
        int rollNumber = Convert.ToInt32(Console.ReadLine());

        string fileName = FilePath + rollNumber.ToString() + ".txt";

        if (File.Exists(fileName))
        {
            Student student = ReadFile(fileName);
            Print(student.Name, student.RollNumber, student.MarksObtained);
        }
        else
        {
            Console.WriteLine("Student record not found.");
        }
    }
    /// <summary>
    /// read the file if exists enter new student data, write in file again
    /// </summary>
    public void EditStudent()
    {
        Console.Write("Enter RollNumber of the student you want to edit: ");
        int rollNumber = Convert.ToInt32(Console.ReadLine());
        string fileName = FilePath + rollNumber + ".txt";

        if (File.Exists(fileName))
        {
            Student student = ReadFile(fileName);
            Print(student.Name, student.RollNumber, student.MarksObtained);

            // New data for update students
            Console.WriteLine("Enter new data:");

            Console.Write("Name: ");
            string newName = Console.ReadLine()!;
            Console.Write("RollNumber: ");
            int newRollNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Marks obtained:");
            Dictionary<string, int> newMarks = new Dictionary<string, int>();
            foreach (var subject in student.MarksObtained.Keys)
            {
                Console.Write($"{subject}: ");
                int markObtained = Convert.ToInt32(Console.ReadLine());
                newMarks.Add(subject, markObtained);
            }
            Student newStudent = new Student(newName, newRollNumber, newMarks);
            // write to file

            WriteToFile(newStudent);

            Console.WriteLine("Student data updated successfully!");
        }
        else
        {
            Console.WriteLine("Student with the given RollNumber does not exist.");
        }
    }
    /// <summary>
    /// enter rollnumber delete student by delete the file use File static class
    /// </summary>
    public void DeleteStudent()
    {
        Console.WriteLine("Enter the RollNumber of the student to delete:");
        string rollNumber = Console.ReadLine()!;

        string filePath = FilePath + rollNumber + ".txt";
        if (File.Exists(filePath))
        {
            try
            {
                File.Delete(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not delete file something wrong" + ex.Message);
            }
            Console.WriteLine("Student record deleted successfully!");
        }
        else
        {
            Console.WriteLine("Student record with RollNumber {0} does not exist.", rollNumber);
        }
    }
    /// <summary>
    /// file the folder path contain student file, foreach each file and use streamreader 
    /// not use readfile() cause input object Student but not create object in loop
    /// </summary>
    public void DisplayAllStudents()
    {
        string[] file = Directory.GetFiles(FilePath);
        foreach (var item in file)
        {
            if (File.Exists(item))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(item))
                    {
                        string name = reader.ReadLine()!;
                        int rollNum = Convert.ToInt32(reader.ReadLine())!;
                        Dictionary<string, int> marks = new Dictionary<string, int>();
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine()!;
                            string[] markObtained = line.Split(":");
                            marks.Add(markObtained[0], Convert.ToInt32(markObtained[1]));
                        }
                        Print(name, rollNum, marks);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Can not read file something wrong" + ex.Message);
                }

            }
            else
            {
                Console.WriteLine("File do not exists");
            }
        }
    }
    public void ExitSystem()
    {
        Console.WriteLine("Exiting the Student Management System...");
        Environment.Exit(0);
    }

}
