using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TienDien
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Modify modify = new Modify();
            string query = $@"
                        UPDATE HoaDon 
                        SET ThanhTien = 
                            CASE
                                WHEN SoDien <= 50 THEN SoDien * 1893
                                WHEN SoDien <= 100 THEN (50 * 1893) + ((SoDien - 50) * 1956)
                                WHEN SoDien <= 200 THEN (50 * 1893) + (50 * 1956) + ((SoDien - 100) * 2271)
                                WHEN SoDien <= 300 THEN (50 * 1893) + (50 * 1956) + (100 * 2271) + ((SoDien - 200) * 2860)
                                WHEN SoDien <= 400 THEN (50 * 1893) + (50 * 1956) + (100 * 2271) + (100 * 2860) + ((SoDien - 300) * 3197)
                                ELSE (50 * 1893) + (50 * 1956) + (100 * 2271) + (100 * 2860) + (100 * 3197) + ((SoDien - 400) * 3302)
                            END
                    ";
            modify.Command(query);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
