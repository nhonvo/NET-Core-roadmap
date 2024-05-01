

using StudentManage.ConsoleApp.LogicTier;

namespace StudentManage.ConsoleApp.Presentation
{
    public class StudentPresentation
    {
        private readonly StudentManagement _studentManagement;
        public StudentPresentation()
        {
            _studentManagement = new StudentManagement();
        }

        public async Task Add()
        {
            Console.Write("Enter the name of the student: ");
            string name = Console.ReadLine()!;

            Console.Write("Enter the email of the student: ");
            string email = Console.ReadLine()!;

            Console.Write("Enter the class ID of the student: ");
            int classId = int.Parse(Console.ReadLine()!);

            Student newStudent = new Student()
            {
                Name = name,
                Email = email,
                ClassID = classId
            };

            await _studentManagement.Add(newStudent);
            Console.WriteLine("Student added successfully.");
        }
        public async Task ViewAll()
        {
            Console.Write("Enter the class ID of the student: ");
            int classId = int.Parse(Console.ReadLine()!);

            var students = await _studentManagement.GetAll(classId);
            Console.WriteLine("List of all students:");
            foreach (var s in students)
            {
                Console.WriteLine($"ID: {s.ID}, Name: {s.Name}, Email: {s.Email}, Class ID: {s.ClassID}");
            }
        }

        public async Task Update()
        {
            Console.Write("Enter the ID of the student to update: ");
            int id = int.Parse(Console.ReadLine()!);

            var oldStudent = await _studentManagement.GetById(id);

            if (oldStudent == null)
            {
                Console.WriteLine("Student not found.");
            }
            else
            {
                Console.Write("Enter the new name of the student (old value = {0}): ", oldStudent.Name);
                string name = Console.ReadLine()!;

                Console.Write("Enter the new email of the student (old value = {0}): ", oldStudent.Email);
                string email = Console.ReadLine()!;

                Console.Write("Enter the new class ID of the student (old value = {0}): ", oldStudent.ClassID);
                int classID = int.Parse(Console.ReadLine()!);

                Student updatedStudent = new Student()
                {
                    ID = id,
                    Name = name,
                    Email = email,
                    ClassID = classID
                };

                await _studentManagement.Update(updatedStudent);
                Console.WriteLine("Student updated successfully.");
            }
        }

        public async Task Delete()
        {
            Console.WriteLine("Enter the ID of the student to delete:");
            int id = int.Parse(Console.ReadLine()!);

            Student studentToDelete = await _studentManagement.GetById(id);
            if (studentToDelete == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            await _studentManagement.Delete(id);
            Console.WriteLine("Student deleted successfully.");
        }

    }
}
