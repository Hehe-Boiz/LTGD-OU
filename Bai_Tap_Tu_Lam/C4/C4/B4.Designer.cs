namespace C4
{
    partial class B4
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
            this.components = new System.ComponentModel.Container();
            this.btFile = new System.Windows.Forms.Button();
            this.btFiles = new System.Windows.Forms.Button();
            this.btFolder = new System.Windows.Forms.Button();
            this.btBackColor = new System.Windows.Forms.Button();
            this.btTextColor = new System.Windows.Forms.Button();
            this.btFont = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.rtxtHienThi = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btFile
            // 
            this.btFile.AutoSize = true;
            this.btFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFile.Location = new System.Drawing.Point(16, 23);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(182, 28);
            this.btFile.TabIndex = 0;
            this.btFile.Text = "Chọn một tập tin";
            this.btFile.UseVisualStyleBackColor = true;
            this.btFile.Click += new System.EventHandler(this.btFile_Click);
            // 
            // btFiles
            // 
            this.btFiles.AutoSize = true;
            this.btFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFiles.Location = new System.Drawing.Point(16, 65);
            this.btFiles.Name = "btFiles";
            this.btFiles.Size = new System.Drawing.Size(182, 28);
            this.btFiles.TabIndex = 0;
            this.btFiles.Text = "Chọn nhiều tập tin";
            this.btFiles.UseVisualStyleBackColor = true;
            this.btFiles.Click += new System.EventHandler(this.btFiles_Click);
            // 
            // btFolder
            // 
            this.btFolder.AutoSize = true;
            this.btFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFolder.Location = new System.Drawing.Point(16, 107);
            this.btFolder.Name = "btFolder";
            this.btFolder.Size = new System.Drawing.Size(182, 28);
            this.btFolder.TabIndex = 0;
            this.btFolder.Text = "Chọn thư mục";
            this.btFolder.UseVisualStyleBackColor = true;
            this.btFolder.Click += new System.EventHandler(this.btFolder_Click);
            // 
            // btBackColor
            // 
            this.btBackColor.AutoSize = true;
            this.btBackColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBackColor.Location = new System.Drawing.Point(16, 149);
            this.btBackColor.Name = "btBackColor";
            this.btBackColor.Size = new System.Drawing.Size(182, 28);
            this.btBackColor.TabIndex = 0;
            this.btBackColor.Text = "Chọn màu nền";
            this.btBackColor.UseVisualStyleBackColor = true;
            this.btBackColor.Click += new System.EventHandler(this.btBackColor_Click);
            // 
            // btTextColor
            // 
            this.btTextColor.AutoSize = true;
            this.btTextColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTextColor.Location = new System.Drawing.Point(16, 191);
            this.btTextColor.Name = "btTextColor";
            this.btTextColor.Size = new System.Drawing.Size(182, 28);
            this.btTextColor.TabIndex = 0;
            this.btTextColor.Text = "Chọn màu chữ";
            this.btTextColor.UseVisualStyleBackColor = true;
            this.btTextColor.Click += new System.EventHandler(this.btTextColor_Click);
            // 
            // btFont
            // 
            this.btFont.AutoSize = true;
            this.btFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFont.Location = new System.Drawing.Point(16, 233);
            this.btFont.Name = "btFont";
            this.btFont.Size = new System.Drawing.Size(182, 28);
            this.btFont.TabIndex = 0;
            this.btFont.Text = "Chọn font";
            this.btFont.UseVisualStyleBackColor = true;
            this.btFont.Click += new System.EventHandler(this.btFont_Click);
            // 
            // btReset
            // 
            this.btReset.AutoSize = true;
            this.btReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.Location = new System.Drawing.Point(204, 233);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(182, 28);
            this.btReset.TabIndex = 0;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btExit
            // 
            this.btExit.AutoSize = true;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(392, 233);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(182, 28);
            this.btExit.TabIndex = 0;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // rtxtHienThi
            // 
            this.rtxtHienThi.Location = new System.Drawing.Point(204, 23);
            this.rtxtHienThi.Name = "rtxtHienThi";
            this.rtxtHienThi.Size = new System.Drawing.Size(370, 196);
            this.rtxtHienThi.TabIndex = 1;
            this.rtxtHienThi.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // B4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 284);
            this.Controls.Add(this.rtxtHienThi);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btFont);
            this.Controls.Add(this.btTextColor);
            this.Controls.Add(this.btBackColor);
            this.Controls.Add(this.btFolder);
            this.Controls.Add(this.btFiles);
            this.Controls.Add(this.btFile);
            this.Name = "B3";
            this.Text = "B3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFile;
        private System.Windows.Forms.Button btFiles;
        private System.Windows.Forms.Button btFolder;
        private System.Windows.Forms.Button btBackColor;
        private System.Windows.Forms.Button btTextColor;
        private System.Windows.Forms.Button btFont;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.RichTextBox rtxtHienThi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}