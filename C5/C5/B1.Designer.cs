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
            pnPic = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnPic
            // 
            pnPic.AutoScroll = true;
            pnPic.BackColor = SystemColors.ButtonShadow;
            pnPic.Location = new Point(537, 12);
            pnPic.Name = "pnPic";
            pnPic.Size = new Size(251, 426);
            pnPic.TabIndex = 0;
            pnPic.MouseDown += pnPic_MouseDown;
            pnPic.MouseMove += pnPic_MouseMove;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(62, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // B1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(pnPic);
            Name = "B1";
            Text = "Form1";
            Load += B1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel pnPic;
        private PictureBox pictureBox1;
    }
}
