namespace C2
{
    partial class B1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtSo1 = new TextBox();
            txtSo2 = new TextBox();
            btnCong = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            label4 = new Label();
            btnDong = new Button();
            lbResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 69);
            label1.TabIndex = 0;
            label1.Text = "CÁC PHÉP TÍNH ĐƠN GIẢN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(74, 95);
            label2.Name = "label2";
            label2.Size = new Size(90, 28);
            label2.TabIndex = 1;
            label2.Text = "Số thứ 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(449, 95);
            label3.Name = "label3";
            label3.Size = new Size(90, 28);
            label3.TabIndex = 2;
            label3.Text = "Số thứ 2:";
            // 
            // txtSo1
            // 
            txtSo1.BorderStyle = BorderStyle.FixedSingle;
            txtSo1.Location = new Point(170, 99);
            txtSo1.Name = "txtSo1";
            txtSo1.Size = new Size(125, 27);
            txtSo1.TabIndex = 3;
            // 
            // txtSo2
            // 
            txtSo2.BorderStyle = BorderStyle.FixedSingle;
            txtSo2.Location = new Point(545, 99);
            txtSo2.Name = "txtSo2";
            txtSo2.Size = new Size(125, 27);
            txtSo2.TabIndex = 4;
            // 
            // btnCong
            // 
            btnCong.BackColor = SystemColors.ControlLight;
            btnCong.FlatStyle = FlatStyle.Flat;
            btnCong.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCong.Location = new Point(215, 205);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(70, 46);
            btnCong.TabIndex = 5;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = false;
            btnCong.Click += btnCong_Click;
            // 
            // btnTru
            // 
            btnTru.BackColor = SystemColors.ControlLight;
            btnTru.FlatStyle = FlatStyle.Flat;
            btnTru.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTru.Location = new Point(321, 205);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(70, 46);
            btnTru.TabIndex = 6;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = false;
            btnTru.Click += btnTru_Click;
            // 
            // btnNhan
            // 
            btnNhan.BackColor = SystemColors.ControlLight;
            btnNhan.FlatStyle = FlatStyle.Flat;
            btnNhan.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNhan.Location = new Point(427, 205);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(70, 46);
            btnNhan.TabIndex = 7;
            btnNhan.Text = "X";
            btnNhan.UseVisualStyleBackColor = false;
            btnNhan.Click += btnNhan_Click;
            // 
            // btnChia
            // 
            btnChia.BackColor = SystemColors.ControlLight;
            btnChia.FlatStyle = FlatStyle.Flat;
            btnChia.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChia.Location = new Point(533, 205);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(70, 46);
            btnChia.TabIndex = 8;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = false;
            btnChia.Click += btnChia_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(88, 348);
            label4.Name = "label4";
            label4.Size = new Size(83, 28);
            label4.TabIndex = 9;
            label4.Text = "Kết quả:";
            // 
            // btnDong
            // 
            btnDong.BackColor = SystemColors.ControlLight;
            btnDong.FlatStyle = FlatStyle.Flat;
            btnDong.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDong.Location = new Point(576, 341);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(94, 41);
            btnDong.TabIndex = 11;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = false;
            btnDong.Click += btnDong_Click;
            // 
            // lbResult
            // 
            lbResult.BackColor = SystemColors.Info;
            lbResult.BorderStyle = BorderStyle.Fixed3D;
            lbResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbResult.Location = new Point(215, 341);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(345, 41);
            lbResult.TabIndex = 12;
            lbResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Violet;
            ClientSize = new Size(800, 450);
            Controls.Add(lbResult);
            Controls.Add(btnDong);
            Controls.Add(label4);
            Controls.Add(btnChia);
            Controls.Add(btnNhan);
            Controls.Add(btnTru);
            Controls.Add(btnCong);
            Controls.Add(txtSo2);
            Controls.Add(txtSo1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSo1;
        private TextBox txtSo2;
        private Button btnCong;
        private Button btnTru;
        private Button btnNhan;
        private Button btnChia;
        private Label label4;
        private Button btnDong;
        private Label lbResult;
    }
}
