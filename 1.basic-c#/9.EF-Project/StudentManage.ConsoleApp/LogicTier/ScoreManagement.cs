namespace StudentManage.ConsoleApp.LogicTier
{
    public class ScoreManagement : GenericManagement<Score>
    {
        public async Task<List<Score>> GetAll(int id)
        {
            var obj = await _dataAccess.GetAll();
            return obj.Where(x => x.StudentID == id).ToList();
        }
    }
}