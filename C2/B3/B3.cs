using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace B3
{
    public partial class B3 : Form
    {
        Random Rand = new Random();
        int Diem = 0;
        public B3()
        {
            InitializeComponent();
        }

        private void btnQuayso_Click(object sender, EventArgs e)
        {
            //Lấy ngẫu nhiên 3 số nguyên từ 1- 6  
            int so1 = Rand.Next(1, 7);
            int so2 = Rand.Next(1, 7);
            int so3 = Rand.Next(1, 7);
            //hiển thị trên giao diện 
            lbSo1.Text = so1.ToString();
            lbSo2.Text = so2.ToString();
            lbSo3.Text = so3.ToString();
            //kiểm tra, hiển thị kết quả 
            if (rd3.Checked) //chọn 3-10 
            {
                if ((so1 + so2 + so3) <= 10)
                    Diem += 10;
                else
                    Diem -= 10;
            }
            else //chọn 11-18 
            {
                if ((so1 + so2 + so3) <= 10)
                    Diem -= 10;
                else
                    Diem += 10;
            }
            lbDiem.Text = Diem.ToString();
        }
    }
}
