namespace De_2019_2020
{
    partial class Welcome
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
            components = new System.ComponentModel.Container();
            lb1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ptr2 = new PictureBox();
            ptr1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptr2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptr1).BeginInit();
            SuspendLayout();
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb1.ForeColor = Color.Red;
            lb1.Location = new Point(179, 40);
            lb1.Margin = new Padding(4, 0, 4, 0);
            lb1.Name = "lb1";
            lb1.Size = new Size(840, 54);
            lb1.TabIndex = 0;
            lb1.Text = "Chào mừng bạn đến với CAMPUCHIA";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 5;
            timer1.Tick += timer1_Tick;
            // 
            // ptr2
            // 
            ptr2.Image = Properties.Resources._2;
            ptr2.Location = new Point(1104, 18);
            ptr2.Margin = new Padding(4, 5, 4, 5);
            ptr2.Name = "ptr2";
            ptr2.Size = new Size(101, 109);
            ptr2.SizeMode = PictureBoxSizeMode.StretchImage;
            ptr2.TabIndex = 2;
            ptr2.TabStop = false;
            // 
            // ptr1
            // 
            ptr1.Image = Properties.Resources._1;
            ptr1.Location = new Point(57, 18);
            ptr1.Margin = new Padding(4, 5, 4, 5);
            ptr1.Name = "ptr1";
            ptr1.Size = new Size(101, 109);
            ptr1.SizeMode = PictureBoxSizeMode.StretchImage;
            ptr1.TabIndex = 1;
            ptr1.TabStop = false;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1245, 151);
            Controls.Add(ptr2);
            Controls.Add(ptr1);
            Controls.Add(lb1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Welcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome";
            Load += Welcome_Load;
            Paint += Welcome_Paint;
            ((System.ComponentModel.ISupportInitialize)ptr2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptr1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.PictureBox ptr1;
        private System.Windows.Forms.PictureBox ptr2;
        private System.Windows.Forms.Timer timer1;
    }
}