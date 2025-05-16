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
        public object GetFieldValue(string fieldName, string tableName, string conditionField, string conditionValue)
        {
            object fieldValue = null;
            string query = $"SELECT {fieldName} FROM {tableName} WHERE {conditionField} = @ConditionValue";

            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ConditionValue", conditionValue);
                        fieldValue = cmd.ExecuteScalar();
                    }
                }
                catch
                {
                    fieldValue = null;
                }
                connection.Close();
            }

            return fieldValue;
        }
        public object CmdGet(string query)
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thực thi truy vấn và lấy giá trị
                    object result = command.ExecuteScalar();
                    return result == DBNull.Value ? null : result;
                }
            }
        }
        public void Command(string query)
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
        public DataTable HoaDon(string mahoadon)
        {
            DataTable dt = new DataTable();
            string query = "select * from HoaDon where MaHoaDon = '" + mahoadon + "'";
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
                tk.HoTen,
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
        public DataTable all_ADMIN()
        {
            DataTable dt = new DataTable();
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
                TaiKhoan tk ON hd.TenTaiKhoan = tk.TenTaiKhoan
            ";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dt);
                sqlConnection.Close();
            }
            return dt;
        }
        public DataTable getTaiKhoan_ADMIN()
        {
            DataTable dt = new DataTable();
            string query = @"
            SELECT 
                tk.TenTaiKhoan,
                tk.MatKhau,
                tk.HoTen,
                tk.Email,
                tk.SoDienThoai,
                tk.DiaChi
            FROM 
                TaiKhoan tk
            ";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dt);
                sqlConnection.Close();
            }
            return dt;
        }
        public DataTable ChuaThanhToan_ADMIN()
        {
            DataTable dt = new DataTable();
            string query = @"
            SELECT DISTINCT TaiKhoan.TenTaiKhoan,TaiKhoan.Email,TaiKhoan.HoTen,TaiKhoan.SoDienThoai, TaiKhoan.DiaChi
            FROM TaiKhoan
            JOIN HoaDon ON TaiKhoan.TenTaiKhoan = HoaDon.TenTaiKhoan
            WHERE TrangThai = 0;

            ";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dt);
                sqlConnection.Close();
            }
            return dt;
        }
        public void addAccount(string tentk, string matkhau, string email, string hoten, string sdt, string diachi)
        {
            Modify modify = new Modify();
            if (hoten.Trim() == "") { MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else if (email.Trim() == "") { MessageBox.Show("Vui lòng nhập Email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else if (sdt.Trim() == "") { MessageBox.Show("Vui lòng nhập Số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            else if (diachi.Trim() == "") { MessageBox.Show("Vui lòng nhập địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else if (tentk.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else if (matkhau.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else if (modify.TaiKhoans("Select * from TaiKhoan where Email = '" + email + "'").Count() != 0)
            {

                MessageBox.Show("Email này đã được đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                try
                {
                    string query = "Insert into TaiKhoan values ('" + tentk + "','" + matkhau + "','" + email + "','" + hoten + "','" + sdt + "','" + diachi + "')";
                    modify.Command(query);
                    MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Tên tài khoản này đã được đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void editAccount(string oldTenTaiKhoan, string newTenTaiKhoan, string matkhau, string email, string hoten, string sdt, string diachi)
        {
            if (hoten.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (sdt.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (diachi.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (newTenTaiKhoan.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (matkhau.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();

                // Kiểm tra trùng tên tài khoản nếu đổi tên
                if (!string.Equals(oldTenTaiKhoan, newTenTaiKhoan, StringComparison.OrdinalIgnoreCase))
                {
                    string checkUsernameQuery = "SELECT COUNT(*) FROM TaiKhoan WHERE TenTaiKhoan = @NewTenTaiKhoan";
                    using (SqlCommand cmd = new SqlCommand(checkUsernameQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@NewTenTaiKhoan", newTenTaiKhoan);
                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Tên tài khoản này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }

                string checkEmailQuery = "SELECT COUNT(*) FROM TaiKhoan WHERE Email = @Email AND TenTaiKhoan <> @OldTenTaiKhoan";
                using (SqlCommand cmd = new SqlCommand(checkEmailQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@OldTenTaiKhoan", oldTenTaiKhoan);
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
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
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@NewTenTaiKhoan", newTenTaiKhoan);
                        cmd.Parameters.AddWithValue("@MatKhau", matkhau);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@HoTen", hoten);
                        cmd.Parameters.AddWithValue("@SoDienThoai", sdt);
                        cmd.Parameters.AddWithValue("@DiaChi", diachi);
                        cmd.Parameters.AddWithValue("@OldTenTaiKhoan", oldTenTaiKhoan);
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy tài khoản để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra khi sửa tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
            }
        }

        public void deleteAccount(string tenTaiKhoan)
        {
            if (string.IsNullOrWhiteSpace(tenTaiKhoan))
            {
                MessageBox.Show("Tên tài khoản trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa tài khoản '{tenTaiKhoan}' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                try
                {
                    conn.Open();

                    // Xóa các hóa đơn liên quan trước
                    string deleteHoaDonQuery = "DELETE FROM HoaDon WHERE TenTaiKhoan = @TenTaiKhoan";
                    using (SqlCommand cmdHoaDon = new SqlCommand(deleteHoaDonQuery, conn))
                    {
                        cmdHoaDon.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                        cmdHoaDon.ExecuteNonQuery();
                    }

                    // Sau đó xóa tài khoản
                    string deleteTaiKhoanQuery = "DELETE FROM TaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan";
                    using (SqlCommand cmdTaiKhoan = new SqlCommand(deleteTaiKhoanQuery, conn))
                    {
                        cmdTaiKhoan.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                        int rows = cmdTaiKhoan.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy tài khoản để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi xóa tài khoản!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
