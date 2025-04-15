namespace De_2019_2020
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox2 = new GroupBox();
            lbTien = new Label();
            label3 = new Label();
            btnQuay = new Button();
            txtCuoc = new TextBox();
            label2 = new Label();
            cbchon = new ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Backgrd;
            pictureBox1.Location = new Point(56, 32);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(687, 374);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(56, 452);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(687, 205);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kết quả";
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(516, 38);
            pictureBox4.Margin = new Padding(4, 5, 4, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(133, 138);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(281, 38);
            pictureBox3.Margin = new Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(133, 138);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(52, 38);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(133, 138);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbTien);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnQuay);
            groupBox2.Controls.Add(txtCuoc);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cbchon);
            groupBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(777, 32);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(225, 625);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chọn";
            // 
            // lbTien
            // 
            lbTien.BorderStyle = BorderStyle.Fixed3D;
            lbTien.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTien.ForeColor = SystemColors.MenuHighlight;
            lbTien.Location = new Point(16, 474);
            lbTien.Margin = new Padding(4, 0, 4, 0);
            lbTien.Name = "lbTien";
            lbTien.Size = new Size(201, 103);
            lbTien.TabIndex = 10;
            lbTien.Text = "1000";
            lbTien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 420);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(118, 25);
            label3.TabIndex = 9;
            label3.Text = "Tiền còn lại:";
            // 
            // btnQuay
            // 
            btnQuay.Location = new Point(16, 298);
            btnQuay.Margin = new Padding(4, 5, 4, 5);
            btnQuay.Name = "btnQuay";
            btnQuay.Size = new Size(201, 52);
            btnQuay.TabIndex = 7;
            btnQuay.Text = "Quay";
            btnQuay.UseVisualStyleBackColor = true;
            btnQuay.Click += btnQuay_Click;
            // 
            // txtCuoc
            // 
            txtCuoc.Location = new Point(13, 225);
            txtCuoc.Margin = new Padding(4, 5, 4, 5);
            txtCuoc.Name = "txtCuoc";
            txtCuoc.Size = new Size(203, 30);
            txtCuoc.TabIndex = 6;
            txtCuoc.KeyPress += txtCuoc_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 169);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 5;
            label2.Text = "Tiền cược:";
            // 
            // cbchon
            // 
            cbchon.FormattingEnabled = true;
            cbchon.Location = new Point(8, 58);
            cbchon.Margin = new Padding(4, 5, 4, 5);
            cbchon.Name = "cbchon";
            cbchon.Size = new Size(208, 33);
            cbchon.TabIndex = 3;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 675);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQuay;
        private System.Windows.Forms.TextBox txtCuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbchon;
        private System.Windows.Forms.Timer timer1;
    }
}
