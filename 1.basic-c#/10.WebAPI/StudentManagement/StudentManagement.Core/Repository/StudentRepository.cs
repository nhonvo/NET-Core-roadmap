using StudentManagement.API.Data;
using StudentManagement.API.Repository.IRepository;
using StudentManagement.Core.Models.StudentViewModel;

namespace StudentManagement.API.Repository
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        private readonly ApplicationDbContext _db;
        public StudentRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}