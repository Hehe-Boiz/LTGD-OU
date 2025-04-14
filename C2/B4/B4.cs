namespace B4
{
    public partial class B4 : Form
    {
        Random rd = new Random();
        string[] toantu = { "+", "-", "x", ":" };
        int vitri = 0;
        int a, b;
        public B4()
        {
            InitializeComponent();
            a = rd.Next(10);
            b = rd.Next(10);
            vitri = rd.Next(4);
            lbSo1.Text = a.ToString();
            lbToantu.Text = toantu[vitri];
            lbSo2.Text = b.ToString();
        }

        private void btTieptuc_Click(object sender, EventArgs e)
        {
            txtDoan.Text = "";
            lbKQ.Text = "";
            a = rd.Next(10);
            b = rd.Next(10);
            vitri = rd.Next(4);
            lbSo1.Text = a.ToString();
            lbToantu.Text = toantu[vitri];
            lbSo2.Text = b.ToString();
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            int kq = 0;
            try
            {
                switch (vitri)
                {
                    case 0:
                        kq = a + b;
                        break;
                    case 1:
                        kq = a - b;
                        break;
                    case 2:
                        kq = a * b;
                        break;
                    case 3:
                        kq = a / b;
                        break;
                }
                if (kq == int.Parse(txtDoan.Text))
                {
                    lbKQ.Text = "Đúng rồi";
                }
                else
                {
                    lbKQ.Text = "Sai rồi";
                }
            }
            catch
            {
                MessageBox.Show("Mời bạn nhập số");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtDoan.Text == "") return;
            txtDoan.Text =
            txtDoan.Text.Substring(0, txtDoan.Text.Length - 1);
        }

        private void btDau_Click(object sender, EventArgs e)
        {
            if (txtDoan.Text != "") return;
            txtDoan.Text = "-";
        }
    }
}
