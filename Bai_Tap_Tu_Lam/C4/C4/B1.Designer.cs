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
            lbName = new Label();
            pic1 = new PictureBox();
            pic2 = new PictureBox();
            pic3 = new PictureBox();
            lbResult = new Label();
            btPlay = new Button();
            btClose = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic3).BeginInit();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.Location = new Point(15, 25);
            lbName.Margin = new Padding(4, 0, 4, 0);
            lbName.Name = "lbName";
            lbName.Size = new Size(970, 78);
            lbName.TabIndex = 0;
            lbName.Text = "2351050128 - Lê Minh Nhựt";
            lbName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pic1
            // 
            pic1.Location = new Point(230, 141);
            pic1.Margin = new Padding(4);
            pic1.Name = "pic1";
            pic1.Size = new Size(156, 150);
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1.TabIndex = 1;
            pic1.TabStop = false;
            // 
            // pic2
            // 
            pic2.Location = new Point(422, 141);
            pic2.Margin = new Padding(4);
            pic2.Name = "pic2";
            pic2.Size = new Size(156, 150);
            pic2.SizeMode = PictureBoxSizeMode.StretchImage;
            pic2.TabIndex = 2;
            pic2.TabStop = false;
            // 
            // pic3
            // 
            pic3.Location = new Point(615, 141);
            pic3.Margin = new Padding(4);
            pic3.Name = "pic3";
            pic3.Size = new Size(156, 150);
            pic3.SizeMode = PictureBoxSizeMode.StretchImage;
            pic3.TabIndex = 3;
            pic3.TabStop = false;
            // 
            // lbResult
            // 
            lbResult.BackColor = SystemColors.Highlight;
            lbResult.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbResult.ForeColor = SystemColors.ButtonHighlight;
            lbResult.Location = new Point(364, 332);
            lbResult.Margin = new Padding(4, 0, 4, 0);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(253, 68);
            lbResult.TabIndex = 4;
            lbResult.Text = "label2";
            lbResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btPlay
            // 
            btPlay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btPlay.ForeColor = SystemColors.Highlight;
            btPlay.Location = new Point(301, 436);
            btPlay.Margin = new Padding(4);
            btPlay.Name = "btPlay";
            btPlay.Size = new Size(151, 58);
            btPlay.TabIndex = 5;
            btPlay.Text = "Quay số";
            btPlay.UseVisualStyleBackColor = true;
            btPlay.Click += btPlay_Click;
            // 
            // btClose
            // 
            btClose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btClose.ForeColor = SystemColors.Highlight;
            btClose.Location = new Point(526, 436);
            btClose.Margin = new Padding(4);
            btClose.Name = "btClose";
            btClose.Size = new Size(151, 58);
            btClose.TabIndex = 6;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // B1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(btClose);
            Controls.Add(btPlay);
            Controls.Add(lbResult);
            Controls.Add(pic3);
            Controls.Add(pic2);
            Controls.Add(pic1);
            Controls.Add(lbName);
            Margin = new Padding(4);
            Name = "B1";
            Text = "Form1";
            FormClosing += B1_FormClosing;
            Load += B1_Load;
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbName;
        private PictureBox pic1;
        private PictureBox pic2;
        private PictureBox pic3;
        private Label lbResult;
        private Button btPlay;
        private Button btClose;
        private System.Windows.Forms.Timer timer1;
    }
}
