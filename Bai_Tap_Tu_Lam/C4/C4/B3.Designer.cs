namespace C4
{
    partial class B3
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
            this.lstFont = new System.Windows.Forms.ListBox();
            this.rtxtContent = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.chbB = new System.Windows.Forms.CheckBox();
            this.chbI = new System.Windows.Forms.CheckBox();
            this.chbU = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.hScrRed = new System.Windows.Forms.HScrollBar();
            this.hScrBlue = new System.Windows.Forms.HScrollBar();
            this.hScrGreen = new System.Windows.Forms.HScrollBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pColor = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lstFont
            // 
            this.lstFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFont.FormattingEnabled = true;
            this.lstFont.ItemHeight = 18;
            this.lstFont.Location = new System.Drawing.Point(12, 30);
            this.lstFont.Name = "lstFont";
            this.lstFont.Size = new System.Drawing.Size(230, 346);
            this.lstFont.TabIndex = 0;
            this.lstFont.SelectedIndexChanged += new System.EventHandler(this.lstFont_SelectedIndexChanged);
            // 
            // rtxtContent
            // 
            this.rtxtContent.Location = new System.Drawing.Point(248, 30);
            this.rtxtContent.Name = "rtxtContent";
            this.rtxtContent.Size = new System.Drawing.Size(275, 346);
            this.rtxtContent.TabIndex = 1;
            this.rtxtContent.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Font list:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Content:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Font list:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Size:";
            // 
            // cbSize
            // 
            this.cbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Location = new System.Drawing.Point(56, 380);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(84, 26);
            this.cbSize.TabIndex = 3;
            this.cbSize.SelectedIndexChanged += new System.EventHandler(this.cbSize_SelectedIndexChanged);
            // 
            // chbB
            // 
            this.chbB.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbB.AutoSize = true;
            this.chbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbB.Location = new System.Drawing.Point(146, 380);
            this.chbB.Name = "chbB";
            this.chbB.Size = new System.Drawing.Size(29, 28);
            this.chbB.TabIndex = 4;
            this.chbB.Text = "B";
            this.chbB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbB.UseVisualStyleBackColor = true;
            this.chbB.CheckedChanged += new System.EventHandler(this.chbB_CheckedChanged);
            // 
            // chbI
            // 
            this.chbI.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbI.Location = new System.Drawing.Point(180, 380);
            this.chbI.Name = "chbI";
            this.chbI.Size = new System.Drawing.Size(28, 28);
            this.chbI.TabIndex = 4;
            this.chbI.Text = "I";
            this.chbI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbI.UseVisualStyleBackColor = true;
            this.chbI.CheckedChanged += new System.EventHandler(this.chbI_CheckedChanged);
            // 
            // chbU
            // 
            this.chbU.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbU.AutoSize = true;
            this.chbU.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbU.Location = new System.Drawing.Point(214, 380);
            this.chbU.Name = "chbU";
            this.chbU.Size = new System.Drawing.Size(29, 28);
            this.chbU.TabIndex = 4;
            this.chbU.Text = "U";
            this.chbU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbU.UseVisualStyleBackColor = true;
            this.chbU.CheckedChanged += new System.EventHandler(this.chbU_CheckedChanged);
            // 
            // hScrRed
            // 
            this.hScrRed.LargeChange = 1;
            this.hScrRed.Location = new System.Drawing.Point(268, 384);
            this.hScrRed.Maximum = 255;
            this.hScrRed.Name = "hScrRed";
            this.hScrRed.Size = new System.Drawing.Size(200, 17);
            this.hScrRed.TabIndex = 5;
            this.hScrRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrRed_Scroll);
            // 
            // hScrBlue
            // 
            this.hScrBlue.LargeChange = 1;
            this.hScrBlue.Location = new System.Drawing.Point(268, 401);
            this.hScrBlue.Maximum = 255;
            this.hScrBlue.Name = "hScrBlue";
            this.hScrBlue.Size = new System.Drawing.Size(200, 17);
            this.hScrBlue.TabIndex = 5;
            this.hScrBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrBlue_Scroll);
            // 
            // hScrGreen
            // 
            this.hScrGreen.LargeChange = 1;
            this.hScrGreen.Location = new System.Drawing.Point(268, 418);
            this.hScrGreen.Maximum = 255;
            this.hScrGreen.Name = "hScrGreen";
            this.hScrGreen.Size = new System.Drawing.Size(200, 17);
            this.hScrGreen.TabIndex = 5;
            this.hScrGreen.Value = 1;
            this.hScrGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrGreen_Scroll);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(249, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Blue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(249, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Green;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(249, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 6;
            // 
            // pColor
            // 
            this.pColor.Location = new System.Drawing.Point(471, 384);
            this.pColor.Name = "pColor";
            this.pColor.Size = new System.Drawing.Size(52, 51);
            this.pColor.TabIndex = 7;
            this.pColor.Paint += new System.Windows.Forms.PaintEventHandler(this.pColor_Paint);
            // 
            // B3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 445);
            this.Controls.Add(this.pColor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hScrGreen);
            this.Controls.Add(this.hScrBlue);
            this.Controls.Add(this.hScrRed);
            this.Controls.Add(this.chbU);
            this.Controls.Add(this.chbI);
            this.Controls.Add(this.chbB);
            this.Controls.Add(this.cbSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtContent);
            this.Controls.Add(this.lstFont);
            this.Name = "B3";
            this.Text = "B3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFont;
        private System.Windows.Forms.RichTextBox rtxtContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.CheckBox chbB;
        private System.Windows.Forms.CheckBox chbI;
        private System.Windows.Forms.CheckBox chbU;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.HScrollBar hScrRed;
        private System.Windows.Forms.HScrollBar hScrBlue;
        private System.Windows.Forms.HScrollBar hScrGreen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pColor;

    }
}