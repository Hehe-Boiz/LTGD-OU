namespace C7
{
    public partial class B1 : Form
    {
        public B1()
        {
            InitializeComponent();
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            panelPaint.Invalidate();
        }

        private void txtMonday_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void panelPaint_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(panelPaint.BackColor);

            TextBox[] tb = new TextBox[] { txtMonday, txtTuesday, txtWednesday, txtThursday, txtFriday };

            int barWidth = 50;
            int space = 20;
            int baseY = panelPaint.Height - 30;
            int maxBarHeight = panelPaint.Height - 50;
            Color[] colors = { Color.Red, Color.Black, Color.Blue, Color.Green, Color.Yellow };
            for (int i = 0; i < tb.Length; i++)
            {
                if (int.TryParse(tb[i].Text, out int value))
                {
                    int barHeight = Math.Min(value, maxBarHeight);
                    int x = i * (barWidth + space) + 30;
                    int y = baseY - barHeight;
                    // Vẽ cột
                    g.FillRectangle(new SolidBrush(colors[i]), x, y, barWidth, barHeight);
                    g.DrawRectangle(Pens.Black, x, y, barWidth, barHeight);
                }
            }
        }
    }
}
