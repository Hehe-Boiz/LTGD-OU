namespace C2
{
    public partial class B1 : Form
    {
        public B1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSo1.Text);
            int b = int.Parse(txtSo2.Text);

            lbResult.Text = (a + b).ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSo1.Text);
            int b = int.Parse(txtSo2.Text);

            lbResult.Text = string.Format("{0}", a - b);
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSo1.Text);
            int b = int.Parse(txtSo2.Text);

            lbResult.Text = string.Format("{0}", a * b);
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSo1.Text);
            int b = int.Parse(txtSo2.Text);

            if (b == 0)
            {
                lbResult.Text = "Khong the chia cho 0";
                return;
            }
            lbResult.Text = string.Format("{0:0.00}", a / b);
        }
    }
}
