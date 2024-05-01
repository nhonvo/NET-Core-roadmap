using StudentManagement.API.Data;
using StudentManagement.API.Repository.IRepository;
using StudentManagement.Core.Models.CourseViewModel;

namespace StudentManagement.API.Repository
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        private readonly ApplicationDbContext _db;

        public CourseRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}