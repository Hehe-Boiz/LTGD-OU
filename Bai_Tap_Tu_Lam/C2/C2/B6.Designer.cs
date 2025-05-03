namespace C2
{
    partial class B6
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btNhap = new Button();
            label4 = new Label();
            btTimKiem = new Button();
            lstDSSV = new ListBox();
            btSapXep = new Button();
            txtMSSV = new TextBox();
            txtHo = new TextBox();
            txtTen = new TextBox();
            txtTimKiem = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 56);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 32);
            label1.TabIndex = 0;
            label1.Text = "MSSV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 136);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 32);
            label2.TabIndex = 1;
            label2.Text = "Họ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 233);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 32);
            label3.TabIndex = 1;
            label3.Text = "Tên";
            // 
            // btNhap
            // 
            btNhap.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btNhap.Location = new Point(105, 290);
            btNhap.Margin = new Padding(4, 5, 4, 5);
            btNhap.Name = "btNhap";
            btNhap.Size = new Size(414, 77);
            btNhap.TabIndex = 2;
            btNhap.Text = "Nhập sinh viên";
            btNhap.UseVisualStyleBackColor = true;
            btNhap.Click += btNhap_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 408);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(136, 32);
            label4.TabIndex = 1;
            label4.Text = "Tìm kiếm:";
            // 
            // btTimKiem
            // 
            btTimKiem.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btTimKiem.Location = new Point(105, 480);
            btTimKiem.Margin = new Padding(4, 5, 4, 5);
            btTimKiem.Name = "btTimKiem";
            btTimKiem.Size = new Size(414, 77);
            btTimKiem.TabIndex = 2;
            btTimKiem.Text = "Tìm kiếm";
            btTimKiem.UseVisualStyleBackColor = true;
            btTimKiem.Click += btTimKiem_Click;
            // 
            // lstDSSV
            // 
            lstDSSV.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstDSSV.FormattingEnabled = true;
            lstDSSV.ItemHeight = 32;
            lstDSSV.Location = new Point(36, 624);
            lstDSSV.Margin = new Padding(4, 5, 4, 5);
            lstDSSV.Name = "lstDSSV";
            lstDSSV.Size = new Size(536, 164);
            lstDSSV.TabIndex = 3;
            lstDSSV.SelectedIndexChanged += lstDSSV_SelectedIndexChanged;
            // 
            // btSapXep
            // 
            btSapXep.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btSapXep.Location = new Point(105, 825);
            btSapXep.Margin = new Padding(4, 5, 4, 5);
            btSapXep.Name = "btSapXep";
            btSapXep.Size = new Size(414, 77);
            btSapXep.TabIndex = 2;
            btSapXep.Text = "Sắp xếp";
            btSapXep.UseVisualStyleBackColor = true;
            btSapXep.Click += btSapXep_Click;
            // 
            // txtMSSV
            // 
            txtMSSV.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMSSV.Location = new Point(212, 52);
            txtMSSV.Margin = new Padding(4, 5, 4, 5);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(360, 39);
            txtMSSV.TabIndex = 4;
            // 
            // txtHo
            // 
            txtHo.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHo.Location = new Point(212, 131);
            txtHo.Margin = new Padding(4, 5, 4, 5);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(360, 39);
            txtHo.TabIndex = 4;
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTen.Location = new Point(212, 228);
            txtTen.Margin = new Padding(4, 5, 4, 5);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(360, 39);
            txtTen.TabIndex = 4;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(212, 403);
            txtTimKiem.Margin = new Padding(4, 5, 4, 5);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(360, 39);
            txtTimKiem.TabIndex = 4;
            // 
            // B6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 920);
            Controls.Add(txtTimKiem);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(txtMSSV);
            Controls.Add(lstDSSV);
            Controls.Add(btSapXep);
            Controls.Add(btTimKiem);
            Controls.Add(btNhap);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "B6";
            Text = "B6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.ListBox lstDSSV;
        private System.Windows.Forms.Button btSapXep;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtTimKiem;

    }
}