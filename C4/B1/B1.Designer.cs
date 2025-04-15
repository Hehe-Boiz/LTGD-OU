namespace C4
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
            components = new System.ComponentModel.Container();
            picBall = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picBall).BeginInit();
            SuspendLayout();
            // 
            // picBall
            // 
            picBall.Image = global::B1.Properties.Resources.football_PNG28463;
            picBall.Location = new Point(260, 163);
            picBall.Name = "picBall";
            picBall.Size = new Size(77, 72);
            picBall.SizeMode = PictureBoxSizeMode.StretchImage;
            picBall.TabIndex = 0;
            picBall.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picBall);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picBall).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picBall;
        private System.Windows.Forms.Timer timer1;
    }
}
