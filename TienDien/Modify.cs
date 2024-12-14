using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Reflection.Emit;
namespace TienDien
{
    internal class Modify
    {
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        public List<TaiKhoan> TaiKhoans(string query)
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    taiKhoans.Add(new TaiKhoan(dataReader.GetString(0), dataReader.GetString(1)));
                }
                sqlConnection.Close();
            }
            return taiKhoans;
        }
        public void Command(string query) // dang ky tai khoan
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery(); // thuc thi cau truy van
                sqlConnection.Close();
            }
        }
        SqlDataAdapter dataAdapter;
        public DataTable getHoaDon(string tentk)
        {
            DataTable dt = new DataTable();
            string query = "select * from HoaDon where TenTaiKhoan = '" + tentk + "'";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dt);
                sqlConnection.Close();
            }
            return dt;
        }
        public DataTable getTaiKhoan(string tentk)
        {
            DataTable dt = new DataTable();
            string query = "select * from TaiKhoan where TenTaiKhoan = '" + tentk + "'";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dt);
                sqlConnection.Close();
            }
            return dt;
        }
        public DataTable HoaDon_TaiKhoan(string tentk)
        {
            DataTable dt = new DataTable();
            string query = @"
            SELECT 
                hd.MaHoaDon,
                hd.TenTaiKhoan,
                hd.SoDien,
                hd.ThangHoaDon,
                hd.TrangThai,
                hd.ThanhTien,
                tk.Email,
                tk.SoDienThoai,
                tk.DiaChi
            FROM 
                HoaDon hd
            INNER JOIN 
                TaiKhoan tk ON hd.TenTaiKhoan = tk.TenTaiKhoan
            WHERE 
                hd.TenTaiKhoan = '" + tentk + "' ";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dt);
                sqlConnection.Close();
            }
            return dt;
        }
    }
}
