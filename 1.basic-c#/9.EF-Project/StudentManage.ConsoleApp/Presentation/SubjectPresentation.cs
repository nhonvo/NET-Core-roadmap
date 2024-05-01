using StudentManage.ConsoleApp.LogicTier;


namespace StudentManage.ConsoleApp.Presentation
{
    public class SubjectPresentation
    {
        private readonly SubjectManagement _subjectManagement;

        public SubjectPresentation()
        {
            _subjectManagement = new SubjectManagement();
        }

        public async Task Add()
        {
            Console.Write("Enter the name of the subject: ");
            string name = Console.ReadLine()!;

            Console.Write("Enter the description of the subject: ");
            string description = Console.ReadLine()!;

            Subject newSubject = new Subject()
            {
                Name = name,
                Description = description
            };

            await _subjectManagement.Add(newSubject);
            Console.WriteLine("Subject added successfully.");
        }

        public async Task ViewAll()
        {
            var subjects = await _subjectManagement.GetAll();
            Console.WriteLine("List of all subjects:");
            foreach (var s in subjects)
            {
                Console.WriteLine($"ID: {s.ID}, Name: {s.Name}, Description: {s.Description}");
            }
        }

        public async Task Update()
        {
            Console.Write("Enter the ID of the subject to update: ");
            int id = int.Parse(Console.ReadLine()!);

            var oldSubject = await _subjectManagement.GetById(id);

            if (oldSubject == null)
            {
                Console.WriteLine("Subject not found.");
            }
            else
            {
                Console.Write("Enter the new name of the subject (old value = {0}): ", oldSubject.Name);
                string name = Console.ReadLine()!;

                Console.Write("Enter the new description of the subject (old value = {0}): ", oldSubject.Description);
                string description = Console.ReadLine()!;

                Subject updatedSubject = new Subject()
                {
                    ID = id,
                    Name = name,
                    Description = description
                };

                await _subjectManagement.Update(updatedSubject);
                Console.WriteLine("Subject updated successfully.");
            }
        }

        public async Task Delete()
        {
            Console.Write("Enter the ID of the subject to delete: ");
            int id = int.Parse(Console.ReadLine()!);

            Subject subjectToDelete = await _subjectManagement.GetById(id);
            if (subjectToDelete == null)
            {
                Console.WriteLine("Subject not found.");
                return;
            }

            await _subjectManagement.Delete(id);
            Console.WriteLine("Subject deleted successfully.");
        }
    }
}
