using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3
{
    internal class TamGiac
    {
        double a, b, c;

        public TamGiac(double a, double b, double c)
        {
            this.a = a; this.b = b; this.c = c;
        }

        public double A { get { return a; } set { a = value; } }
        public double B { get { return b; } set { b = value; } }
        public double C { get { return c; } set { c = value; } }

        public string KieuTamGiac()
        {
            double a2 = a * a; double b2 = b * b; double c2 = c * c;
            string ketQua = "Tam giác thường";
            if (a == b || b == c || a == c)
            {
                ketQua = "Tam giác cân";
                if (a == b && b == c)
                {
                    ketQua = "Tam giác đều";
                }
            }
            else if (a2 == b2 + c2 || b2 == a2 + c2 || c2 == a2 + b2)
            {
                ketQua = "Tam giác vuông";
            }

            return ketQua;
        }
        public double DienTich()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public double ChuVi()
        {
            return a + b + c;
        }

    }
}
