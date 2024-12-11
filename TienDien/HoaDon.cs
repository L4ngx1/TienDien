using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TienDien
{
    internal class HoaDon
    {
        private string MaHoaDon;
        private string TenTaiKhoan;
        private float SoDien;
        private int ThangHoaDon;
        public HoaDon(string maHoaDon, string tenTaiKhoan, float soDien, int thangHoaDon)
        {
            MaHoaDon=maHoaDon;
            TenTaiKhoan=tenTaiKhoan;
            SoDien=soDien;
            ThangHoaDon=thangHoaDon;
    }
        
public string MaHoaDon1 { get => MaHoaDon; set => MaHoaDon = value; }
        public string TenTaiKhoan1 { get => TenTaiKhoan; set => TenTaiKhoan = value; }
        public float SoDien1 { get => SoDien; set => SoDien = value; }
        public int ThangHoaDon1 { get => ThangHoaDon; set => ThangHoaDon = value; }
    }


}

