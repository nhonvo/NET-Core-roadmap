
namespace StudentManage.ConsoleApp.Presentation
{

    class Presentation
    {
        private ClassPresentation classPresentation;
        private ScorePresentation scorePresentation;
        private StudentPresentation studentPresentation;
        private SubjectPresentation subjectPresentation;
        public Presentation()
        {
            classPresentation = new ClassPresentation();
            scorePresentation = new ScorePresentation();
            studentPresentation = new StudentPresentation();
            subjectPresentation = new SubjectPresentation();
        }
        public async Task Run()
        {
            bool exit = false;
            while (!exit)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Select an option: \n");
                Console.WriteLine("1. Class");
                Console.WriteLine("2. Student");
                Console.WriteLine("3. Subject");
                Console.WriteLine("4. Score");
                Console.WriteLine("5. Exit");

                int option = 0;
                while (option < 1 || option > 5)
                {
                    System.Console.WriteLine("Enter your choice...");
                    if (!int.TryParse(Console.ReadLine(), out option))
                        System.Console.WriteLine("Invalid input!!");

                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (option)
                    {
                        case 1:
                            await ClassMenu();
                            break;
                        case 2:
                            await StudentMenu();
                            break;
                        case 3:
                            await SubjectMenu();
                            break;
                        case 4:
                            await ScoreMenu();
                            break;
                        case 5:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
            }
        }
        public async Task ClassMenu()
        {
            bool back = false;
            while (!back)
            {
                Console.WriteLine("Class Menu: \n");
                Console.WriteLine("1. Add a new class");
                Console.WriteLine("2. View all classes");
                Console.WriteLine("3. Update a class");
                Console.WriteLine("4. Delete a class");
                Console.WriteLine("5. Back to main menu");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                int option = 0;
                while (option < 1 || option > 5)
                {
                    System.Console.WriteLine("Enter your choice...");
                    if (!int.TryParse(Console.ReadLine(), out option))
                        System.Console.WriteLine("Invalid input!!");

                    Console.ForegroundColor = ConsoleColor.Gray;
                    switch (option)
                    {
                        case 1:
                            await classPresentation.Add();
                            break;
                        case 2:
                            await classPresentation.ViewAll();
                            break;
                        case 3:
                            await classPresentation.Update();
                            break;
                        case 4:
                            await classPresentation.Delete();
                            break;
                        case 5:
                            back = true;
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
            }
        }
        public async Task StudentMenu()
        {
            bool back = false;
            while (!back)
            {

                Console.WriteLine("STUDENT MENU\n");
                Console.WriteLine("1. Add a new student");
                Console.WriteLine("2. View all students in a class");
                Console.WriteLine("3. Update a student");
                Console.WriteLine("4. Delete a student");
                Console.WriteLine("5. Back to menu");
                Console.Write("\nEnter your choice: ");

                Console.ForegroundColor = ConsoleColor.Green;
                int option = 0;
                while (option < 1 || option > 5)
                {
                    System.Console.WriteLine("Enter your choice...");
                    if (!int.TryParse(Console.ReadLine(), out option))
                        System.Console.WriteLine("Invalid input!!");

                    Console.ForegroundColor = ConsoleColor.Gray;
                    switch (option)
                    {
                        case 1:
                            await studentPresentation.Add();
                            break;
                        case 2:
                            await studentPresentation.ViewAll();
                            break;
                        case 3:
                            await studentPresentation.Update();
                            break;
                        case 4:
                            await studentPresentation.Delete();
                            break;
                        case 5:
                            back = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Press any key to try again...");
                            Console.ReadKey();
                            break;
                    }
                }
            }
        }
        public async Task SubjectMenu()
        {
            bool back = false;
            while (!back)
            {
                Console.WriteLine("\nSubject Menu\n");
                Console.WriteLine("1. Add a new subject");
                Console.WriteLine("2. View all subjects");
                Console.WriteLine("3. Update a subject");
                Console.WriteLine("4. Delete a subject");
                Console.WriteLine("5. Back to menu");
                Console.Write("\nEnter choice: ");

                Console.ForegroundColor = ConsoleColor.Green;
                int option = 0;
                while (option < 1 || option > 5)
                {
                    System.Console.WriteLine("Enter your choice...");
                    if (!int.TryParse(Console.ReadLine(), out option))
                        System.Console.WriteLine("Invalid input!!");

                    Console.ForegroundColor = ConsoleColor.Red;

                    switch (option)
                    {
                        case 1:
                            await subjectPresentation.Add();
                            break;

                        case 2:
                            await subjectPresentation.ViewAll();
                            break;

                        case 3:
                            await subjectPresentation.Update();
                            break;

                        case 4:
                            await subjectPresentation.Delete();
                            break;

                        case 5:
                            return;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }
        }
        public async Task ScoreMenu()
        {
            bool back = false;
            while (!back)
            {
                Console.WriteLine("\nScore Menu\n");
                Console.WriteLine("1. Add a new score");
                Console.WriteLine("2. View all scores for a student");
                Console.WriteLine("3. Update a score");
                Console.WriteLine("4. Delete a score");
                Console.WriteLine("5. Back to menu");

                Console.Write("\nEnter choice: ");

                Console.ForegroundColor = ConsoleColor.Green;
                int option = 0;
                while (option < 1 || option > 5)
                {
                    System.Console.WriteLine("Enter your choice...");
                    if (!int.TryParse(Console.ReadLine(), out option))
                        System.Console.WriteLine("Invalid input!!");

                    Console.ForegroundColor = ConsoleColor.Red;

                    switch (option)
                    {
                        case 1:
                            await scorePresentation.Add();
                            break;

                        case 2:
                            await scorePresentation.ViewAll();
                            break;

                        case 3:
                            await scorePresentation.Update();
                            break;

                        case 4:
                            await scorePresentation.Delete();
                            break;

                        case 5:
                            return;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }

        }
    }

}