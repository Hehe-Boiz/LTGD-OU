using System.Xml.Linq;

namespace C4
{
    public partial class B1 : Form
    {
        public B1()
        {
            InitializeComponent();
        }

        string path = Application.StartupPath + @"\HinhXucXac\";
        int diem = 0; // Điểm ban đầu
        Random random = new Random();
        private int textX; // Vị trí X của lbName


        private void B1_Load(object sender, EventArgs e)
        {
            textX = this.Width; // Chạy từ ngoài màn hình
            timer1.Start();
            int so1 = random.Next(1, 7); // Số ngẫu nhiên từ 1 đến 6
            int so2 = random.Next(1, 7);
            int so3 = random.Next(1, 7);
            pic1.Image = Image.FromFile($"{path}{so1}.png");
            pic2.Image = Image.FromFile($"{path}{so2}.png");
            pic3.Image = Image.FromFile($"{path}{so3}.png");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbName.Text = lbName.Text.Substring(1) +
                lbName.Text.Substring(0, 1);
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            int so1 = random.Next(1, 7); // Số ngẫu nhiên từ 1 đến 6
            int so2 = random.Next(1, 7);
            int so3 = random.Next(1, 7);

            try
            {
                pic1.Image = Image.FromFile($"{path}{so1}.png");
                pic2.Image = Image.FromFile($"{path}{so2}.png");
                pic3.Image = Image.FromFile($"{path}{so3}.png");
            }
            catch
            {
                MessageBox.Show("Không tìm thấy hình ảnh, vui lòng kiểm tra thư mục!");
            }

            if (so1 == so2 && so2 == so3)
            {
                diem += 10;
                lbResult.Text = "Chúc mừng! Bạn thắng!";
            }
            else
            {
                lbResult.Text = "Thử lại!";
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void B1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
