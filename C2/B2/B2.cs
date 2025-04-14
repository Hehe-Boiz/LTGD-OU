namespace B2
{
    public partial class B2 : Form
    {
        public B2()
        {
            InitializeComponent();
        }

        private void btTinh_Click(object sender, EventArgs e)
        {
            try
            {
                int a = checked(int.Parse(txtSo1.Text));
                int b = checked(int.Parse(txtSo2.Text));
                if (rdCong.Checked)
                    lbKetqua.Text = String.Format("{0}", checked(a + b));
                else if (rdTru.Checked)
                    lbKetqua.Text = String.Format("{0}", a - b);
                else if (rdNhan.Checked)
                    lbKetqua.Text = String.Format("{0}", checked(a * b));
                else if (rdChia.Checked)
                {
                    if (b == 0)
                        throw new DivideByZeroException("S? chia ph?i khác 0");
                    lbKetqua.Text = String.Format("{0:0.00}", (double)a / b);
                }
                else
                    lbKetqua.Text = String.Format("{0}", a % b);
            }
            catch (FormatException)
            {
                lbKetqua.Text = "B?n ph?i nh?p hai s?";
            }
            catch (DivideByZeroException ex)
            {
                lbKetqua.Text = ex.Message;
            }
            catch (OverflowException)
            {
                lbKetqua.Text = "Không th? x? lý s? quá l?n";
            }
        }
    }
}
