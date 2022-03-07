namespace DLWMS.WinForms.IBBrojIndeksa
{
    partial class frmCovidTestIBBrojIndeksa
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
            this.dtpDatumTestiranja = new System.Windows.Forms.DateTimePicker();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cbNalaz = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRezultatTesta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTest = new System.Windows.Forms.DataGridView();
            this.lblBrojTestova = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGenerisi = new System.Windows.Forms.TextBox();
            this.btnGenerisi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTestove = new System.Windows.Forms.Button();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.studentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezultatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nalazDostavljenDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.studentiCovidTestoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentiCovidTestoviBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDatumTestiranja
            // 
            this.dtpDatumTestiranja.Location = new System.Drawing.Point(164, 31);
            this.dtpDatumTestiranja.Name = "dtpDatumTestiranja";
            this.dtpDatumTestiranja.Size = new System.Drawing.Size(186, 20);
            this.dtpDatumTestiranja.TabIndex = 0;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(641, 32);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cbNalaz
            // 
            this.cbNalaz.AutoSize = true;
            this.cbNalaz.Location = new System.Drawing.Point(502, 32);
            this.cbNalaz.Name = "cbNalaz";
            this.cbNalaz.Size = new System.Drawing.Size(104, 17);
            this.cbNalaz.TabIndex = 2;
            this.cbNalaz.Text = "Nalaz dostavljen";
            this.cbNalaz.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student: ";
            // 
            // cmbStudent
            // 
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(16, 30);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(121, 21);
            this.cmbStudent.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Datum testiranja:";
            // 
            // cmbRezultatTesta
            // 
            this.cmbRezultatTesta.FormattingEnabled = true;
            this.cmbRezultatTesta.Items.AddRange(new object[] {
            "Pozitivan",
            "Negativan"});
            this.cmbRezultatTesta.Location = new System.Drawing.Point(382, 31);
            this.cmbRezultatTesta.Name = "cmbRezultatTesta";
            this.cmbRezultatTesta.Size = new System.Drawing.Size(100, 21);
            this.cmbRezultatTesta.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rezultat testa:";
            // 
            // dgvTest
            // 
            this.dgvTest.AllowUserToAddRows = false;
            this.dgvTest.AllowUserToDeleteRows = false;
            this.dgvTest.AutoGenerateColumns = false;
            this.dgvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.rezultatDataGridViewTextBoxColumn,
            this.nalazDostavljenDataGridViewCheckBoxColumn});
            this.dgvTest.DataSource = this.studentiCovidTestoviBindingSource;
            this.dgvTest.Location = new System.Drawing.Point(16, 66);
            this.dgvTest.Name = "dgvTest";
            this.dgvTest.ReadOnly = true;
            this.dgvTest.Size = new System.Drawing.Size(700, 292);
            this.dgvTest.TabIndex = 8;
            // 
            // lblBrojTestova
            // 
            this.lblBrojTestova.AutoSize = true;
            this.lblBrojTestova.Location = new System.Drawing.Point(16, 395);
            this.lblBrojTestova.Name = "lblBrojTestova";
            this.lblBrojTestova.Size = new System.Drawing.Size(69, 13);
            this.lblBrojTestova.TabIndex = 9;
            this.lblBrojTestova.Text = "Broj testova: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerisi);
            this.groupBox1.Controls.Add(this.txtGenerisi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(142, 364);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 74);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generisanje testova";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Broj testova:";
            // 
            // txtGenerisi
            // 
            this.txtGenerisi.Location = new System.Drawing.Point(80, 31);
            this.txtGenerisi.Name = "txtGenerisi";
            this.txtGenerisi.Size = new System.Drawing.Size(84, 20);
            this.txtGenerisi.TabIndex = 1;
            // 
            // btnGenerisi
            // 
            this.btnGenerisi.Location = new System.Drawing.Point(170, 28);
            this.btnGenerisi.Name = "btnGenerisi";
            this.btnGenerisi.Size = new System.Drawing.Size(74, 23);
            this.btnGenerisi.TabIndex = 2;
            this.btnGenerisi.Text = "Generisi";
            this.btnGenerisi.UseVisualStyleBackColor = true;
            this.btnGenerisi.Click += new System.EventHandler(this.btnGenerisi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTestove);
            this.groupBox2.Location = new System.Drawing.Point(409, 364);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 74);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Brisanje testova";
            // 
            // btnTestove
            // 
            this.btnTestove.Location = new System.Drawing.Point(17, 29);
            this.btnTestove.Name = "btnTestove";
            this.btnTestove.Size = new System.Drawing.Size(119, 23);
            this.btnTestove.TabIndex = 0;
            this.btnTestove.Text = "OBRISI TESTOVE";
            this.btnTestove.UseVisualStyleBackColor = true;
            this.btnTestove.Click += new System.EventHandler(this.btnTestove_Click);
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(615, 395);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(75, 23);
            this.btnPrintaj.TabIndex = 12;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // studentDataGridViewTextBoxColumn
            // 
            this.studentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentDataGridViewTextBoxColumn.DataPropertyName = "Student";
            this.studentDataGridViewTextBoxColumn.HeaderText = "Student";
            this.studentDataGridViewTextBoxColumn.Name = "studentDataGridViewTextBoxColumn";
            this.studentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rezultatDataGridViewTextBoxColumn
            // 
            this.rezultatDataGridViewTextBoxColumn.DataPropertyName = "Rezultat";
            this.rezultatDataGridViewTextBoxColumn.HeaderText = "Rezultat";
            this.rezultatDataGridViewTextBoxColumn.Name = "rezultatDataGridViewTextBoxColumn";
            this.rezultatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nalazDostavljenDataGridViewCheckBoxColumn
            // 
            this.nalazDostavljenDataGridViewCheckBoxColumn.DataPropertyName = "NalazDostavljen";
            this.nalazDostavljenDataGridViewCheckBoxColumn.HeaderText = "NalazDostavljen";
            this.nalazDostavljenDataGridViewCheckBoxColumn.Name = "nalazDostavljenDataGridViewCheckBoxColumn";
            this.nalazDostavljenDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // studentiCovidTestoviBindingSource
            // 
            this.studentiCovidTestoviBindingSource.DataSource = typeof(DLWMS.WinForms.IBBrojIndeksa.StudentiCovidTestovi);
            // 
            // frmCovidTestIBBrojIndeksa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBrojTestova);
            this.Controls.Add(this.dgvTest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbRezultatTesta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNalaz);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dtpDatumTestiranja);
            this.Name = "frmCovidTestIBBrojIndeksa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezultati COVID testiranja";
            this.Load += new System.EventHandler(this.frmCovidTestIBBrojIndeksa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentiCovidTestoviBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDatumTestiranja;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.CheckBox cbNalaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRezultatTesta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTest;
        private System.Windows.Forms.Label lblBrojTestova;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerisi;
        private System.Windows.Forms.TextBox txtGenerisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTestove;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.BindingSource studentiCovidTestoviBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezultatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn nalazDostavljenDataGridViewCheckBoxColumn;
    }
}