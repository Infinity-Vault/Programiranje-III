using System.Collections.Generic;

namespace DLWMS.WinForms
{
    partial class frmGlavna
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
            this.Meni = new System.Windows.Forms.MenuStrip();
            this.dobroDosliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dLWMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.igreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.napustiAplikacijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Meni.SuspendLayout();
            this.SuspendLayout();
            // 
            // Meni
            // 
            this.Meni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dobroDosliToolStripMenuItem,
            this.dLWMSToolStripMenuItem,
            this.napustiAplikacijuToolStripMenuItem});
            this.Meni.Location = new System.Drawing.Point(0, 0);
            this.Meni.Name = "Meni";
            this.Meni.Size = new System.Drawing.Size(572, 24);
            this.Meni.TabIndex = 1;
            this.Meni.Text = "menuStrip1";
            // 
            // dobroDosliToolStripMenuItem
            // 
            this.dobroDosliToolStripMenuItem.Name = "dobroDosliToolStripMenuItem";
            this.dobroDosliToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.dobroDosliToolStripMenuItem.Text = "Dobro dosli";
            this.dobroDosliToolStripMenuItem.Click += new System.EventHandler(this.dobroDosliToolStripMenuItem_Click);
            // 
            // dLWMSToolStripMenuItem
            // 
            this.dLWMSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentiToolStripMenuItem,
            this.igreToolStripMenuItem});
            this.dLWMSToolStripMenuItem.Name = "dLWMSToolStripMenuItem";
            this.dLWMSToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.dLWMSToolStripMenuItem.Text = "DLWMS";
            // 
            // studentiToolStripMenuItem
            // 
            this.studentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noviStudentToolStripMenuItem});
            this.studentiToolStripMenuItem.Name = "studentiToolStripMenuItem";
            this.studentiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.studentiToolStripMenuItem.Text = "Studenti";
            this.studentiToolStripMenuItem.Click += new System.EventHandler(this.studentiToolStripMenuItem_Click);
            // 
            // noviStudentToolStripMenuItem
            // 
            this.noviStudentToolStripMenuItem.Name = "noviStudentToolStripMenuItem";
            this.noviStudentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.noviStudentToolStripMenuItem.Text = "Novi student";
            this.noviStudentToolStripMenuItem.Click += new System.EventHandler(this.noviStudentToolStripMenuItem_Click);
            // 
            // igreToolStripMenuItem
            // 
            this.igreToolStripMenuItem.Name = "igreToolStripMenuItem";
            this.igreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.igreToolStripMenuItem.Text = "Igre";
            // 
            // napustiAplikacijuToolStripMenuItem
            // 
            this.napustiAplikacijuToolStripMenuItem.Name = "napustiAplikacijuToolStripMenuItem";
            this.napustiAplikacijuToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.napustiAplikacijuToolStripMenuItem.Text = "Napusti aplikaciju";
            this.napustiAplikacijuToolStripMenuItem.Click += new System.EventHandler(this.napustiAplikacijuToolStripMenuItem_Click);
            // 
            // frmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 385);
            this.Controls.Add(this.Meni);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Meni;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRIII";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Meni.ResumeLayout(false);
            this.Meni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Meni;
        private System.Windows.Forms.ToolStripMenuItem dobroDosliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dLWMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem igreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem napustiAplikacijuToolStripMenuItem;
    }

    partial class Student
    {
        public int Indeks { get; set; }
        public List<int> Ocjene { get; set; } = new List<int>();
    }
}

