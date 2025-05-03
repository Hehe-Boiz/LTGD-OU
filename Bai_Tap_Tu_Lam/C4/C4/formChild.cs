using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C4
{
    public partial class formChild : Form
    {
        Image img;
        public formChild()
        {
            InitializeComponent();
        }

        private void formChild_Load(object sender, EventArgs e)
        {
            loadImage(Application.StartupPath + @"\Hehe-Boi-meme-7.jpg");
        }
        private void loadImage(string filename)
        {
            img = Image.FromFile(filename);
            pictureBox1.Image = img;
        }

        private void menuLoad_Click(object sender, EventArgs e)
        {
            loadImage(Application.StartupPath + @"\Hehe-Boi-meme-7.jpg");
        }

        private void menuClear_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
        private void menuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (jpeg, gif, bmp, png)|*.jpg;*.gif;*.bmp;*.png|" +
             "JPEG files (*.jpg)|*.jpg|" +
             "GIF files (*.gif)|*.gif|" +
             "Bitmap files (*.bmp)|*.bmp|" +
             "PNG files (*.png)|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                loadImage(ofd.FileName);
            }
        }
        private void menuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Filter = "Image files (jpeg, gif, bmp, png)|*.jpg;*.gif;*.bmp;*.png|" +
             "JPEG files (*.jpg)|*.jpg|" +
             "GIF files (*.gif)|*.gif|" +
             "Bitmap files (*.bmp)|*.bmp|" +
             "PNG files (*.png)|*.png";
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                if (ofd.FileName.ToLower().EndsWith(".jpg"))
                    img.Save(ofd.FileName, ImageFormat.Jpeg);
                else if (ofd.FileName.ToLower().EndsWith(".bmp"))
                    img.Save(ofd.FileName, ImageFormat.Bmp);
                else if (ofd.FileName.ToLower().EndsWith(".png"))
                    img.Save(ofd.FileName, ImageFormat.Png);
                else if (ofd.FileName.ToLower().EndsWith(".gif"))
                    img.Save(ofd.FileName, ImageFormat.Gif);

            }
        }

    }
}
