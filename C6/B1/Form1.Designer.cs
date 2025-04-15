namespace C6
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            treeFolder = new TreeView();
            imageList1 = new ImageList(components);
            pnThum = new FlowLayoutPanel();
            picView = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picView).BeginInit();
            SuspendLayout();
            // 
            // treeFolder
            // 
            treeFolder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            treeFolder.BackColor = Color.White;
            treeFolder.ImageIndex = 0;
            treeFolder.ImageList = imageList1;
            treeFolder.Location = new Point(16, 18);
            treeFolder.Margin = new Padding(4, 5, 4, 5);
            treeFolder.Name = "treeFolder";
            treeFolder.SelectedImageIndex = 0;
            treeFolder.Size = new Size(257, 839);
            treeFolder.TabIndex = 0;
            treeFolder.AfterCollapse += treeFolder_AfterCollapse;
            treeFolder.BeforeExpand += treeFolder_BeforeExpand;
            treeFolder.AfterExpand += treeFolder_AfterExpand;
            treeFolder.AfterSelect += treeFolder_AfterSelect;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "1.jpg");
            imageList1.Images.SetKeyName(1, "2.jpg");
            imageList1.Images.SetKeyName(2, "3.jpg");
            // 
            // pnThum
            // 
            pnThum.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnThum.AutoScroll = true;
            pnThum.BackColor = Color.Green;
            pnThum.Location = new Point(283, 706);
            pnThum.Margin = new Padding(4, 5, 4, 5);
            pnThum.Name = "pnThum";
            pnThum.Size = new Size(927, 154);
            pnThum.TabIndex = 1;
            pnThum.WrapContents = false;
            // 
            // picView
            // 
            picView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picView.BackColor = Color.FromArgb(255, 128, 128);
            picView.Location = new Point(283, 18);
            picView.Margin = new Padding(4, 5, 4, 5);
            picView.Name = "picView";
            picView.Size = new Size(927, 678);
            picView.SizeMode = PictureBoxSizeMode.Zoom;
            picView.TabIndex = 2;
            picView.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 878);
            Controls.Add(picView);
            Controls.Add(pnThum);
            Controls.Add(treeFolder);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picView).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeFolder;
        private System.Windows.Forms.FlowLayoutPanel pnThum;
        private System.Windows.Forms.PictureBox picView;
        private System.Windows.Forms.ImageList imageList1;

    }
}
