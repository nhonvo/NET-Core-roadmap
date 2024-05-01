using StudentManagement.ConsoleApp.Data;
using StudentManagement.ConsoleApp.Repository.IRepository;
using StudentManagement.ConsoleApp.Models.GradeViewModel;

namespace StudentManagement.ConsoleApp.Repository
{
    public class GradeRepository : Repository<Grade>, IGradeRepository
    {

        public GradeRepository() { }
    }
}