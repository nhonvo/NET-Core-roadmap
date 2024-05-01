using StudentManagement.ConsoleApp.Data;
using StudentManagement.ConsoleApp.Repository.IRepository;
using StudentManagement.ConsoleApp.Models.StudentViewModel;

namespace StudentManagement.ConsoleApp.Repository
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        private readonly ApplicationDbContext _db;
        public StudentRepository() { }
    }
}