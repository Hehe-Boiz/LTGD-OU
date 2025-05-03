using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C4
{
    public partial class B4 : Form
    {
        private bool allowClose = false;

        public B4()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1)
            {
                Opacity += 0.1;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!allowClose)
            {
                DialogResult rel = MessageBox.Show(
                "Bạn chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rel == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = true;
                    timer2.Start();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Opacity > 0)
            {
                Opacity -= 0.1;
            }
            else
            {
                timer2.Stop();
                allowClose = true;       // Cho phép form đóng thật sự
                Application.Exit();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"; // (tuỳ chọn)
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                rtxtHienThi.Text = dlg.FileName;
            }
        }

        private void btFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"; // (tuỳ chọn)
            dlg.Multiselect = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in dlg.FileNames)
                {
                    rtxtHienThi.AppendText(file + Environment.NewLine);
                }
            }
        }

        private void btFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                rtxtHienThi.Text = dialog.SelectedPath;
            }
        }

        private void btBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                rtxtHienThi.BackColor = colorDialog.Color;
            }
        }

        private void btTextColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                rtxtHienThi.ForeColor = colorDialog.Color;
            }
        }

        private void btFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if ((fontDialog.ShowDialog() == DialogResult.OK))
            {
                rtxtHienThi.Font = fontDialog.Font;
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            rtxtHienThi.Clear();
            rtxtHienThi.Font = new Font("Arial", 8);
            rtxtHienThi.ForeColor = Color.Black;
            rtxtHienThi.BackColor = Color.White;

        }

    }
}
