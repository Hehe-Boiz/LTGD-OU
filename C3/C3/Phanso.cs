using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3
{
    internal class Phanso
    {
        int tuso, mauso;
        public Phanso()
        {
            tuso = 0;
            mauso = 1;
        }
        public Phanso(int ts, int ms)
        {
            tuso = ts;
            mauso = (ms == 0 ? 1 : ms);
        }
        public int Tuso
        {
            get { return tuso; }
            set { tuso = value; }
        }
        public int Mauso
        {
            get { return mauso; }
            set { mauso = (value == 0 ? 1 : value); }
        }
        private void Toigian()
        {
            int us = Lopdungchung.USCLN(tuso, mauso);
            if (us > 0)
            {
                tuso /= us;
                mauso /= us;
            }
        }
        public Phanso Cong(Phanso p)
        {
            Phanso kq = new Phanso();
            kq.tuso = tuso * p.mauso + p.tuso * mauso;
            kq.mauso = mauso * p.mauso;
            kq.Toigian();
            return kq;
        }
        public Phanso Tru(Phanso p)
        {
            Phanso kq = new Phanso();
            kq.tuso = tuso * p.mauso - p.tuso * mauso;
            kq.mauso = mauso * p.mauso;
            kq.Toigian();
            return kq;
        }
        public Phanso Nhan(Phanso p)
        {
            Phanso kq = new Phanso();
            kq.tuso = tuso * p.tuso;
            kq.mauso = mauso * p.mauso;
            kq.Toigian();
            return kq;
        }
        public Phanso Chia(Phanso p)
        {
            Phanso kq = new Phanso();
            kq.tuso = tuso * p.mauso;
            kq.mauso = mauso * p.tuso;
            kq.Toigian();
            return kq;
        }
    }
}
