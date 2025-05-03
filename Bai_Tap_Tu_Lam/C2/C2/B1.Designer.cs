namespace C2
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
            lb1 = new Label();
            groupBox1 = new GroupBox();
            lbAscii = new Label();
            label2 = new Label();
            btAscii = new Button();
            txtAscii = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lbKytu = new Label();
            label5 = new Label();
            btKytu = new Button();
            txtKytu = new TextBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lb1
            // 
            lb1.BackColor = SystemColors.Highlight;
            lb1.Dock = DockStyle.Top;
            lb1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb1.ForeColor = SystemColors.Control;
            lb1.Location = new Point(0, 0);
            lb1.Margin = new Padding(4, 0, 4, 0);
            lb1.Name = "lb1";
            lb1.Size = new Size(1000, 100);
            lb1.TabIndex = 0;
            lb1.Text = "CHUYỂN MÃ ASCII";
            lb1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbAscii);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btAscii);
            groupBox1.Controls.Add(txtAscii);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(15, 142);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(438, 300);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chuyển mã ASCII sang ký tự ";
            // 
            // lbAscii
            // 
            lbAscii.BorderStyle = BorderStyle.Fixed3D;
            lbAscii.Location = new Point(148, 200);
            lbAscii.Margin = new Padding(4, 0, 4, 0);
            lbAscii.Name = "lbAscii";
            lbAscii.Size = new Size(156, 65);
            lbAscii.TabIndex = 4;
            lbAscii.Text = "A";
            lbAscii.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 208);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 38);
            label2.TabIndex = 3;
            label2.Text = "Kết quả";
            // 
            // btAscii
            // 
            btAscii.Location = new Point(148, 128);
            btAscii.Margin = new Padding(4, 4, 4, 4);
            btAscii.Name = "btAscii";
            btAscii.Size = new Size(156, 55);
            btAscii.TabIndex = 2;
            btAscii.Text = "Chuyển";
            btAscii.UseVisualStyleBackColor = true;
            btAscii.Click += btAscii_Click;
            // 
            // txtAscii
            // 
            txtAscii.Location = new Point(148, 72);
            txtAscii.Margin = new Padding(4, 4, 4, 4);
            txtAscii.Name = "txtAscii";
            txtAscii.Size = new Size(155, 44);
            txtAscii.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 76);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(128, 38);
            label1.TabIndex = 0;
            label1.Text = "Mã ASCII";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbKytu);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btKytu);
            groupBox2.Controls.Add(txtKytu);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(536, 142);
            groupBox2.Margin = new Padding(4, 4, 4, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 4, 4, 4);
            groupBox2.Size = new Size(438, 300);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chuyển mã ký tự sang ASCII ";
            // 
            // lbKytu
            // 
            lbKytu.BorderStyle = BorderStyle.Fixed3D;
            lbKytu.Location = new Point(148, 200);
            lbKytu.Margin = new Padding(4, 0, 4, 0);
            lbKytu.Name = "lbKytu";
            lbKytu.Size = new Size(156, 65);
            lbKytu.TabIndex = 4;
            lbKytu.Text = "A";
            lbKytu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 208);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 38);
            label5.TabIndex = 3;
            label5.Text = "Kết quả";
            // 
            // btKytu
            // 
            btKytu.Location = new Point(148, 128);
            btKytu.Margin = new Padding(4, 4, 4, 4);
            btKytu.Name = "btKytu";
            btKytu.Size = new Size(156, 55);
            btKytu.TabIndex = 2;
            btKytu.Text = "Chuyển";
            btKytu.UseVisualStyleBackColor = true;
            btKytu.Click += btKytu_Click;
            // 
            // txtKytu
            // 
            txtKytu.Location = new Point(148, 72);
            txtKytu.Margin = new Padding(4, 4, 4, 4);
            txtKytu.Name = "txtKytu";
            txtKytu.Size = new Size(155, 44);
            txtKytu.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 76);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(85, 38);
            label6.TabIndex = 0;
            label6.Text = "Ký tự:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(1000, 562);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lb1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Chuyển mã ASCII";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lb1;
        private GroupBox groupBox1;
        private Label label1;
        private Label lbAscii;
        private Label label2;
        private Button btAscii;
        private TextBox txtAscii;
        private GroupBox groupBox2;
        private Label lbKytu;
        private Label label5;
        private Button btKytu;
        private TextBox txtKytu;
        private Label label6;
    }
}
