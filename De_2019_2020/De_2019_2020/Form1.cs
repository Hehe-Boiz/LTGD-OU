using System.Windows.Forms;

namespace De_2019_2020
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int tien = 1000000000;
        string path;
        int chon;
        public Form1()
        {
            Welcome w = new Welcome();
            w.ShowDialog();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] str = { "Bầu", "Cá", "Cua", "Gà", "Nai", "Tôm" };
            cbchon.Items.AddRange(str);
            txtCuoc.Text = "10000";
            lbTien.Text = tien.ToString();
            path = Application.StartupPath + @"\Hinh";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn mốn đóng chươn trình?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnQuay_Click(object sender, EventArgs e)
        {
            if (cbchon.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn chưa chọn!");
                return;
            }

            try
            {
                int cuoc = Convert.ToInt32(txtCuoc.Text);
                if (cuoc < 100 || cuoc % 100 != 0 || cuoc > tien)
                {
                    MessageBox.Show("Tiền cược không hợp lệ");
                    return;
                }

                chon = cbchon.SelectedIndex;
                int s1 = rand.Next(0, 6);
                int s2 = rand.Next(0, 6);
                int s3 = rand.Next(0, 6);
                pictureBox2.Image = Image.FromFile(path + @"\" + s1.ToString() + ".jpg");
                pictureBox3.Image = Image.FromFile(path + @"\" + s2.ToString() + ".jpg");
                pictureBox4.Image = Image.FromFile(path + @"\" + s3.ToString() + ".jpg");

                if (s1 != chon && s2 != chon && s3 != chon)
                {
                    tien -= cuoc;
                }
                else
                {
                    if (s1 == chon) tien += cuoc;
                    if (s2 == chon) tien += cuoc;
                    if (s3 == chon) tien += cuoc;
                }
                lbTien.Text = tien.ToString();
                if (tien <= 0) btnQuay.Enabled = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn chưa đặt tiền cược");
            }
        }

        private void txtCuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cbchon.SelectedIndex = rand.Next(0, 6);
            btnQuay_Click(sender, e);
        }
    }
}
