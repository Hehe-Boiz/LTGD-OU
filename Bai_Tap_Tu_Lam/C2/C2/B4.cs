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
    public partial class B4 : Form
    {
        string[] arr = new string[2];
        double ketQua = 0;
        public B4()
        {
            InitializeComponent();
        }

        private void B4_Load(object sender, EventArgs e)
        {

        }

        private void bt0_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            lbManhinh.Text += bt.Text;
        }

        private void btBang_Click(object sender, EventArgs e)
        {

            string tmp = lbManhinh.Text;
            char phepToan = ' ';
            int so1 = 0, so2 = 0;
            if (lbManhinh.Text.Contains("+"))
            {
                phepToan = '+';
            }
            else if (lbManhinh.Text.Contains("-"))
            {
                phepToan = '-';
            }
            else if (lbManhinh.Text.Contains("x"))
            {
                phepToan = 'x';
            }
            else if (lbManhinh.Text.Contains("/"))
            {
                phepToan = '/';
            }
            if (phepToan == ' ') return;
            arr = lbManhinh.Text.Split(phepToan);
            so1 = int.Parse(arr[0]);
            so2 = int.Parse(arr[1]);
            if (arr.Length > 2)
            {
                MessageBox.Show("Phép toán chỉ được phép có 2 toán hạng và 1 toán tử!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch (phepToan)
            {
                case '+':
                    ketQua = so1 + so2;
                    break;
                case '-':
                    ketQua = so1 - so2;
                    break;
                case 'x':
                    ketQua = so1 * so2;
                    break;
                case '/':
                    if (so2 == 0)
                    {
                        MessageBox.Show("Phép chia cho 0 không thể thực hiện.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    ketQua = so1 / so2;
                    break;
            }
            lbManhinh2.Text = ketQua.ToString();

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            lbManhinh.Text = "";
            lbManhinh2.Text = "";
        }

        private void btR_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbManhinh.Text))
                lbManhinh.Text = lbManhinh.Text.Substring(0, lbManhinh.Text.Length - 1);
        }

    }
}
