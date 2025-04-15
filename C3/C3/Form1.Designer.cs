namespace C3
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
            panel1 = new Panel();
            txtMauso1 = new TextBox();
            txtTuso1 = new TextBox();
            panel2 = new Panel();
            txtMauso2 = new TextBox();
            txtTuso2 = new TextBox();
            panel3 = new Panel();
            txtMauso3 = new TextBox();
            txtTuso3 = new TextBox();
            lbToanTu = new Label();
            label2 = new Label();
            btCong = new Button();
            btTru = new Button();
            btNhan = new Button();
            btChia = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtMauso1);
            panel1.Controls.Add(txtTuso1);
            panel1.Location = new Point(47, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 221);
            panel1.TabIndex = 0;
            // 
            // txtMauso1
            // 
            txtMauso1.Location = new Point(29, 140);
            txtMauso1.Multiline = true;
            txtMauso1.Name = "txtMauso1";
            txtMauso1.Size = new Size(138, 43);
            txtMauso1.TabIndex = 1;
            // 
            // txtTuso1
            // 
            txtTuso1.Location = new Point(29, 27);
            txtTuso1.Multiline = true;
            txtTuso1.Name = "txtTuso1";
            txtTuso1.Size = new Size(138, 43);
            txtTuso1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtMauso2);
            panel2.Controls.Add(txtTuso2);
            panel2.Location = new Point(380, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(194, 221);
            panel2.TabIndex = 1;
            // 
            // txtMauso2
            // 
            txtMauso2.Location = new Point(29, 140);
            txtMauso2.Multiline = true;
            txtMauso2.Name = "txtMauso2";
            txtMauso2.Size = new Size(138, 43);
            txtMauso2.TabIndex = 1;
            // 
            // txtTuso2
            // 
            txtTuso2.Location = new Point(29, 27);
            txtTuso2.Multiline = true;
            txtTuso2.Name = "txtTuso2";
            txtTuso2.Size = new Size(138, 43);
            txtTuso2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtMauso3);
            panel3.Controls.Add(txtTuso3);
            panel3.Location = new Point(692, 58);
            panel3.Name = "panel3";
            panel3.Size = new Size(194, 221);
            panel3.TabIndex = 2;
            // 
            // txtMauso3
            // 
            txtMauso3.Location = new Point(29, 140);
            txtMauso3.Multiline = true;
            txtMauso3.Name = "txtMauso3";
            txtMauso3.Size = new Size(138, 43);
            txtMauso3.TabIndex = 1;
            // 
            // txtTuso3
            // 
            txtTuso3.Location = new Point(29, 27);
            txtTuso3.Multiline = true;
            txtTuso3.Name = "txtTuso3";
            txtTuso3.Size = new Size(138, 43);
            txtTuso3.TabIndex = 0;
            // 
            // lbToanTu
            // 
            lbToanTu.AutoSize = true;
            lbToanTu.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbToanTu.Location = new Point(291, 162);
            lbToanTu.Name = "lbToanTu";
            lbToanTu.Size = new Size(36, 38);
            lbToanTu.TabIndex = 3;
            lbToanTu.Text = "+";
            lbToanTu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(617, 162);
            label2.Name = "label2";
            label2.Size = new Size(36, 38);
            label2.TabIndex = 4;
            label2.Text = "=";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btCong
            // 
            btCong.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btCong.Location = new Point(282, 324);
            btCong.Name = "btCong";
            btCong.Size = new Size(60, 57);
            btCong.TabIndex = 5;
            btCong.Text = "+";
            btCong.UseVisualStyleBackColor = true;
            btCong.Click += btCong_Click;
            // 
            // btTru
            // 
            btTru.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btTru.Location = new Point(380, 324);
            btTru.Name = "btTru";
            btTru.Size = new Size(60, 57);
            btTru.TabIndex = 6;
            btTru.Text = "-";
            btTru.UseVisualStyleBackColor = true;
            // 
            // btNhan
            // 
            btNhan.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btNhan.Location = new Point(487, 324);
            btNhan.Name = "btNhan";
            btNhan.Size = new Size(60, 57);
            btNhan.TabIndex = 7;
            btNhan.Text = "*";
            btNhan.UseVisualStyleBackColor = true;
            // 
            // btChia
            // 
            btChia.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btChia.Location = new Point(593, 324);
            btChia.Name = "btChia";
            btChia.Size = new Size(60, 57);
            btChia.TabIndex = 8;
            btChia.Text = "/";
            btChia.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 450);
            Controls.Add(btChia);
            Controls.Add(btNhan);
            Controls.Add(btTru);
            Controls.Add(btCong);
            Controls.Add(label2);
            Controls.Add(lbToanTu);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtMauso1;
        private TextBox txtTuso1;
        private Panel panel2;
        private TextBox txtMauso2;
        private TextBox txtTuso2;
        private Panel panel3;
        private TextBox txtMauso3;
        private TextBox txtTuso3;
        private Label lbToanTu;
        private Label label2;
        private Button btCong;
        private Button btTru;
        private Button btNhan;
        private Button btChia;
    }
}
