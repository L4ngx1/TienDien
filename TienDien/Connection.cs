using System.Data.SqlClient;

namespace TienDien
{
    internal class Connection
    {
        private static string GetConnectionString()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\TienDien\TienDien\Database1.mdf;Integrated Security=True";
            return connectionString;
        }

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(GetConnectionString());
        }
    }
}


