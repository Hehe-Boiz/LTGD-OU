using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C3
{
    public partial class B3 : Form
    {
        public B3()
        {
            InitializeComponent();
        }

        private void btTinhToan_Click(object sender, EventArgs e)
        {
            double DiemX = double.Parse(txtX.Text);
            double DiemY = double.Parse(txtY.Text);
            double banKinh = double.Parse(txtBK.Text);
            double DiemOx = double.Parse(txtOx.Text);
            double DiemOy = double.Parse(txtOy.Text);
            Diem tamDuongTrong = new Diem(DiemX, DiemY);
            HinhTron hinhTron = new HinhTron(tamDuongTrong, banKinh);
            Diem DiemO = new Diem(DiemOx, DiemOy);
            if (hinhTron.IsNamTrongDuongTron(DiemO))
            {
                lbCoOrKhong.Text = "Có";
            }
            else
            {
                lbCoOrKhong.Text = "Không";
            }
            lbDienTich.Text = hinhTron.DienTich().ToString("F2");
            lbChuVi.Text = hinhTron.ChuVi().ToString("F2");
        }

    }
}
