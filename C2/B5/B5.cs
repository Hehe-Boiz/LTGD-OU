namespace B5
{
    public partial class B5 : Form
    {
        string s1 = "Khoa công nghệ thông tin, đại học Mở thành phố Hồ Chí Minh";
        public B5()
        {
            InitializeComponent();
        }

        private void B5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vitri = int.Parse(textBox4.Text);
            textBox1.Text = textBox1.Text.Insert(vitri, textBox2.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = s1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(label1.Text.Length - 1) + label1.Text.Substring(0, label1.Text.Length - 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string txts1 = textBox1.Text.ToLower();
            string txts2 = textBox2.Text.ToLower();
            string txts3 = textBox3.Text.ToLower();

            int index = txts1.IndexOf(txts2);
            while (index >= 0)
            {
                txts1 = txts1.Replace(txts2, txts3);
                index = txts1.IndexOf(txts2);
            }
            textBox1.Text = txts1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] str = textBox1.Text.Split(' ');
            string re = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                re += str[i] + " ";
            }
            textBox1.Text = re;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string txts1 = textBox1.Text.ToLower();
            string txts2 = textBox2.Text.ToLower();

            int index = txts1.IndexOf(txts2);
            while (index >= 0)
            {
                txts1 = txts1.Remove(index, textBox2.Text.Length);
                index = txts1.IndexOf(txts2);
            }
            textBox1.Text = txts1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            char[] token = { ' ', '\t' };
            string[] arr = textBox1.Text.Split(token, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i].Substring(0, 1).ToUpper() + arr[i].Substring(1).ToLower();

            }
            textBox1.Text = String.Join(" ", arr);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = s1;
        }
    }
}
