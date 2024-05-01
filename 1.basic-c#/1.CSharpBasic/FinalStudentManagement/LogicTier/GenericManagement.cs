using FinalStudentManagement.DataTier;

namespace FinalStudentManagement.LogicTier
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
            if (await _dataAccess.Add(entity))
            {
                System.Console.WriteLine("Added " + entity.ToString());
            }
            System.Console.WriteLine("Can't add " + entity.ToString());

        }
        public virtual async Task Update(T entity)
        {
            if (await _dataAccess.Update(entity))
            {
                System.Console.WriteLine("Updated " + entity.ToString());
            }
            System.Console.WriteLine("Can't update " + entity.ToString());
        }
        public virtual async Task Delete(int id)
        {
            if (await _dataAccess.Delete(id))
            {
                System.Console.WriteLine("Updated " + id.ToString());
            }
            System.Console.WriteLine("Can't update " + id.ToString());
        }
        public virtual async Task<T> GetById(int id) => await _dataAccess.GetById(id);
    }
}