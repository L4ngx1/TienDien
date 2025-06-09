using System.Data.SqlClient;
using System.Configuration;
namespace TienDien
{
    internal class Connection
    {
        private static string GetConnectionString()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["TienDien.Properties.Settings.Database1ConnectionString"].ConnectionString;
            return connectionString;
        }

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(GetConnectionString());
        }
    }
}


