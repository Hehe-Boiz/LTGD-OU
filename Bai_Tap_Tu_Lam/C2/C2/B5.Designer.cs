namespace C2
{
    partial class B5
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
            this.label1 = new System.Windows.Forms.Label();
            this.btSinhMang = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lbChan = new System.Windows.Forms.Label();
            this.lstMang = new System.Windows.Forms.ListBox();
            this.lbLe = new System.Windows.Forms.Label();
            this.lbTB = new System.Windows.Forms.Label();
            this.lbNguyenTo = new System.Windows.Forms.Label();
            this.btThongKe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số lượng phần tử:";
            // 
            // btSinhMang
            // 
            this.btSinhMang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSinhMang.Location = new System.Drawing.Point(40, 81);
            this.btSinhMang.Name = "btSinhMang";
            this.btSinhMang.Size = new System.Drawing.Size(181, 45);
            this.btSinhMang.TabIndex = 1;
            this.btSinhMang.Text = "Sinh mảng";
            this.btSinhMang.UseVisualStyleBackColor = true;
            this.btSinhMang.Click += new System.EventHandler(this.btSinhMang_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(291, 19);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(364, 34);
            this.txtSoLuong.TabIndex = 2;
            // 
            // lbChan
            // 
            this.lbChan.AutoSize = true;
            this.lbChan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChan.Location = new System.Drawing.Point(37, 275);
            this.lbChan.Name = "lbChan";
            this.lbChan.Size = new System.Drawing.Size(133, 29);
            this.lbChan.TabIndex = 4;
            this.lbChan.Text = "Tổng chẵn:";
            // 
            // lstMang
            // 
            this.lstMang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMang.FormattingEnabled = true;
            this.lstMang.ItemHeight = 20;
            this.lstMang.Location = new System.Drawing.Point(291, 85);
            this.lstMang.Name = "lstMang";
            this.lstMang.Size = new System.Drawing.Size(364, 164);
            this.lstMang.TabIndex = 5;
            // 
            // lbLe
            // 
            this.lbLe.AutoSize = true;
            this.lbLe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLe.Location = new System.Drawing.Point(37, 320);
            this.lbLe.Name = "lbLe";
            this.lbLe.Size = new System.Drawing.Size(109, 29);
            this.lbLe.TabIndex = 4;
            this.lbLe.Text = "Tổng Lẻ:";
            // 
            // lbTB
            // 
            this.lbTB.AutoSize = true;
            this.lbTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTB.Location = new System.Drawing.Point(37, 359);
            this.lbTB.Name = "lbTB";
            this.lbTB.Size = new System.Drawing.Size(194, 29);
            this.lbTB.TabIndex = 4;
            this.lbTB.Text = "Trung bình cộng:";
            // 
            // lbNguyenTo
            // 
            this.lbNguyenTo.AutoSize = true;
            this.lbNguyenTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNguyenTo.Location = new System.Drawing.Point(35, 397);
            this.lbNguyenTo.Name = "lbNguyenTo";
            this.lbNguyenTo.Size = new System.Drawing.Size(159, 29);
            this.lbNguyenTo.TabIndex = 4;
            this.lbNguyenTo.Text = "Số nguyên tố:";
            // 
            // btThongKe
            // 
            this.btThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThongKe.Location = new System.Drawing.Point(449, 372);
            this.btThongKe.Name = "btThongKe";
            this.btThongKe.Size = new System.Drawing.Size(183, 38);
            this.btThongKe.TabIndex = 6;
            this.btThongKe.Text = "Thống kê";
            this.btThongKe.UseVisualStyleBackColor = true;
            this.btThongKe.Click += new System.EventHandler(this.btThongKe_Click);
            // 
            // Form2
            // 

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.btThongKe);
            this.Controls.Add(this.lstMang);
            this.Controls.Add(this.lbNguyenTo);
            this.Controls.Add(this.lbTB);
            this.Controls.Add(this.lbLe);
            this.Controls.Add(this.lbChan);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.btSinhMang);
            this.Controls.Add(this.label1);
            this.Text = "B5";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSinhMang;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lbChan;
        private System.Windows.Forms.ListBox lstMang;
        private System.Windows.Forms.Label lbLe;
        private System.Windows.Forms.Label lbTB;
        private System.Windows.Forms.Label lbNguyenTo;
        private System.Windows.Forms.Button btThongKe;

    }
}