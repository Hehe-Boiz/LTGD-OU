namespace TL2
{
    partial class Formopition
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
            groupBox1 = new GroupBox();
            rdTamGiac = new RadioButton();
            rdEll = new RadioButton();
            rdHCN = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdTamGiac);
            groupBox1.Controls.Add(rdEll);
            groupBox1.Controls.Add(rdHCN);
            groupBox1.Location = new Point(88, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 138);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Shapes";
            // 
            // rdTamGiac
            // 
            rdTamGiac.AutoSize = true;
            rdTamGiac.Location = new Point(16, 95);
            rdTamGiac.Name = "rdTamGiac";
            rdTamGiac.Size = new Size(83, 24);
            rdTamGiac.TabIndex = 2;
            rdTamGiac.TabStop = true;
            rdTamGiac.Text = "Triangle";
            rdTamGiac.UseVisualStyleBackColor = true;
            // 
            // rdEll
            // 
            rdEll.AutoSize = true;
            rdEll.Location = new Point(16, 65);
            rdEll.Name = "rdEll";
            rdEll.Size = new Size(73, 24);
            rdEll.TabIndex = 1;
            rdEll.TabStop = true;
            rdEll.Text = "Ellipse";
            rdEll.UseVisualStyleBackColor = true;
            // 
            // rdHCN
            // 
            rdHCN.AutoSize = true;
            rdHCN.Location = new Point(16, 35);
            rdHCN.Name = "rdHCN";
            rdHCN.Size = new Size(96, 24);
            rdHCN.TabIndex = 0;
            rdHCN.TabStop = true;
            rdHCN.Text = "Rectangle";
            rdHCN.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(88, 167);
            button1.Name = "button1";
            button1.Size = new Size(250, 29);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(88, 213);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Ok";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(244, 213);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnCancel_Click;
            // 
            // Formopition
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 254);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Formopition";
            Text = "Formopition";
            Load += Formopition_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private RadioButton rdTamGiac;
        private RadioButton rdEll;
        private RadioButton rdHCN;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}