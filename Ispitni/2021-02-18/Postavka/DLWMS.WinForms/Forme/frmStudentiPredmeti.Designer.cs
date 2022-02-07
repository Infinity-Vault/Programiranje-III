
namespace DLWMS.WinForms.Forme
{
    partial class frmStudentiPredmeti
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
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbPredmeti = new System.Windows.Forms.ComboBox();
            this.cmbOcjene = new System.Windows.Forms.ComboBox();
            this.dtpDatumPolaganja = new System.Windows.Forms.DateTimePicker();
            this.btnDodajPolozeni = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblBrojZapisa = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblProsjek = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolozeniPredmeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPolozeniPredmeti
            // 
            this.dgvPolozeniPredmeti.AllowUserToAddRows = false;
            this.dgvPolozeniPredmeti.AllowUserToDeleteRows = false;
            this.dgvPolozeniPredmeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolozeniPredmeti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Predmet,
            this.Ocjena,
            this.Datum});
            this.dgvPolozeniPredmeti.Location = new System.Drawing.Point(12, 75);
            this.dgvPolozeniPredmeti.Name = "dgvPolozeniPredmeti";
            this.dgvPolozeniPredmeti.ReadOnly = true;
            this.dgvPolozeniPredmeti.Size = new System.Drawing.Size(528, 150);
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
            // Ocjena
            // 
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum polaganja";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // cmbPredmeti
            // 
            this.cmbPredmeti.FormattingEnabled = true;
            this.cmbPredmeti.Location = new System.Drawing.Point(13, 48);
            this.cmbPredmeti.Name = "cmbPredmeti";
            this.cmbPredmeti.Size = new System.Drawing.Size(185, 21);
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
            this.cmbOcjene.Location = new System.Drawing.Point(204, 48);
            this.cmbOcjene.Name = "cmbOcjene";
            this.cmbOcjene.Size = new System.Drawing.Size(82, 21);
            this.cmbOcjene.TabIndex = 2;
            // 
            // dtpDatumPolaganja
            // 
            this.dtpDatumPolaganja.Location = new System.Drawing.Point(293, 48);
            this.dtpDatumPolaganja.Name = "dtpDatumPolaganja";
            this.dtpDatumPolaganja.Size = new System.Drawing.Size(167, 20);
            this.dtpDatumPolaganja.TabIndex = 3;
            // 
            // btnDodajPolozeni
            // 
            this.btnDodajPolozeni.Location = new System.Drawing.Point(467, 47);
            this.btnDodajPolozeni.Name = "btnDodajPolozeni";
            this.btnDodajPolozeni.Size = new System.Drawing.Size(72, 23);
            this.btnDodajPolozeni.TabIndex = 4;
            this.btnDodajPolozeni.Text = "Dodaj";
            this.btnDodajPolozeni.UseVisualStyleBackColor = true;
            this.btnDodajPolozeni.Click += new System.EventHandler(this.btnDodajPolozeni_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblBrojZapisa,
            this.toolStripStatusLabel2,
            this.lblProsjek});
            this.statusStrip1.Location = new System.Drawing.Point(0, 262);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(551, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblBrojZapisa
            // 
            this.lblBrojZapisa.Name = "lblBrojZapisa";
            this.lblBrojZapisa.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel2.Text = " | ";
            // 
            // lblProsjek
            // 
            this.lblProsjek.Name = "lblProsjek";
            this.lblProsjek.Size = new System.Drawing.Size(0, 17);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(467, 231);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(72, 23);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Printaj";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmStudentiPredmeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 284);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnDodajPolozeni);
            this.Controls.Add(this.dtpDatumPolaganja);
            this.Controls.Add(this.cmbOcjene);
            this.Controls.Add(this.cmbPredmeti);
            this.Controls.Add(this.dgvPolozeniPredmeti);
            this.Name = "frmStudentiPredmeti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Položeni predmeti";
            this.Load += new System.EventHandler(this.frmStudentiPredmeti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolozeniPredmeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPolozeniPredmeti;
        private System.Windows.Forms.ComboBox cmbPredmeti;
        private System.Windows.Forms.ComboBox cmbOcjene;
        private System.Windows.Forms.DateTimePicker dtpDatumPolaganja;
        private System.Windows.Forms.Button btnDodajPolozeni;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblBrojZapisa;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblProsjek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.Button btnPrint;
    }
}