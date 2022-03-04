namespace cSharpIntroWinForms.IBBrojIndeksa
{
    partial class frmPretragaIBBrojIndeksa
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.dgvPredmet = new System.Windows.Forms.DataGridView();
            this.Poruke = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblProsjekOcjena = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblzracunataSuma = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSuma = new System.Windows.Forms.Button();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predmetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocjenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisniciPredmetiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredmet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciPredmetiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv predmeta: ";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(107, 13);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(528, 20);
            this.txtPretraga.TabIndex = 1;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // dgvPredmet
            // 
            this.dgvPredmet.AllowUserToAddRows = false;
            this.dgvPredmet.AllowUserToDeleteRows = false;
            this.dgvPredmet.AutoGenerateColumns = false;
            this.dgvPredmet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPredmet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.korisnikDataGridViewTextBoxColumn,
            this.predmetDataGridViewTextBoxColumn,
            this.ocjenaDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.Poruke});
            this.dgvPredmet.DataSource = this.korisniciPredmetiBindingSource;
            this.dgvPredmet.Location = new System.Drawing.Point(16, 50);
            this.dgvPredmet.Name = "dgvPredmet";
            this.dgvPredmet.ReadOnly = true;
            this.dgvPredmet.Size = new System.Drawing.Size(619, 205);
            this.dgvPredmet.TabIndex = 2;
            this.dgvPredmet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPredmet_CellContentClick);
            // 
            // Poruke
            // 
            this.Poruke.HeaderText = "Poruke";
            this.Poruke.Name = "Poruke";
            this.Poruke.ReadOnly = true;
            this.Poruke.Text = "Poruke";
            this.Poruke.ToolTipText = "Poruke";
            this.Poruke.UseColumnTextForButtonValue = true;
            // 
            // lblProsjekOcjena
            // 
            this.lblProsjekOcjena.AutoSize = true;
            this.lblProsjekOcjena.Location = new System.Drawing.Point(16, 278);
            this.lblProsjekOcjena.Name = "lblProsjekOcjena";
            this.lblProsjekOcjena.Size = new System.Drawing.Size(35, 13);
            this.lblProsjekOcjena.TabIndex = 3;
            this.lblProsjekOcjena.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblzracunataSuma);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSuma);
            this.groupBox1.Controls.Add(this.txtSuma);
            this.groupBox1.Location = new System.Drawing.Point(284, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 177);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Threading";
            // 
            // lblzracunataSuma
            // 
            this.lblzracunataSuma.AutoSize = true;
            this.lblzracunataSuma.Location = new System.Drawing.Point(6, 116);
            this.lblzracunataSuma.Name = "lblzracunataSuma";
            this.lblzracunataSuma.Size = new System.Drawing.Size(31, 13);
            this.lblzracunataSuma.TabIndex = 3;
            this.lblzracunataSuma.Text = "0000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Suma:";
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(250, 29);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 23);
            this.btnSuma.TabIndex = 1;
            this.btnSuma.Text = "Sumiraj";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(6, 31);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(226, 20);
            this.txtSuma.TabIndex = 0;
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            this.korisnikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // predmetDataGridViewTextBoxColumn
            // 
            this.predmetDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.predmetDataGridViewTextBoxColumn.DataPropertyName = "Predmet";
            this.predmetDataGridViewTextBoxColumn.HeaderText = "Predmet";
            this.predmetDataGridViewTextBoxColumn.Name = "predmetDataGridViewTextBoxColumn";
            this.predmetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ocjenaDataGridViewTextBoxColumn
            // 
            this.ocjenaDataGridViewTextBoxColumn.DataPropertyName = "Ocjena";
            this.ocjenaDataGridViewTextBoxColumn.HeaderText = "Ocjena";
            this.ocjenaDataGridViewTextBoxColumn.Name = "ocjenaDataGridViewTextBoxColumn";
            this.ocjenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // korisniciPredmetiBindingSource
            // 
            this.korisniciPredmetiBindingSource.DataSource = typeof(cSharpIntroWinForms.P10.KorisniciPredmeti);
            // 
            // frmPretragaIBBrojIndeksa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblProsjekOcjena);
            this.Controls.Add(this.dgvPredmet);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label1);
            this.Name = "frmPretragaIBBrojIndeksa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga";
            this.Load += new System.EventHandler(this.frmPretragaIBBrojIndeksa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredmet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciPredmetiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.DataGridView dgvPredmet;
        private System.Windows.Forms.Label lblProsjekOcjena;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblzracunataSuma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.BindingSource korisniciPredmetiBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn predmetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocjenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Poruke;
    }
}