namespace C5
{
    public partial class B1 : Form
    {
        string[] arrFile;
        Random rand = new Random();
        Point pOld;
        int count = 0;

        public B1()
        {
            InitializeComponent();
        }

        private void B1_Load(object sender, EventArgs e)
        {
            arrFile = Directory.GetFiles(Application.StartupPath + @"\Hinh");
            AddNewPic();

        }

        void AddNewPic()
        {
            count++;
            PictureBox pic = new PictureBox();
            pic.Image = Image.FromFile(arrFile[rand.Next(arrFile.Length)]);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Width = pic.Height = pnPic.Width - 20;
            pic.MouseDown += Pic_MouseDown;
            pic.MouseMove += Pic_MouseMove;
            pic.MouseUp += Pic_MouseUp;
            pic.Name = count.ToString();
            this.Controls.Add(pic);
            this.Controls.SetChildIndex(pic, 0);
        }

        private void Pic_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if (pnPic.Bounds.Contains(pic.Bounds))
            {
                pnPic.Controls.Add(pic);
                AddNewPic();
            }
        }

        private void Pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - pOld.X;
                int dy = e.Y - pOld.Y;
                PictureBox pic = (PictureBox)sender;
                pic.Left += dx;
                pic.Top += dy;
            }
        }

        private void Pic_MouseDown(object sender, MouseEventArgs e)
        {
            pOld = e.Location;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Control[] arr = this.Controls.Find(count.ToString(), false);
            PictureBox pic = (PictureBox)arr[0];
            //PictureBox pic = (PictureBox)this.Controls[0];
            switch (e.KeyCode)
            {
                case Keys.Left: pic.Left -= 10; break;
                case Keys.Right: pic.Left += 10; break;
                case Keys.Up: pic.Top -= 10; break;
                case Keys.Down: pic.Top += 10; break;
            }
            if (pnPic.Bounds.Contains(pic.Bounds))
            {
                pnPic.Controls.Add(pic);
                AddNewPic();
            }
        }

        private void pnPic_MouseDown(object sender, MouseEventArgs e)
        {
            pOld = e.Location;
        }

        private void pnPic_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - pOld.X;
                int dy = e.Y - pOld.Y;

                pnPic.Left += dx;
                pnPic.Top += dy;
            }
        }

    }
}
