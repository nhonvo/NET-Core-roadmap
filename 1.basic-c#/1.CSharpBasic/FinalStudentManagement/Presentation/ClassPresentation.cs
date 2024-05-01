using FinalStudentManagement.LogicTier;

namespace FinalStudentManagement.Presentation
{
    public class ClassPresentation
    {
        private readonly ClassManagement _classManagement;
        public ClassPresentation()
        {
            _classManagement = new ClassManagement();
        }
        public async Task Add()
        {
            Console.Write("Enter the name of the class: ");
            string name = Console.ReadLine()!;

            Console.Write("Enter the description of the class: ");
            string description = Console.ReadLine()!;

            Class newClass = new Class()
            {
                Name = name,
                Description = description
            };

            await _classManagement.Add(newClass);
            Console.WriteLine("Class added successfully.");
        }

        public async Task ViewAll()
        {
            var classes = await _classManagement.GetAll();
            Console.WriteLine("List of all classes:");
            foreach (var c in classes)
            {
                Console.WriteLine($"ID: {c.ID}, Name: {c.Name}, Description: {c.Description}");
            }
        }

        public async Task Update()
        {
            Console.Write("Enter the ID of the class to update: ");
            int id = int.Parse(Console.ReadLine()!);

            var oldClass = await _classManagement.GetById(id);

            if (oldClass == null)
            {
                Console.WriteLine("Class not found.");
            }
            else
            {
                Console.Write("Enter the new name of the class (old value = {0}): ", oldClass.Name);
                string name = Console.ReadLine()!;

                Console.Write("Enter the new description of the class (old value = {0}): ", oldClass.Description);
                string description = Console.ReadLine()!;

                Class updatedClass = new Class()
                {
                    ID = id,
                    Name = name,
                    Description = description
                };

                await _classManagement.Update(updatedClass);
                Console.WriteLine("Class updated successfully.");
            }
        }
        public async Task Delete()
        {
            Console.WriteLine("Enter the ID of the class to delete:");
            int id = int.Parse(Console.ReadLine()!);

            Class classToDelete = await _classManagement.GetById(id);
            if (classToDelete == null)
            {
                Console.WriteLine("class not found.");
                return;
            }

            await _classManagement.Delete(id);
            Console.WriteLine("class deleted successfully.");
        }

    }
}