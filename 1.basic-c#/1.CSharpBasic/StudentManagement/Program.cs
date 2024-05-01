class Program
{
    public static void Main()
    {
        StudentManagementSystem sms = new StudentManagementSystem();
        int option = 0;

        do
        {
            Console.WriteLine("\n Student Management System ");
            Console.WriteLine("1. Add a new student record");
            Console.WriteLine("2. Search for a student record");
            Console.WriteLine("3. Edit an existing student record");
            Console.WriteLine("4. Delete an existing student record");
            Console.WriteLine("5. Display all students records");
            Console.WriteLine("6. Exit");

            Console.Write("\nEnter your choice: ");
            try
            {

                option = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Just enter integer number !" + ex.Message);
            }

            switch (option)
            {
                case 1:
                    sms.AddStudent();
                    break;

                case 2:
                    sms.SearchStudent();
                    break;

                case 3:
                    sms.EditStudent();
                    break;

                case 4:
                    sms.DeleteStudent();
                    break;

                case 5:
                    sms.DisplayAllStudents();
                    break;

                case 6:
                    sms.ExitSystem();
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please enter a valid choice.");
                    break;
            }
        } while (option != 6);
    }
}

