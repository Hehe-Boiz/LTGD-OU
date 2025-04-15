namespace B2
{
    public partial class B2 : Form
    {
        public B2()
        {
            InitializeComponent();
        }

        String imgPath;
        int count, lose, win, n, nChoose;
        private void Form2_Load(object sender, EventArgs e)
        {
            imgPath = Application.StartupPath ;
            Init();
        }
        public void Init()
        {
            count = lose = win = 0;
            nChoose = 1;
            picChoose.Image = Image.FromFile(imgPath + "1.jpg");
            picResult.Image = null;
            lbCount.Text = lbLose.Text = lbWin.Text = "";
            listResult.Items.Clear();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            Choose(sender);
        }



        private void Choose(object sender)
        {
            Button btn = (Button)sender;
            nChoose = int.Parse(btn.Text);
            picChoose.Image = Image.FromFile(imgPath + nChoose + ".jpg");
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            Play();
        }
        private void Play()
        {
            n++;
            Random rand = new Random();
            n = rand.Next(1, 7);
            picResult.Image = Image.FromFile(imgPath + n + ".jpg");
            String result = "";
            if (nChoose == n)
            {
                win++;
                result = "Thắng";
            }
            else
            {
                lose++;
                result = "Thua";
            }
            lbCount.Text = String.Format("Lần đoán: {0}", n);
            lbWin.Text = String.Format("Lần thắng: {0} ({1:0.##})", win, (double)win * 100 / n);
            lbLose.Text = String.Format("Lần thua: {0} ({1:0.##})", lose, (double)lose * 100 / n);
            listResult.Items.Add(String.Format("{0}.{1} (Đoán {2} ra {3})", n, result, nChoose, n));
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Init();
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter: Play(); break;
                case Keys.Escape: Init(); break;
                case Keys.D1: case Keys.NumPad1: Choose(btn1); break;
                case Keys.D2: case Keys.NumPad2: Choose(btn2); break;
                case Keys.D3: case Keys.NumPad3: Choose(btn3); break;
                case Keys.D4: case Keys.NumPad4: Choose(btn4); break;
                case Keys.D5: case Keys.NumPad5: Choose(btn5); break;
                case Keys.D6: case Keys.NumPad6: Choose(btn6); break;

            }
            return base.ProcessDialogKey(keyData);
        }

    }
}
