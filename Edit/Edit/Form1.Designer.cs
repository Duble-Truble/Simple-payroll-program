﻿namespace Edit
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novKlientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novKlientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.podjetjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VpisUr = new System.Windows.Forms.ToolStripMenuItem();
            this.izračunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novKlientToolStripMenuItem,
            this.podjetjeToolStripMenuItem,
            this.VpisUr,
            this.izračunToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1275, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novKlientToolStripMenuItem
            // 
            this.novKlientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novKlientToolStripMenuItem1});
            this.novKlientToolStripMenuItem.Name = "novKlientToolStripMenuItem";
            this.novKlientToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.novKlientToolStripMenuItem.Text = "Klient";
            // 
            // novKlientToolStripMenuItem1
            // 
            this.novKlientToolStripMenuItem1.Name = "novKlientToolStripMenuItem1";
            this.novKlientToolStripMenuItem1.Size = new System.Drawing.Size(198, 34);
            this.novKlientToolStripMenuItem1.Text = "Nov klient:";
            this.novKlientToolStripMenuItem1.Click += new System.EventHandler(this.novKlientToolStripMenuItem1_Click);
            // 
            // podjetjeToolStripMenuItem
            // 
            this.podjetjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNovoToolStripMenuItem});
            this.podjetjeToolStripMenuItem.Name = "podjetjeToolStripMenuItem";
            this.podjetjeToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.podjetjeToolStripMenuItem.Text = "Podjetje";
            // 
            // dodajNovoToolStripMenuItem
            // 
            this.dodajNovoToolStripMenuItem.Name = "dodajNovoToolStripMenuItem";
            this.dodajNovoToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.dodajNovoToolStripMenuItem.Text = "Dodaj novo:";
            this.dodajNovoToolStripMenuItem.Click += new System.EventHandler(this.dodajNovoToolStripMenuItem_Click);
            // 
            // VpisUr
            // 
            this.VpisUr.Name = "VpisUr";
            this.VpisUr.Size = new System.Drawing.Size(82, 29);
            this.VpisUr.Text = "Vpis ur";
            this.VpisUr.Click += new System.EventHandler(this.VpisUr_Click);
            // 
            // izračunToolStripMenuItem
            // 
            this.izračunToolStripMenuItem.Name = "izračunToolStripMenuItem";
            this.izračunToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.izračunToolStripMenuItem.Text = "Izračun";
            this.izračunToolStripMenuItem.Click += new System.EventHandler(this.izračunToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(16, 29);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1275, 877);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E_dit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novKlientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novKlientToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem podjetjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VpisUr;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem izračunToolStripMenuItem;
    }
}

