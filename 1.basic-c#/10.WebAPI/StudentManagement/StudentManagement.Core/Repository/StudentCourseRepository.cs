using System.Net.Mime;
using StudentManagement.API.Data;
using StudentManagement.API.Repository.IRepository;
using StudentManagement.Core.Models.StudentCourseViewModel;

namespace StudentManagement.API.Repository
{
    public class StudentCourseRepository : Repository<StudentCourse>, IStudentCourseRepository
    {
        private readonly ApplicationDbContext _db;
        public StudentCourseRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}