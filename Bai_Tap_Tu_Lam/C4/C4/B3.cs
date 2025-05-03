using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Interop;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C4
{
    public partial class B3 : Form
    {
        public B3()
        {
            InitializeComponent();
            foreach (FontFamily font in FontFamily.Families)
            {
                lstFont.Items.Add(font.Name);
            }

            cbSize.Items.AddRange(new object[] { 8, 10, 12, 14, 16, 18, 20, 24, 28, 32, 36, 48, 72 });
            cbSize.SelectedItem = 16;

        }

        private void UpdateFontStyle()
        {
            string fontName = lstFont.SelectedItem?.ToString() ?? "Arial";
            float fontSize = float.TryParse(cbSize.Text, out float s) ? s : 16;

            FontStyle style = FontStyle.Regular;
            if (chbB.Checked) style |= FontStyle.Bold;
            if (chbI.Checked) style |= FontStyle.Italic;
            if (chbU.Checked) style |= FontStyle.Underline;

            rtxtContent.SelectionFont = new Font(fontName, fontSize, style);

        }

        private void lstFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFontStyle();
        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFontStyle();
        }

        private void chbB_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFontStyle();
        }

        private void chbI_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFontStyle();
        }

        private void chbU_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFontStyle();
        }
        private void UpdateColor()
        {
            int r = hScrRed.Value;
            int g = hScrGreen.Value;
            int b = hScrBlue.Value;
            Color color = Color.FromArgb(r, g, b);
            rtxtContent.SelectionColor = color;
            pColor.BackColor = color;
        }
        private void hScrRed_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColor();
        }

        private void hScrBlue_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColor();
        }

        private void hScrGreen_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateColor();
        }

        private void pColor_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
