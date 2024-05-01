using StudentManagement.ConsoleApp.Data;
using StudentManagement.ConsoleApp.Repository.IRepository;
using StudentManagement.ConsoleApp.Models.CourseViewModel;

namespace StudentManagement.ConsoleApp.Repository
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {


        public CourseRepository() { }
    }
}