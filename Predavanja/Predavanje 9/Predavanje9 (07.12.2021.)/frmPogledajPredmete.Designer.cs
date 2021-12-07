
namespace Predavanje9__07._12._2021._
{
    partial class frmPogledajPredmete
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
            this.lblOcjena = new System.Windows.Forms.Label();
            this.lblPredmet = new System.Windows.Forms.Label();
            this.cmbOcjene = new System.Windows.Forms.ComboBox();
            this.dtpPolaganje = new System.Windows.Forms.DateTimePicker();
            this.lblDatumPolaganja = new System.Windows.Forms.Label();
            this.dgvPolozeniPredmeti = new System.Windows.Forms.DataGridView();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Godina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datumpolaganja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodajPredmet = new System.Windows.Forms.Button();
            this.cmbPredmeti = new System.Windows.Forms.ComboBox();
            this.errorPolozeniPredmeti = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolozeniPredmeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPolozeniPredmeti)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOcjena
            // 
            this.lblOcjena.AutoSize = true;
            this.lblOcjena.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOcjena.Location = new System.Drawing.Point(314, 48);
            this.lblOcjena.Name = "lblOcjena";
            this.lblOcjena.Size = new System.Drawing.Size(87, 26);
            this.lblOcjena.TabIndex = 6;
            this.lblOcjena.Text = "Ocjena:";
            // 
            // lblPredmet
            // 
            this.lblPredmet.AutoSize = true;
            this.lblPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPredmet.Location = new System.Drawing.Point(24, 47);
            this.lblPredmet.Name = "lblPredmet";
            this.lblPredmet.Size = new System.Drawing.Size(101, 26);
            this.lblPredmet.TabIndex = 4;
            this.lblPredmet.Text = "Predmet:";
            // 
            // cmbOcjene
            // 
            this.cmbOcjene.FormattingEnabled = true;
            this.cmbOcjene.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbOcjene.Location = new System.Drawing.Point(408, 51);
            this.cmbOcjene.Name = "cmbOcjene";
            this.cmbOcjene.Size = new System.Drawing.Size(121, 21);
            this.cmbOcjene.TabIndex = 7;
            // 
            // dtpPolaganje
            // 
            this.dtpPolaganje.Location = new System.Drawing.Point(724, 51);
            this.dtpPolaganje.Name = "dtpPolaganje";
            this.dtpPolaganje.Size = new System.Drawing.Size(133, 20);
            this.dtpPolaganje.TabIndex = 8;
            // 
            // lblDatumPolaganja
            // 
            this.lblDatumPolaganja.AutoSize = true;
            this.lblDatumPolaganja.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatumPolaganja.Location = new System.Drawing.Point(535, 47);
            this.lblDatumPolaganja.Name = "lblDatumPolaganja";
            this.lblDatumPolaganja.Size = new System.Drawing.Size(183, 26);
            this.lblDatumPolaganja.TabIndex = 9;
            this.lblDatumPolaganja.Text = "Datum polaganja:";
            // 
            // dgvPolozeniPredmeti
            // 
            this.dgvPolozeniPredmeti.AllowUserToAddRows = false;
            this.dgvPolozeniPredmeti.AllowUserToDeleteRows = false;
            this.dgvPolozeniPredmeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolozeniPredmeti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Predmet,
            this.Godina,
            this.Datumpolaganja});
            this.dgvPolozeniPredmeti.Location = new System.Drawing.Point(29, 98);
            this.dgvPolozeniPredmeti.Name = "dgvPolozeniPredmeti";
            this.dgvPolozeniPredmeti.ReadOnly = true;
            this.dgvPolozeniPredmeti.Size = new System.Drawing.Size(828, 202);
            this.dgvPolozeniPredmeti.TabIndex = 10;
            // 
            // Predmet
            // 
            this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            // 
            // Godina
            // 
            this.Godina.DataPropertyName = "Ocjena";
            this.Godina.HeaderText = "Ocjena";
            this.Godina.Name = "Godina";
            this.Godina.ReadOnly = true;
            // 
            // Datumpolaganja
            // 
            this.Datumpolaganja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datumpolaganja.DataPropertyName = "DatumPolaganja";
            this.Datumpolaganja.HeaderText = "Datum polaganja";
            this.Datumpolaganja.Name = "Datumpolaganja";
            this.Datumpolaganja.ReadOnly = true;
            // 
            // btnDodajPredmet
            // 
            this.btnDodajPredmet.Location = new System.Drawing.Point(782, 306);
            this.btnDodajPredmet.Name = "btnDodajPredmet";
            this.btnDodajPredmet.Size = new System.Drawing.Size(75, 23);
            this.btnDodajPredmet.TabIndex = 11;
            this.btnDodajPredmet.Text = "Dodaj";
            this.btnDodajPredmet.UseVisualStyleBackColor = true;
            this.btnDodajPredmet.Click += new System.EventHandler(this.btnDodajPredmet_Click);
            // 
            // cmbPredmeti
            // 
            this.cmbPredmeti.FormattingEnabled = true;
            this.cmbPredmeti.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV"});
            this.cmbPredmeti.Location = new System.Drawing.Point(131, 50);
            this.cmbPredmeti.Name = "cmbPredmeti";
            this.cmbPredmeti.Size = new System.Drawing.Size(177, 21);
            this.cmbPredmeti.TabIndex = 12;
            // 
            // errorPolozeniPredmeti
            // 
            this.errorPolozeniPredmeti.ContainerControl = this;
            // 
            // frmPogledajPredmete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 335);
            this.Controls.Add(this.cmbPredmeti);
            this.Controls.Add(this.btnDodajPredmet);
            this.Controls.Add(this.dgvPolozeniPredmeti);
            this.Controls.Add(this.dtpPolaganje);
            this.Controls.Add(this.lblDatumPolaganja);
            this.Controls.Add(this.cmbOcjene);
            this.Controls.Add(this.lblOcjena);
            this.Controls.Add(this.lblPredmet);
            this.Name = "frmPogledajPredmete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPogledajPredmete";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolozeniPredmeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPolozeniPredmeti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblOcjena;
        private System.Windows.Forms.Label lblPredmet;
        private System.Windows.Forms.ComboBox cmbOcjene;
        private System.Windows.Forms.DateTimePicker dtpPolaganje;
        private System.Windows.Forms.Label lblDatumPolaganja;
        private System.Windows.Forms.DataGridView dgvPolozeniPredmeti;
        private System.Windows.Forms.Button btnDodajPredmet;
        private System.Windows.Forms.ComboBox cmbPredmeti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Godina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datumpolaganja;
        private System.Windows.Forms.ErrorProvider errorPolozeniPredmeti;
    }
}