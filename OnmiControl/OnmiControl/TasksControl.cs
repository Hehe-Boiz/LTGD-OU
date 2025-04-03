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
using Microsoft.VisualBasic;

namespace OnmiControl
{
    public partial class TasksControl : UserControl
    {

        private string placeholderTask = "  Thêm task";
        private string placeholder = "  Mô tả chi tiết";

        public TasksControl()
        {
            InitializeComponent();
            InitializeTasksControl();
        }

        private void InitializeTasksControl()
        {
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 0;


            txtTask.Enter += (s, e) =>
            {
                if (txtTask.Text == placeholderTask)
                {
                    txtTask.Text = "  ";
                    txtTask.ForeColor = Color.Black;
                }
            };

            txtTask.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtTask.Text))
                {
                    txtTask.Text = placeholderTask;
                    txtTask.ForeColor = Color.Gray;
                }
            };

            txtDetail.Enter += (s, e) =>
            {
                if (txtDetail.Text == placeholder)
                {
                    txtDetail.Text = "  ";
                    txtDetail.ForeColor = Color.Black;
                }
            };

            txtDetail.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtDetail.Text))
                {
                    txtDetail.Text = placeholder;
                    txtDetail.ForeColor = Color.Gray;
                }
            };

            txtDetail.Region = GetRoundedRegion(txtDetail, 25);
            txtTask.Region = GetRoundedRegion(txtTask, 25);
            btnAdd.Region = GetRoundedRegion(btnAdd, 20);


        }

        // tạo vùng bo góc
        private Region GetRoundedRegion(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, control.Width, control.Height);

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return new Region(path);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
