namespace OnmiControl
{
    partial class CalendarControl
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
            label1 = new Label();
            btnBefore = new Button();
            btnAfter = new Button();
            label2 = new Label();
            lbThang = new Label();
            pnNgay = new Panel();
            pnThu = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 21);
            label1.Name = "label1";
            label1.Size = new Size(167, 30);
            label1.TabIndex = 0;
            label1.Text = "Work Schedule";
            // 
            // btnBefore
            // 
            btnBefore.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBefore.Location = new Point(429, 17);
            btnBefore.Name = "btnBefore";
            btnBefore.Size = new Size(40, 41);
            btnBefore.TabIndex = 1;
            btnBefore.Text = "<";
            btnBefore.UseVisualStyleBackColor = true;
            btnBefore.Click += btnBefore_Click;
            // 
            // btnAfter
            // 
            btnAfter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAfter.Location = new Point(475, 17);
            btnAfter.Name = "btnAfter";
            btnAfter.Size = new Size(40, 41);
            btnAfter.TabIndex = 2;
            btnAfter.Text = ">";
            btnAfter.UseVisualStyleBackColor = true;
            btnAfter.Click += btnAfter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 77);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 3;
            label2.Click += label2_Click;
            // 
            // lbThang
            // 
            lbThang.AutoSize = true;
            lbThang.Location = new Point(211, 25);
            lbThang.Name = "lbThang";
            lbThang.Size = new Size(66, 25);
            lbThang.TabIndex = 17;
            lbThang.Text = "Tháng ";
            // 
            // pnNgay
            // 
            pnNgay.Location = new Point(19, 100);
            pnNgay.Name = "pnNgay";
            pnNgay.Size = new Size(586, 250);
            pnNgay.TabIndex = 18;
            // 
            // pnThu
            // 
            pnThu.Location = new Point(20, 65);
            pnThu.Name = "pnThu";
            pnThu.Size = new Size(585, 44);
            pnThu.TabIndex = 19;
            // 
            // CalendarControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(pnThu);
            Controls.Add(pnNgay);
            Controls.Add(lbThang);
            Controls.Add(label2);
            Controls.Add(btnAfter);
            Controls.Add(btnBefore);
            Controls.Add(label1);
            Margin = new Padding(40);
            Name = "CalendarControl";
            Size = new Size(530, 353);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBefore;
        private Button btnAfter;
        private Label label2;
        private Label lbThang;
        private Panel pnNgay;
        private Panel pnThu;
    }
}
