using StudentManagement.ConsoleApp.Repository;
using StudentManagement.ConsoleApp.Models.GradeViewModel;


namespace StudentManagement.ConsoleApp.LogicTier
{
    public class GradeLogicTier
    {
        private readonly GradeRepository _gradeRepository = new GradeRepository();

        public async Task<GradeDTO> InputGrade()
        {
            Console.Write("Enter grade name: ");
            string gradeName = Console.ReadLine();

            Console.Write("Enter grade section: ");
            string gradeSection = Console.ReadLine();

            GradeDTO gradeDTO = new GradeDTO
            {
                Name = gradeName,
                Section = gradeSection
            };

            return gradeDTO;
        }

        public async Task Add(GradeDTO gradeDTO)
        {
            Grade grade = new Grade
            {
                Name = gradeDTO.Name,
                Section = gradeDTO.Section
            };

            await _gradeRepository.AddAsync(grade);
            await _gradeRepository.CommitAsync();
        }

        public async Task DeleteGrade(int gradeId)
        {
            try
            {
                _gradeRepository.Delete(gradeId);
                await _gradeRepository.CommitAsync();
                Console.WriteLine($"Grade with Id {gradeId} deleted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting grade with Id {gradeId}: {ex.Message}");
            }
        }

        public async Task UpdateGrade(int gradeId, GradeDTO gradeDTO)
        {
            try
            {
                var grade = await _gradeRepository.GetByIdAsync(gradeId);
                if (grade == null)
                {
                    Console.WriteLine($"Grade with Id {gradeId} not found.");
                    return;
                }

                grade.Name = gradeDTO.Name;
                grade.Section = gradeDTO.Section;

                _gradeRepository.Update(grade);
                await _gradeRepository.CommitAsync();

                Console.WriteLine($"Grade with Id {gradeId} updated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating grade with Id {gradeId}: {ex.Message}");
            }
        }

        public async Task<IEnumerable<Grade>> GetAllGrades()
        {
            try
            {
                var grades = await _gradeRepository.GetListAsync();
                if (grades.Count() == 0)
                {
                    Console.WriteLine("No grades found.");
                }
                else
                {
                    Console.WriteLine("All grades:");
                    foreach (var grade in grades)
                    {
                        Console.WriteLine($"Id: {grade.Id}, Name: {grade.Name}, Section: {grade.Section}");
                    }
                }

                return grades;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving grades: {ex.Message}");
                return new List<Grade>();
            }
        }

        public async Task<Grade> GetGradeById(int gradeId)
        {
            try
            {
                var grade = await _gradeRepository.GetByIdAsync(gradeId);
                if (grade == null)
                {
                    Console.WriteLine($"Grade with Id {gradeId} not found.");
                }
                else
                {
                    Console.WriteLine($"Grade with Id {gradeId}: Name = {grade.Name}, Section = {grade.Section}");
                }

                return grade;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving grade with Id {gradeId}: {ex.Message}");
                return null;
            }
        }
    }

}