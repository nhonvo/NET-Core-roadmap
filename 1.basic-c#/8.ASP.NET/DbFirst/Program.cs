using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst
{
    internal class Program
    {
        public static void ReadSQLCommand(string connectString, string query)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("Id: {0} Name: {1}", reader[0], reader[1]);
                    }
                }
                connection.Close();

            }

        }
        static void Main(string[] args)
        {

            //PlutoDBContext db = new PlutoDBContext();
            string connectString = "Data Source = CVPNHONVTT\\SQLEXPRESS01; Initial Catalog = Pluto; Integrated Security = True";
            string Readquery = "select * from Authors";

            ReadSQLCommand(connectString, Readquery);

        }
    }
}
