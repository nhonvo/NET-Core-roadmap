using System;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace AdoSql
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string connectionString = "your_connection_string_here";
            string query = "CREATE TABLE Customers (Id INT PRIMARY KEY IDENTITY, Name VARCHAR(50), Email VARCHAR(50))";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
        }
    }
}