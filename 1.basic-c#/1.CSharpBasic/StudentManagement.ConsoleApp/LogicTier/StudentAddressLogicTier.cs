using StudentManagement.ConsoleApp.Repository;
using StudentManagement.ConsoleApp.Models.StudentAddressViewModel;


namespace StudentManagement.ConsoleApp.LogicTier
{
    public class StudentAddressLogicTier
    {
        private readonly StudentAddressRepository _studentAddressRepository;

        public StudentAddressLogicTier()
        {
            _studentAddressRepository = new StudentAddressRepository();
        }

        public StudentAddressDTO Input()
        {
            Console.Write("Enter student address: ");
            string address = Console.ReadLine();

            Console.Write("Enter city: ");
            string city = Console.ReadLine();

            Console.Write("Enter state: ");
            string state = Console.ReadLine();

            Console.Write("Enter country: ");
            string country = Console.ReadLine();

            StudentAddressDTO studentAddressDTO = new StudentAddressDTO
            {
                Address = address,
                City = city,
                State = state,
                Country = country
            };

            return studentAddressDTO;
        }

        public async Task Add(StudentAddressDTO studentAddressDTO)
        {
            try
            {
                StudentAddress studentAddress = new StudentAddress
                {
                    Address = studentAddressDTO.Address,
                    City = studentAddressDTO.City,
                    State = studentAddressDTO.State,
                    Country = studentAddressDTO.Country
                };

                await _studentAddressRepository.AddAsync(studentAddress);
                await _studentAddressRepository.CommitAsync();
                Console.WriteLine("Student address added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding student address: {ex.Message}");
            }
        }

        public async Task Update(int studentAddressId, StudentAddressDTO studentAddressDTO)
        {
            try
            {
                var studentAddress = await _studentAddressRepository.GetByIdAsync(studentAddressId);
                if (studentAddress == null)
                {
                    Console.WriteLine($"Student address with Id {studentAddressId} not found.");
                    return;
                }

                studentAddress.Address = studentAddressDTO.Address;
                studentAddress.City = studentAddressDTO.City;
                studentAddress.State = studentAddressDTO.State;
                studentAddress.Country = studentAddressDTO.Country;

                _studentAddressRepository.Update(studentAddress);
                await _studentAddressRepository.CommitAsync();

                Console.WriteLine($"Student address with Id {studentAddressId} updated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating student address with Id {studentAddressId}: {ex.Message}");
            }
        }

        public async Task Delete(int studentAddressId)
        {
            try
            {
                _studentAddressRepository.Delete(studentAddressId);
                await _studentAddressRepository.CommitAsync();
                Console.WriteLine($"Student address with Id {studentAddressId} deleted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting student address with Id {studentAddressId}: {ex.Message}");
            }
        }

        public async Task<IEnumerable<StudentAddress>> Get()
        {
            try
            {
                var studentAddresses = await _studentAddressRepository.GetListAsync();
                if (studentAddresses.Count() == 0)
                {
                    Console.WriteLine("No student addresses found.");
                }
                else
                {
                    Console.WriteLine("All student addresses:");
                    foreach (var studentAddress in studentAddresses)
                    {
                        Console.WriteLine($"Id: {studentAddress.Id}, Address: {studentAddress.Address}, City: {studentAddress.City}, State: {studentAddress.State}, Country: {studentAddress.Country}");
                    }
                }

                return studentAddresses;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving student addresses: {ex.Message}");
                return new List<StudentAddress>();
            }
        }
    }
}