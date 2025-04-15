using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        Bitmap canvas;
        Graphics g;
        Point lastPoint;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(canvas);
            g.Clear(Color.White);
            pictureBox1.Image = canvas;
        }
    }
}
