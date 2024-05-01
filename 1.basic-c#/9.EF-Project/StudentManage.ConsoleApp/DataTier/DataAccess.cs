using Microsoft.EntityFrameworkCore;

namespace StudentManage.ConsoleApp.DataTier
{
    public class DataAccess<T> : IDataAccess<T> where T : class
    {
        private readonly AppDbContext _db;
        private string tableName = typeof(T).Name;
        public DataAccess()
        {
            _db = new AppDbContext();
        }
        public async Task<List<T>> GetAll()
        {
            List<T> entities = new List<T>();
            try
            {
                entities = await _db.Set<T>().ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving {typeof(T).Name}s: {ex.Message}");
            }
            return entities;
        }

        public async Task<bool> Add(T entity)
        {
            try
            {
                await _db.Set<T>().AddAsync(entity);
                int rowsAffected = await _db.SaveChangesAsync();
                if (rowsAffected == 1)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating {typeof(T).Name}: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> Update(T entity)
        {
            try
            {
                _db.Entry(entity).State = EntityState.Modified;
                int rowsAffected = await _db.SaveChangesAsync();
                if (rowsAffected == 1)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating {typeof(T).Name}: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                T entity = await GetById(id);
                if (entity != null)
                {
                    _db.Set<T>().Remove(entity);
                    int rowsAffected = await _db.SaveChangesAsync();
                    if (rowsAffected == 1)
                    {
                        return true;
                    }
                    return false;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting {typeof(T).Name}: {ex.Message}");
                return false;
            }
        }

        public async Task<T> GetById(int id)
        {
            try
            {
                return await _db.Set<T>().FindAsync(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving {typeof(T).Name}: {ex.Message}");
                return null!;
            }
        }
    }
}