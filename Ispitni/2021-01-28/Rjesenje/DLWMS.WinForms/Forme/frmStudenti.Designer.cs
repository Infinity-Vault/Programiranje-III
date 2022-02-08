namespace DLWMS.WinForms.Forme
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
            this.components = new System.ComponentModel.Container();
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.Indeks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GodinaStudija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Polozeni = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBrojStudenata = new System.Windows.Forms.Label();
            this.lblProsjecnaOcjena = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxImePrezime = new System.Windows.Forms.TextBox();
            this.cmbGodine = new System.Windows.Forms.ComboBox();
            this.cmbAktivnost = new System.Windows.Forms.ComboBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnPotvrde = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.AllowUserToAddRows = false;
            this.dgvStudenti.AllowUserToDeleteRows = false;
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Indeks,
            this.Ime,
            this.Prezime,
            this.Spol,
            this.GodinaStudija,
            this.Aktivan,
            this.Polozeni});
            this.dgvStudenti.Location = new System.Drawing.Point(12, 44);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.ReadOnly = true;
            this.dgvStudenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudenti.Size = new System.Drawing.Size(800, 302);
            this.dgvStudenti.TabIndex = 0;
            this.dgvStudenti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudenti_CellContentClick);
            // 
            // Indeks
            // 
            this.Indeks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Indeks.DataPropertyName = "Indeks";
            this.Indeks.HeaderText = "Indeks";
            this.Indeks.Name = "Indeks";
            this.Indeks.ReadOnly = true;
            // 
            // Ime
            // 
            this.Ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Spol
            // 
            this.Spol.DataPropertyName = "Spol";
            this.Spol.HeaderText = "Spol";
            this.Spol.Name = "Spol";
            this.Spol.ReadOnly = true;
            // 
            // GodinaStudija
            // 
            this.GodinaStudija.DataPropertyName = "GodinaStudija";
            this.GodinaStudija.HeaderText = "Godina studija";
            this.GodinaStudija.Name = "GodinaStudija";
            this.GodinaStudija.ReadOnly = true;
            // 
            // Aktivan
            // 
            this.Aktivan.DataPropertyName = "Aktivan";
            this.Aktivan.HeaderText = "Aktivan";
            this.Aktivan.Name = "Aktivan";
            this.Aktivan.ReadOnly = true;
            // 
            // Polozeni
            // 
            this.Polozeni.HeaderText = "Polozeni";
            this.Polozeni.Name = "Polozeni";
            this.Polozeni.ReadOnly = true;
            this.Polozeni.Text = "Polozeni";
            this.Polozeni.UseColumnTextForButtonValue = true;
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(715, 365);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(97, 23);
            this.btnPrintaj.TabIndex = 1;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ime i prezime:";
            // 
            // lblBrojStudenata
            // 
            this.lblBrojStudenata.AutoSize = true;
            this.lblBrojStudenata.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrojStudenata.Location = new System.Drawing.Point(12, 349);
            this.lblBrojStudenata.Name = "lblBrojStudenata";
            this.lblBrojStudenata.Size = new System.Drawing.Size(107, 18);
            this.lblBrojStudenata.TabIndex = 3;
            this.lblBrojStudenata.Text = "Broj studenata:";
            // 
            // lblProsjecnaOcjena
            // 
            this.lblProsjecnaOcjena.AutoSize = true;
            this.lblProsjecnaOcjena.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProsjecnaOcjena.Location = new System.Drawing.Point(12, 370);
            this.lblProsjecnaOcjena.Name = "lblProsjecnaOcjena";
            this.lblProsjecnaOcjena.Size = new System.Drawing.Size(127, 18);
            this.lblProsjecnaOcjena.TabIndex = 4;
            this.lblProsjecnaOcjena.Text = "Prosjecna ocjena:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(335, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Godine studija:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(630, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aktivnost:";
            // 
            // txtBoxImePrezime
            // 
            this.txtBoxImePrezime.Location = new System.Drawing.Point(118, 17);
            this.txtBoxImePrezime.Name = "txtBoxImePrezime";
            this.txtBoxImePrezime.Size = new System.Drawing.Size(186, 20);
            this.txtBoxImePrezime.TabIndex = 7;
            this.txtBoxImePrezime.TextChanged += new System.EventHandler(this.txtBoxImePrezime_TextChanged);
            // 
            // cmbGodine
            // 
            this.cmbGodine.FormattingEnabled = true;
            this.cmbGodine.Location = new System.Drawing.Point(447, 17);
            this.cmbGodine.Name = "cmbGodine";
            this.cmbGodine.Size = new System.Drawing.Size(162, 21);
            this.cmbGodine.TabIndex = 8;
            this.cmbGodine.SelectedIndexChanged += new System.EventHandler(this.cmbGodine_SelectedIndexChanged);
            // 
            // cmbAktivnost
            // 
            this.cmbAktivnost.FormattingEnabled = true;
            this.cmbAktivnost.Location = new System.Drawing.Point(708, 15);
            this.cmbAktivnost.Name = "cmbAktivnost";
            this.cmbAktivnost.Size = new System.Drawing.Size(104, 21);
            this.cmbAktivnost.TabIndex = 9;
            this.cmbAktivnost.SelectedIndexChanged += new System.EventHandler(this.cmbAktivnost_SelectedIndexChanged);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // btnPotvrde
            // 
            this.btnPotvrde.Location = new System.Drawing.Point(338, 365);
            this.btnPotvrde.Name = "btnPotvrde";
            this.btnPotvrde.Size = new System.Drawing.Size(97, 23);
            this.btnPotvrde.TabIndex = 10;
            this.btnPotvrde.Text = "POTVRDE";
            this.btnPotvrde.UseVisualStyleBackColor = true;
            this.btnPotvrde.Click += new System.EventHandler(this.btnPotvrde_Click);
            // 
            // frmStudenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 397);
            this.Controls.Add(this.btnPotvrde);
            this.Controls.Add(this.cmbAktivnost);
            this.Controls.Add(this.cmbGodine);
            this.Controls.Add(this.txtBoxImePrezime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblProsjecnaOcjena);
            this.Controls.Add(this.lblBrojStudenata);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.dgvStudenti);
            this.Name = "frmStudenti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studenti";
            this.Load += new System.EventHandler(this.frmStudenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indeks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GodinaStudija;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktivan;
        private System.Windows.Forms.DataGridViewButtonColumn Polozeni;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBrojStudenata;
        private System.Windows.Forms.Label lblProsjecnaOcjena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxImePrezime;
        private System.Windows.Forms.ComboBox cmbGodine;
        private System.Windows.Forms.ComboBox cmbAktivnost;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Button btnPotvrde;
    }
}