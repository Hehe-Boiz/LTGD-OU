﻿namespace C7
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            drawByMouseToolStripMenuItem = new ToolStripMenuItem();
            drawTextToolStripMenuItem = new ToolStripMenuItem();
            drawImageToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { drawByMouseToolStripMenuItem, drawTextToolStripMenuItem, drawImageToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // drawByMouseToolStripMenuItem
            // 
            drawByMouseToolStripMenuItem.Name = "drawByMouseToolStripMenuItem";
            drawByMouseToolStripMenuItem.Size = new Size(224, 26);
            drawByMouseToolStripMenuItem.Text = "Draw By Mouse";
            drawByMouseToolStripMenuItem.Click += drawByMouseToolStripMenuItem_Click;
            // 
            // drawTextToolStripMenuItem
            // 
            drawTextToolStripMenuItem.Name = "drawTextToolStripMenuItem";
            drawTextToolStripMenuItem.Size = new Size(224, 26);
            drawTextToolStripMenuItem.Text = "Draw Text";
            drawTextToolStripMenuItem.Click += drawTextToolStripMenuItem_Click;
            // 
            // drawImageToolStripMenuItem
            // 
            drawImageToolStripMenuItem.Name = "drawImageToolStripMenuItem";
            drawImageToolStripMenuItem.Size = new Size(224, 26);
            drawImageToolStripMenuItem.Text = "Draw Image";
            drawImageToolStripMenuItem.Click += drawImageToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem drawByMouseToolStripMenuItem;
        private ToolStripMenuItem drawTextToolStripMenuItem;
        private ToolStripMenuItem drawImageToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}
