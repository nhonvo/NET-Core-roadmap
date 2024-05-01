using StudentManagement.API.Data;
using StudentManagement.API.Repository.IRepository;
using StudentManagement.Core.Models.StudentAddressViewModel;

namespace StudentManagement.API.Repository
{
    public class StudentAddressRepository : Repository<StudentAddress>, IStudentAddressRepository
    {
        private readonly ApplicationDbContext _db;
        public StudentAddressRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}