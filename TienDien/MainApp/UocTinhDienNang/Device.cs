using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TienDien.UocTinhDienNang
{
    internal class Device
    {
        public string TenThietBi { get; set; }
        public double CongSuat { get; set; }
        public double SoGio { get; set; }
        public int SoLuong { get; set; }
        public double TongDienNang { get; set; }
        public bool IsChecked { get; set; }
        public string LoaiThietBi { get; set; }
    }
}
