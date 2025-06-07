using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TienDien
{
    internal class DienBacThang
    {
        public double dienBacThang(double soDien)
        {
            double tien = 0;

            if (soDien <= 0)
                return 0;

            if (soDien <= 50)
                tien = soDien * 1678;
            else if (soDien <= 100)
                tien = 50 * 1678 + (soDien - 50) * 1734;
            else if (soDien <= 200)
                tien = 50 * 1678 + 50 * 1734 + (soDien - 100) * 2014;
            else if (soDien <= 300)
                tien = 50 * 1678 + 50 * 1734 + 100 * 2014 + (soDien - 200) * 2536;
            else if (soDien <= 400)
                tien = 50 * 1678 + 50 * 1734 + 100 * 2014 + 100 * 2536 + (soDien - 300) * 2834;
            else
                tien = 50 * 1678 + 50 * 1734 + 100 * 2014 + 100 * 2536 + 100 * 2834 + (soDien - 400) * 2927;

            return tien;
        }

    }
}
