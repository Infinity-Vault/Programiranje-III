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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPredmet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGodinaStudija = new System.Windows.Forms.ComboBox();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prosjek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Konsultacije = new System.Windows.Forms.DataGridViewButtonColumn();
            this.godinaStudijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
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
            this.label1.Text = "Ime ili prezime: ";
            // 
            // txtPredmet
            // 
            this.txtPredmet.Location = new System.Drawing.Point(95, 10);
            this.txtPredmet.Name = "txtPredmet";
            this.txtPredmet.Size = new System.Drawing.Size(423, 20);
            this.txtPredmet.TabIndex = 1;
            this.txtPredmet.TextChanged += new System.EventHandler(this.txtPredmet_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Godina studija:";
            // 
            // cmbGodinaStudija
            // 
            this.cmbGodinaStudija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGodinaStudija.FormattingEnabled = true;
            this.cmbGodinaStudija.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbGodinaStudija.Location = new System.Drawing.Point(608, 13);
            this.cmbGodinaStudija.Name = "cmbGodinaStudija";
            this.cmbGodinaStudija.Size = new System.Drawing.Size(133, 21);
            this.cmbGodinaStudija.TabIndex = 3;
            this.cmbGodinaStudija.SelectedIndexChanged += new System.EventHandler(this.cmbGodinaStudija_SelectedIndexChanged);
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.AutoGenerateColumns = false;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezime,
            this.godinaStudijaDataGridViewTextBoxColumn,
            this.Prosjek,
            this.Konsultacije});
            this.dgvStudent.DataSource = this.studentBindingSource;
            this.dgvStudent.Location = new System.Drawing.Point(16, 47);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.Size = new System.Drawing.Size(725, 221);
            this.dgvStudent.TabIndex = 4;
            this.dgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellContentClick);
            // 
            // ImePrezime
            // 
            this.ImePrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImePrezime.DataPropertyName = "ImePrezime";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ImePrezime.DefaultCellStyle = dataGridViewCellStyle1;
            this.ImePrezime.HeaderText = "Ime Prezime";
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            // 
            // Prosjek
            // 
            this.Prosjek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prosjek.DataPropertyName = "Prosjek";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Prosjek.DefaultCellStyle = dataGridViewCellStyle3;
            this.Prosjek.HeaderText = "Prosjek";
            this.Prosjek.Name = "Prosjek";
            this.Prosjek.ReadOnly = true;
            // 
            // Konsultacije
            // 
            this.Konsultacije.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Konsultacije.HeaderText = "Konsultacije";
            this.Konsultacije.Name = "Konsultacije";
            this.Konsultacije.ReadOnly = true;
            this.Konsultacije.Text = "Konsultacije";
            this.Konsultacije.ToolTipText = "Konsultacije";
            this.Konsultacije.UseColumnTextForButtonValue = true;
            // 
            // godinaStudijaDataGridViewTextBoxColumn
            // 
            this.godinaStudijaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.godinaStudijaDataGridViewTextBoxColumn.DataPropertyName = "GodinaStudija";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.godinaStudijaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.godinaStudijaDataGridViewTextBoxColumn.HeaderText = "GodinaStudija";
            this.godinaStudijaDataGridViewTextBoxColumn.Name = "godinaStudijaDataGridViewTextBoxColumn";
            this.godinaStudijaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(DLWMS.WinForms.Student);
            // 
            // frmPretragaIBBrojIndeksa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 286);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.cmbGodinaStudija);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPredmet);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(770, 325);
            this.MinimumSize = new System.Drawing.Size(770, 325);
            this.Name = "frmPretragaIBBrojIndeksa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga studenta";
            this.Load += new System.EventHandler(this.frmPretragaIBBrojIndeksa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPredmet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGodinaStudija;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn godinaStudijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prosjek;
        private System.Windows.Forms.DataGridViewButtonColumn Konsultacije;
    }
}