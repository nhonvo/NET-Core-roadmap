using StudentManagement.API.Data;
using StudentManagement.API.Repository.IRepository;
using StudentManagement.Core.Models.GradeViewModel;

namespace StudentManagement.API.Repository
{
    public class GradeRepository : Repository<Grade>, IGradeRepository
    {
        private readonly ApplicationDbContext _db;
        public GradeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}