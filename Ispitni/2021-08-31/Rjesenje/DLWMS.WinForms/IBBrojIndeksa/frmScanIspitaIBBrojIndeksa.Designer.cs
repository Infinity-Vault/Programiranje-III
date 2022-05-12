namespace DLWMS.WinForms.IBBrojIndeksa
{
    partial class frmScanIspitaIBBrojIndeksa
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
            this.lblStudent = new System.Windows.Forms.Label();
            this.dgvIspiti = new System.Windows.Forms.DataGridView();
            this.Brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.btnDodajScanIspita = new System.Windows.Forms.Button();
            this.predmetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slikaDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.varanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.studentiIspitiScanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIspiti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiIspitiScanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pregled ispita za studenta :";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(153, 12);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(66, 24);
            this.lblStudent.TabIndex = 1;
            this.lblStudent.Text = "label2";
            // 
            // dgvIspiti
            // 
            this.dgvIspiti.AllowUserToAddRows = false;
            this.dgvIspiti.AllowUserToDeleteRows = false;
            this.dgvIspiti.AutoGenerateColumns = false;
            this.dgvIspiti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIspiti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.predmetDataGridViewTextBoxColumn,
            this.napomenaDataGridViewTextBoxColumn,
            this.slikaDataGridViewImageColumn,
            this.varanjeDataGridViewTextBoxColumn,
            this.Brisi});
            this.dgvIspiti.DataSource = this.studentiIspitiScanBindingSource;
            this.dgvIspiti.Location = new System.Drawing.Point(15, 56);
            this.dgvIspiti.Name = "dgvIspiti";
            this.dgvIspiti.ReadOnly = true;
            this.dgvIspiti.Size = new System.Drawing.Size(773, 237);
            this.dgvIspiti.TabIndex = 2;
            this.dgvIspiti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIspiti_CellContentClick);
            this.dgvIspiti.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIspiti_CellDoubleClick);
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
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(713, 312);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(75, 23);
            this.btnPrintaj.TabIndex = 3;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // btnDodajScanIspita
            // 
            this.btnDodajScanIspita.Location = new System.Drawing.Point(690, 27);
            this.btnDodajScanIspita.Name = "btnDodajScanIspita";
            this.btnDodajScanIspita.Size = new System.Drawing.Size(98, 23);
            this.btnDodajScanIspita.TabIndex = 4;
            this.btnDodajScanIspita.Text = "Dodaj scan ispita";
            this.btnDodajScanIspita.UseVisualStyleBackColor = true;
            this.btnDodajScanIspita.Click += new System.EventHandler(this.btnDodajScanIspita_Click);
            // 
            // predmetDataGridViewTextBoxColumn
            // 
            this.predmetDataGridViewTextBoxColumn.DataPropertyName = "Predmet";
            this.predmetDataGridViewTextBoxColumn.HeaderText = "Predmet";
            this.predmetDataGridViewTextBoxColumn.Name = "predmetDataGridViewTextBoxColumn";
            this.predmetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // napomenaDataGridViewTextBoxColumn
            // 
            this.napomenaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.napomenaDataGridViewTextBoxColumn.DataPropertyName = "Napomena";
            this.napomenaDataGridViewTextBoxColumn.HeaderText = "Napomena";
            this.napomenaDataGridViewTextBoxColumn.Name = "napomenaDataGridViewTextBoxColumn";
            this.napomenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // slikaDataGridViewImageColumn
            // 
            this.slikaDataGridViewImageColumn.DataPropertyName = "Slika";
            this.slikaDataGridViewImageColumn.HeaderText = "Scan ispita";
            this.slikaDataGridViewImageColumn.Name = "slikaDataGridViewImageColumn";
            this.slikaDataGridViewImageColumn.ReadOnly = true;
            // 
            // varanjeDataGridViewTextBoxColumn
            // 
            this.varanjeDataGridViewTextBoxColumn.DataPropertyName = "Varanje";
            this.varanjeDataGridViewTextBoxColumn.HeaderText = "Varanje";
            this.varanjeDataGridViewTextBoxColumn.Name = "varanjeDataGridViewTextBoxColumn";
            this.varanjeDataGridViewTextBoxColumn.ReadOnly = true;
            this.varanjeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.varanjeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // studentiIspitiScanBindingSource
            // 
            this.studentiIspitiScanBindingSource.DataSource = typeof(DLWMS.WinForms.IBBrojIndeksa.StudentiIspitiScan);
            // 
            // frmScanIspitaIBBrojIndeksa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 352);
            this.Controls.Add(this.btnDodajScanIspita);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.dgvIspiti);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.label1);
            this.Name = "frmScanIspitaIBBrojIndeksa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStudentiIspiti";
            this.Load += new System.EventHandler(this.frmScanIspitaIBBrojIndeksa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIspiti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiIspitiScanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.DataGridView dgvIspiti;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.Button btnDodajScanIspita;
        private System.Windows.Forms.BindingSource studentiIspitiScanBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn predmetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn slikaDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn varanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Brisi;
    }
}