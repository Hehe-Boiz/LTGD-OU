namespace OnmiControl
{
    partial class TasksControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTask = new TextBox();
            date = new DateTimePicker();
            txtDetail = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // txtTask
            // 
            txtTask.BorderStyle = BorderStyle.None;
            txtTask.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtTask.ForeColor = Color.Gray;
            txtTask.Location = new Point(30, 28);
            txtTask.Multiline = true;
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(480, 46);
            txtTask.TabIndex = 0;
            txtTask.Text = "  Thêm task";
            // 
            // date
            // 
            date.CustomFormat = "   dd/MM/yyyy";
            date.Format = DateTimePickerFormat.Custom;
            date.Location = new Point(30, 107);
            date.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            date.Name = "date";
            date.Size = new Size(169, 31);
            date.TabIndex = 1;
            // 
            // txtDetail
            // 
            txtDetail.BorderStyle = BorderStyle.None;
            txtDetail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDetail.ForeColor = Color.Gray;
            txtDetail.Location = new Point(30, 157);
            txtDetail.Multiline = true;
            txtDetail.Name = "txtDetail";
            txtDetail.Size = new Size(480, 160);
            txtDetail.TabIndex = 3;
            txtDetail.Text = "  Mô tả chi tiết";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "  h:mm tt";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(242, 107);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(142, 31);
            dateTimePicker1.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SeaGreen;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.LightGreen;
            btnAdd.Location = new Point(380, 353);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 46);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // TasksControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(btnAdd);
            Controls.Add(txtDetail);
            Controls.Add(dateTimePicker1);
            Controls.Add(date);
            Controls.Add(txtTask);
            Name = "TasksControl";
            Size = new Size(530, 420);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTask;
        private DateTimePicker date;
        private TextBox txtDetail;
        private DateTimePicker dateTimePicker1;
        private Button btnAdd;
    }
}
