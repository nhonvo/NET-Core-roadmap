using StudentManageList.Core.Models.StudentViewModel;

namespace StudentManageList.Core.Models.StudentAddressViewModel
{
    public class StudentAddress
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public int AddressOfStudentId { get; set; }
        public Student Student { get; set; }
    }
}