using StudentManagement.ConsoleApp.Data;
using StudentManagement.ConsoleApp.Repository.IRepository;
using StudentManagement.ConsoleApp.Models.StudentAddressViewModel;

namespace StudentManagement.ConsoleApp.Repository
{
    public class StudentAddressRepository : Repository<StudentAddress>, IStudentAddressRepository
    {

        public StudentAddressRepository() { }
    }
}