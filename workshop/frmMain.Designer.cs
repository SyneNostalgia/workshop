﻿namespace workshop
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            workshopToolStripMenuItem = new ToolStripMenuItem();
            workshop1ToolStripMenuItem = new ToolStripMenuItem();
            workshop3ToolStripMenuItem = new ToolStripMenuItem();
            workshop4ToolStripMenuItem = new ToolStripMenuItem();
            workshop6ToolStripMenuItem = new ToolStripMenuItem();
            jihanToolStripMenuItem = new ToolStripMenuItem();
            from5ToolStripMenuItem = new ToolStripMenuItem();
            from6ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { workshopToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // workshopToolStripMenuItem
            // 
            workshopToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { workshop1ToolStripMenuItem, workshop3ToolStripMenuItem, workshop4ToolStripMenuItem, workshop6ToolStripMenuItem, jihanToolStripMenuItem, from5ToolStripMenuItem, from6ToolStripMenuItem });
            workshopToolStripMenuItem.Name = "workshopToolStripMenuItem";
            workshopToolStripMenuItem.Size = new Size(89, 24);
            workshopToolStripMenuItem.Text = "Workshop";
            // 
            // workshop1ToolStripMenuItem
            // 
            workshop1ToolStripMenuItem.Name = "workshop1ToolStripMenuItem";
            workshop1ToolStripMenuItem.Size = new Size(224, 26);
            workshop1ToolStripMenuItem.Text = "Workshop1-2";
            workshop1ToolStripMenuItem.Click += workshop1ToolStripMenuItem_Click;
            // 
            // workshop3ToolStripMenuItem
            // 
            workshop3ToolStripMenuItem.Name = "workshop3ToolStripMenuItem";
            workshop3ToolStripMenuItem.Size = new Size(224, 26);
            workshop3ToolStripMenuItem.Text = "Workshop3";
            workshop3ToolStripMenuItem.Click += workshop3ToolStripMenuItem_Click;
            // 
            // workshop4ToolStripMenuItem
            // 
            workshop4ToolStripMenuItem.Name = "workshop4ToolStripMenuItem";
            workshop4ToolStripMenuItem.Size = new Size(224, 26);
            workshop4ToolStripMenuItem.Text = "Workshop4-5";
            workshop4ToolStripMenuItem.Click += workshop4ToolStripMenuItem_Click;
            // 
            // workshop6ToolStripMenuItem
            // 
            workshop6ToolStripMenuItem.Name = "workshop6ToolStripMenuItem";
            workshop6ToolStripMenuItem.Size = new Size(224, 26);
            workshop6ToolStripMenuItem.Text = "Workshop6";
            workshop6ToolStripMenuItem.Click += workshop6ToolStripMenuItem_Click;
            // 
            // jihanToolStripMenuItem
            // 
            jihanToolStripMenuItem.Name = "jihanToolStripMenuItem";
            jihanToolStripMenuItem.Size = new Size(224, 26);
            jihanToolStripMenuItem.Text = "Jihan";
            jihanToolStripMenuItem.Click += jihanToolStripMenuItem_Click;
            // 
            // from5ToolStripMenuItem
            // 
            from5ToolStripMenuItem.Name = "from5ToolStripMenuItem";
            from5ToolStripMenuItem.Size = new Size(224, 26);
            from5ToolStripMenuItem.Text = "From5";
            from5ToolStripMenuItem.Click += from5ToolStripMenuItem_Click;
            // 
            // from6ToolStripMenuItem
            // 
            from6ToolStripMenuItem.Name = "from6ToolStripMenuItem";
            from6ToolStripMenuItem.Size = new Size(224, 26);
            from6ToolStripMenuItem.Text = "From6";
            from6ToolStripMenuItem.Click += from6ToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "frmMain";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem workshopToolStripMenuItem;
        private ToolStripMenuItem workshop1ToolStripMenuItem;
        private ToolStripMenuItem workshop3ToolStripMenuItem;
        private ToolStripMenuItem workshop4ToolStripMenuItem;
        private ToolStripMenuItem workshop6ToolStripMenuItem;
        private ToolStripMenuItem jihanToolStripMenuItem;
        private ToolStripMenuItem from5ToolStripMenuItem;
        private ToolStripMenuItem from6ToolStripMenuItem;
    }
}