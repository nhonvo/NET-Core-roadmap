namespace FinalStudentManagement.LogicTier
{
    public class StudentManagement : GenericManagement<Student>
    {
        public async Task<List<Student>> GetAll(int id)
        {
            var obj =  await _dataAccess.GetAll();
            return obj.Where(x => x.ClassID == id).ToList();
        }
    }
}