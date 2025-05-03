using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3
{
    internal class Diem
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Diem() { X = 0; Y = 0; }
        public Diem(double x, double y) { X = x; Y = y; }
        public override string ToString()
        {
            return $"({X},{Y})";
        }

    }
}
