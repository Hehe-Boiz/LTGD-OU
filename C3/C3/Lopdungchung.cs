using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3
{
    internal class Lopdungchung
    {
        public static int USCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (b == 0) return a;
            return USCLN(b, a % b);
        }
    }
}
