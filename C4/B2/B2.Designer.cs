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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            btn6 = new Button();
            btn3 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            picChoose = new PictureBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            btnReset = new Button();
            btnPlay = new Button();
            picResult = new PictureBox();
            groupBox4 = new GroupBox();
            lbLose = new Label();
            lbWin = new Label();
            lbCount = new Label();
            listResult = new ListBox();
            toolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picChoose).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picResult).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn6);
            groupBox1.Controls.Add(btn3);
            groupBox1.Controls.Add(btn5);
            groupBox1.Controls.Add(btn4);
            groupBox1.Controls.Add(btn2);
            groupBox1.Controls.Add(btn1);
            groupBox1.Controls.Add(picChoose);
            groupBox1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.DarkOliveGreen;
            groupBox1.Location = new Point(29, 43);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(297, 260);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đoán số";
            // 
            // btn6
            // 
            btn6.Location = new Point(231, 169);
            btn6.Margin = new Padding(4, 5, 4, 5);
            btn6.Name = "btn6";
            btn6.Size = new Size(47, 52);
            btn6.TabIndex = 2;
            btn6.Text = "6";
            toolTip1.SetToolTip(btn6, "Click một nút để đoán số ");
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn1_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(16, 169);
            btn3.Margin = new Padding(4, 5, 4, 5);
            btn3.Name = "btn3";
            btn3.Size = new Size(47, 52);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            toolTip1.SetToolTip(btn3, "Click một nút để đoán số ");
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn1_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(231, 108);
            btn5.Margin = new Padding(4, 5, 4, 5);
            btn5.Name = "btn5";
            btn5.Size = new Size(47, 52);
            btn5.TabIndex = 2;
            btn5.Text = "5";
            toolTip1.SetToolTip(btn5, "Click một nút để đoán số ");
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn1_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(231, 46);
            btn4.Margin = new Padding(4, 5, 4, 5);
            btn4.Name = "btn4";
            btn4.Size = new Size(47, 52);
            btn4.TabIndex = 2;
            btn4.Text = "4";
            toolTip1.SetToolTip(btn4, "Click một nút để đoán số ");
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(16, 108);
            btn2.Margin = new Padding(4, 5, 4, 5);
            btn2.Name = "btn2";
            btn2.Size = new Size(47, 52);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            toolTip1.SetToolTip(btn2, "Click một nút để đoán số ");
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn1_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(16, 46);
            btn1.Margin = new Padding(4, 5, 4, 5);
            btn1.Name = "btn1";
            btn1.Size = new Size(47, 52);
            btn1.TabIndex = 2;
            btn1.Text = "1";
            toolTip1.SetToolTip(btn1, "Click một nút để đoán số ");
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // picChoose
            // 
            picChoose.Location = new Point(99, 88);
            picChoose.Margin = new Padding(4, 5, 4, 5);
            picChoose.Name = "picChoose";
            picChoose.Size = new Size(104, 97);
            picChoose.SizeMode = PictureBoxSizeMode.StretchImage;
            picChoose.TabIndex = 1;
            picChoose.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(296, 449);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(11, 12);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnReset);
            groupBox3.Controls.Add(btnPlay);
            groupBox3.Controls.Add(picResult);
            groupBox3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.FromArgb(0, 64, 0);
            groupBox3.Location = new Point(29, 312);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 5, 4, 5);
            groupBox3.Size = new Size(296, 235);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Quay Số ( sinh số ngẫu nhiên )";
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(168, 168);
            btnReset.Margin = new Padding(4, 5, 4, 5);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(120, 43);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset(ESC)";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnPlay
            // 
            btnPlay.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlay.Location = new Point(16, 168);
            btnPlay.Margin = new Padding(4, 5, 4, 5);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(120, 43);
            btnPlay.TabIndex = 2;
            btnPlay.Text = "Quay số(Enter)";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // picResult
            // 
            picResult.Location = new Point(99, 52);
            picResult.Margin = new Padding(4, 5, 4, 5);
            picResult.Name = "picResult";
            picResult.Size = new Size(104, 97);
            picResult.SizeMode = PictureBoxSizeMode.StretchImage;
            picResult.TabIndex = 1;
            picResult.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lbLose);
            groupBox4.Controls.Add(lbWin);
            groupBox4.Controls.Add(lbCount);
            groupBox4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.FromArgb(0, 64, 0);
            groupBox4.Location = new Point(31, 575);
            groupBox4.Margin = new Padding(4, 5, 4, 5);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 5, 4, 5);
            groupBox4.Size = new Size(296, 191);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Quay Số ( sinh số ngẫu nhiên )";
            // 
            // lbLose
            // 
            lbLose.AutoSize = true;
            lbLose.ForeColor = Color.Purple;
            lbLose.Location = new Point(28, 138);
            lbLose.Margin = new Padding(4, 0, 4, 0);
            lbLose.Name = "lbLose";
            lbLose.Size = new Size(53, 20);
            lbLose.TabIndex = 1;
            lbLose.Text = "label2";
            // 
            // lbWin
            // 
            lbWin.AutoSize = true;
            lbWin.ForeColor = Color.Fuchsia;
            lbWin.Location = new Point(28, 91);
            lbWin.Margin = new Padding(4, 0, 4, 0);
            lbWin.Name = "lbWin";
            lbWin.Size = new Size(53, 20);
            lbWin.TabIndex = 1;
            lbWin.Text = "label2";
            // 
            // lbCount
            // 
            lbCount.AutoSize = true;
            lbCount.ForeColor = Color.Blue;
            lbCount.Location = new Point(28, 45);
            lbCount.Margin = new Padding(4, 0, 4, 0);
            lbCount.Name = "lbCount";
            lbCount.Size = new Size(53, 20);
            lbCount.TabIndex = 0;
            lbCount.Text = "label1";
            // 
            // listResult
            // 
            listResult.FormattingEnabled = true;
            listResult.Location = new Point(383, 65);
            listResult.Margin = new Padding(4, 5, 4, 5);
            listResult.Name = "listResult";
            listResult.Size = new Size(432, 704);
            listResult.TabIndex = 3;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Đoán số ";
            // 
            // B2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 818);
            Controls.Add(listResult);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "B2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picChoose).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picResult).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picChoose;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbWin;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Label lbLose;
        private System.Windows.Forms.ListBox listResult;
        private ToolTip toolTip1;
    }
}
