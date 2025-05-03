namespace C2
{
    partial class B2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            label3 = new Label();
            txtC = new TextBox();
            label4 = new Label();
            label5 = new Label();
            lbKetqua = new Label();
            btTinh = new Button();
            btDong = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(239, 41);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(512, 48);
            label1.TabIndex = 0;
            label1.Text = "Chương trình giải thích bậc 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(124, 174);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 32);
            label2.TabIndex = 1;
            label2.Text = "a=";
            // 
            // txtA
            // 
            txtA.Location = new Point(176, 175);
            txtA.Margin = new Padding(4);
            txtA.Name = "txtA";
            txtA.Size = new Size(155, 31);
            txtA.TabIndex = 2;
            // 
            // txtB
            // 
            txtB.Location = new Point(440, 174);
            txtB.Margin = new Padding(4);
            txtB.Name = "txtB";
            txtB.Size = new Size(155, 31);
            txtB.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(388, 172);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(44, 32);
            label3.TabIndex = 3;
            label3.Text = "b=";
            // 
            // txtC
            // 
            txtC.Location = new Point(730, 179);
            txtC.Margin = new Padding(4);
            txtC.Name = "txtC";
            txtC.Size = new Size(155, 31);
            txtC.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(678, 178);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(41, 32);
            label4.TabIndex = 5;
            label4.Text = "c=";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(169, 282);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(126, 38);
            label5.TabIndex = 7;
            label5.Text = "Kết quả:";
            // 
            // lbKetqua
            // 
            lbKetqua.BackColor = SystemColors.GradientActiveCaption;
            lbKetqua.Enabled = false;
            lbKetqua.Location = new Point(298, 282);
            lbKetqua.Margin = new Padding(4, 0, 4, 0);
            lbKetqua.Name = "lbKetqua";
            lbKetqua.Size = new Size(525, 48);
            lbKetqua.TabIndex = 8;
            // 
            // btTinh
            // 
            btTinh.Font = new Font("Segoe UI", 12F);
            btTinh.Location = new Point(298, 431);
            btTinh.Margin = new Padding(4);
            btTinh.Name = "btTinh";
            btTinh.Size = new Size(149, 54);
            btTinh.TabIndex = 9;
            btTinh.Text = "Giải";
            btTinh.UseVisualStyleBackColor = true;
            btTinh.Click += btTinh_Click;
            // 
            // btDong
            // 
            btDong.Font = new Font("Segoe UI", 12F);
            btDong.Location = new Point(495, 431);
            btDong.Margin = new Padding(4);
            btDong.Name = "btDong";
            btDong.Size = new Size(149, 54);
            btDong.TabIndex = 10;
            btDong.Text = "Đóng";
            btDong.UseVisualStyleBackColor = true;
            btDong.Click += btDong_Click;
            // 
            // B2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(btDong);
            Controls.Add(btTinh);
            Controls.Add(lbKetqua);
            Controls.Add(label5);
            Controls.Add(txtC);
            Controls.Add(label4);
            Controls.Add(txtB);
            Controls.Add(label3);
            Controls.Add(txtA);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "B2";
            Text = "PHƯƠNG TRÌNH BẬC 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtA;
        private TextBox txtB;
        private Label label3;
        private TextBox txtC;
        private Label label4;
        private Label label5;
        private Label lbKetqua;
        private Button btTinh;
        private Button btDong;
    }
}