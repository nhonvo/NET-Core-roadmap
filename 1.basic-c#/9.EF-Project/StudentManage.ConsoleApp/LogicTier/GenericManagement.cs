using StudentManage.ConsoleApp.DataTier;

namespace StudentManage.ConsoleApp.LogicTier
{
    public class GenericManagement<T> where T : class, new()
    {
        protected readonly DataAccess<T> _dataAccess;
        public GenericManagement()
        {
            _dataAccess = new DataAccess<T>();
        }
        public virtual async Task<List<T>> GetAll() => await _dataAccess.GetAll();
        public virtual async Task Add(T entity)
        {
            try
            {
                await _dataAccess.Add(entity);
            }
            catch (System.Exception)
            {
                throw new Exception("Can't add " + entity.ToString());
            }
        }
        public virtual async Task Update(T entity)
        {
            try
            {
                await _dataAccess.Update(entity);
            }
            catch (System.Exception)
            {
                throw new Exception("Can't update " + entity.ToString());
            }
        }
        public virtual async Task Delete(int id)
        {
            try
            {
                await _dataAccess.Delete(id);
            }
            catch (System.Exception)
            {
                throw new Exception("Can't update " + id.ToString());
            }
        }
        public virtual async Task<T> GetById(int id) => await _dataAccess.GetById(id);
    }
}