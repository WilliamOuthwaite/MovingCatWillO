﻿namespace MovingCatWillO
{
    partial class frmMovingCat
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
            this.picCat = new System.Windows.Forms.PictureBox();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picCat
            // 
            this.picCat.Image = global::MovingCatWillO.Properties.Resources.cat2;
            this.picCat.Location = new System.Drawing.Point(55, 51);
            this.picCat.Name = "picCat";
            this.picCat.Size = new System.Drawing.Size(174, 156);
            this.picCat.TabIndex = 0;
            this.picCat.TabStop = false;
            this.picCat.Click += new System.EventHandler(this.picCat_Click);
            // 
            // mnuMenu
            // 
            this.mnuMenu.Location = new System.Drawing.Point(0, 24);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(284, 24);
            this.mnuMenu.TabIndex = 1;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile,
            this.mniCat});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(284, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(40, 20);
            this.mniFile.Text = "File ";
            // 
            // mniCat
            // 
            this.mniCat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCat1,
            this.mniCat2});
            this.mniCat.Name = "mniCat";
            this.mniCat.Size = new System.Drawing.Size(37, 20);
            this.mniCat.Text = "Cat";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            // 
            // mniCat1
            // 
            this.mniCat1.Name = "mniCat1";
            this.mniCat1.Size = new System.Drawing.Size(152, 22);
            this.mniCat1.Text = "Cat 1";
            this.mniCat1.Click += new System.EventHandler(this.mniCat1_Click);
            // 
            // mniCat2
            // 
            this.mniCat2.Name = "mniCat2";
            this.mniCat2.Size = new System.Drawing.Size(152, 22);
            this.mniCat2.Text = "Cat2";
            this.mniCat2.Click += new System.EventHandler(this.mniCat2_Click);
            // 
            // frmMovingCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.picCat);
            this.Controls.Add(this.mnuMenu);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "frmMovingCat";
            this.Text = "Moving Cat";
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCat;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem mniCat;
        private System.Windows.Forms.ToolStripMenuItem mniCat1;
        private System.Windows.Forms.ToolStripMenuItem mniCat2;
    }
}

