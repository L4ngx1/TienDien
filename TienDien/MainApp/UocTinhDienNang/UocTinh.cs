using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TienDien.UocTinhDienNang;
namespace TienDien
{
    public partial class UocTinh : UserControl
    {
        List<Device> calculatedDevices = new List<Device>();
        public UocTinh()
        {
            InitializeComponent();
        }
        private void OpenFormLoaiThietBi(string LoaiThietBi, List<(string Name, double TongDienNang)> devices)
        {
            Form modal = new Form
            {
                Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                BackColor = Color.White,
                Text = $"{LoaiThietBi}",
                Size = new Size(400, 500),
                StartPosition = FormStartPosition.CenterParent
            };
            FlowLayoutPanel flowPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };
            foreach (var device in devices)
            {
                Panel devicePanel = CreateDevicePanel(device.Name, device.TongDienNang, LoaiThietBi);
                flowPanel.Controls.Add(devicePanel);
            }

            Button btnConfirm = new Button
            {
                Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                ForeColor = System.Drawing.Color.White,
                FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                Cursor = System.Windows.Forms.Cursors.Hand,
                BackColor = System.Drawing.Color.Navy,
                Size = new Size(30, 50),
                Text = "Xác Nhận",
                Dock = DockStyle.Bottom
            };
            btnConfirm.Click += (sender, e) =>
            {
                CalculateDeviceConsumption(LoaiThietBi, flowPanel);
                modal.Close();
            };
            modal.Controls.Add(flowPanel);
            modal.Controls.Add(btnConfirm);
            modal.ShowDialog();
        }
        // Tạo panel cho mỗi thiết bị
        private Panel CreateDevicePanel(string deviceName, double powerConsumption, string categoryName)
        {
            Panel panel = new Panel
            {
                Size = new Size(375, 150),
                BorderStyle = BorderStyle.FixedSingle,
                Tag = powerConsumption // Lưu công suất vào Tag để dễ truy xuất
            };
            CheckBox chkDevice = new CheckBox
            {
                Text = deviceName,
                AutoSize = true,
                Location = new Point(10, 10)
            };
            NumericUpDown numHours = new NumericUpDown
            {
                Minimum = 0,
                Maximum = 24,
                Value = 1,
                Location = new Point(10, 50),
                Width = 100
            };
            Label lblHours = new Label
            {
                AutoSize = true,
                Text = "Số giờ sử dụng",
                Location = new Point(120, 52)
            };
            NumericUpDown numQuantity = new NumericUpDown
            {
                Minimum = 1,
                Maximum = 100,
                Value = 1,
                Location = new Point(10, 90),
                Width = 100
            };
            Label lblQuantity = new Label
            {
                AutoSize = true,
                Text = "Số lượng",
                Location = new Point(120, 92)
            };
            // Kiểm tra và điền lại giá trị nếu đã tồn tại
            var existingDevice = calculatedDevices.FirstOrDefault(d => d.TenThietBi == deviceName && d.LoaiThietBi == categoryName);
            if (existingDevice != null)
            {
                chkDevice.Checked = existingDevice.IsChecked;
                numHours.Value = (decimal)existingDevice.SoGio;
                numQuantity.Value = existingDevice.SoLuong;
            }
            panel.Controls.AddRange(new Control[]
            {
                chkDevice,
                numHours,
                lblHours,
                numQuantity,
                lblQuantity
            });
            return panel;
        }
        // Tính toán điện năng tiêu thụ cho từng thiết bị
        private void CalculateDeviceConsumption(string categoryName, FlowLayoutPanel flowPanel)
        {
            // Xóa các thiết bị cũ trong danh mục này
            calculatedDevices.RemoveAll(d => d.LoaiThietBi == categoryName);
            foreach (Panel panel in flowPanel.Controls)
            {
                var chkDevice = panel.Controls.OfType<CheckBox>().First();
                var numHours = panel.Controls.OfType<NumericUpDown>().First();
                var numQuantity = panel.Controls.OfType<NumericUpDown>().Last();
                // Lấy thông tin từ Tag
                double powerConsumption = Convert.ToDouble(panel.Tag);
                double hours = (double)numHours.Value;
                int quantity = (int)numQuantity.Value;
                // Lưu thông tin chi tiết của thiết bị
                var deviceDetail = new Device
                {
                    TenThietBi = chkDevice.Text,
                    LoaiThietBi = categoryName,
                    CongSuat = powerConsumption,
                    SoGio = hours,
                    SoLuong = quantity,
                    IsChecked = chkDevice.Checked,
                    TongDienNang = chkDevice.Checked ? powerConsumption * hours * quantity : 0
                };
                if (chkDevice.Checked)
                {
                    calculatedDevices.Add(deviceDetail);
                }
            }
        }
        private void btnBepDien_Click(object sender, EventArgs e)
        {
            OpenFormLoaiThietBi("Bếp Điện", new List<(string, double)>
            {
                ("Bếp điện từ", 1.5),
                ("Bếp hồng ngoại", 2.0)
            });
        }
        private void btnTuLanh_Click(object sender, EventArgs e)
        {
            OpenFormLoaiThietBi("Tủ Lạnh", new List<(string, double)>
            {
                ("Tủ lạnh mini", 0.5),
                ("Tủ lạnh lớn", 1.0)
            });
        }
        private void btnMayGiat_Click(object sender, EventArgs e)
        {
            OpenFormLoaiThietBi("Máy Giặt", new List<(string, double)>
            {
                ("Máy giặt cửa trên", 1.2),
                ("Máy giặt cửa trước", 1.5)
            });
        }
        private void btnDenChieuSang_Click(object sender, EventArgs e)
        {
            OpenFormLoaiThietBi("Đèn Chiếu Sáng", new List<(string, double)>
            {
                ("Đèn LED", 0.1),
                ("Đèn Huỳnh Quang", 0.2)
            });
        }
        private void btnMayRuaBat_Click(object sender, EventArgs e)
        {
            OpenFormLoaiThietBi("Máy Rửa Bát", new List<(string, double)>
            {
                ("Máy rửa bát thông thường", 1.5)
            });
        }
        private void btnDieuHoa_Click(object sender, EventArgs e)
        {
            OpenFormLoaiThietBi("Điều Hòa", new List<(string, double)>
            {
                ("Điều hòa cây", 2.5),
                ("Điều hòa âm trần", 2.0)
            });
        }
        private void btnBinhNongLanh_Click(object sender, EventArgs e)
        {
            OpenFormLoaiThietBi("Bình Nóng Lạnh", new List<(string, double)>
            {
                ("Bình nóng lạnh 15L", 1.5),
                ("Bình nóng lạnh 20L", 1.8)
            });
        }
        private void btnLoNuong_Click(object sender, EventArgs e)
        {
            OpenFormLoaiThietBi("Lò Nướng", new List<(string, double)>
            {
                ("Lò nướng điện", 1.5)
            });
        }
        private void btnMaySayQuanAo_Click(object sender, EventArgs e)
        {
            OpenFormLoaiThietBi("Máy Sấy Quần Áo", new List<(string, double)>
            {
                ("Máy sấy quần áo", 1.6)
            });
        }
        private void btnThietBiKhac_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này chưa được triển khai.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnTinhDienNang_Click(object sender, EventArgs e)
        {
            if (calculatedDevices.Count == 0)
            {
                MessageBox.Show("Chưa có thiết bị nào được tính toán.", "Thông Báo");
                return;
            }
            double totalElectricity = calculatedDevices.Sum(d => d.TongDienNang);
            lblTongDienNang.Text = $"Tổng điện năng tiêu thụ: {totalElectricity:N2} kWh";
            // Hiển thị chi tiết
            string deviceDetails = string.Join("\n", calculatedDevices.Select(d =>
                $"{d.TenThietBi}: {d.TongDienNang:N2} kWh"));
            MessageBox.Show(
                $"Chi Tiết Điện Năng Tiêu Thụ:\n\n" +
                $"{deviceDetails}\n\n" +
                $"Tổng điện năng: {totalElectricity:N2} kWh",
                "Tổng Điện Năng",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}