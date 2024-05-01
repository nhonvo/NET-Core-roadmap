namespace StudentManage.ConsoleApp.DataTier
{
    public interface IDataAccess<TEntity> where TEntity : class
    {
        Task<List<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        Task<bool> Delete(int id);
        Task<bool> Update(TEntity entity);
        Task<bool> Add(TEntity entity);

    }
}