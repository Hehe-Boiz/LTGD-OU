using System.Drawing.Drawing2D;
using System.Security.Cryptography;

namespace OnmiControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RemoveButtonBorders(pnNav);
            pnNav.Region = GetRoundedRegion(pnNav, 30);
            pnNav.Resize += (s, ev) =>
            {
                pnNav.Region = GetRoundedRegion(pnNav, 30);
            };

            Shown_Home();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.Region = GetRoundedRegion(this, 700);

            this.Resize += (s, ev) =>
            {
                this.Region = GetRoundedRegion(this, 70);
            };

            
            Shown_Home();

            
        }

        
        private void RemoveButtonBorders(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Button btn && btn.Name.StartsWith("btn"))
                {
                    // Xóa viền + hover
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatAppearance.MouseOverBackColor = Color.White;
                    btn.UseVisualStyleBackColor = false;
                    // Bo góc ngay lập tức
                    btn.Region = GetRoundedRegion(btn, 25);

                }


            }
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

        // reset lại các nút 
        private void HighlightButton(Button activeButton)
        {
            btnHome.BackColor = Color.LightGray;
            btnReport.BackColor = Color.LightGray;
            btnGoals.BackColor = Color.LightGray;
            btnNotebook.BackColor = Color.LightGray;
            btnDel.BackColor = Color.LightGray;

            activeButton.BackColor = Color.White;
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            Shown_Home();
        }

        

        private void btnReport_Click(object sender, EventArgs e)
        {
            Shown_Report();
        }

        private void btnGoals_Click(object sender, EventArgs e)
        {
            Shown_Goals();
        }

        private void btnNotebook_Click(object sender, EventArgs e)
        {
            Shown_Notebook();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Shown_Del();
        }

        private void Shown_Home()
        {

            HighlightButton(btnHome);
            pnContent.Controls.Clear();

            // đặt lai pnContent
            pnContent.BackColor = Color.White;
            pnContent.Padding = new Padding(100);
            pnContent.Location = new Point(321
                , 0);

            CalendarControl calendarControl = new CalendarControl();
            // Đặt Dock cho CalendarControl để chiếm toàn bộ MainForm
            calendarControl.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Nếu MainForm của bạn có các control khác (ví dụ: panel chứa nội dung), bạn có thể thêm vào container đó.
            // Ví dụ: this.Controls.Add(calendarControl);
            calendarControl.Location = new Point(0, 15);

            calendarControl.Region = GetRoundedRegion(calendarControl, 35);
            pnContent.Controls.Add(calendarControl);

            TasksControl tasksControl = new TasksControl();
            tasksControl.Location = new Point(0, 380);
            tasksControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tasksControl.Region = GetRoundedRegion(tasksControl, 35);
            pnContent.Controls.Add(tasksControl);
        }

        private void Shown_Report()
        {
            HighlightButton(btnReport);
            resetPnContent();
            pnContent.Controls.Clear();
        }

        private void Shown_Goals()
        {
            HighlightButton(btnGoals);
            resetPnContent();
            pnContent.Controls.Clear();
        }

        private void Shown_Notebook()
        {
            HighlightButton(btnNotebook);
            resetPnContent();
            pnContent.Controls.Clear();
        }

        private void Shown_Del()
        {
            HighlightButton(btnDel);
            resetPnContent();
            pnContent.Controls.Clear();
        }

        private void resetPnContent()
        {
            pnContent.Controls.Clear();
            pnContent.BackColor = Color.LightGray;
            pnContent.Padding = new Padding(20);
            pnContent.Location = new Point(321, 0);

            pnContent.Region = GetRoundedRegion(pnContent, 30);
            pnContent.Resize += (s, ev) =>
            {
                pnContent.Region = GetRoundedRegion(pnContent, 30);
            };
        }
    }





}
