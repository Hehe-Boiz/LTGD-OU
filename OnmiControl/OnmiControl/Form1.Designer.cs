namespace OnmiControl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnNav = new Panel();
            btnDel = new Button();
            btnGoals = new Button();
            btnNotebook = new Button();
            btnReport = new Button();
            btnHome = new Button();
            pnContent = new Panel();
            pnNav.SuspendLayout();
            SuspendLayout();
            // 
            // pnNav
            // 
            pnNav.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnNav.BackColor = Color.LightGray;
            pnNav.Controls.Add(btnDel);
            pnNav.Controls.Add(btnGoals);
            pnNav.Controls.Add(btnNotebook);
            pnNav.Controls.Add(btnReport);
            pnNav.Controls.Add(btnHome);
            pnNav.Location = new Point(0, 0);
            pnNav.Name = "pnNav";
            pnNav.Size = new Size(305, 810);
            pnNav.TabIndex = 1;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.LightGray;
            btnDel.FlatStyle = FlatStyle.Flat;
            btnDel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDel.ImageAlign = ContentAlignment.MiddleLeft;
            btnDel.Location = new Point(23, 410);
            btnDel.Name = "btnDel";
            btnDel.Padding = new Padding(30, 0, 0, 0);
            btnDel.Size = new Size(260, 56);
            btnDel.TabIndex = 4;
            btnDel.Text = "Delete temp files";
            btnDel.TextAlign = ContentAlignment.MiddleLeft;
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // btnGoals
            // 
            btnGoals.BackColor = Color.LightGray;
            btnGoals.FlatStyle = FlatStyle.Flat;
            btnGoals.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGoals.ImageAlign = ContentAlignment.MiddleLeft;
            btnGoals.Location = new Point(23, 247);
            btnGoals.Name = "btnGoals";
            btnGoals.Padding = new Padding(30, 0, 0, 0);
            btnGoals.Size = new Size(260, 56);
            btnGoals.TabIndex = 3;
            btnGoals.Text = "Goals";
            btnGoals.TextAlign = ContentAlignment.MiddleLeft;
            btnGoals.UseVisualStyleBackColor = false;
            btnGoals.Click += btnGoals_Click;
            // 
            // btnNotebook
            // 
            btnNotebook.BackColor = Color.LightGray;
            btnNotebook.FlatStyle = FlatStyle.Flat;
            btnNotebook.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnNotebook.ImageAlign = ContentAlignment.MiddleLeft;
            btnNotebook.Location = new Point(23, 328);
            btnNotebook.Name = "btnNotebook";
            btnNotebook.Padding = new Padding(30, 0, 0, 0);
            btnNotebook.Size = new Size(260, 56);
            btnNotebook.TabIndex = 2;
            btnNotebook.Text = "Notebook";
            btnNotebook.TextAlign = ContentAlignment.MiddleLeft;
            btnNotebook.UseVisualStyleBackColor = false;
            btnNotebook.Click += btnNotebook_Click;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.LightGray;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(23, 166);
            btnReport.Name = "btnReport";
            btnReport.Padding = new Padding(30, 0, 0, 0);
            btnReport.Size = new Size(260, 56);
            btnReport.TabIndex = 1;
            btnReport.Text = "Reports";
            btnReport.TextAlign = ContentAlignment.MiddleLeft;
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.White;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(23, 83);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(30, 0, 0, 0);
            btnHome.Size = new Size(260, 56);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // pnContent
            // 
            pnContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnContent.BackColor = Color.White;
            pnContent.Location = new Point(304, 0);
            pnContent.Name = "pnContent";
            pnContent.Size = new Size(1264, 810);
            pnContent.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1570, 810);
            Controls.Add(pnContent);
            Controls.Add(pnNav);
            Name = "Form1";
            Text = "OnmiControl";
            pnNav.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnNav;
        private Panel pnContent;
        private Button btnHome;
        private Button btnGoals;
        private Button btnNotebook;
        private Button btnReport;
        private Button btnDel;
    }
}
