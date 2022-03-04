namespace cSharpIntroWinForms.IBBrojIndeksa
{
    partial class frmPorukeIBBrojIndeksa
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
            this.lblKorisnikPoruka = new System.Windows.Forms.Label();
            this.dgvPoruke = new System.Windows.Forms.DataGridView();
            this.datumVrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sadrzajPorukeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slikaDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.Brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.korisniciPorukeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.btnPoruka = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoruke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciPorukeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKorisnikPoruka
            // 
            this.lblKorisnikPoruka.AutoSize = true;
            this.lblKorisnikPoruka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorisnikPoruka.Location = new System.Drawing.Point(108, 13);
            this.lblKorisnikPoruka.Name = "lblKorisnikPoruka";
            this.lblKorisnikPoruka.Size = new System.Drawing.Size(76, 25);
            this.lblKorisnikPoruka.TabIndex = 1;
            this.lblKorisnikPoruka.Text = "label2";
            // 
            // dgvPoruke
            // 
            this.dgvPoruke.AllowUserToAddRows = false;
            this.dgvPoruke.AllowUserToDeleteRows = false;
            this.dgvPoruke.AutoGenerateColumns = false;
            this.dgvPoruke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoruke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datumVrijemeDataGridViewTextBoxColumn,
            this.sadrzajPorukeDataGridViewTextBoxColumn,
            this.slikaDataGridViewImageColumn,
            this.Brisi});
            this.dgvPoruke.DataSource = this.korisniciPorukeBindingSource;
            this.dgvPoruke.Location = new System.Drawing.Point(16, 69);
            this.dgvPoruke.Name = "dgvPoruke";
            this.dgvPoruke.ReadOnly = true;
            this.dgvPoruke.Size = new System.Drawing.Size(703, 244);
            this.dgvPoruke.TabIndex = 2;
            this.dgvPoruke.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPoruke_CellContentClick);
            this.dgvPoruke.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPoruke_CellDoubleClick);
            // 
            // datumVrijemeDataGridViewTextBoxColumn
            // 
            this.datumVrijemeDataGridViewTextBoxColumn.DataPropertyName = "DatumVrijeme";
            this.datumVrijemeDataGridViewTextBoxColumn.HeaderText = "DatumVrijeme";
            this.datumVrijemeDataGridViewTextBoxColumn.Name = "datumVrijemeDataGridViewTextBoxColumn";
            this.datumVrijemeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sadrzajPorukeDataGridViewTextBoxColumn
            // 
            this.sadrzajPorukeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sadrzajPorukeDataGridViewTextBoxColumn.DataPropertyName = "SadrzajPoruke";
            this.sadrzajPorukeDataGridViewTextBoxColumn.HeaderText = "SadrzajPoruke";
            this.sadrzajPorukeDataGridViewTextBoxColumn.Name = "sadrzajPorukeDataGridViewTextBoxColumn";
            this.sadrzajPorukeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // slikaDataGridViewImageColumn
            // 
            this.slikaDataGridViewImageColumn.DataPropertyName = "Slika";
            this.slikaDataGridViewImageColumn.HeaderText = "Slika";
            this.slikaDataGridViewImageColumn.Name = "slikaDataGridViewImageColumn";
            this.slikaDataGridViewImageColumn.ReadOnly = true;
            // 
            // Brisi
            // 
            this.Brisi.HeaderText = "Brisi";
            this.Brisi.Name = "Brisi";
            this.Brisi.ReadOnly = true;
            this.Brisi.Text = "Brisi";
            this.Brisi.ToolTipText = "Brisi";
            this.Brisi.UseColumnTextForButtonValue = true;
            // 
            // korisniciPorukeBindingSource
            // 
            this.korisniciPorukeBindingSource.DataSource = typeof(cSharpIntroWinForms.IBBrojIndeksa.KorisniciPoruke);
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(644, 329);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(75, 23);
            this.btnPrintaj.TabIndex = 3;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // btnPoruka
            // 
            this.btnPoruka.Location = new System.Drawing.Point(626, 26);
            this.btnPoruka.Name = "btnPoruka";
            this.btnPoruka.Size = new System.Drawing.Size(93, 23);
            this.btnPoruka.TabIndex = 4;
            this.btnPoruka.Text = "Nova poruka";
            this.btnPoruka.UseVisualStyleBackColor = true;
            this.btnPoruka.Click += new System.EventHandler(this.btnPoruka_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Komunikacija sa: ";
            // 
            // frmPorukeIBBrojIndeksa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(733, 364);
            this.Controls.Add(this.btnPoruka);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.dgvPoruke);
            this.Controls.Add(this.lblKorisnikPoruka);
            this.Controls.Add(this.label2);
            this.Name = "frmPorukeIBBrojIndeksa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poruke";
            this.Load += new System.EventHandler(this.frmPorukeIBBrojIndeksa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoruke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciPorukeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblKorisnikPoruka;
        private System.Windows.Forms.DataGridView dgvPoruke;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.Button btnPoruka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource korisniciPorukeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumVrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sadrzajPorukeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn slikaDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Brisi;
    }
}