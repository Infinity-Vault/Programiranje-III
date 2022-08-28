
namespace DLWMS.WinForms.IBBrojIndeksa
{
    partial class frmSeminarskiIBBrojIndeksa
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
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblPredmet = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbDodaj = new System.Windows.Forms.PictureBox();
            this.Opis = new System.Windows.Forms.Label();
            this.txtDodajOpis = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblStranica = new System.Windows.Forms.Label();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.btnLijevo = new System.Windows.Forms.Button();
            this.btnDesno = new System.Windows.Forms.Button();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDodaj)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(138, 19);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(93, 25);
            this.lblStudent.TabIndex = 0;
            this.lblStudent.Text = "Student";
            // 
            // lblPredmet
            // 
            this.lblPredmet.AutoSize = true;
            this.lblPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredmet.Location = new System.Drawing.Point(137, 57);
            this.lblPredmet.Name = "lblPredmet";
            this.lblPredmet.Size = new System.Drawing.Size(99, 25);
            this.lblPredmet.TabIndex = 1;
            this.lblPredmet.Text = "Predmet";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.txtDodajOpis);
            this.groupBox1.Controls.Add(this.Opis);
            this.groupBox1.Controls.Add(this.pbDodaj);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 133);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Slika:";
            // 
            // pbDodaj
            // 
            this.pbDodaj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDodaj.Location = new System.Drawing.Point(7, 37);
            this.pbDodaj.Name = "pbDodaj";
            this.pbDodaj.Size = new System.Drawing.Size(100, 90);
            this.pbDodaj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDodaj.TabIndex = 1;
            this.pbDodaj.TabStop = false;
            this.pbDodaj.Click += new System.EventHandler(this.pbDodaj_Click);
            // 
            // Opis
            // 
            this.Opis.AutoSize = true;
            this.Opis.Location = new System.Drawing.Point(145, 20);
            this.Opis.Name = "Opis";
            this.Opis.Size = new System.Drawing.Size(31, 13);
            this.Opis.TabIndex = 2;
            this.Opis.Text = "Opis:";
            // 
            // txtDodajOpis
            // 
            this.txtDodajOpis.Location = new System.Drawing.Point(148, 37);
            this.txtDodajOpis.Multiline = true;
            this.txtDodajOpis.Name = "txtDodajOpis";
            this.txtDodajOpis.Size = new System.Drawing.Size(210, 61);
            this.txtDodajOpis.TabIndex = 3;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(283, 104);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj sliku";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblOpis);
            this.groupBox2.Controls.Add(this.lblDatum);
            this.groupBox2.Controls.Add(this.btnDesno);
            this.groupBox2.Controls.Add(this.btnLijevo);
            this.groupBox2.Controls.Add(this.pbSlika);
            this.groupBox2.Controls.Add(this.lblStranica);
            this.groupBox2.Location = new System.Drawing.Point(13, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 334);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pregled seminarskog";
            // 
            // lblStranica
            // 
            this.lblStranica.AutoSize = true;
            this.lblStranica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStranica.Location = new System.Drawing.Point(104, 27);
            this.lblStranica.Name = "lblStranica";
            this.lblStranica.Size = new System.Drawing.Size(119, 24);
            this.lblStranica.TabIndex = 0;
            this.lblStranica.Text = "Stranica 0/0";
            // 
            // pbSlika
            // 
            this.pbSlika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSlika.Location = new System.Drawing.Point(93, 54);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(161, 197);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 1;
            this.pbSlika.TabStop = false;
            // 
            // btnLijevo
            // 
            this.btnLijevo.Location = new System.Drawing.Point(10, 146);
            this.btnLijevo.Name = "btnLijevo";
            this.btnLijevo.Size = new System.Drawing.Size(75, 23);
            this.btnLijevo.TabIndex = 2;
            this.btnLijevo.Text = "<==";
            this.btnLijevo.UseVisualStyleBackColor = true;
            this.btnLijevo.Click += new System.EventHandler(this.btnLijevo_Click);
            // 
            // btnDesno
            // 
            this.btnDesno.Location = new System.Drawing.Point(260, 146);
            this.btnDesno.Name = "btnDesno";
            this.btnDesno.Size = new System.Drawing.Size(75, 23);
            this.btnDesno.TabIndex = 3;
            this.btnDesno.Text = "==>";
            this.btnDesno.UseVisualStyleBackColor = true;
            this.btnDesno.Click += new System.EventHandler(this.btnDesno_Click);
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(130, 258);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(38, 13);
            this.lblDatum.TabIndex = 4;
            this.lblDatum.Text = "Datum";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(133, 285);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(28, 13);
            this.lblOpis.TabIndex = 5;
            this.lblOpis.Text = "Opis";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            // 
            // frmSeminarskiIBBrojIndeksa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 615);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPredmet);
            this.Controls.Add(this.lblStudent);
            this.Name = "frmSeminarskiIBBrojIndeksa";
            this.Text = "frmSeminarskiIBBrojIndeksa";
            this.Load += new System.EventHandler(this.frmSeminarskiIBBrojIndeksa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDodaj)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblPredmet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtDodajOpis;
        private System.Windows.Forms.Label Opis;
        private System.Windows.Forms.PictureBox pbDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Button btnDesno;
        private System.Windows.Forms.Button btnLijevo;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Label lblStranica;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog fileDialog;
    }
}