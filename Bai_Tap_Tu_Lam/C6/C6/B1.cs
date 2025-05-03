namespace C6
{
    public partial class B1 : Form
    {
        public B1()
        {
            InitializeComponent();
        }

        private void LoadFilesAndDirectories(string path)
        {
            lstFolderAndFile.Items.Clear();
            try
            {
                string[] directories = Directory.GetDirectories(path);
                string[] files = Directory.GetFiles(path);
                // Hiển thị folder
                foreach (string dir in directories)
                {
                    DirectoryInfo d = new DirectoryInfo(dir);
                    ListViewItem item = new ListViewItem(d.Name);
                    item.SubItems.Add("");
                    item.SubItems.Add(d.LastAccessTime.ToString());
                    item.Tag = dir;
                    item.ImageIndex = 0;
                    lstFolderAndFile.Items.Add(item);
                }
                // Hiển thì file
                foreach (string fil in files)
                {
                    FileInfo f = new FileInfo(fil);
                    ListViewItem item = new ListViewItem(f.Name);
                    item.SubItems.Add(GetReadableFileSize(f.Length));
                    item.SubItems.Add(f.LastAccessTime.ToString());
                    item.Tag = fil;
                    item.ImageIndex = 2;
                    lstFolderAndFile.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }
        // Quy đổi byte
        string GetReadableFileSize(long sizeInBytes)
        {
            if (sizeInBytes >= 1024 * 1024 * 1024)
                return (sizeInBytes / (1024.0 * 1024 * 1024)).ToString("0.##") + " GB";
            else if (sizeInBytes >= 1024 * 1024)
                return (sizeInBytes / (1024.0 * 1024)).ToString("0.##") + " MB";
            else if (sizeInBytes >= 1024)
                return (sizeInBytes / 1024.0).ToString("0.##") + " KB";
            else
                return sizeInBytes + " B";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbDrive.Items.AddRange(Directory.GetLogicalDrives());
            cbDrive.SelectedIndex = 0;
            LoadFilesAndDirectories(cbDrive.SelectedItem.ToString());
        }
        //Hiển thị thư mục và file khi chọn ổ đĩa
        private void cbDrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDrive = cbDrive.SelectedItem.ToString();
            LoadFilesAndDirectories(selectedDrive);
        }

        private void lstFolderAndFile_DoubleClick(object sender, EventArgs e)
        {
            if (lstFolderAndFile.SelectedItems.Count > 0)
            {
                string path = lstFolderAndFile.SelectedItems[0].Tag.ToString();
                if (Directory.Exists(path))
                {
                    LoadFilesAndDirectories(path);
                }
                else if (File.Exists(path))
                {
                    System.Diagnostics.Process.Start(path);
                }
            }
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rdLargeIcon.Checked) lstFolderAndFile.View = View.LargeIcon;
            else if (rdSmallIcon.Checked) lstFolderAndFile.View = View.SmallIcon;
            else if (rdList.Checked) lstFolderAndFile.View = View.List;
            else if (rdTile.Checked) lstFolderAndFile.View = View.Tile;
            else if (rdDetails.Checked) lstFolderAndFile.View = View.Details;
        }

    }
}
