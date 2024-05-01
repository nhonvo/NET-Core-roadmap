using System.Data.SqlClient;

namespace AdoSql
{
    class SqlControl
    {
        string sqlStringConnection = @"Data Source=LAPTOP=949JRPAI";
        var connection = new SqlConnection(sqlStringConnection);

    }
}