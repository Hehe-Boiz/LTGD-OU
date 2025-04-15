using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C7
{
    public partial class FormImage : Form
    {
        public FormImage()
        {
            InitializeComponent();
        }

        private void FormImage_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rc1 = new Rectangle(0, 0, ClientRectangle.Width / 2, ClientRectangle.Height / 2);
            Rectangle rc2 = new Rectangle(0, ClientRectangle.Height / 2, ClientRectangle.Width / 2, ClientRectangle.Height / 2);
            Rectangle rc3 = new Rectangle(ClientRectangle.Width / 2, 0, ClientRectangle.Width / 2, ClientRectangle.Height);
            DrawImage(e.Graphics, rc1);
            DrawText(e.Graphics, rc2);
            DrawPolygon(e.Graphics, rc3);
            Pen pen = new Pen(Color.Blue, 3);
            e.Graphics.DrawRectangles(pen, new Rectangle[] { rc1, rc2, rc3 });
        }
        void DrawImage(Graphics g, Rectangle rc)
        {
            Image img = Image.FromFile(Application.StartupPath+ "hehe.jpg");
            g.DrawImage(img, rc);
            Font font = new Font("Nhut", 24, FontStyle.Bold | FontStyle.Italic);
            SolidBrush br = new SolidBrush(Color.Red);
            g.DrawString("LE MINH NHUT", font, br, rc);
        }
        void DrawText(Graphics g, Rectangle rc)
        {
            LinearGradientBrush lbr = new LinearGradientBrush(rc, Color.Black, Color.Blue, LinearGradientMode.ForwardDiagonal);
            g.FillRectangle(lbr, rc);
            LinearGradientBrush lbr2 = new LinearGradientBrush(rc, Color.Red, Color.Aqua, 45);
            Font font = new Font("Nhut", 40, FontStyle.Bold);
            StringFormat fm = new StringFormat();
            fm.Alignment = StringAlignment.Center;
            fm.LineAlignment = StringAlignment.Center;
            g.DrawString("LE MINH NHUT", font, lbr2, rc, fm);

        }
        void DrawPolygon(Graphics g, Rectangle rc)
        {
            Point[] arrP =
            {
                new Point(rc.Left, rc.Height / 3),
                new Point(rc.Left + rc.Width/4, rc.Height/3),
                new Point(rc.Left + rc.Width/2, rc.Top),
                new Point(rc.Left + rc.Width*3/4, rc.Height/3),
                new Point(rc.Left + rc.Width, rc.Height/3),
                new Point(rc.Left+ rc.Width*5/6,rc.Height*2/3),
                new Point(rc.Left+ rc.Width*5/6,rc.Height),
                new Point(rc.Left + rc.Width/2, rc.Height*3/4),
                new Point(rc.Left+ rc.Width/6,rc.Height),
                new Point(rc.Left + rc.Width/6, rc.Height*2/3)


            };
            GraphicsPath path = new GraphicsPath();
            path.AddPolygon(arrP);
            PathGradientBrush br = new PathGradientBrush(path);
            br.CenterColor = Color.White;
            br.SurroundColors = new Color[] { Color.Yellow, Color.Yellow, Color.Yellow, Color.Yellow };
            g.FillPolygon(br, arrP);
            g.FillPath(br, path);

        }
    }
}
