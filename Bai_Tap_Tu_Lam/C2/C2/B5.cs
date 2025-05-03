using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C2
{
    public partial class B5 : Form
    {
        public B5()
        {
            InitializeComponent();
        }

        private List<int> mang = new List<int>();
        Random rnd = new Random();

        private void btSinhMang_Click(object sender, EventArgs e)
        {
            lstMang.Items.Clear();
            mang.Clear();

            if (int.TryParse(txtSoLuong.Text, out int soLuong) && soLuong > 0)
            {
                for (int i = 0; i < soLuong; i++)
                {
                    int so = rnd.Next(1, 100);
                    mang.Add(so);
                    lstMang.Items.Add(so);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ!");
            }
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            if (mang.Count == 0)
            {
                MessageBox.Show("Vui lòng sinh mảng trước!");
                return;
            }

            int tongChan = mang.Where(x => x % 2 == 0).Sum();
            int tongLe = mang.Where(x => x % 2 != 0).Sum();
            double trungBinh = mang.Average();
            int demNguyenTo = mang.Count(IsNguyenTo);

            lbChan.Text = $"Tổng chẵn: {tongChan}";
            lbLe.Text = $"Tổng lẻ: {tongLe}";
            lbTB.Text = $"Trung bình cộng: {trungBinh:F2}";
            lbNguyenTo.Text = $"Số nguyên tố: {demNguyenTo}";
        }

        private bool IsNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return true;
        }

    }
}
