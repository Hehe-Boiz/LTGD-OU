namespace C6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B1));
            cbDrive = new ComboBox();
            lstFolderAndFile = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            imageList1 = new ImageList(components);
            grChangeList = new GroupBox();
            rdTile = new RadioButton();
            rdDetails = new RadioButton();
            rdList = new RadioButton();
            rdSmallIcon = new RadioButton();
            rdLargeIcon = new RadioButton();
            grChangeList.SuspendLayout();
            SuspendLayout();
            // 
            // cbDrive
            // 
            cbDrive.BackColor = SystemColors.Window;
            cbDrive.FormattingEnabled = true;
            cbDrive.Location = new Point(16, 18);
            cbDrive.Margin = new Padding(4, 5, 4, 5);
            cbDrive.Name = "cbDrive";
            cbDrive.Size = new Size(181, 28);
            cbDrive.TabIndex = 0;
            cbDrive.SelectedIndexChanged += cbDrive_SelectedIndexChanged;
            // 
            // lstFolderAndFile
            // 
            lstFolderAndFile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstFolderAndFile.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lstFolderAndFile.FullRowSelect = true;
            lstFolderAndFile.LargeImageList = imageList1;
            lstFolderAndFile.Location = new Point(16, 68);
            lstFolderAndFile.Margin = new Padding(4, 5, 4, 5);
            lstFolderAndFile.Name = "lstFolderAndFile";
            lstFolderAndFile.Size = new Size(560, 467);
            lstFolderAndFile.SmallImageList = imageList1;
            lstFolderAndFile.StateImageList = imageList1;
            lstFolderAndFile.TabIndex = 1;
            lstFolderAndFile.UseCompatibleStateImageBehavior = false;
            lstFolderAndFile.View = View.Details;
            lstFolderAndFile.DoubleClick += lstFolderAndFile_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "File Name";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Size";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Last accessed";
            columnHeader3.Width = 150;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "1.png");
            imageList1.Images.SetKeyName(1, "2.png");
            imageList1.Images.SetKeyName(2, "3.png");
            // 
            // grChangeList
            // 
            grChangeList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            grChangeList.Controls.Add(rdTile);
            grChangeList.Controls.Add(rdDetails);
            grChangeList.Controls.Add(rdList);
            grChangeList.Controls.Add(rdSmallIcon);
            grChangeList.Controls.Add(rdLargeIcon);
            grChangeList.Location = new Point(585, 68);
            grChangeList.Margin = new Padding(4, 5, 4, 5);
            grChangeList.Name = "grChangeList";
            grChangeList.Padding = new Padding(4, 5, 4, 5);
            grChangeList.Size = new Size(177, 469);
            grChangeList.TabIndex = 2;
            grChangeList.TabStop = false;
            grChangeList.Text = "View Mode";
            // 
            // rdTile
            // 
            rdTile.AutoSize = true;
            rdTile.Location = new Point(32, 355);
            rdTile.Margin = new Padding(4, 5, 4, 5);
            rdTile.Name = "rdTile";
            rdTile.Size = new Size(54, 24);
            rdTile.TabIndex = 3;
            rdTile.Text = "Tile";
            rdTile.UseVisualStyleBackColor = true;
            rdTile.CheckedChanged += radioButton_CheckedChanged;
            // 
            // rdDetails
            // 
            rdDetails.AutoSize = true;
            rdDetails.Checked = true;
            rdDetails.Location = new Point(32, 295);
            rdDetails.Margin = new Padding(4, 5, 4, 5);
            rdDetails.Name = "rdDetails";
            rdDetails.Size = new Size(76, 24);
            rdDetails.TabIndex = 3;
            rdDetails.TabStop = true;
            rdDetails.Text = "Details";
            rdDetails.UseVisualStyleBackColor = true;
            rdDetails.CheckedChanged += radioButton_CheckedChanged;
            // 
            // rdList
            // 
            rdList.AutoSize = true;
            rdList.Location = new Point(32, 235);
            rdList.Margin = new Padding(4, 5, 4, 5);
            rdList.Name = "rdList";
            rdList.Size = new Size(52, 24);
            rdList.TabIndex = 3;
            rdList.Text = "List";
            rdList.UseVisualStyleBackColor = true;
            rdList.CheckedChanged += radioButton_CheckedChanged;
            // 
            // rdSmallIcon
            // 
            rdSmallIcon.AutoSize = true;
            rdSmallIcon.Location = new Point(32, 175);
            rdSmallIcon.Margin = new Padding(4, 5, 4, 5);
            rdSmallIcon.Name = "rdSmallIcon";
            rdSmallIcon.Size = new Size(95, 24);
            rdSmallIcon.TabIndex = 3;
            rdSmallIcon.Text = "SmallIcon";
            rdSmallIcon.UseVisualStyleBackColor = true;
            rdSmallIcon.CheckedChanged += radioButton_CheckedChanged;
            // 
            // rdLargeIcon
            // 
            rdLargeIcon.AutoSize = true;
            rdLargeIcon.Location = new Point(32, 115);
            rdLargeIcon.Margin = new Padding(4, 5, 4, 5);
            rdLargeIcon.Name = "rdLargeIcon";
            rdLargeIcon.Size = new Size(95, 24);
            rdLargeIcon.TabIndex = 3;
            rdLargeIcon.Text = "LargeIcon";
            rdLargeIcon.UseVisualStyleBackColor = true;
            rdLargeIcon.CheckedChanged += radioButton_CheckedChanged;
            // 
            // B1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 555);
            Controls.Add(grChangeList);
            Controls.Add(lstFolderAndFile);
            Controls.Add(cbDrive);
            Margin = new Padding(4, 5, 4, 5);
            Name = "B1";
            Text = "B1";
            Load += Form1_Load;
            grChangeList.ResumeLayout(false);
            grChangeList.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDrive;
        private System.Windows.Forms.GroupBox grChangeList;
        private System.Windows.Forms.RadioButton rdTile;
        private System.Windows.Forms.RadioButton rdDetails;
        private System.Windows.Forms.RadioButton rdList;
        private System.Windows.Forms.RadioButton rdSmallIcon;
        private System.Windows.Forms.RadioButton rdLargeIcon;
        private System.Windows.Forms.ListView lstFolderAndFile;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ImageList imageList1;
    }
}
