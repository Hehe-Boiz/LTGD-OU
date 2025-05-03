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
    public partial class B3 : Form
    {
        Random rand = new Random();
        int diem = 100;
        public B3()
        {
            InitializeComponent();
        }

        private void B3_Load(object sender, EventArgs e)
        {
            lbDiem.Text = diem.ToString();

        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            int so1 = rand.Next(1, 7);
            int so2 = rand.Next(1, 7);
            int so3 = rand.Next(1, 7);
            lbSo1.Text = so1.ToString();
            lbSo2.Text = so2.ToString();
            lbSo3.Text = so3.ToString();

            if (so1 + so2 + so3 == so1 * 3)
            {
                diem += 100;
            }
            else
            {
                diem -= 10;
            }
            lbDiem.Text = diem.ToString();
            if (diem <= 0)
            {
                DialogResult result = MessageBox.Show("Bạn đã dùng hết điểm, ban có muốn nạp thêm?", "Điểm đã hết.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    diem += 100;
                    MessageBox.Show("Nạp điểm thành công!", "Điểm đã được nạp.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bạn đã từ chối nạp điểm!", "Điểm không được nạp.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    Close();
                }
            }

        }


        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
