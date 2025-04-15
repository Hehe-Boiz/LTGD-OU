using System.Reflection.Metadata;

namespace TL1
{
    public partial class Form1 : Form
    {
        bool gameRunning = false;
        int dx = 5, dy = 5;
        Point pOld;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            picBall.Left += dx;
            picBall.Top += dy;

            if (picBall.Left < 0 || picBall.Right >= this.ClientSize.Width)
            {
                dx = -dx;
            }

            if (picBall.Top < 0)
            {
                dy = -dy;
            }

            if (picBall.Bounds.IntersectsWith(pnChan.Bounds))
            {
                dy = -dy;
            }

            if (picBall.Bottom >= this.ClientSize.Height)
            {
                timer1.Stop();
                MessageBox.Show("Game Over");
                picBall.Location = new Point(this.ClientSize.Width / 3 + this.ClientSize.Width / 6, this.ClientSize.Height / 4);
                gameRunning = false;
            }
        }

        private void pnChan_MouseDown(object sender, MouseEventArgs e)
        {
            pOld = e.Location;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                gameRunning = !gameRunning;
                if (gameRunning) timer1.Start();
                else timer1.Stop();
            }

            if (e.KeyCode == Keys.Left) pnChan.Left -= 20;
            if (e.KeyCode == Keys.Right) pnChan.Left += 20;
        }

        private void pnChan_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - pOld.X;
                int newLeft = pnChan.Left + dx;

                // Giới hạn không ra khỏi khung
                if (newLeft < 0)
                    newLeft = 0;

                if (newLeft + pnChan.Width > this.ClientSize.Width)
                    newLeft = this.ClientSize.Width - pnChan.Width;

                pnChan.Left = newLeft;
            }
        }
    }
}
