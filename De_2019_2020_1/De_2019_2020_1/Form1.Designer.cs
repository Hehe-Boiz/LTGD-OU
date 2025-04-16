namespace De_2019_2020_1
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
            groupBox1 = new GroupBox();
            cbCuoc1 = new ComboBox();
            label4 = new Label();
            rdLe = new RadioButton();
            rdChan = new RadioButton();
            groupBox2 = new GroupBox();
            cbCuoc2 = new ComboBox();
            label5 = new Label();
            rd11 = new RadioButton();
            rd3 = new RadioButton();
            pic1 = new PictureBox();
            pic2 = new PictureBox();
            pic3 = new PictureBox();
            panelLb = new Panel();
            lb3 = new Label();
            lb2 = new Label();
            lb1 = new Label();
            checkBox1 = new CheckBox();
            btnQuay = new Button();
            label6 = new Label();
            lbTienCon = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic3).BeginInit();
            panelLb.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbCuoc1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(rdLe);
            groupBox1.Controls.Add(rdChan);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(120, 273);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(332, 141);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn chẵn lẻ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cbCuoc1
            // 
            cbCuoc1.FormattingEnabled = true;
            cbCuoc1.Items.AddRange(new object[] { "100", "200", "300", "400", "500" });
            cbCuoc1.Location = new Point(171, 95);
            cbCuoc1.Name = "cbCuoc1";
            cbCuoc1.Size = new Size(151, 36);
            cbCuoc1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 96);
            label4.Name = "label4";
            label4.Size = new Size(124, 28);
            label4.TabIndex = 2;
            label4.Text = "Số tiền cược:";
            // 
            // rdLe
            // 
            rdLe.AutoSize = true;
            rdLe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdLe.Location = new Point(163, 56);
            rdLe.Name = "rdLe";
            rdLe.Size = new Size(42, 24);
            rdLe.TabIndex = 1;
            rdLe.Text = "lẻ";
            rdLe.UseVisualStyleBackColor = true;
            // 
            // rdChan
            // 
            rdChan.AutoSize = true;
            rdChan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdChan.Location = new Point(38, 56);
            rdChan.Name = "rdChan";
            rdChan.Size = new Size(63, 24);
            rdChan.TabIndex = 0;
            rdChan.Text = "Chẵn";
            rdChan.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbCuoc2);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(rd11);
            groupBox2.Controls.Add(rd3);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(501, 273);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(322, 141);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chọn tổng số";
            // 
            // cbCuoc2
            // 
            cbCuoc2.FormattingEnabled = true;
            cbCuoc2.Items.AddRange(new object[] { "100", "200", "300", "400", "500" });
            cbCuoc2.Location = new Point(165, 93);
            cbCuoc2.Name = "cbCuoc2";
            cbCuoc2.Size = new Size(151, 36);
            cbCuoc2.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 95);
            label5.Name = "label5";
            label5.Size = new Size(124, 28);
            label5.TabIndex = 3;
            label5.Text = "Số tiền cược:";
            // 
            // rd11
            // 
            rd11.AutoSize = true;
            rd11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rd11.Location = new Point(155, 56);
            rd11.Name = "rd11";
            rd11.Size = new Size(68, 24);
            rd11.TabIndex = 2;
            rd11.Text = "11-18";
            rd11.UseVisualStyleBackColor = true;
            // 
            // rd3
            // 
            rd3.AutoSize = true;
            rd3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rd3.Location = new Point(36, 56);
            rd3.Name = "rd3";
            rd3.Size = new Size(60, 24);
            rd3.TabIndex = 1;
            rd3.Text = "3-10";
            rd3.UseVisualStyleBackColor = true;
            // 
            // pic1
            // 
            pic1.Location = new Point(119, 70);
            pic1.Name = "pic1";
            pic1.Size = new Size(167, 165);
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1.TabIndex = 5;
            pic1.TabStop = false;
            // 
            // pic2
            // 
            pic2.Location = new Point(394, 70);
            pic2.Name = "pic2";
            pic2.Size = new Size(167, 165);
            pic2.SizeMode = PictureBoxSizeMode.StretchImage;
            pic2.TabIndex = 6;
            pic2.TabStop = false;
            // 
            // pic3
            // 
            pic3.Location = new Point(656, 70);
            pic3.Name = "pic3";
            pic3.Size = new Size(167, 165);
            pic3.SizeMode = PictureBoxSizeMode.StretchImage;
            pic3.TabIndex = 7;
            pic3.TabStop = false;
            // 
            // panelLb
            // 
            panelLb.Controls.Add(lb3);
            panelLb.Controls.Add(lb2);
            panelLb.Controls.Add(lb1);
            panelLb.Location = new Point(119, 27);
            panelLb.Name = "panelLb";
            panelLb.Size = new Size(704, 230);
            panelLb.TabIndex = 8;
            // 
            // lb3
            // 
            lb3.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb3.Location = new Point(548, 23);
            lb3.Name = "lb3";
            lb3.Size = new Size(153, 198);
            lb3.TabIndex = 2;
            lb3.Text = "0";
            lb3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb2
            // 
            lb2.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb2.Location = new Point(275, 23);
            lb2.Name = "lb2";
            lb2.Size = new Size(153, 198);
            lb2.TabIndex = 1;
            lb2.Text = "0";
            lb2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb1
            // 
            lb1.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb1.Location = new Point(3, 23);
            lb1.Name = "lb1";
            lb1.Size = new Size(153, 198);
            lb1.TabIndex = 0;
            lb1.Text = "0";
            lb1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(125, 460);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(161, 32);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Giao diện hình";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnQuay
            // 
            btnQuay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuay.Location = new Point(298, 457);
            btnQuay.Name = "btnQuay";
            btnQuay.Size = new Size(154, 37);
            btnQuay.TabIndex = 10;
            btnQuay.Text = "Quay số";
            btnQuay.UseVisualStyleBackColor = true;
            btnQuay.Click += btnQuay_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(501, 460);
            label6.Name = "label6";
            label6.Size = new Size(114, 28);
            label6.TabIndex = 11;
            label6.Text = "Tiền còn lại:";
            // 
            // lbTienCon
            // 
            lbTienCon.BorderStyle = BorderStyle.Fixed3D;
            lbTienCon.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTienCon.Location = new Point(652, 441);
            lbTienCon.Name = "lbTienCon";
            lbTienCon.Size = new Size(171, 79);
            lbTienCon.TabIndex = 12;
            lbTienCon.Text = "1000";
            lbTienCon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 552);
            Controls.Add(lbTienCon);
            Controls.Add(label6);
            Controls.Add(btnQuay);
            Controls.Add(checkBox1);
            Controls.Add(panelLb);
            Controls.Add(pic3);
            Controls.Add(pic2);
            Controls.Add(pic1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic3).EndInit();
            panelLb.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private RadioButton rdLe;
        private RadioButton rdChan;
        private GroupBox groupBox2;
        private PictureBox pic1;
        private PictureBox pic2;
        private PictureBox pic3;
        private Panel panelLb;
        private Label lb3;
        private Label lb2;
        private Label lb1;
        private Label label4;
        private ComboBox cbCuoc1;
        private ComboBox cbCuoc2;
        private Label label5;
        private RadioButton rd11;
        private RadioButton rd3;
        private CheckBox checkBox1;
        private Button btnQuay;
        private Label label6;
        private Label lbTienCon;
    }
}
