namespace B3
{
    partial class B3
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
            lbSo1 = new Label();
            lbSo2 = new Label();
            lbSo3 = new Label();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            rd3 = new RadioButton();
            btnQuayso = new Button();
            label4 = new Label();
            lbDiem = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbSo1
            // 
            lbSo1.BorderStyle = BorderStyle.Fixed3D;
            lbSo1.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSo1.Location = new Point(117, 43);
            lbSo1.Name = "lbSo1";
            lbSo1.Size = new Size(161, 199);
            lbSo1.TabIndex = 0;
            lbSo1.Text = "0";
            lbSo1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbSo2
            // 
            lbSo2.BorderStyle = BorderStyle.Fixed3D;
            lbSo2.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSo2.Location = new Point(338, 43);
            lbSo2.Name = "lbSo2";
            lbSo2.Size = new Size(161, 199);
            lbSo2.TabIndex = 1;
            lbSo2.Text = "0";
            lbSo2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbSo3
            // 
            lbSo3.BorderStyle = BorderStyle.Fixed3D;
            lbSo3.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSo3.Location = new Point(567, 43);
            lbSo3.Name = "lbSo3";
            lbSo3.Size = new Size(161, 199);
            lbSo3.TabIndex = 2;
            lbSo3.Text = "0";
            lbSo3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(rd3);
            groupBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(117, 289);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(611, 134);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn:";
            // 
            // radioButton1
            // 
            radioButton1.Appearance = Appearance.Button;
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(395, 58);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(98, 48);
            radioButton1.TabIndex = 1;
            radioButton1.Text = "11-18";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // rd3
            // 
            rd3.Appearance = Appearance.Button;
            rd3.AutoSize = true;
            rd3.Checked = true;
            rd3.Location = new Point(157, 58);
            rd3.Name = "rd3";
            rd3.Size = new Size(83, 48);
            rd3.TabIndex = 0;
            rd3.TabStop = true;
            rd3.Text = "3-10";
            rd3.UseVisualStyleBackColor = true;
            // 
            // btnQuayso
            // 
            btnQuayso.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuayso.Location = new Point(117, 462);
            btnQuayso.Name = "btnQuayso";
            btnQuayso.Size = new Size(133, 49);
            btnQuayso.TabIndex = 4;
            btnQuayso.Text = "Quay số ";
            btnQuayso.UseVisualStyleBackColor = true;
            btnQuayso.Click += btnQuayso_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(512, 473);
            label4.Name = "label4";
            label4.Size = new Size(89, 38);
            label4.TabIndex = 5;
            label4.Text = "Điểm:";
            // 
            // lbDiem
            // 
            lbDiem.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDiem.Location = new Point(635, 450);
            lbDiem.Name = "lbDiem";
            lbDiem.Size = new Size(54, 71);
            lbDiem.TabIndex = 6;
            lbDiem.Text = "0";
            lbDiem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // B3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 564);
            Controls.Add(lbDiem);
            Controls.Add(label4);
            Controls.Add(btnQuayso);
            Controls.Add(groupBox1);
            Controls.Add(lbSo3);
            Controls.Add(lbSo2);
            Controls.Add(lbSo1);
            Name = "B3";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbSo1;
        private Label lbSo2;
        private Label lbSo3;
        private GroupBox groupBox1;
        private Button btnQuayso;
        private Label label4;
        private Label lbDiem;
        private RadioButton radioButton1;
        private RadioButton rd3;
    }
}
