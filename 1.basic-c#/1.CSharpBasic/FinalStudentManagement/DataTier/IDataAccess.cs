namespace FinalStudentManagement.DataTier
{
    public interface IDataAccess<TEntity> where TEntity : class
    {
        Task<List<TEntity>> GetAll();
        Task<bool> Add(TEntity entity);
        Task<bool> Update(TEntity entity);
        Task<bool> Delete(int id);
        Task<TEntity> GetById(int id);
    }
}