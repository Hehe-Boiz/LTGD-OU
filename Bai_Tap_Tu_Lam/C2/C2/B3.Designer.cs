namespace C2
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
            lbSo1 = new Label();
            lbSo2 = new Label();
            lbSo3 = new Label();
            lbDiem = new Label();
            btPlay = new Button();
            btExit = new Button();
            SuspendLayout();
            // 
            // lbSo1
            // 
            lbSo1.BorderStyle = BorderStyle.Fixed3D;
            lbSo1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lbSo1.ForeColor = SystemColors.Highlight;
            lbSo1.Location = new Point(181, 61);
            lbSo1.Margin = new Padding(4, 0, 4, 0);
            lbSo1.Name = "lbSo1";
            lbSo1.Size = new Size(150, 175);
            lbSo1.TabIndex = 0;
            lbSo1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbSo2
            // 
            lbSo2.BorderStyle = BorderStyle.Fixed3D;
            lbSo2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lbSo2.ForeColor = SystemColors.Highlight;
            lbSo2.Location = new Point(459, 61);
            lbSo2.Margin = new Padding(4, 0, 4, 0);
            lbSo2.Name = "lbSo2";
            lbSo2.Size = new Size(150, 175);
            lbSo2.TabIndex = 1;
            lbSo2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbSo3
            // 
            lbSo3.BorderStyle = BorderStyle.Fixed3D;
            lbSo3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lbSo3.ForeColor = SystemColors.Highlight;
            lbSo3.Location = new Point(690, 61);
            lbSo3.Margin = new Padding(4, 0, 4, 0);
            lbSo3.Name = "lbSo3";
            lbSo3.Size = new Size(150, 175);
            lbSo3.TabIndex = 2;
            lbSo3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbDiem
            // 
            lbDiem.BackColor = SystemColors.ActiveCaption;
            lbDiem.BorderStyle = BorderStyle.Fixed3D;
            lbDiem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDiem.ForeColor = Color.Red;
            lbDiem.Location = new Point(181, 291);
            lbDiem.Margin = new Padding(4, 0, 4, 0);
            lbDiem.Name = "lbDiem";
            lbDiem.Size = new Size(659, 61);
            lbDiem.TabIndex = 3;
            lbDiem.Text = "label4";
            lbDiem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btPlay
            // 
            btPlay.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btPlay.ForeColor = SystemColors.Highlight;
            btPlay.Location = new Point(281, 388);
            btPlay.Margin = new Padding(4);
            btPlay.Name = "btPlay";
            btPlay.Size = new Size(154, 61);
            btPlay.TabIndex = 4;
            btPlay.Text = "Play";
            btPlay.UseVisualStyleBackColor = true;
            btPlay.Click += btPlay_Click;
            // 
            // btExit
            // 
            btExit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExit.ForeColor = SystemColors.Highlight;
            btExit.Location = new Point(565, 388);
            btExit.Margin = new Padding(4);
            btExit.Name = "btExit";
            btExit.Size = new Size(154, 61);
            btExit.TabIndex = 5;
            btExit.Text = "Exit";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // B3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(btExit);
            Controls.Add(btPlay);
            Controls.Add(lbDiem);
            Controls.Add(lbSo3);
            Controls.Add(lbSo2);
            Controls.Add(lbSo1);
            Margin = new Padding(4);
            Name = "B3";
            Text = "Random Number";
            Load += B3_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lbSo1;
        private Label lbSo2;
        private Label lbSo3;
        private Label lbDiem;
        private Button btPlay;
        private Button btExit;
    }
}