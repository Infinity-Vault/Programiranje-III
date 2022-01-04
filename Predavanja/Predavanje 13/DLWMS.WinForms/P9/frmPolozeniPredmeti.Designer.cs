namespace DLWMS.WinForms.P9
{
    partial class frmPolozeniPredmeti
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
            this.dgvPolozeniPredmeti = new System.Windows.Forms.DataGridView();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbPredmeti = new System.Windows.Forms.ComboBox();
            this.cmbOcjene = new System.Windows.Forms.ComboBox();
            this.dtpDatumPolaganja = new System.Windows.Forms.DateTimePicker();
            this.btnDodajPolozeni = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvUloge = new System.Windows.Forms.DataGridView();
            this.cmbUloge = new System.Windows.Forms.ComboBox();
            this.btnDodajUlogu = new System.Windows.Forms.Button();
            this.btnPrintajUvjerenje = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolozeniPredmeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUloge)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPolozeniPredmeti
            // 
            this.dgvPolozeniPredmeti.AllowUserToAddRows = false;
            this.dgvPolozeniPredmeti.AllowUserToDeleteRows = false;
            this.dgvPolozeniPredmeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolozeniPredmeti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Predmet,
            this.Datum,
            this.Ocjena});
            this.dgvPolozeniPredmeti.Location = new System.Drawing.Point(12, 85);
            this.dgvPolozeniPredmeti.Name = "dgvPolozeniPredmeti";
            this.dgvPolozeniPredmeti.ReadOnly = true;
            this.dgvPolozeniPredmeti.Size = new System.Drawing.Size(603, 150);
            this.dgvPolozeniPredmeti.TabIndex = 0;
            // 
            // Predmet
            // 
            this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "DatumPolaganja";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Ocjena
            // 
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            // 
            // cmbPredmeti
            // 
            this.cmbPredmeti.FormattingEnabled = true;
            this.cmbPredmeti.Location = new System.Drawing.Point(12, 58);
            this.cmbPredmeti.Name = "cmbPredmeti";
            this.cmbPredmeti.Size = new System.Drawing.Size(204, 21);
            this.cmbPredmeti.TabIndex = 1;
            this.cmbPredmeti.SelectedIndexChanged += new System.EventHandler(this.cmbPredmeti_SelectedIndexChanged);
            // 
            // cmbOcjene
            // 
            this.cmbOcjene.FormattingEnabled = true;
            this.cmbOcjene.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbOcjene.Location = new System.Drawing.Point(222, 58);
            this.cmbOcjene.Name = "cmbOcjene";
            this.cmbOcjene.Size = new System.Drawing.Size(104, 21);
            this.cmbOcjene.TabIndex = 2;
            // 
            // dtpDatumPolaganja
            // 
            this.dtpDatumPolaganja.Location = new System.Drawing.Point(332, 58);
            this.dtpDatumPolaganja.Name = "dtpDatumPolaganja";
            this.dtpDatumPolaganja.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumPolaganja.TabIndex = 3;
            // 
            // btnDodajPolozeni
            // 
            this.btnDodajPolozeni.Location = new System.Drawing.Point(539, 58);
            this.btnDodajPolozeni.Name = "btnDodajPolozeni";
            this.btnDodajPolozeni.Size = new System.Drawing.Size(75, 23);
            this.btnDodajPolozeni.TabIndex = 4;
            this.btnDodajPolozeni.Text = "Dodaj";
            this.btnDodajPolozeni.UseVisualStyleBackColor = true;
            this.btnDodajPolozeni.Click += new System.EventHandler(this.btnDodajPolozeni_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // dgvUloge
            // 
            this.dgvUloge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUloge.Location = new System.Drawing.Point(12, 392);
            this.dgvUloge.Name = "dgvUloge";
            this.dgvUloge.Size = new System.Drawing.Size(602, 112);
            this.dgvUloge.TabIndex = 5;
            // 
            // cmbUloge
            // 
            this.cmbUloge.FormattingEnabled = true;
            this.cmbUloge.Location = new System.Drawing.Point(12, 365);
            this.cmbUloge.Name = "cmbUloge";
            this.cmbUloge.Size = new System.Drawing.Size(204, 21);
            this.cmbUloge.TabIndex = 6;
            // 
            // btnDodajUlogu
            // 
            this.btnDodajUlogu.Location = new System.Drawing.Point(539, 363);
            this.btnDodajUlogu.Name = "btnDodajUlogu";
            this.btnDodajUlogu.Size = new System.Drawing.Size(75, 23);
            this.btnDodajUlogu.TabIndex = 7;
            this.btnDodajUlogu.Text = "Dodaj";
            this.btnDodajUlogu.UseVisualStyleBackColor = true;
            this.btnDodajUlogu.Click += new System.EventHandler(this.btnDodajUlogu_Click);
            // 
            // btnPrintajUvjerenje
            // 
            this.btnPrintajUvjerenje.Location = new System.Drawing.Point(472, 241);
            this.btnPrintajUvjerenje.Name = "btnPrintajUvjerenje";
            this.btnPrintajUvjerenje.Size = new System.Drawing.Size(142, 23);
            this.btnPrintajUvjerenje.TabIndex = 8;
            this.btnPrintajUvjerenje.Text = "Printaj uvjerenje";
            this.btnPrintajUvjerenje.UseVisualStyleBackColor = true;
            this.btnPrintajUvjerenje.Click += new System.EventHandler(this.btnPrintajUvjerenje_Click);
            // 
            // frmPolozeniPredmeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 282);
            this.Controls.Add(this.btnPrintajUvjerenje);
            this.Controls.Add(this.btnDodajUlogu);
            this.Controls.Add(this.cmbUloge);
            this.Controls.Add(this.dgvUloge);
            this.Controls.Add(this.btnDodajPolozeni);
            this.Controls.Add(this.dtpDatumPolaganja);
            this.Controls.Add(this.cmbOcjene);
            this.Controls.Add(this.cmbPredmeti);
            this.Controls.Add(this.dgvPolozeniPredmeti);
            this.Name = "frmPolozeniPredmeti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polozeni predmeti";
            this.Load += new System.EventHandler(this.frmPolozeniPredmeti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolozeniPredmeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUloge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPolozeniPredmeti;
        private System.Windows.Forms.ComboBox cmbPredmeti;
        private System.Windows.Forms.ComboBox cmbOcjene;
        private System.Windows.Forms.DateTimePicker dtpDatumPolaganja;
        private System.Windows.Forms.Button btnDodajPolozeni;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridView dgvUloge;
        private System.Windows.Forms.ComboBox cmbUloge;
        private System.Windows.Forms.Button btnDodajUlogu;
        private System.Windows.Forms.Button btnPrintajUvjerenje;
    }
}