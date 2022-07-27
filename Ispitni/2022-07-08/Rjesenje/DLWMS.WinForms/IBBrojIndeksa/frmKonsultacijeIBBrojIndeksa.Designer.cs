namespace DLWMS.WinForms.IBBrojIndeksa
{
    partial class frmKonsultacijeIBBrojIndeksa
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
            this.lblLista = new System.Windows.Forms.Label();
            this.dgvKonsultacije = new System.Windows.Forms.DataGridView();
            this.Brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDodajZahtjev = new System.Windows.Forms.Button();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPredmet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrojZahtjeva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.predmetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeOdrzavanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentKonsultacijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKonsultacije)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentKonsultacijeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(13, 18);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(35, 13);
            this.lblLista.TabIndex = 0;
            this.lblLista.Text = "label1";
            // 
            // dgvKonsultacije
            // 
            this.dgvKonsultacije.AllowUserToAddRows = false;
            this.dgvKonsultacije.AllowUserToDeleteRows = false;
            this.dgvKonsultacije.AutoGenerateColumns = false;
            this.dgvKonsultacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKonsultacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.predmetDataGridViewTextBoxColumn,
            this.vrijemeOdrzavanjaDataGridViewTextBoxColumn,
            this.napomenaDataGridViewTextBoxColumn,
            this.Brisi});
            this.dgvKonsultacije.DataSource = this.studentKonsultacijeBindingSource;
            this.dgvKonsultacije.Location = new System.Drawing.Point(16, 39);
            this.dgvKonsultacije.Name = "dgvKonsultacije";
            this.dgvKonsultacije.ReadOnly = true;
            this.dgvKonsultacije.Size = new System.Drawing.Size(772, 242);
            this.dgvKonsultacije.TabIndex = 1;
            this.dgvKonsultacije.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKonsultacije_CellContentClick);
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
            // btnDodajZahtjev
            // 
            this.btnDodajZahtjev.Location = new System.Drawing.Point(707, 13);
            this.btnDodajZahtjev.Name = "btnDodajZahtjev";
            this.btnDodajZahtjev.Size = new System.Drawing.Size(81, 23);
            this.btnDodajZahtjev.TabIndex = 2;
            this.btnDodajZahtjev.Text = "Dodaj zahtjev";
            this.btnDodajZahtjev.UseVisualStyleBackColor = true;
            this.btnDodajZahtjev.Click += new System.EventHandler(this.btnDodajZahtjev_Click);
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(727, 303);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(61, 23);
            this.btnPrintaj.TabIndex = 3;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.txtInfo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbPredmet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBrojZahtjeva);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 258);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(50, 142);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(81, 23);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj => ";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(162, 46);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(510, 189);
            this.txtInfo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Info:";
            // 
            // cmbPredmet
            // 
            this.cmbPredmet.FormattingEnabled = true;
            this.cmbPredmet.Location = new System.Drawing.Point(10, 97);
            this.cmbPredmet.Name = "cmbPredmet";
            this.cmbPredmet.Size = new System.Drawing.Size(121, 21);
            this.cmbPredmet.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Predmet: ";
            // 
            // txtBrojZahtjeva
            // 
            this.txtBrojZahtjeva.Location = new System.Drawing.Point(10, 46);
            this.txtBrojZahtjeva.Name = "txtBrojZahtjeva";
            this.txtBrojZahtjeva.Size = new System.Drawing.Size(100, 20);
            this.txtBrojZahtjeva.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj zahtjeva:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // predmetDataGridViewTextBoxColumn
            // 
            this.predmetDataGridViewTextBoxColumn.DataPropertyName = "Predmet";
            this.predmetDataGridViewTextBoxColumn.HeaderText = "Predmet";
            this.predmetDataGridViewTextBoxColumn.Name = "predmetDataGridViewTextBoxColumn";
            this.predmetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrijemeOdrzavanjaDataGridViewTextBoxColumn
            // 
            this.vrijemeOdrzavanjaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vrijemeOdrzavanjaDataGridViewTextBoxColumn.DataPropertyName = "VrijemeOdrzavanja";
            this.vrijemeOdrzavanjaDataGridViewTextBoxColumn.HeaderText = "VrijemeOdrzavanja";
            this.vrijemeOdrzavanjaDataGridViewTextBoxColumn.Name = "vrijemeOdrzavanjaDataGridViewTextBoxColumn";
            this.vrijemeOdrzavanjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // napomenaDataGridViewTextBoxColumn
            // 
            this.napomenaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.napomenaDataGridViewTextBoxColumn.DataPropertyName = "Napomena";
            this.napomenaDataGridViewTextBoxColumn.HeaderText = "Napomena";
            this.napomenaDataGridViewTextBoxColumn.Name = "napomenaDataGridViewTextBoxColumn";
            this.napomenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentKonsultacijeBindingSource
            // 
            this.studentKonsultacijeBindingSource.DataSource = typeof(DLWMS.WinForms.IBBrojIndeksa.StudentKonsultacije);
            // 
            // frmKonsultacijeIBBrojIndeksa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 578);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.btnDodajZahtjev);
            this.Controls.Add(this.dgvKonsultacije);
            this.Controls.Add(this.lblLista);
            this.Name = "frmKonsultacijeIBBrojIndeksa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKonsultacijeIBBrojIndeksa";
            this.Load += new System.EventHandler(this.frmKonsultacijeIBBrojIndeksa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKonsultacije)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentKonsultacijeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.DataGridView dgvKonsultacije;
        private System.Windows.Forms.Button btnDodajZahtjev;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPredmet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrojZahtjeva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn predmetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeOdrzavanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Brisi;
        private System.Windows.Forms.BindingSource studentKonsultacijeBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}