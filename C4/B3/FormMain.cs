namespace B3
{
    public partial class FormMain : Form
    {
        string username;
        public FormMain()
        {
            FormLogin loginForm = new FormLogin();
            loginForm.ShowDialog(); // Hiển thị form đăng nhập
            username = loginForm.GetUsername();
            InitializeComponent();
            lbusername.Text = username;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(txtHoten.Text);
            item.SubItems.Add(dtNgaysinh.Text);
            item.SubItems.Add(rdNam.Checked ? "Nam" : "Nữ");
            item.ImageIndex = rdNam.Checked ? 0 : 1;
            listNhanvien.Items.Add(item);
            txtHoten.Clear();
            txtHoten.Focus();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listNhanvien.SelectedItems)
                listNhanvien.Items.Remove(item);
        }
    }
}
