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
    public partial class B2 : Form
    {
        int a = 0, b = 0, c = 0;

        public B2()
        {
            InitializeComponent();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private int delta(int a, int b, int c)
        {
            return b * b - 4 * a * c;
        }
        private void btTinh_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtA.Text) || string.IsNullOrEmpty(txtB.Text)
                    || string.IsNullOrEmpty(txtC.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ các hệ số a, b, c.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                a = int.Parse(txtA.Text);
                b = int.Parse(txtB.Text);
                c = int.Parse(txtC.Text);
                if (a == 0)
                {
                    MessageBox.Show("Hệ số a phải khác 0. Đây không phải phương trình bậc 2!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int dt = delta(a, b, c);
                if (dt > 0)
                {
                    double x1 = (-b + Math.Sqrt(dt)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(dt)) / (2 * a);
                    lbKetqua.Text = String.Format("2 nghiệm: x1 = {0}, x2 = {1}", x1, x2);
                }
                else if (dt == 0)
                {
                    double x = -b / (2 * a);
                    lbKetqua.Text = String.Format("Nghiệm kép: x = {0}", x);
                }
                else
                {
                    lbKetqua.Text = "Phương trình vô nghiệm";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Dữ liệu nhập vào phải là số. Vui lòng kiểm tra lại!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi không xác định: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
