using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3
{
    public class Phanso
    {
        public int Tuso { get; set; }
        public int Mauso { get; set; }

        public Phanso() { }

        public Phanso(int tu, int mau)
        {
            if (mau == 0)
                throw new DivideByZeroException("Mẫu số không được bằng 0");
            Tuso = tu;
            Mauso = mau;
            Rutgon(); // Rút gọn sau khi tạo
        }

        public static Phanso Cong(Phanso a, Phanso b)
        {
            return new Phanso(
                a.Tuso * b.Mauso + b.Tuso * a.Mauso,
                a.Mauso * b.Mauso
            );
        }

        public static Phanso Tru(Phanso a, Phanso b)
        {
            return new Phanso(
                a.Tuso * b.Mauso - b.Tuso * a.Mauso,
                a.Mauso * b.Mauso
            );
        }

        public static Phanso Nhan(Phanso a, Phanso b)
        {
            return new Phanso(a.Tuso * b.Tuso, a.Mauso * b.Mauso);
        }

        public static Phanso Chia(Phanso a, Phanso b)
        {
            if (b.Tuso == 0)
                throw new DivideByZeroException("Không thể chia cho phân số có tử số = 0");
            return new Phanso(a.Tuso * b.Mauso, a.Mauso * b.Tuso);
        }

        public static bool BangNhau(Phanso a, Phanso b)
        {
            return a.Tuso * b.Mauso == b.Tuso * a.Mauso;
        }

        private void Rutgon()
        {
            int gcd = GCD(Math.Abs(Tuso), Math.Abs(Mauso));
            Tuso /= gcd;
            Mauso /= gcd;
            if (Mauso < 0)  // Đưa dấu âm lên tử
            {
                Tuso *= -1;
                Mauso *= -1;
            }
        }

        private int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        public override string ToString()
        {
            return $"{Tuso}/{Mauso}";
        }
    }
}