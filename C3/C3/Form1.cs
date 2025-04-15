namespace C3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Phanso ps1, ps2, ps3;
        private void btCong_Click(object sender, EventArgs e)
        {
            try
            {
                int tuSo1 = int.Parse(txtTuso1.Text);
                int tuSo2 = int.Parse(txtTuso2.Text);
                int mauSo1 = int.Parse(txtMauso1.Text);
                int mauSo2 = int.Parse(txtMauso2.Text);
                Button btn = (Button)sender;
                ps1 = new Phanso(tuSo1, mauSo1);
                ps2 = new Phanso(tuSo2, mauSo2);
                ps3 = new Phanso();
                switch (btn.Text)
                {
                    case "+":
                        {
                            lbToanTu.Text = btn.Text;
                            ps3 = ps1.Cong(ps2);
                            break;
                        }
                    case "-":
                        {
                            lbToanTu.Text = btn.Text;
                            ps3 = ps1.Tru(ps2);
                            break;
                        }
                    case "*":
                        {
                            lbToanTu.Text = btn.Text;
                            ps3 = ps1.Nhan(ps2);
                            break;
                        }
                    case "/":
                        {
                            lbToanTu.Text = btn.Text;
                            ps3 = ps1.Chia(ps2);
                            break;
                        }
                }
                txtTuso3.Text = ps3.Tuso.ToString();
                txtMauso3.Text = ps3.Mauso.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Nhap sai dinh dang");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Loi Chia 0");
            }

        }
    }
}
