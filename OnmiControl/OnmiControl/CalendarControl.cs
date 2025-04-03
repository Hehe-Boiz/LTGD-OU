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

namespace OnmiControl
{
    public partial class CalendarControl : UserControl
    {
        private DateTime now = DateTime.Now;
        public CalendarControl()
        {
            InitializeComponent();
            CreateButtons(now);

            // Xóa viền + hover
            btnBefore.Region = GetRoundedRegion(btnBefore, 30);
            btnBefore.FlatStyle = FlatStyle.Flat;
            btnBefore.FlatAppearance.BorderSize = 0;
            btnBefore.BackColor = Color.White;

            btnAfter.Region = GetRoundedRegion(btnAfter, 30);
            btnAfter.FlatStyle = FlatStyle.Flat;
            btnAfter.FlatAppearance.BorderSize = 0;
            btnAfter.BackColor = Color.White;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            now = now.AddMonths(-1);
            CreateButtons(now);
            

        }

        private void btnAfter_Click(object sender, EventArgs e)
        {
            now = now.AddMonths(1);
            CreateButtons(now);
        }

        private void CreateLabelThu()
        {
            int horizontalSpacing = 74;
            int startX = 14;
            int startY = 12;
            int LabelWidth = 40;
            int LabelHeight = 25;
            int count = 2;
            for (int i = 0; i < 7; i++)
            {
                // Tính toán vị trí hàng và cột cho button
                int col = i;

                Label label = new Label();
                label.Size = new Size(LabelWidth, LabelHeight);
                label.Location = new Point(startX + col * horizontalSpacing, startY);
                label.Font = new Font("Arial", 9, FontStyle.Bold);


                if (i != 6)
                {
                    label.Text = "T" + count.ToString();
                }
                else
                {
                    label.Text = "CN";
                }
                count++;

                pnThu.Controls.Add(label);
            }
        }

        private void CreateButtons(DateTime thang)
        {
            lbThang.Text = "Tháng " + thang.Month.ToString() + " " + thang.Year.ToString();
            CreateLabelThu();
            pnNgay.Controls.Clear();

            int buttonsPerRow = 7;
            int numRows = 6;               // Lưới 6 hàng
            int numButtons = buttonsPerRow * numRows; // 42 button
            int horizontalSpacing = 75;    // Khoảng cách giữa các button theo chiều ngang
            int verticalSpacing = 40;      // Khoảng cách giữa các hàng
            int startX = 10;               // Vị trí X ban đầu
            int startY = 10;               // Vị trí Y ban đầu
            int buttonWidth = 40;          // Chiều rộng của button
            int buttonHeight = 40;         // Chiều cao của button

            // Tính toán ngày đầu tiên của tháng và số ngày trong tháng
            DateTime firstDay = new DateTime(thang.Year, thang.Month, 1);
            int daysInMonth = DateTime.DaysInMonth(thang.Year, thang.Month);

            // Sửa: Điều chỉnh chỉ số bắt đầu dựa vào cách sắp xếp của bạn
            // Giả sử thứ 2 là ngày đầu tiên trong tuần (cột 0)
            int startCol;
            if (firstDay.DayOfWeek == DayOfWeek.Sunday)
                startCol = 6; // Nếu chủ nhật là cuối tuần (cột 6)
            else
                startCol = (int)firstDay.DayOfWeek - 1; // Trừ 1 vì thứ 2 (Monday=1) sẽ là cột 0

            int dayCounter = 1;
            for (int i = 0; i < numButtons; i++)
            {
                // Tính toán vị trí hàng và cột cho button
                int col = i % buttonsPerRow;
                int row = i / buttonsPerRow;
                Button btn = new Button();
                btn.Size = new Size(buttonWidth, buttonHeight);
                btn.Location = new Point(startX + col * horizontalSpacing, startY + row * verticalSpacing);
                btn.Font = new Font("Arial", 9, FontStyle.Regular);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseOverBackColor = Color.White;
                // Nếu ô hiện tại nằm sau vị trí bắt đầu và chưa vượt quá số ngày của tháng,
                // thì gán số ngày vào Button và cho phép bấm.
                if (i >= startCol && dayCounter <= daysInMonth)
                {
                    btn.Text = dayCounter.ToString();
                    btn.Enabled = true;

                    dayCounter++;
                }
                else
                {
                    // Các ô không có ngày: để trống và vô hiệu hóa
                    btn.Text = "";
                    btn.Enabled = false;
                }
                btn.Region = GetRoundedRegion(btn, 43);
                pnNgay.Controls.Add(btn);
            }
        }

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


    }
}
