namespace C5
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
            pnChan = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picBall).BeginInit();
            SuspendLayout();
            // 
            // picBall
            // 
            picBall.Image = Properties.Resources.football_PNG28463;
            picBall.Location = new Point(414, 26);
            picBall.Margin = new Padding(4, 4, 4, 4);
            picBall.Name = "picBall";
            picBall.Size = new Size(118, 109);
            picBall.SizeMode = PictureBoxSizeMode.StretchImage;
            picBall.TabIndex = 0;
            picBall.TabStop = false;
            // 
            // pnChan
            // 
            pnChan.BackColor = SystemColors.ActiveCaption;
            pnChan.Location = new Point(331, 408);
            pnChan.Margin = new Padding(4, 4, 4, 4);
            pnChan.Name = "pnChan";
            pnChan.Size = new Size(312, 48);
            pnChan.TabIndex = 1;
            pnChan.MouseDown += pnChan_MouseDown;
            pnChan.MouseMove += pnChan_MouseMove;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // B1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(pnChan);
            Controls.Add(picBall);
            Margin = new Padding(4, 4, 4, 4);
            Name = "B1";
            Text = "B1";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)picBall).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picBall;
        private Panel pnChan;
        private System.Windows.Forms.Timer timer1;

    }
}
