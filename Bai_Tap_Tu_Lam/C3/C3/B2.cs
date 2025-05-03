using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C3
{
    public partial class B2 : Form
    {
        public B2()
        {
            InitializeComponent();
        }

        private void btTinhToan_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int c = int.Parse(txtC.Text);
            if (a >= b + c || b >= c + a || c >= a + b)
            {
                lbLaTamGiac.Text = "Không";
                return;
            }
            lbLaTamGiac.Text = "Có";
            TamGiac tamGiac = new TamGiac(a, b, c);
            lbKieuTamGiac.Text = tamGiac.KieuTamGiac();
            lbDienTich.Text = tamGiac.DienTich().ToString();
            lbChuVi.Text = tamGiac.ChuVi().ToString();
        }

    }
}
