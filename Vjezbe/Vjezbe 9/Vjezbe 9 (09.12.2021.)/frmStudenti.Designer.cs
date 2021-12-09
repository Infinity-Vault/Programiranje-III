namespace Vjezbe_9__09._12._2021._
{
    partial class frmStudenti
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
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.dgvPredmetiStudenta = new System.Windows.Forms.DataGridView();
            this.btnDodajStudenta = new System.Windows.Forms.Button();
            this.msDodavanjePredmeta = new System.Windows.Forms.MenuStrip();
            this.predmetiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajPredmetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodijeliPredmetStudentuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Godina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredmetiStudenta)).BeginInit();
            this.msDodavanjePredmeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime,
            this.Prezime,
            this.Godina});
            this.dgvStudenti.Location = new System.Drawing.Point(12, 44);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudenti.Size = new System.Drawing.Size(776, 260);
            this.dgvStudenti.TabIndex = 0;
            this.dgvStudenti.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudenti_CellDoubleClick);
            // 
            // dgvPredmetiStudenta
            // 
            this.dgvPredmetiStudenta.AllowUserToAddRows = false;
            this.dgvPredmetiStudenta.AllowUserToDeleteRows = false;
            this.dgvPredmetiStudenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPredmetiStudenta.Location = new System.Drawing.Point(12, 346);
            this.dgvPredmetiStudenta.Name = "dgvPredmetiStudenta";
            this.dgvPredmetiStudenta.ReadOnly = true;
            this.dgvPredmetiStudenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPredmetiStudenta.Size = new System.Drawing.Size(776, 150);
            this.dgvPredmetiStudenta.TabIndex = 1;
            // 
            // btnDodajStudenta
            // 
            this.btnDodajStudenta.Location = new System.Drawing.Point(713, 15);
            this.btnDodajStudenta.Name = "btnDodajStudenta";
            this.btnDodajStudenta.Size = new System.Drawing.Size(75, 23);
            this.btnDodajStudenta.TabIndex = 2;
            this.btnDodajStudenta.Text = "Dodaj";
            this.btnDodajStudenta.UseVisualStyleBackColor = true;
            this.btnDodajStudenta.Click += new System.EventHandler(this.btnDodajStudenta_Click);
            // 
            // msDodavanjePredmeta
            // 
            this.msDodavanjePredmeta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.predmetiToolStripMenuItem});
            this.msDodavanjePredmeta.Location = new System.Drawing.Point(0, 0);
            this.msDodavanjePredmeta.Name = "msDodavanjePredmeta";
            this.msDodavanjePredmeta.Size = new System.Drawing.Size(800, 24);
            this.msDodavanjePredmeta.TabIndex = 3;
            this.msDodavanjePredmeta.Text = "menuStrip1";
            // 
            // predmetiToolStripMenuItem
            // 
            this.predmetiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajPredmetToolStripMenuItem,
            this.dodijeliPredmetStudentuToolStripMenuItem});
            this.predmetiToolStripMenuItem.Name = "predmetiToolStripMenuItem";
            this.predmetiToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.predmetiToolStripMenuItem.Text = "Predmeti";
            // 
            // dodajPredmetToolStripMenuItem
            // 
            this.dodajPredmetToolStripMenuItem.Name = "dodajPredmetToolStripMenuItem";
            this.dodajPredmetToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.dodajPredmetToolStripMenuItem.Text = "Dodaj predmet";
            this.dodajPredmetToolStripMenuItem.Click += new System.EventHandler(this.dodajPredmetToolStripMenuItem_Click);
            // 
            // dodijeliPredmetStudentuToolStripMenuItem
            // 
            this.dodijeliPredmetStudentuToolStripMenuItem.Name = "dodijeliPredmetStudentuToolStripMenuItem";
            this.dodijeliPredmetStudentuToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.dodijeliPredmetStudentuToolStripMenuItem.Text = "Dodijeli predmet studentu";
            this.dodijeliPredmetStudentuToolStripMenuItem.Click += new System.EventHandler(this.dodijeliPredmetStudentuToolStripMenuItem_Click);
            // 
            // Ime
            // 
            this.Ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            // 
            // Prezime
            // 
            this.Prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            // 
            // Godina
            // 
            this.Godina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Godina.DataPropertyName = "Godina";
            this.Godina.HeaderText = "Godina";
            this.Godina.Name = "Godina";
            // 
            // frmStudenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.btnDodajStudenta);
            this.Controls.Add(this.dgvPredmetiStudenta);
            this.Controls.Add(this.dgvStudenti);
            this.Controls.Add(this.msDodavanjePredmeta);
            this.MainMenuStrip = this.msDodavanjePredmeta;
            this.Name = "frmStudenti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studenti";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredmetiStudenta)).EndInit();
            this.msDodavanjePredmeta.ResumeLayout(false);
            this.msDodavanjePredmeta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Windows.Forms.DataGridView dgvPredmetiStudenta;
        private System.Windows.Forms.Button btnDodajStudenta;
        private System.Windows.Forms.MenuStrip msDodavanjePredmeta;
        private System.Windows.Forms.ToolStripMenuItem predmetiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajPredmetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodijeliPredmetStudentuToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Godina;
    }
}

