namespace C7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawByMouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormByMouse formByMouse = new FormByMouse();
            formByMouse.Show();
        }

        private void drawTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormText formText = new FormText();
            formText.Show();
        }

        private void drawImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormImage formImage = new FormImage();
            formImage.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
