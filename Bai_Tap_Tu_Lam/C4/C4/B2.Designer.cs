namespace C4
{
    partial class B2
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

            this.lstLeft = new System.Windows.Forms.ListBox();
            this.lstRight = new System.Windows.Forms.ListBox();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btInsert = new System.Windows.Forms.Button();
            this.btMoveRight = new System.Windows.Forms.Button();
            this.btMoveLeft = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btClearAll = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstLeft
            // 
            this.lstLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLeft.FormattingEnabled = true;
            this.lstLeft.ItemHeight = 18;
            this.lstLeft.Location = new System.Drawing.Point(14, 95);
            this.lstLeft.Name = "lstLeft";
            this.lstLeft.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstLeft.Size = new System.Drawing.Size(204, 328);
            this.lstLeft.TabIndex = 0;
            // 
            // lstRight
            // 
            this.lstRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRight.FormattingEnabled = true;
            this.lstRight.ItemHeight = 18;
            this.lstRight.Location = new System.Drawing.Point(305, 95);
            this.lstRight.Name = "lstRight";
            this.lstRight.Size = new System.Drawing.Size(204, 328);
            this.lstRight.TabIndex = 0;
            // 
            // txtNhap
            // 
            this.txtNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhap.Location = new System.Drawing.Point(14, 31);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(204, 24);
            this.txtNhap.TabIndex = 1;
            // 
            // btInsert
            // 
            this.btInsert.AutoSize = true;
            this.btInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsert.Location = new System.Drawing.Point(14, 61);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(75, 28);
            this.btInsert.TabIndex = 2;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // btMoveRight
            // 
            this.btMoveRight.AutoSize = true;
            this.btMoveRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMoveRight.Location = new System.Drawing.Point(224, 129);
            this.btMoveRight.Name = "btMoveRight";
            this.btMoveRight.Size = new System.Drawing.Size(75, 28);
            this.btMoveRight.TabIndex = 2;
            this.btMoveRight.Text = "->";
            this.btMoveRight.UseVisualStyleBackColor = true;
            this.btMoveRight.Click += new System.EventHandler(this.btMoveRight_Click);
            // 
            // btMoveLeft
            // 
            this.btMoveLeft.AutoSize = true;
            this.btMoveLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMoveLeft.Location = new System.Drawing.Point(224, 171);
            this.btMoveLeft.Name = "btMoveLeft";
            this.btMoveLeft.Size = new System.Drawing.Size(75, 28);
            this.btMoveLeft.TabIndex = 2;
            this.btMoveLeft.Text = "<-";
            this.btMoveLeft.UseVisualStyleBackColor = true;
            this.btMoveLeft.Click += new System.EventHandler(this.btMoveLeft_Click);
            // 
            // btRemove
            // 
            this.btRemove.AutoSize = true;
            this.btRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemove.Location = new System.Drawing.Point(224, 213);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(75, 28);
            this.btRemove.TabIndex = 2;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btClearAll
            // 
            this.btClearAll.AutoSize = true;
            this.btClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClearAll.Location = new System.Drawing.Point(224, 255);
            this.btClearAll.Name = "btClearAll";
            this.btClearAll.Size = new System.Drawing.Size(75, 28);
            this.btClearAll.TabIndex = 2;
            this.btClearAll.Text = "Clear All";
            this.btClearAll.UseVisualStyleBackColor = true;
            this.btClearAll.Click += new System.EventHandler(this.btClearAll_Click);
            // 
            // btExit
            // 
            this.btExit.AutoSize = true;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(224, 297);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 28);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // cbColor
            // 
            this.cbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "AliceBlue",
            "AntiqueWhite",
            "Aqua",
            "Aquamarine",
            "Azure",
            "Beige",
            "Bisque",
            "Black",
            "BlanchedAlmond",
            "Blue",
            "BlueViolet",
            "Brown",
            "BurlyWood",
            "CadetBlue",
            "Chartreuse",
            "Chocolate",
            "Coral",
            "CornflowerBlue",
            "Cornsilk",
            "Crimson",
            "Cyan",
            "DarkBlue",
            "DarkCyan",
            "DarkGoldenrod",
            "DarkGray",
            "DarkGreen",
            "DarkKhaki",
            "DarkMagenta",
            "DarkOliveGreen",
            "DarkOrange",
            "DarkOrchid",
            "DarkRed",
            "DarkSalmon",
            "DarkSeaGreen",
            "DarkSlateBlue",
            "DarkSlateGray",
            "DarkTurquoise",
            "DarkViolet",
            "DeepPink",
            "DeepSkyBlue",
            "DimGray",
            "DodgerBlue",
            "Firebrick",
            "FloralWhite",
            "ForestGreen",
            "Fuchsia",
            "Gainsboro",
            "GhostWhite",
            "Gold",
            "Goldenrod",
            "Gray",
            "Green",
            "GreenYellow",
            "Honeydew",
            "HotPink",
            "IndianRed",
            "Indigo",
            "Ivory",
            "Khaki",
            "Lavender",
            "LavenderBlush",
            "LawnGreen",
            "LemonChiffon",
            "LightBlue",
            "LightCoral",
            "LightCyan",
            "LightGoldenrodYellow",
            "LightGray",
            "LightGreen",
            "LightPink",
            "LightSalmon",
            "LightSeaGreen",
            "LightSkyBlue",
            "LightSlateGray",
            "LightSteelBlue",
            "LightYellow",
            "Lime",
            "LimeGreen",
            "Linen",
            "Magenta",
            "Maroon",
            "MediumAquamarine",
            "MediumBlue",
            "MediumOrchid",
            "MediumPurple",
            "MediumSeaGreen",
            "MediumSlateBlue",
            "MediumSpringGreen",
            "MediumTurquoise",
            "MediumVioletRed",
            "MidnightBlue",
            "MintCream",
            "MistyRose",
            "Moccasin",
            "NavajoWhite",
            "Navy",
            "OldLace",
            "Olive",
            "OliveDrab",
            "Orange",
            "OrangeRed",
            "Orchid",
            "PaleGoldenrod",
            "PaleGreen",
            "PaleTurquoise",
            "PaleVioletRed",
            "PapayaWhip",
            "PeachPuff",
            "Peru",
            "Pink",
            "Plum",
            "PowderBlue",
            "Purple",
            "Red",
            "RosyBrown",
            "RoyalBlue",
            "SaddleBrown",
            "Salmon",
            "SandyBrown",
            "SeaGreen",
            "Seashell",
            "Sienna",
            "Silver",
            "SkyBlue",
            "SlateBlue",
            "SlateGray",
            "Snow",
            "SpringGreen"});
            this.cbColor.Location = new System.Drawing.Point(305, 31);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(204, 26);
            this.cbColor.TabIndex = 3;
            this.cbColor.SelectedIndexChanged += new System.EventHandler(this.cbColor_SelectedIndexChanged);
            // 
            // B2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 455);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.btClearAll);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btMoveLeft);
            this.Controls.Add(this.btMoveRight);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.lstRight);
            this.Controls.Add(this.lstLeft);
            this.Name = "B2";
            this.Text = "B2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLeft;
        private System.Windows.Forms.ListBox lstRight;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Button btMoveRight;
        private System.Windows.Forms.Button btMoveLeft;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btClearAll;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.ComboBox cbColor;
    }
}