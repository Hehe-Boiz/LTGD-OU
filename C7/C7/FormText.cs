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
    public partial class FormText : Form
    {
        public FormText()
        {
            InitializeComponent();
        }

        private void FrmDrawWithText_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font("Arial", 64, FontStyle.Bold);
            HatchBrush hbr = new HatchBrush(HatchStyle.DarkHorizontal, Color.Orange);
            LinearGradientBrush lbr = new LinearGradientBrush(new Rectangle(0, 0, 20, 20), Color.Blue, Color.White, 45);
            StringFormat fm = new StringFormat();
            fm.Alignment = StringAlignment.Far;
            e.Graphics.DrawString("HELLO", font, Brushes.Green, ClientRectangle, fm);
            fm.Alignment = StringAlignment.Near;
            fm.LineAlignment = StringAlignment.Far;
            TextureBrush tbr = new TextureBrush(Image.FromFile(Application.StartupPath+"hehe.jpg"));
            e.Graphics.DrawString("HELLO", font, tbr, ClientRectangle, fm);
            fm.LineAlignment = StringAlignment.Near;
            fm.FormatFlags = StringFormatFlags.DirectionVertical;
            e.Graphics.DrawString("HELLO", font, hbr, ClientRectangle, fm);
            fm.Alignment = StringAlignment.Far;
            fm.LineAlignment = StringAlignment.Far;
            fm.FormatFlags = StringFormatFlags.DirectionVertical;
            e.Graphics.DrawString("HELLO", font, lbr, ClientRectangle, fm);
            //fm.Alignment = StringAlignment.Near;

        }

        private void FrmDrawWithText_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
