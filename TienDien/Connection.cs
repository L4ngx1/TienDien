using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace TienDien
{
    internal class Connection
    {
        private static string GetConnectionString()
        {
            string dbPath = @"C:\Users\ADMIN\Desktop\TienDien\TienDien\Database1.mdf";
            return $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbPath};Integrated Security=True";
        }

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(GetConnectionString());
        }
    }
}

    
