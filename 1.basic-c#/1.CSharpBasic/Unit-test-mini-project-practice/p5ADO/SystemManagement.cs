using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p5ADONET;

namespace AdoSql
{
    public class SystemManagement
    {
        public static void Run()
        {
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Class");
                Console.WriteLine("2. Student");
                Console.WriteLine("3. Subject");
                Console.WriteLine("4. Score");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                _ = int.TryParse(Console.ReadLine(), out int choice);

                switch (choice)
                {
                    case 1:
                        ClassMenu();
                        break;
                    case 2:
                        StudentMenu();
                        break;
                    case 3:
                        SubjectMenu();
                        break;
                    case 4:
                        ScoreMenu();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        #region menus
        static void ClassMenu()
        {
            while (true)
            {
                Console.WriteLine("Class Menu:");
                Console.WriteLine("1. Add a new class");
                Console.WriteLine("2. View all classes");
                Console.WriteLine("3. Update a class");
                Console.WriteLine("4. Delete a class");
                Console.WriteLine("5. Back to menu");
                Console.Write("Enter your choice: ");
                _ = int.TryParse(Console.ReadLine(), out int choice);

                switch (choice)
                {
                    case 1:
                        AddClass();
                        break;
                    case 2:
                        ViewClasses();
                        break;
                    case 3:
                        UpdateClass();
                        break;
                    case 4:
                        DeleteClass();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        static void StudentMenu()
        {
            while (true)
            {
                Console.WriteLine("Student Menu:");
                Console.WriteLine("1. Add a new student");
                Console.WriteLine("2. View all students in a class");
                Console.WriteLine("3. Update a student");
                Console.WriteLine("4. Delete a student");
                Console.WriteLine("5. Back to menu");
                Console.Write("Enter your choice: ");
                _ = int.TryParse(Console.ReadLine(), out int choice);

                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        ViewStudents();
                        break;
                    case 3:
                        UpdateStudent();
                        break;
                    case 4:
                        DeleteStudent();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        static void SubjectMenu()
        {
            while (true)
            {
                Console.WriteLine("Subject Menu:");
                Console.WriteLine("1. Add a new subject");
                Console.WriteLine("2. View all subjects");
                Console.WriteLine("3. Update a subject");
                Console.WriteLine("4. Delete a subject");
                Console.WriteLine("5. Back to menu");
                Console.Write("Enter your choice: ");
                _ = int.TryParse(Console.ReadLine(), out int choice);

                switch (choice)
                {
                    case 1:
                        AddSubject();
                        break;
                    case 2:
                        ViewSubjects();
                        break;
                    case 3:
                        UpdateSubject();
                        break;
                    case 4:
                        DeleteSubject();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        static void ScoreMenu()
        {
            while (true)
            {
                Console.WriteLine("Score Menu:");
                Console.WriteLine("1. Add a new score");
                Console.WriteLine("2. View all scores for a student");
                Console.WriteLine("3. Update a score");
                Console.WriteLine("4. Delete a score");
                Console.WriteLine("5. Back to menu");
                Console.Write("Enter your choice: ");
                _ = int.TryParse(Console.ReadLine(), out int choice);

                switch (choice)
                {
                    case 1:
                        AddScore();
                        break;
                    case 2:
                        ViewScores();
                        break;
                    case 3:
                        UpdateScore();
                        break;
                    case 4:
                        DeleteScore();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
        #endregion

        #region class
        static void AddClass()
        {
            try
            {
                Console.WriteLine("AddClass");
                Class newItem = new();
                Console.Write("Name: ");
                newItem.Name = Console.ReadLine() ?? "";
                Console.Write("Description: ");
                newItem.Description = Console.ReadLine() ?? "";

                var rowsAffected = SchoolManagement.AddClass(newItem);
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Added.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error: AddClass.");
            }
        }

        static void ViewClasses()
        {
            try
            {
                Console.WriteLine("ViewClasses");
                var allItems = SchoolManagement.ViewClasses();
                foreach (var item in allItems)
                {
                    Console.WriteLine($"ID: {item.ID}, Name: {item.Name}, Description: {item.Description}");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error: ViewClasses.");
            }
        }

        static void UpdateClass()
        {
            try
            {
                Console.WriteLine("UpdateClass");
                Class itemToUpdate = new();
                Console.Write("ID: ");
                itemToUpdate.ID = int.Parse(Console.ReadLine() ?? "");
                Console.Write("Name: ");
                itemToUpdate.Name = Console.ReadLine() ?? "";
                Console.Write("Description: ");
                itemToUpdate.Description = Console.ReadLine() ?? "";

                var rowsAffected = SchoolManagement.UpdateClass(itemToUpdate.ID, itemToUpdate);
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Updated.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error: UpdateClass.");
            }
        }

        static void DeleteClass()
        {
            try
            {
                Console.WriteLine("DeleteClass");
                Console.Write("ID: ");
                _ = int.TryParse(Console.ReadLine(), out int id);
                var rowsAffected = SchoolManagement.DeleteClass(id);
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Deleted.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error: DeleteClass.");
            }
        }
        #endregion

        #region student
        static void AddStudent()
        {
            try
            {
                Console.WriteLine("AddStudent");
                Student newItem = new();
                Console.Write("Name: ");
                newItem.Name = Console.ReadLine() ?? "";
                Console.Write("Email: ");
                newItem.Email = Console.ReadLine() ?? "";
                Console.Write("ClassID: ");
                newItem.ClassID = int.Parse(Console.ReadLine() ?? "");

                var rowsAffected = SchoolManagement.AddStudent(newItem);
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Added.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error: AddClass.");
            }
        }

        static void ViewStudents()
        {
            try
            {
                Console.WriteLine("ViewStudents");
                var allItems = SchoolManagement.ViewStudents();
                foreach (var item in allItems)
                {
                    Console.WriteLine($"ID: {item.ID}, Name: {item.Name}, ClassID: {item.ClassID}, Email: {item.Email}");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error: ViewStudents.");
            }
        }

        static void UpdateStudent()
        {
            try
            {
                Console.WriteLine("UpdateStudent");
                Student itemToUpdate = new();
                Console.Write("ID: ");
                itemToUpdate.ID = int.Parse(Console.ReadLine() ?? "");
                Console.Write("Name: ");
                itemToUpdate.Name = Console.ReadLine() ?? "";
                Console.Write("Email: ");
                itemToUpdate.Email = Console.ReadLine() ?? "";
                Console.Write("ClassID: ");
                itemToUpdate.ClassID = int.Parse(Console.ReadLine() ?? "");

                var rowsAffected = SchoolManagement.UpdateStudent(itemToUpdate.ID, itemToUpdate);
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Updated.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error: UpdateStudent.");
            }
        }

        static void DeleteStudent()
        {
            try
            {
                Console.WriteLine("DeleteStudent");
                Console.Write("ID: ");
                _ = int.TryParse(Console.ReadLine(), out int id);
                var rowsAffected = SchoolManagement.DeleteStudent(id);
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Deleted.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error: DeleteStudent.");
            }
        }
        #endregion

        #region subject
        static void AddSubject()
        {
            try
            {
                Console.WriteLine("AddSubject");
                Subject newItem = new();
                Console.Write("Name: ");
                newItem.Name = Console.ReadLine() ?? "";
                Console.Write("Description: ");
                newItem.Description = Console.ReadLine() ?? "";

                var rowsAffected = SchoolManagement.AddSubject(newItem);
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Added.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error: AddSubject.");
            }
        }

        static void ViewSubjects()
        {
            try
            {
                Console.WriteLine("ViewSubjects");
                var allItems = SchoolManagement.ViewSubjects();
                foreach (var item in allItems)
                {
                    Console.WriteLine($"ID: {item.ID}, Name: {item.Name}, Description: {item.Description}");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error: ViewSubjects.");
            }
        }

        static void UpdateSubject()
        {
            try
            {
                Console.WriteLine("UpdateSubject");
                Subject itemToUpdate = new();
                Console.Write("ID: ");
                itemToUpdate.ID = int.Parse(Console.ReadLine() ?? "");
                Console.Write("Name: ");
                itemToUpdate.Name = Console.ReadLine() ?? "";
                Console.Write("Description: ");
                itemToUpdate.Description = Console.ReadLine() ?? "";

                var rowsAffected = SchoolManagement.UpdateSubject(itemToUpdate.ID, itemToUpdate);
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Updated.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error: UpdateSubject.");
            }
        }

        static void DeleteSubject()
        {
            try
            {
                Console.WriteLine("DeleteSubject");
                Console.Write("ID: ");
                _ = int.TryParse(Console.ReadLine(), out int id);
                var rowsAffected = SchoolManagement.DeleteSubject(id);
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Deleted.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error: DeleteSubject.");
            }
        }
        #endregion

        #region score    
        static void AddScore()
        {
            try
            {
                Console.WriteLine("AddScore");
                Score newItem = new();
                Console.Write("StudentID: ");
                newItem.StudentID = int.Parse(Console.ReadLine() ?? "");
                Console.Write("SubjectID: ");
                newItem.SubjectID = int.Parse(Console.ReadLine() ?? "");
                Console.Write("ScoreValue: ");
                newItem.ScoreValue = int.Parse(Console.ReadLine() ?? "");

                var rowsAffected = SchoolManagement.AddScore(newItem);
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Added.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error: AddScore.");
            }
        }

        static void ViewScores()
        {
            try
            {
                Console.WriteLine("ViewScores");
                var allItems = SchoolManagement.ViewScores();
                foreach (var item in allItems)
                {
                    Console.WriteLine($"ID: {item.ID}, StudentID: {item.StudentID}, SubjectID: {item.SubjectID}, ScoreValue: {item.ScoreValue}");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error: ViewScores.");
            }
        }

        static void UpdateScore()
        {
            try
            {
                Console.WriteLine("UpdateScore");
                Score itemToUpdate = new();
                Console.Write("ID: ");
                itemToUpdate.ID = int.Parse(Console.ReadLine() ?? "");
                Console.Write("StudentID: ");
                itemToUpdate.StudentID = int.Parse(Console.ReadLine() ?? "");
                Console.Write("SubjectID: ");
                itemToUpdate.SubjectID = int.Parse(Console.ReadLine() ?? "");
                Console.Write("ScoreValue: ");
                itemToUpdate.ScoreValue = int.Parse(Console.ReadLine() ?? "");

                var rowsAffected = SchoolManagement.UpdateScore(itemToUpdate.ID, itemToUpdate);
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Updated.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error: UpdateScore.");
            }
        }

        static void DeleteScore()
        {
            try
            {
                Console.WriteLine("DeleteScore");
                Console.Write("ID: ");
                _ = int.TryParse(Console.ReadLine(), out int id);
                var rowsAffected = SchoolManagement.DeleteScore(id);
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Deleted.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error: DeleteScore.");
            }
        }
        #endregion

    }

