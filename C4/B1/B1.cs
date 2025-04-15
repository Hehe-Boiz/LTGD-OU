namespace C4
{
    public partial class B1 : Form
    {
        public B1()
        {
            InitializeComponent();
        }
        int dx = 5, dy = 5; // Ball speed in pixels

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (picBall.Left < 0 || picBall.Right > ClientRectangle.Width)
                dx = -dx;
            if (picBall.Top < 0 || picBall.Bottom > ClientRectangle.Height)
                dy = -dy;
            picBall.Left += dx;
            picBall.Top += dy;
        }
    }
}
