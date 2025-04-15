namespace C6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        void InitTree()
        {
            string[] arrDrive = Directory.GetLogicalDrives();
            TreeNode node = null;
            foreach (string drive in arrDrive)
            {
                node = new TreeNode(drive);
                node.Nodes.Add("tmp");
                treeFolder.Nodes.Add(node);
            }
        }

        private void treeFolder_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                e.Node.Nodes.Clear();
                string[] arrDir = Directory.GetDirectories(e.Node.FullPath);
                TreeNode node = null;
                foreach (string dir in arrDir)
                {
                    node = new TreeNode(Path.GetFileName(dir));
                    node.ImageIndex = 1;
                    node.Nodes.Add("tmp");
                    e.Node.Nodes.Add(node);
                }
            }
            catch { }
        }

        private void treeFolder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                pnThum.Controls.Clear();
                string[] arrFile = Directory.GetFiles(e.Node.FullPath);
                foreach (string file in arrFile)
                {
                    if (file.ToLower().EndsWith("jpg") ||
                        file.ToLower().EndsWith("png") ||
                        file.ToLower().EndsWith("jpe") ||
                        file.ToLower().EndsWith("gif") ||
                        file.ToLower().EndsWith("ico"))
                    {
                        PictureBox pic = new PictureBox();
                        pic.Image = Image.FromFile(file);
                        pic.Height = pnThum.Height - 5;
                        pic.Width = pic.Height * 5 / 4;
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Cursor = Cursors.Hand;
                        pic.Click += Pic_Click;
                        pnThum.Controls.Add(pic);
                        pnThum.Controls.SetChildIndex(pic, 0);
                    }
                }
                if (e.Node.Level > 0)
                {
                    e.Node.ImageIndex = 1;
                    e.Node.SelectedImageIndex = 1;
                }
            }
            catch { }
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            picView.Image = pic.Image;
        }

        private void treeFolder_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level > 0)
            {
                e.Node.ImageIndex = 2;
                e.Node.SelectedImageIndex = 2;
            }
        }

        private void treeFolder_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level > 0)
            {
                e.Node.ImageIndex = 1;
                e.Node.SelectedImageIndex = 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitTree();
        }
    }
}
