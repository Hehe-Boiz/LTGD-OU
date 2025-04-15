using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De_2019_2020
{
    public partial class Welcome : Form
    {
        Random rand = new Random();
        Bitmap bitmap;
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
        }

        private void Draw()
        {
            Graphics g = Graphics.FromImage(bitmap);

            g.Clear(this.BackColor);

            for (int i = 0; i <= 1000; i++)
            {
                int x = rand.Next(0, ClientRectangle.Width);
                int y = rand.Next(0, ClientRectangle.Height);
                int w = rand.Next(1, 5);
                g.FillEllipse(Brushes.Red, x, y, w, w);
            }
        }

            private void timer1_Tick(object sender, EventArgs e)
        {
            ptr1.Left++;
            ptr2.Left--;
            if (ptr1.Right > ptr2.Left)
            {
                timer1.Enabled = false;
                this.Close();
            }
            Draw();
        }

        private void Welcome_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    
    
    }
}
