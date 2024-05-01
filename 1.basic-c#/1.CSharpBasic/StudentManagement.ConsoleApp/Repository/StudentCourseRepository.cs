using System.Net.Mime;
using StudentManagement.ConsoleApp.Data;
using StudentManagement.ConsoleApp.Repository.IRepository;
using StudentManagement.ConsoleApp.Models.StudentCourseViewModel;

namespace StudentManagement.ConsoleApp.Repository
{
    public class StudentCourseRepository : Repository<StudentCourse>, IStudentCourseRepository
    {

        public StudentCourseRepository() { }
    }
}