using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

                    string deleteChiSoDienQuery = "DELETE FROM ChiSoDien WHERE TenTaiKhoan = @TenTaiKhoan";
                    using (var cmdChiSoDien = new SqlCommand(deleteChiSoDienQuery, conn))
                    {
                        cmdChiSoDien.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                        cmdChiSoDien.ExecuteNonQuery();
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
        public void LoadComboboxKhachHang(ComboBox cb)
        {
            string query = "SELECT TenTaiKhoan FROM TaiKhoan";
            DataTable dt = GetDataTable(query);
            cb.DataSource = dt;
            cb.DisplayMember = "TenTaiKhoan";
            cb.ValueMember = "TenTaiKhoan";
            cb.SelectedIndex = -1;
        }
        public static bool CheckExistHD(string tentk, int thang, int nam)
        {
            string query = "SELECT COUNT(*) FROM HoaDon WHERE TenTaiKhoan = @TenTaiKhoan AND ThangHoaDon = @ThangHoaDon AND NamHoaDon = @NamHoaDon";
            using (var connection = Connection.GetSqlConnection())
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@TenTaiKhoan", tentk);
                command.Parameters.AddWithValue("@ThangHoaDon", thang);
                command.Parameters.AddWithValue("@NamHoaDon", nam);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
        public void AddHoaDon(string tentk, double sodien, int thang, int nam, double thanhTien)
        {
            string query = "INSERT INTO HoaDon (TenTaiKhoan, SoDien, ThangHoaDon, NamHoaDon, ThoiGianTao, ThanhTien) VALUES (@TenTaiKhoan, @SoDien, @ThangHoaDon, @NamHoaDon, @ThoiGianTao, @ThanhTien)";
            Command(query,
                new SqlParameter("@TenTaiKhoan", tentk),
                new SqlParameter("@SoDien", sodien),
                new SqlParameter("@ThangHoaDon", thang),
                new SqlParameter("@NamHoaDon", nam),
                new SqlParameter("@ThoiGianTao", DateTime.Now),
                new SqlParameter("@ThanhTien", thanhTien));
        }
        public void addChiSoDien(string tentk, int thang, int nam, float chiSoCu, float chiSoMoi)
        {
            string query = "INSERT INTO ChiSoDien (TenTaiKhoan, Thang, Nam, ChiSoCu, ChiSoMoi) VALUES (@TenTaiKhoan, @Thang, @Nam, @ChiSoCu, @ChiSoMoi)";
            Command(query,
                new SqlParameter("@TenTaiKhoan", tentk),
                new SqlParameter("@Thang", thang),
                new SqlParameter("@Nam", nam),
                new SqlParameter("@ChiSoCu", chiSoCu),
                new SqlParameter("@ChiSoMoi", chiSoMoi));
        }
        public double LayChiSoCuGanNhat(string tentk)
        {
            string query = @"
                SELECT TOP 1 ChiSoMoi
                FROM ChiSoDien
                WHERE TenTaiKhoan = @TenTaiKhoan
                ORDER BY Nam DESC, Thang DESC";

            using (var conn = Connection.GetSqlConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@TenTaiKhoan", tentk);
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToDouble(result);
                }
            }
            return 0;
        }
        public DataTable GetHoaDon_QLHD()
        {
            string query = @"
                SELECT 
                    *
                FROM 
                    HoaDon ";
            DataTable dt = GetDataTable(query);
            return dt;
        }
        public void deleteHoaDon_ChiSoDien(int maHoaDon, int thang, int nam, string tenTaiKhoan)
        {
            using (var conn = Connection.GetSqlConnection())
            {
                conn.Open();
                // Xóa hóa đơn theo MaHoaDon
                string deleteHoaDonQuery = "DELETE FROM HoaDon WHERE MaHoaDon = @MaHoaDon";
                using (var cmdHoaDon = new SqlCommand(deleteHoaDonQuery, conn))
                {
                    cmdHoaDon.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                    cmdHoaDon.ExecuteNonQuery();
                }
                // Xóa chỉ số điện theo TenTaiKhoan, Thang, Nam
                string deleteChiSoDienQuery = "DELETE FROM ChiSoDien WHERE TenTaiKhoan = @TenTaiKhoan AND Thang = @Thang AND Nam = @Nam";
                using (var cmdChiSoDien = new SqlCommand(deleteChiSoDienQuery, conn))
                {
                    cmdChiSoDien.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                    cmdChiSoDien.Parameters.AddWithValue("@Thang", thang);
                    cmdChiSoDien.Parameters.AddWithValue("@Nam", nam);
                    cmdChiSoDien.ExecuteNonQuery();
                }
            }
        }
        public void UpdateThongTinCaNhan(string tentk, string hoTen, string email, string sdt, string diachi)
        {
            string query = "UPDATE TaiKhoan SET HoTen = @HoTen, Email = @Email, SoDienThoai = @SoDienThoai, DiaChi = @DiaChi WHERE TenTaiKhoan = @TenTaiKhoan";
            Command(query,
                new SqlParameter("@TenTaiKhoan", tentk),
                new SqlParameter("@HoTen", hoTen),
                new SqlParameter("@Email", email),
                new SqlParameter("@SoDienThoai", sdt),
                new SqlParameter("@DiaChi", diachi));
        }
        public void updateMatKhau(string tentk, string mkCu, string mkMoi)
        {
            if (string.IsNullOrWhiteSpace(mkCu) || string.IsNullOrWhiteSpace(mkMoi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Kiểm tra mật khẩu cũ có đúng không
            string checkQuery = "SELECT COUNT(*) FROM TaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan AND MatKhau = @MatKhauCu";
            int count = 0;
            using (var conn = Connection.GetSqlConnection())
            using (var cmd = new SqlCommand(checkQuery, conn))
            {
                cmd.Parameters.AddWithValue("@TenTaiKhoan", tentk);
                cmd.Parameters.AddWithValue("@MatKhauCu", mkCu);
                conn.Open();
                count = (int)cmd.ExecuteScalar();
            }

            if (count == 0)
            {
                MessageBox.Show("Mật khẩu cũ không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string query = "UPDATE TaiKhoan SET MatKhau = @MatKhau WHERE TenTaiKhoan = @TenTaiKhoan";
            Command(query,
                new SqlParameter("@TenTaiKhoan", tentk),
                new SqlParameter("@MatKhau", mkMoi));
            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
