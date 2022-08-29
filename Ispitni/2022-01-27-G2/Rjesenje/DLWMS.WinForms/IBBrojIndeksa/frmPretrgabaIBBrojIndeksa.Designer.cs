
namespace DLWMS.WinForms.IBBrojIndeksa
{
    partial class frmPretrgabaIBBrojIndeksa
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
            this.cmbOcjena = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOcjena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.btnTeorija = new System.Windows.Forms.Button();
            this.dgvOcjena = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predmetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocjenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumPolaganjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seminarski = new System.Windows.Forms.DataGridViewButtonColumn();
            this.studentiPredmetiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPretraga = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcjena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiPredmetiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maksimalna ocjena: ";
            // 
            // cmbOcjena
            // 
            this.cmbOcjena.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOcjena.FormattingEnabled = true;
            this.cmbOcjena.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbOcjena.Location = new System.Drawing.Point(123, 10);
            this.cmbOcjena.Name = "cmbOcjena";
            this.cmbOcjena.Size = new System.Drawing.Size(121, 21);
            this.cmbOcjena.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.txtInfo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbStudent);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtOcjena);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 169);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje polozenih";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(53, 133);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj =>";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(185, 35);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(334, 121);
            this.txtInfo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Info:";
            // 
            // cmbStudent
            // 
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(10, 98);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(118, 21);
            this.cmbStudent.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student:";
            // 
            // txtOcjena
            // 
            this.txtOcjena.Location = new System.Drawing.Point(10, 36);
            this.txtOcjena.Name = "txtOcjena";
            this.txtOcjena.Size = new System.Drawing.Size(118, 20);
            this.txtOcjena.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Broj ocjena: ";
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(618, 269);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(75, 23);
            this.btnPrintaj.TabIndex = 4;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // btnTeorija
            // 
            this.btnTeorija.Location = new System.Drawing.Point(618, 326);
            this.btnTeorija.Name = "btnTeorija";
            this.btnTeorija.Size = new System.Drawing.Size(75, 23);
            this.btnTeorija.TabIndex = 5;
            this.btnTeorija.Text = "Teorija";
            this.btnTeorija.UseVisualStyleBackColor = true;
            this.btnTeorija.Click += new System.EventHandler(this.btnTeorija_Click);
            // 
            // dgvOcjena
            // 
            this.dgvOcjena.AutoGenerateColumns = false;
            this.dgvOcjena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOcjena.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.studentDataGridViewTextBoxColumn,
            this.predmetDataGridViewTextBoxColumn,
            this.ocjenaDataGridViewTextBoxColumn,
            this.datumPolaganjaDataGridViewTextBoxColumn,
            this.Seminarski});
            this.dgvOcjena.DataSource = this.studentiPredmetiBindingSource;
            this.dgvOcjena.Location = new System.Drawing.Point(16, 37);
            this.dgvOcjena.Name = "dgvOcjena";
            this.dgvOcjena.Size = new System.Drawing.Size(677, 194);
            this.dgvOcjena.TabIndex = 6;
            this.dgvOcjena.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOcjena_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Rb";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // studentDataGridViewTextBoxColumn
            // 
            this.studentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentDataGridViewTextBoxColumn.DataPropertyName = "Student";
            this.studentDataGridViewTextBoxColumn.HeaderText = "Ime prezime";
            this.studentDataGridViewTextBoxColumn.Name = "studentDataGridViewTextBoxColumn";
            // 
            // predmetDataGridViewTextBoxColumn
            // 
            this.predmetDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.predmetDataGridViewTextBoxColumn.DataPropertyName = "Predmet";
            this.predmetDataGridViewTextBoxColumn.HeaderText = "Predmet";
            this.predmetDataGridViewTextBoxColumn.Name = "predmetDataGridViewTextBoxColumn";
            // 
            // ocjenaDataGridViewTextBoxColumn
            // 
            this.ocjenaDataGridViewTextBoxColumn.DataPropertyName = "ocjena";
            this.ocjenaDataGridViewTextBoxColumn.HeaderText = "Ocjena";
            this.ocjenaDataGridViewTextBoxColumn.Name = "ocjenaDataGridViewTextBoxColumn";
            // 
            // datumPolaganjaDataGridViewTextBoxColumn
            // 
            this.datumPolaganjaDataGridViewTextBoxColumn.DataPropertyName = "DatumPolaganja";
            this.datumPolaganjaDataGridViewTextBoxColumn.HeaderText = "DatumPolaganja";
            this.datumPolaganjaDataGridViewTextBoxColumn.Name = "datumPolaganjaDataGridViewTextBoxColumn";
            // 
            // Seminarski
            // 
            this.Seminarski.HeaderText = "Seminarski";
            this.Seminarski.Name = "Seminarski";
            this.Seminarski.Text = "Seminarski";
            this.Seminarski.ToolTipText = "Seminarski";
            this.Seminarski.UseColumnTextForButtonValue = true;
            // 
            // studentiPredmetiBindingSource
            // 
            this.studentiPredmetiBindingSource.DataSource = typeof(DLWMS.WinForms.IBBrojIndeksa.StudentiPredmeti);
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(268, 7);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga.TabIndex = 7;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // frmPretrgabaIBBrojIndeksa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.dgvOcjena);
            this.Controls.Add(this.btnTeorija);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbOcjena);
            this.Controls.Add(this.label1);
            this.Name = "frmPretrgabaIBBrojIndeksa";
            this.Text = "frmPretrgabaIBBrojIndeksa";
            this.Load += new System.EventHandler(this.frmPretrgabaIBBrojIndeksa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcjena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiPredmetiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOcjena;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOcjena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.Button btnTeorija;
        private System.Windows.Forms.DataGridView dgvOcjena;
        private System.Windows.Forms.BindingSource studentiPredmetiBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn predmetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocjenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumPolaganjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Seminarski;
        private System.Windows.Forms.Button btnPretraga;
    }
}