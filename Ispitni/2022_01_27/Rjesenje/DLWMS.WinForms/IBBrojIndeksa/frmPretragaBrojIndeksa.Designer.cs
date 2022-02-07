
namespace DLWMS.WinForms.IBBrojIndeksa
{
    partial class frmPretragaBrojIndeksa
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
            this.txtPredmet = new System.Windows.Forms.TextBox();
            this.dgvPredmet = new System.Windows.Forms.DataGridView();
            this.BrisiPredmet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Slike = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.txtDO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.btnTeorija = new System.Windows.Forms.Button();
            this.studentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predmetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocjenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumPolaganjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentiPredmetiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredmet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentiPredmetiBindingSource)).BeginInit();
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
            // txtPredmet
            // 
            this.txtPredmet.Location = new System.Drawing.Point(98, 13);
            this.txtPredmet.Name = "txtPredmet";
            this.txtPredmet.Size = new System.Drawing.Size(668, 20);
            this.txtPredmet.TabIndex = 1;
            this.txtPredmet.TextChanged += new System.EventHandler(this.txtPredmet_TextChanged);
            // 
            // dgvPredmet
            // 
            this.dgvPredmet.AutoGenerateColumns = false;
            this.dgvPredmet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPredmet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentDataGridViewTextBoxColumn,
            this.predmetDataGridViewTextBoxColumn,
            this.ocjenaDataGridViewTextBoxColumn,
            this.datumPolaganjaDataGridViewTextBoxColumn,
            this.BrisiPredmet,
            this.Slike});
            this.dgvPredmet.DataSource = this.studentiPredmetiBindingSource;
            this.dgvPredmet.Location = new System.Drawing.Point(16, 39);
            this.dgvPredmet.Name = "dgvPredmet";
            this.dgvPredmet.Size = new System.Drawing.Size(750, 218);
            this.dgvPredmet.TabIndex = 2;
            this.dgvPredmet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPredmet_CellContentClick);
            // 
            // BrisiPredmet
            // 
            this.BrisiPredmet.HeaderText = "Brisi Predmet";
            this.BrisiPredmet.Name = "BrisiPredmet";
            this.BrisiPredmet.Text = "Brisi predmet";
            this.BrisiPredmet.ToolTipText = "Brisi predmet";
            this.BrisiPredmet.UseColumnTextForButtonValue = true;
            // 
            // Slike
            // 
            this.Slike.HeaderText = "Slike";
            this.Slike.Name = "Slike";
            this.Slike.Text = "Slike";
            this.Slike.ToolTipText = "Slike";
            this.Slike.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSuma);
            this.groupBox1.Controls.Add(this.btnSuma);
            this.groupBox1.Controls.Add(this.txtDO);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtOD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 137);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sumiraj brojeve";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Suma:";
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(298, 56);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(100, 20);
            this.txtSuma.TabIndex = 5;
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(207, 53);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 23);
            this.btnSuma.TabIndex = 4;
            this.btnSuma.Text = "Sumiraj =>";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // txtDO
            // 
            this.txtDO.Location = new System.Drawing.Point(101, 57);
            this.txtDO.Name = "txtDO";
            this.txtDO.Size = new System.Drawing.Size(89, 20);
            this.txtDO.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Do:";
            // 
            // txtOD
            // 
            this.txtOD.Location = new System.Drawing.Point(10, 57);
            this.txtOD.Name = "txtOD";
            this.txtOD.Size = new System.Drawing.Size(63, 20);
            this.txtOD.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Od:";
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(691, 273);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(75, 23);
            this.btnPrintaj.TabIndex = 4;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // btnTeorija
            // 
            this.btnTeorija.Location = new System.Drawing.Point(691, 361);
            this.btnTeorija.Name = "btnTeorija";
            this.btnTeorija.Size = new System.Drawing.Size(75, 23);
            this.btnTeorija.TabIndex = 5;
            this.btnTeorija.Text = "Teorija";
            this.btnTeorija.UseVisualStyleBackColor = true;
            this.btnTeorija.Click += new System.EventHandler(this.btnTeorija_Click);
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
            this.ocjenaDataGridViewTextBoxColumn.DataPropertyName = "Ocjena";
            this.ocjenaDataGridViewTextBoxColumn.HeaderText = "Ocjena";
            this.ocjenaDataGridViewTextBoxColumn.Name = "ocjenaDataGridViewTextBoxColumn";
            // 
            // datumPolaganjaDataGridViewTextBoxColumn
            // 
            this.datumPolaganjaDataGridViewTextBoxColumn.DataPropertyName = "DatumPolaganja";
            this.datumPolaganjaDataGridViewTextBoxColumn.HeaderText = "DatumPolaganja";
            this.datumPolaganjaDataGridViewTextBoxColumn.Name = "datumPolaganjaDataGridViewTextBoxColumn";
            // 
            // studentiPredmetiBindingSource
            // 
            this.studentiPredmetiBindingSource.DataSource = typeof(DLWMS.WinForms.IBBrojIndeksa.StudentiPredmeti);
            // 
            // frmPretragaBrojIndeksa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 450);
            this.Controls.Add(this.btnTeorija);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPredmet);
            this.Controls.Add(this.txtPredmet);
            this.Controls.Add(this.label1);
            this.Name = "frmPretragaBrojIndeksa";
            this.Text = "frmPretragaBrojIndeksa";
            this.Load += new System.EventHandler(this.frmPretragaBrojIndeksa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredmet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentiPredmetiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPredmet;
        private System.Windows.Forms.DataGridView dgvPredmet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.TextBox txtDO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.Button btnTeorija;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn predmetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocjenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumPolaganjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn BrisiPredmet;
        private System.Windows.Forms.DataGridViewButtonColumn Slike;
        private System.Windows.Forms.BindingSource studentiPredmetiBindingSource;
    }
}