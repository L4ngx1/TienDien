using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TienDien
{
    internal class KhachHang
    {
        public string maKH { get; set; }
        public string hoten { get; set; }
        public string diachi { get; set; }
        public string sdt { get; set; }
        public double elecUsage { get; set; }

        public double CalculateBill()
        {
            double rate = 0;
            if (elecUsage <= 50)
                rate = 1000;
            else if (elecUsage <= 100)
                rate = 1500;
            else
                rate = 2000;
            return elecUsage * rate;
        }
    }
}
