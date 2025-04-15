using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C7
{
    public partial class FormByMouse : Form
    {
        Point pOld;
        int penWidth;
        Color color;
        Bitmap bmpTemp;
        bool erase = false;

        public FormByMouse()
        {
            InitializeComponent();
        }

        private void FormByMouse_Load(object sender, EventArgs e)
        {
            color = Color.Red;
            penWidth = 1;
            bmpTemp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

        }

        private void FormByMouse_MouseDown(object sender, MouseEventArgs e)
        {
            pOld = e.Location;


        }

        private void FormByMouse_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmpTemp, 0, 0);
        }

        private void FormByMouse_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Pen pen = new Pen(color, penWidth);
                Graphics g = Graphics.FromImage(bmpTemp);
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                g.DrawLine(pen, pOld, e.Location);
                pOld = e.Location;
                Invalidate();
            }
            else
            {
                Pen pen = new Pen(this.BackColor, penWidth + 4);
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                Graphics g = Graphics.FromImage(bmpTemp);
                g.DrawLine(pen, pOld, e.Location);
                pOld = e.Location;
                Invalidate();
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.R: color = Color.Red; break;
                case Keys.G: color = Color.Green; break;
                case Keys.B: color = Color.Blue; break;
                case Keys.Up:
                    {
                        if (penWidth < 50)
                            penWidth++;
                    }
                    break;
                case Keys.Down:
                    {
                        if (penWidth > 2)
                            penWidth--;
                    }
                    break;
                case Keys.E: erase = true; break;
            }
            return base.ProcessDialogKey(keyData);
        }

        
    }
}
