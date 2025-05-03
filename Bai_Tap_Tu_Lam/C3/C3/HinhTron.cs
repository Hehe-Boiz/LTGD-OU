using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3
{
    internal class HinhTron
    {
        public Diem TamDuongTron { get; set; }
        public double BanKinh { get; set; }
        public HinhTron(Diem tamDuongTron, double banKinh)
        {
            TamDuongTron = tamDuongTron;
            BanKinh = banKinh;
        }
        public double DienTich()
        {
            return Math.PI * BanKinh * BanKinh;
        }
        public double ChuVi()
        {
            return 2 * Math.PI * BanKinh;
        }
        public bool IsNamTrongDuongTron(Diem O)
        {
            if (Math.Pow(O.X - TamDuongTron.X, 2) + Math.Pow(O.Y - TamDuongTron.Y, 2) <= Math.Pow(BanKinh, 2))
            {
                return true;
            }
            return false;
        }


    }
}
