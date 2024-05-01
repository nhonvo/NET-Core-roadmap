namespace p2WorkingWithFile
{
    public static class StudentManagementSystem
    {
        public static readonly string DirectoryPath;

#if DEBUG
        static StudentManagementSystem()
        {
            DirectoryPath = "./DebugStudentRecords";
        }
#elif TESTING
        static  StudentManagementSystem()
        {
            directoryPath = "./TestStudentRecords";
        }
#else
        static StudentManagementSystem()
        {
            directoryPath = "./StudentRecords";
        }
#endif

        public static void Run() { }

        public static void AddStudent() { }

        static public void SearchStudent() { }

        public static void EditStudent() { }

        public static void DeleteStudent() { }

        public static void DisplayAllStudents() { }
    }
}