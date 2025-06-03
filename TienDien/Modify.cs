using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Reflection.Emit;
using System.Windows.Forms;
namespace TienDien
{
    internal class Modify
    {
        public List<TaiKhoan> TaiKhoans(string query, params SqlParameter[] parameters)
        {
            var taiKhoans = new List<TaiKhoan>();
            using (var sqlConnection = Connection.GetSqlConnection())
            using (var sqlCommand = new SqlCommand(query, sqlConnection))
            {
                if (parameters != null && parameters.Length > 0)
                    sqlCommand.Parameters.AddRange(parameters);
                sqlConnection.Open();
                using (var dataReader = sqlCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        taiKhoans.Add(new TaiKhoan(dataReader.GetString(0), dataReader.GetString(1)));
                    }
                }
            }
            return taiKhoans;
        }

        public object GetFieldValue(string fieldName, string tableName, string conditionField, string conditionValue)
        {
            string query = $"SELECT {fieldName} FROM {tableName} WHERE {conditionField} = @ConditionValue";
            using (var connection = Connection.GetSqlConnection())
            using (var cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@ConditionValue", conditionValue);
                try
                {
                    connection.Open();
                    var fieldValue = cmd.ExecuteScalar();
                    return fieldValue == DBNull.Value ? null : fieldValue;
                }
                catch
                {
                    return null;
                }
            }
        }

        public object CmdGet(string query, params SqlParameter[] parameters)
        {
            using (var connection = Connection.GetSqlConnection())
            using (var command = new SqlCommand(query, connection))
            {
                if (parameters != null && parameters.Length > 0)
                    command.Parameters.AddRange(parameters);
                connection.Open();
                var result = command.ExecuteScalar();
                return result == DBNull.Value ? null : result;
            }
        }

        public void Command(string query, params SqlParameter[] parameters)
        {
            using (var sqlConnection = Connection.GetSqlConnection())
            using (var sqlCommand = new SqlCommand(query, sqlConnection))
            {
                if (parameters != null && parameters.Length > 0)
                    sqlCommand.Parameters.AddRange(parameters);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
        }

        public DataTable GetDataTable(string query, params SqlParameter[] parameters)
        {
            var dt = new DataTable();
            using (var sqlConnection = Connection.GetSqlConnection())
            using (var dataAdapter = new SqlDataAdapter(query, sqlConnection))
            {
                if (parameters != null && parameters.Length > 0)
                    dataAdapter.SelectCommand.Parameters.AddRange(parameters);
                sqlConnection.Open();
                dataAdapter.Fill(dt);
            }
            return dt;
        }

        public DataTable getHoaDon(string tentk)
        {
            string query = "SELECT * FROM HoaDon WHERE TenTaiKhoan = @TenTaiKhoan";
            return GetDataTable(query, new SqlParameter("@TenTaiKhoan", tentk));
        }

        public DataTable HoaDon(string mahoadon)
        {
            string query = "SELECT * FROM HoaDon WHERE MaHoaDon = @MaHoaDon";
            return GetDataTable(query, new SqlParameter("@MaHoaDon", mahoadon));
        }

        public DataTable HoaDon_TaiKhoan(string tentk)
        {
            string query = @"
                    SELECT 
                        hd.MaHoaDon,
                        hd.TenTaiKhoan,
                        hd.SoDien,
                        hd.ThangHoaDon,
                        hd.TrangThai,
                        hd.ThanhTien,
                        tk.Email,
                        tk.HoTen,
                        tk.SoDienThoai,
                        tk.DiaChi
                    FROM 
                        HoaDon hd
                    INNER JOIN 
                        TaiKhoan tk ON hd.TenTaiKhoan = tk.TenTaiKhoan
                    WHERE 
                        hd.TenTaiKhoan = @TenTaiKhoan";
            return GetDataTable(query, new SqlParameter("@TenTaiKhoan", tentk));
        }

        public DataTable all_ADMIN()
        {
            string query = @"
                    SELECT 
                        hd.MaHoaDon,
                        hd.TenTaiKhoan,
                        tk.HoTen,
                        tk.SoDienThoai,
                        tk.Email,
                        tk.DiaChi,
                        hd.ThangHoaDon,
                        hd.TrangThai,
                        hd.SoDien,
                        hd.ThanhTien
                    FROM 
                        HoaDon hd
                    INNER JOIN 
                        TaiKhoan tk ON hd.TenTaiKhoan = tk.TenTaiKhoan";
            return GetDataTable(query);
        }

        public DataTable getTaiKhoan_ADMIN()
        {
            string query = @"
                    SELECT 
                        tk.TenTaiKhoan,
                        tk.MatKhau,
                        tk.HoTen,
                        tk.Email,
                        tk.SoDienThoai,
                        tk.DiaChi
                    FROM 
                        TaiKhoan tk";
            return GetDataTable(query);
        }

        public DataTable ChuaThanhToan_ADMIN()
        {
            string query = @"
                    SELECT DISTINCT TaiKhoan.TenTaiKhoan, TaiKhoan.Email, TaiKhoan.HoTen, TaiKhoan.SoDienThoai, TaiKhoan.DiaChi
                    FROM TaiKhoan
                    JOIN HoaDon ON TaiKhoan.TenTaiKhoan = HoaDon.TenTaiKhoan
                    WHERE TrangThai = 0";
            return GetDataTable(query);
        }

        public void addAccount(string tentk, string matkhau, string email, string hoten, string sdt, string diachi)
        {
            if (string.IsNullOrWhiteSpace(hoten) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(sdt) ||
                string.IsNullOrWhiteSpace(diachi) ||
                string.IsNullOrWhiteSpace(tentk) ||
                string.IsNullOrWhiteSpace(matkhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string checkEmailQuery = "SELECT COUNT(*) FROM TaiKhoan WHERE Email = @Email";
            if ((int)CmdGet(checkEmailQuery, new SqlParameter("@Email", email)) > 0)
            {
                MessageBox.Show("Email này đã được đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                string query = "INSERT INTO TaiKhoan VALUES (@TenTaiKhoan, @MatKhau, @Email, @HoTen, @SoDienThoai, @DiaChi)";
                Command(query,
                    new SqlParameter("@TenTaiKhoan", tentk),
                    new SqlParameter("@MatKhau", matkhau),
                    new SqlParameter("@Email", email),
                    new SqlParameter("@HoTen", hoten),
                    new SqlParameter("@SoDienThoai", sdt),
                    new SqlParameter("@DiaChi", diachi));
                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Tên tài khoản này đã được đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void editAccount(string oldTenTaiKhoan, string newTenTaiKhoan, string matkhau, string email, string hoten, string sdt, string diachi)
        {
            if (string.IsNullOrWhiteSpace(hoten) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(sdt) ||
                string.IsNullOrWhiteSpace(diachi) ||
                string.IsNullOrWhiteSpace(newTenTaiKhoan) ||
                string.IsNullOrWhiteSpace(matkhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var conn = Connection.GetSqlConnection())
            {
                conn.Open();

                if (!string.Equals(oldTenTaiKhoan, newTenTaiKhoan, StringComparison.OrdinalIgnoreCase))
                {
                    string checkUsernameQuery = "SELECT COUNT(*) FROM TaiKhoan WHERE TenTaiKhoan = @NewTenTaiKhoan";
                    using (var cmd = new SqlCommand(checkUsernameQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@NewTenTaiKhoan", newTenTaiKhoan);
                        if ((int)cmd.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("Tên tài khoản này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }

                string checkEmailQuery = "SELECT COUNT(*) FROM TaiKhoan WHERE Email = @Email AND TenTaiKhoan <> @OldTenTaiKhoan";
                using (var cmd = new SqlCommand(checkEmailQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@OldTenTaiKhoan", oldTenTaiKhoan);
                    if ((int)cmd.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("Email này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                string updateQuery = @"UPDATE TaiKhoan 
                                       SET 
                                        TenTaiKhoan = @NewTenTaiKhoan,
                                        MatKhau = @MatKhau, 
                                        Email = @Email, 
                                        HoTen = @HoTen, 
                                        SoDienThoai = @SoDienThoai, 
                                        DiaChi = @DiaChi 
                                       WHERE TenTaiKhoan = @OldTenTaiKhoan";
                try
                {
                    using (var cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@NewTenTaiKhoan", newTenTaiKhoan);
                        cmd.Parameters.AddWithValue("@MatKhau", matkhau);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@HoTen", hoten);
                        cmd.Parameters.AddWithValue("@SoDienThoai", sdt);
                        cmd.Parameters.AddWithValue("@DiaChi", diachi);
                        cmd.Parameters.AddWithValue("@OldTenTaiKhoan", oldTenTaiKhoan);
                        int rows = cmd.ExecuteNonQuery();
                        MessageBox.Show(rows > 0 ? "Sửa thành công!" : "Không tìm thấy tài khoản để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra khi sửa tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void deleteAccount(string tenTaiKhoan)
        {
            if (string.IsNullOrWhiteSpace(tenTaiKhoan))
            {
                MessageBox.Show("Tên tài khoản trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa tài khoản '{tenTaiKhoan}' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            using (var conn = Connection.GetSqlConnection())
            {
                try
                {
                    conn.Open();

                    string deleteHoaDonQuery = "DELETE FROM HoaDon WHERE TenTaiKhoan = @TenTaiKhoan";
                    using (var cmdHoaDon = new SqlCommand(deleteHoaDonQuery, conn))
                    {
                        cmdHoaDon.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                        cmdHoaDon.ExecuteNonQuery();
                    }

                    string deleteTaiKhoanQuery = "DELETE FROM TaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan";
                    using (var cmdTaiKhoan = new SqlCommand(deleteTaiKhoanQuery, conn))
                    {
                        cmdTaiKhoan.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                        int rows = cmdTaiKhoan.ExecuteNonQuery();
                        MessageBox.Show(rows > 0 ? "Xóa tài khoản thành công!" : "Không tìm thấy tài khoản để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi xóa tài khoản!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
