namespace DLWMS.WinForms.IBBrojIndeksa
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
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.Ispiti = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblProsjek = new System.Windows.Forms.Label();
            this.lblNajveciProsjek = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblZnakovi = new System.Windows.Forms.Label();
            this.lblSuglasnici = new System.Windows.Forms.Label();
            this.lblSamoglasnici = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerisi = new System.Windows.Forms.Button();
            this.txtSadrzaj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imePrezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polozenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojPolozenihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prosjekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime ili prezime :";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(98, 13);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(760, 20);
            this.txtPretraga.TabIndex = 1;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.AutoGenerateColumns = false;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imePrezimeDataGridViewTextBoxColumn,
            this.polozenDataGridViewTextBoxColumn,
            this.brojPolozenihDataGridViewTextBoxColumn,
            this.prosjekDataGridViewTextBoxColumn,
            this.Ispiti});
            this.dgvStudent.DataSource = this.studentBindingSource;
            this.dgvStudent.Location = new System.Drawing.Point(16, 44);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.Size = new System.Drawing.Size(842, 204);
            this.dgvStudent.TabIndex = 2;
            this.dgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellContentClick);
            // 
            // Ispiti
            // 
            this.Ispiti.HeaderText = "Ispiti";
            this.Ispiti.Name = "Ispiti";
            this.Ispiti.ReadOnly = true;
            this.Ispiti.Text = "Ispiti";
            this.Ispiti.ToolTipText = "Ispiti";
            this.Ispiti.UseColumnTextForButtonValue = true;
            // 
            // lblProsjek
            // 
            this.lblProsjek.AutoSize = true;
            this.lblProsjek.Location = new System.Drawing.Point(13, 255);
            this.lblProsjek.Name = "lblProsjek";
            this.lblProsjek.Size = new System.Drawing.Size(152, 13);
            this.lblProsjek.TabIndex = 3;
            this.lblProsjek.Text = "Prosjek prikazanih ocjena : 0.0";
            // 
            // lblNajveciProsjek
            // 
            this.lblNajveciProsjek.AutoSize = true;
            this.lblNajveciProsjek.Location = new System.Drawing.Point(603, 255);
            this.lblNajveciProsjek.Name = "lblNajveciProsjek";
            this.lblNajveciProsjek.Size = new System.Drawing.Size(126, 13);
            this.lblNajveciProsjek.TabIndex = 4;
            this.lblNajveciProsjek.Text = "Najveci prosjek ostvario :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblZnakovi);
            this.groupBox1.Controls.Add(this.lblSuglasnici);
            this.groupBox1.Controls.Add(this.lblSamoglasnici);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnGenerisi);
            this.groupBox1.Controls.Add(this.txtSadrzaj);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 247);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Threading";
            // 
            // lblZnakovi
            // 
            this.lblZnakovi.AutoSize = true;
            this.lblZnakovi.Location = new System.Drawing.Point(63, 194);
            this.lblZnakovi.Name = "lblZnakovi";
            this.lblZnakovi.Size = new System.Drawing.Size(52, 13);
            this.lblZnakovi.TabIndex = 6;
            this.lblZnakovi.Text = "Znakovi :";
            // 
            // lblSuglasnici
            // 
            this.lblSuglasnici.AutoSize = true;
            this.lblSuglasnici.Location = new System.Drawing.Point(63, 172);
            this.lblSuglasnici.Name = "lblSuglasnici";
            this.lblSuglasnici.Size = new System.Drawing.Size(61, 13);
            this.lblSuglasnici.TabIndex = 5;
            this.lblSuglasnici.Text = "Suglasnici :";
            // 
            // lblSamoglasnici
            // 
            this.lblSamoglasnici.AutoSize = true;
            this.lblSamoglasnici.Location = new System.Drawing.Point(63, 151);
            this.lblSamoglasnici.Name = "lblSamoglasnici";
            this.lblSamoglasnici.Size = new System.Drawing.Size(75, 13);
            this.lblSamoglasnici.TabIndex = 4;
            this.lblSamoglasnici.Text = "Samoglasnici :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sadrzaj :";
            // 
            // btnGenerisi
            // 
            this.btnGenerisi.Location = new System.Drawing.Point(741, 141);
            this.btnGenerisi.Name = "btnGenerisi";
            this.btnGenerisi.Size = new System.Drawing.Size(75, 23);
            this.btnGenerisi.TabIndex = 2;
            this.btnGenerisi.Text = "Generi info";
            this.btnGenerisi.UseVisualStyleBackColor = true;
            this.btnGenerisi.Click += new System.EventHandler(this.btnGenerisi_Click);
            // 
            // txtSadrzaj
            // 
            this.txtSadrzaj.Location = new System.Drawing.Point(9, 32);
            this.txtSadrzaj.Multiline = true;
            this.txtSadrzaj.Name = "txtSadrzaj";
            this.txtSadrzaj.Size = new System.Drawing.Size(807, 103);
            this.txtSadrzaj.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Unesite sadrzaj :";
            // 
            // imePrezimeDataGridViewTextBoxColumn
            // 
            this.imePrezimeDataGridViewTextBoxColumn.DataPropertyName = "ImePrezime";
            this.imePrezimeDataGridViewTextBoxColumn.HeaderText = "Ime i prezime";
            this.imePrezimeDataGridViewTextBoxColumn.Name = "imePrezimeDataGridViewTextBoxColumn";
            this.imePrezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // polozenDataGridViewTextBoxColumn
            // 
            this.polozenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.polozenDataGridViewTextBoxColumn.DataPropertyName = "Polozen";
            this.polozenDataGridViewTextBoxColumn.HeaderText = "Polozen";
            this.polozenDataGridViewTextBoxColumn.Name = "polozenDataGridViewTextBoxColumn";
            this.polozenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brojPolozenihDataGridViewTextBoxColumn
            // 
            this.brojPolozenihDataGridViewTextBoxColumn.DataPropertyName = "BrojPolozenih";
            this.brojPolozenihDataGridViewTextBoxColumn.HeaderText = "BrojPolozenih";
            this.brojPolozenihDataGridViewTextBoxColumn.Name = "brojPolozenihDataGridViewTextBoxColumn";
            this.brojPolozenihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prosjekDataGridViewTextBoxColumn
            // 
            this.prosjekDataGridViewTextBoxColumn.DataPropertyName = "Prosjek";
            this.prosjekDataGridViewTextBoxColumn.HeaderText = "Prosjek";
            this.prosjekDataGridViewTextBoxColumn.Name = "prosjekDataGridViewTextBoxColumn";
            this.prosjekDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(DLWMS.WinForms.Entiteti.Student);
            // 
            // frmPretragaIBBrojIndeksa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 545);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNajveciProsjek);
            this.Controls.Add(this.lblProsjek);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label1);
            this.Name = "frmPretragaIBBrojIndeksa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga";
            this.Load += new System.EventHandler(this.frmPretragaIBBrojIndeksa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Label lblProsjek;
        private System.Windows.Forms.Label lblNajveciProsjek;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblZnakovi;
        private System.Windows.Forms.Label lblSuglasnici;
        private System.Windows.Forms.Label lblSamoglasnici;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerisi;
        private System.Windows.Forms.TextBox txtSadrzaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn imePrezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polozenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojPolozenihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prosjekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Ispiti;
        private System.Windows.Forms.BindingSource studentBindingSource;
    }
}