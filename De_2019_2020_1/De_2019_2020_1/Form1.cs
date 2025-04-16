using System.Windows.Forms;

namespace De_2019_2020_1
{
    public partial class Form1 : Form
    {

        Random random = new Random();
        int tienCuoc = 1000;
        string path = Application.StartupPath + @"\Hinh\";
        int so1, so2, so3;
        public Form1()
        {
            InitializeComponent();
            panelLb.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbCuoc1.SelectedIndex = 0;
            cbCuoc2.SelectedIndex = 0;
            lbTienCon.Text = tienCuoc.ToString() + " $";
            randomSo();


        }

        private void randomSo()
        {
            so1 = random.Next(1, 6);
            so2 = random.Next(1, 6);
            so3 = random.Next(1, 6);

            lb1.Text = so1.ToString();
            lb2.Text = so2.ToString();
            lb3.Text = so3.ToString();

            pic1.Image = Image.FromFile(path + so1.ToString() + ".jpg");
            pic2.Image = Image.FromFile(path + so2.ToString() + ".jpg");
            pic3.Image = Image.FromFile(path + so3.ToString() + ".jpg");


        }
        private bool isChan(int so1, int so2, int so3)
        {
            if (so1 % 2 == 0 && so2 % 2 == 0 && so3 % 2 == 0)
                return true;
            return false;
        }

        private bool is3(int so1, int so2, int so3)
        {
            if (so1 + so2  + so3 < 11)
                return true;
            return false;
        }

        private void btnQuay_Click(object sender, EventArgs e)
        {
            if (tienCuoc < 100)
            {
                MessageBox.Show("Bạn không đủ tiền cược, cút!");
                return;
            }

            if(!rdLe.Checked && !rdLe.Checked && !rd3.Checked && !rd11.Checked)
            {
                MessageBox.Show("Bạn chưa chọn cược!");
                return;
            }
            
            randomSo();

            if (isChan(so1, so2, so3) && rdChan.Checked ||!isChan(so1, so2, so3) && rdLe.Checked)
            {
                tienCuoc += 100;
            }
            else
            {
                tienCuoc -= 100;
            }

            if(is3(so1, so2, so3) && rd3.Checked || !is3(so1, so2, so3) && rd11.Checked)
            {
                tienCuoc += 100;
            }
            else
            {
                tienCuoc -= 100;
            }
            lbTienCon.Text = tienCuoc.ToString() + " $";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                panelLb.Visible = true;
            }
            else
            {
                panelLb.Visible = false;
            }
        }
    }
}
