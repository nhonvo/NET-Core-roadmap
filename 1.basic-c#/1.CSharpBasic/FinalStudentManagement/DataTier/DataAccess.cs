using System.Data.SqlClient;
using FinalStudentManagement.ultis;

namespace FinalStudentManagement.DataTier
{
    public class DataAccess<T> : IDataAccess<T> where T : class
    {
        private readonly string _connection;
        private readonly SqlConnection connection;
        private string tableName = typeof(T).Name;
        public DataAccess()
        {
            _connection = Connection.GetConnectString();
            connection = new SqlConnection(_connection);
        }
        public async Task<List<T>> GetAll()
        {
            List<T> entities = new List<T>();
            try
            {
                string query = $"SELECT * FROM {tableName}";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    await connection.OpenAsync();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (await reader.ReadAsync())
                        {
                            T entity = Activator.CreateInstance<T>();
                            foreach (var property in typeof(T).GetProperties())
                            {
                                var value = reader[property.Name];
                                if (value != DBNull.Value)
                                {
                                    property.SetValue(entity, value);
                                }
                            }
                            entities.Add(entity);
                        }
                    }
                    await connection.CloseAsync();
                }
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
                
                string fieldNames = string.Join(", ", typeof(T).GetProperties()
                                                               .Where(p => p.Name != "ID")
                                                               .Select(p => p.Name));
                string parameterNames = string.Join(", ", typeof(T).GetProperties()
                                                                   .Where(p => p.Name != "ID")
                                                                   .Select(p => "@" + p.Name));
                string query = $"INSERT INTO {tableName} ({fieldNames}) VALUES ({parameterNames})";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    foreach (var property in typeof(T).GetProperties())
                    {
                        command.Parameters.AddWithValue("@" + property.Name, property.GetValue(entity));
                    }
                    await connection.OpenAsync();
                    int rowsAffected = command.ExecuteNonQuery();
                    await connection.CloseAsync();
                    if (rowsAffected == 1)
                    {
                        return true;
                    }
                    return false;
                }
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
                
                string updateValues = string.Join(", ", typeof(T).GetProperties()
                                                                 .Where(p => p.Name != "ID")
                                                                 .Select(p => $"{p.Name} = @{p.Name}"));
                string query = $"UPDATE {tableName} SET {updateValues} WHERE ID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    foreach (var property in typeof(T).GetProperties())
                    {
                        command.Parameters.AddWithValue("@" + property.Name, property.GetValue(entity));
                    }
                    await connection.OpenAsync();
                    int rowsAffected = command.ExecuteNonQuery();
                    await connection.CloseAsync();
                    if (rowsAffected == 1)
                    {
                        return true;
                    }
                    return false;
                }
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
                
                string query = $"DELETE FROM {tableName} WHERE ID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    await connection.OpenAsync();
                    int rowsAffected = command.ExecuteNonQuery();
                    await connection.CloseAsync();
                    if (rowsAffected == 1)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting {typeof(T).Name}: {ex.Message}");
                return false;
            }
        }
        public async Task<T> GetById(int id)
        {
            T entity = null!;
            try
            {
                
                string query = $"SELECT * FROM {tableName} WHERE ID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    await connection.OpenAsync();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (await reader.ReadAsync())
                        {
                            entity = Activator.CreateInstance<T>();
                            foreach (var property in typeof(T).GetProperties())
                            {
                                var value = reader[property.Name];
                                if (value != DBNull.Value)
                                {
                                    property.SetValue(entity, value);
                                }
                            }
                        }
                    }
                    await connection.CloseAsync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving {typeof(T).Name}: {ex.Message}");
            }
            return entity;
        }

    }
    // public sealed class DbSingleton
    // {
    //     private static readonly Lazy<DbSingleton> instance = new Lazy<DbSingleton>(() => new DbSingleton());

    //     private readonly string connectionString;

    //     private DbSingleton()
    //     {
    //         connectionString = "your_connection_string_here";
    //     }

    //     public static DbSingleton Instance => instance.Value;

    //     public IDbConnection CreateConnection()
    //     {
    //         return new SqlConnection(connectionString);
    //     }
    // }

}