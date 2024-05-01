using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace p5ADONET
{
    public class CRUD<T> where T : class
    {
        public class CRUDOperations<T> where T : class
        {
            private readonly string _connectionString;
            private readonly string _tableName;

            public CRUDOperations(string connectionString, string tableName)
            {
                _connectionString = connectionString;
                _tableName = tableName;
            }

            public int Add(T obj)
            {
                try
                {
                    using var connection = new SqlConnection(_connectionString);
                    using var command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = $"INSERT INTO {_tableName} VALUES ({CRUDOperations<T>.GetParamString(obj)})";
                    var parameters = CRUDOperations<T>.GetParameters(obj);
                    Console.WriteLine($"GetParamString(obj): {CRUDOperations<T>.GetParamString(obj)}");
                    Console.WriteLine($"parameters: {string.Join(", ", parameters.ToList())}");
                    command.Parameters.AddRange(parameters);
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred while inserting the object.", ex);
                }
            }

            public List<T> GetAll()
            {
                try
                {
                    var result = new List<T>();
                    using (var connection = new SqlConnection(_connectionString))
                    using (var command = new SqlCommand($"SELECT * FROM {_tableName}", connection))
                    {
                        connection.Open();
                        using var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            var obj = CRUDOperations<T>.GetObjectFromReader(reader);
                            result.Add(obj);
                        }
                    }
                    return result;
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred while getting all the objects.", ex);
                }
            }

            public int Update(int id, T obj)
            {
                try
                {
                    using var connection = new SqlConnection(_connectionString);
                    using var command = connection.CreateCommand();
                    command.CommandText = $"UPDATE {_tableName} SET ";
                    var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                    for (int i = 0; i < properties.Length; i++)
                    {
                        var property = properties[i];
                        if (property.Name != "ID")
                        {
                            command.CommandText += $"{property.Name} = @{property.Name}";
                            if (i < properties.Length - 1)
                            {
                                command.CommandText += ", ";
                            }
                            var value = property.GetValue(obj);
                            command.Parameters.AddWithValue($"@{property.Name}", value ?? DBNull.Value);
                        }
                    }
                    command.CommandText += " WHERE ID = @ID";
                    command.Parameters.AddWithValue("@ID", id);
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred while updating the object.", ex);
                }
            }

            public int Delete(int id)
            {
                try
                {
                    using var connection = new SqlConnection(_connectionString);
                    using var command = new SqlCommand($"DELETE FROM {_tableName} WHERE ID = @param1", connection);
                    command.Parameters.AddWithValue("@param1", id);
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred while deleting the object.", ex);
                }
            }

            private static SqlParameter[] GetParameters(T obj)
            {
                var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                return properties.Where(x => x.Name != "ID").Select(p =>
                    new SqlParameter($"@{p.Name.ToLower()}", p.GetValue(obj))
                ).ToArray();
            }

            /// <summary>
            /// Ex: "Name,Description"
            /// </summary>
            private static string GetParamString(T obj) => string.Join(",", CRUDOperations<T>.GetParameters(obj).ToList());

            private static T GetObjectFromReader(IDataReader reader)
            {
                var obj = Activator.CreateInstance<T>();
                var properties = obj.GetType().GetProperties();
                foreach (var property in properties)
                {
                    var value = reader[property.Name];
                    if (value != DBNull.Value)
                    {
                        property.SetValue(obj, value);
                    }
                }
                return obj;
            }
        }

    }
