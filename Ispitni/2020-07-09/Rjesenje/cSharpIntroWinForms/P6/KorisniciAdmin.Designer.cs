namespace cSharpIntroWinForms
{
    partial class KorisniciAdmin
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
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.cmbSpol = new System.Windows.Forms.ComboBox();
            this.cbAdministrator = new System.Windows.Forms.CheckBox();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Admin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Polozeni = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AllowUserToAddRows = false;
            this.dgvKorisnici.AllowUserToDeleteRows = false;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime,
            this.Prezime,
            this.Spol,
            this.KorisnickoIme,
            this.Admin,
            this.Polozeni});
            this.dgvKorisnici.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvKorisnici.Location = new System.Drawing.Point(12, 41);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.ReadOnly = true;
            this.dgvKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKorisnici.Size = new System.Drawing.Size(666, 265);
            this.dgvKorisnici.TabIndex = 0;
            this.dgvKorisnici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKorisnici_CellContentClick);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(12, 15);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(440, 20);
            this.txtPretraga.TabIndex = 2;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(12, 313);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(192, 20);
            this.txtSuma.TabIndex = 3;
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(222, 310);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 23);
            this.btnSuma.TabIndex = 4;
            this.btnSuma.Text = "Suma";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(565, 309);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(115, 23);
            this.btnPrintaj.TabIndex = 5;
            this.btnPrintaj.Text = "Printaj polozene";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // cmbSpol
            // 
            this.cmbSpol.FormattingEnabled = true;
            this.cmbSpol.Location = new System.Drawing.Point(458, 13);
            this.cmbSpol.Name = "cmbSpol";
            this.cmbSpol.Size = new System.Drawing.Size(107, 21);
            this.cmbSpol.TabIndex = 6;
            this.cmbSpol.SelectedIndexChanged += new System.EventHandler(this.cmbSpol_SelectedIndexChanged);
            // 
            // cbAdministrator
            // 
            this.cbAdministrator.AutoSize = true;
            this.cbAdministrator.Location = new System.Drawing.Point(581, 15);
            this.cbAdministrator.Name = "cbAdministrator";
            this.cbAdministrator.Size = new System.Drawing.Size(86, 17);
            this.cbAdministrator.TabIndex = 7;
            this.cbAdministrator.Text = "Administrator";
            this.cbAdministrator.UseVisualStyleBackColor = true;
            this.cbAdministrator.CheckedChanged += new System.EventHandler(this.cbAdministrator_CheckedChanged);
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
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "Korisničko ime";
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.ReadOnly = true;
            // 
            // Admin
            // 
            this.Admin.DataPropertyName = "Admin";
            this.Admin.HeaderText = "Admin";
            this.Admin.Name = "Admin";
            this.Admin.ReadOnly = true;
            // 
            // Polozeni
            // 
            this.Polozeni.HeaderText = "Slike";
            this.Polozeni.Name = "Polozeni";
            this.Polozeni.ReadOnly = true;
            this.Polozeni.Text = "Slike";
            this.Polozeni.ToolTipText = "Slike";
            this.Polozeni.UseColumnTextForButtonValue = true;
            // 
            // KorisniciAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 337);
            this.Controls.Add(this.cbAdministrator);
            this.Controls.Add(this.cmbSpol);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.dgvKorisnici);
            this.Name = "KorisniciAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracija korisnika";
            this.Load += new System.EventHandler(this.KorisniciAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.ComboBox cmbSpol;
        private System.Windows.Forms.CheckBox cbAdministrator;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spol;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Admin;
        private System.Windows.Forms.DataGridViewButtonColumn Polozeni;
    }
}