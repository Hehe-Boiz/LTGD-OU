using System.Text;

namespace C2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAscii_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAscii.Text) && int.TryParse(txtAscii.Text, out int ascii) && ascii >= 0 && ascii <= 255)
            {
                lbAscii.Text = Convert.ToChar(ascii).ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một mã ASCII hợp lệ (0-255).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btKytu_Click(object sender, EventArgs e)
        {
            if (txtKytu.Text.Length == 1 && !string.IsNullOrEmpty(txtKytu.Text))
            {
                lbKytu.Text = ((int)txtKytu.Text[0]).ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một ký tự duy nhất.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
