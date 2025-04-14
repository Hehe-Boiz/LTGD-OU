namespace B2
{
    partial class B2
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
            txtSo1 = new TextBox();
            txtSo2 = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            rdChiadu = new RadioButton();
            rdChia = new RadioButton();
            rdNhan = new RadioButton();
            rdTru = new RadioButton();
            rdCong = new RadioButton();
            label4 = new Label();
            lbKetqua = new Label();
            btTinh = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 55);
            label1.TabIndex = 0;
            label1.Text = "CÁC PHÉP TÍNH ĐƠN GIẢN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(76, 85);
            label2.Name = "label2";
            label2.Size = new Size(90, 28);
            label2.TabIndex = 1;
            label2.Text = "Số thứ 1:";
            // 
            // txtSo1
            // 
            txtSo1.BorderStyle = BorderStyle.FixedSingle;
            txtSo1.Location = new Point(172, 89);
            txtSo1.Name = "txtSo1";
            txtSo1.Size = new Size(125, 27);
            txtSo1.TabIndex = 2;
            txtSo1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSo2
            // 
            txtSo2.BorderStyle = BorderStyle.FixedSingle;
            txtSo2.Location = new Point(577, 89);
            txtSo2.Name = "txtSo2";
            txtSo2.Size = new Size(125, 27);
            txtSo2.TabIndex = 4;
            txtSo2.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(481, 85);
            label3.Name = "label3";
            label3.Size = new Size(90, 28);
            label3.TabIndex = 3;
            label3.Text = "Số thứ 2:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(rdChiadu);
            groupBox1.Controls.Add(rdChia);
            groupBox1.Controls.Add(rdNhan);
            groupBox1.Controls.Add(rdTru);
            groupBox1.Controls.Add(rdCong);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(172, 165);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(530, 128);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn phép toán";
            // 
            // rdChiadu
            // 
            rdChiadu.AutoSize = true;
            rdChiadu.Location = new Point(421, 54);
            rdChiadu.Name = "rdChiadu";
            rdChiadu.Size = new Size(50, 32);
            rdChiadu.TabIndex = 4;
            rdChiadu.TabStop = true;
            rdChiadu.Text = "%";
            rdChiadu.UseVisualStyleBackColor = true;
            // 
            // rdChia
            // 
            rdChia.AutoSize = true;
            rdChia.Location = new Point(333, 54);
            rdChia.Name = "rdChia";
            rdChia.Size = new Size(41, 32);
            rdChia.TabIndex = 3;
            rdChia.TabStop = true;
            rdChia.Text = "/";
            rdChia.UseVisualStyleBackColor = true;
            // 
            // rdNhan
            // 
            rdNhan.AutoSize = true;
            rdNhan.Location = new Point(241, 54);
            rdNhan.Name = "rdNhan";
            rdNhan.Size = new Size(45, 32);
            rdNhan.TabIndex = 2;
            rdNhan.TabStop = true;
            rdNhan.Text = "X";
            rdNhan.UseVisualStyleBackColor = true;
            // 
            // rdTru
            // 
            rdTru.AutoSize = true;
            rdTru.Location = new Point(153, 54);
            rdTru.Name = "rdTru";
            rdTru.Size = new Size(41, 32);
            rdTru.TabIndex = 1;
            rdTru.TabStop = true;
            rdTru.Text = "-";
            rdTru.UseVisualStyleBackColor = true;
            // 
            // rdCong
            // 
            rdCong.AutoSize = true;
            rdCong.Location = new Point(59, 54);
            rdCong.Name = "rdCong";
            rdCong.Size = new Size(47, 32);
            rdCong.TabIndex = 0;
            rdCong.TabStop = true;
            rdCong.Text = "+";
            rdCong.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(83, 349);
            label4.Name = "label4";
            label4.Size = new Size(83, 28);
            label4.TabIndex = 6;
            label4.Text = "Kết quả:";
            // 
            // lbKetqua
            // 
            lbKetqua.BackColor = SystemColors.Info;
            lbKetqua.BorderStyle = BorderStyle.Fixed3D;
            lbKetqua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbKetqua.Location = new Point(172, 341);
            lbKetqua.Name = "lbKetqua";
            lbKetqua.Size = new Size(399, 36);
            lbKetqua.TabIndex = 7;
            lbKetqua.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btTinh
            // 
            btTinh.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTinh.Location = new Point(593, 341);
            btTinh.Name = "btTinh";
            btTinh.Size = new Size(109, 40);
            btTinh.TabIndex = 8;
            btTinh.Text = "Tính";
            btTinh.UseVisualStyleBackColor = true;
            btTinh.Click += btTinh_Click;
            // 
            // B2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Violet;
            ClientSize = new Size(800, 450);
            Controls.Add(btTinh);
            Controls.Add(lbKetqua);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(txtSo2);
            Controls.Add(label3);
            Controls.Add(txtSo1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "B2";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSo1;
        private TextBox txtSo2;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton rdChiadu;
        private RadioButton rdChia;
        private RadioButton rdNhan;
        private RadioButton rdTru;
        private RadioButton rdCong;
        private Label label4;
        private Label lbKetqua;
        private Button btTinh;
    }
}
