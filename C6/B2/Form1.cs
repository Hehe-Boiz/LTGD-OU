using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace B2
{
    public partial class Form1 : Form
    {
        List<Employee> employees = new List<Employee>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btNhap_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int age = int.Parse(txtAge.Text);
            string address = txtAddress.Text;
            Employee emp = new Employee(name, age, address);
            employees.Add(emp);
            txtName.Text = "";
            txtAge.Text = "";
            txtAddress.Text = "";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage2)
            {
                ShowList();
            }

        }

        private void ShowList()
        {
            listView1.Items.Clear(); // Xóa dữ liệu cũ

            foreach (Employee emp in employees)
            {
                ListViewItem item = new ListViewItem(emp.Name);
                item.SubItems.Add(emp.Age.ToString());
                item.SubItems.Add(emp.Address);
                listView1.Items.Add(item);
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Empl file (*.empl)|*.empl";
            saveDialog.DefaultExt = "empl";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string json = JsonSerializer.Serialize(employees); // employees là List<Employee>
                File.WriteAllText(saveDialog.FileName, json);

                MessageBox.Show("Đã lưu thành công!", "Thông báo");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Empl file (*.empl)|*.empl";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string json = File.ReadAllText(openDialog.FileName);
                employees = JsonSerializer.Deserialize<List<Employee>>(json);
                ShowList();
                // Gọi ShowEmployees() để hiển thị lên ListView nếu bạn có
            }
        }
    }
}
