namespace DLWMS.WinForms.Forme
{
    partial class frmNoviStudent
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbAktivan = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtIndeks = new System.Windows.Forms.TextBox();
            this.pbSlikaStudenta = new System.Windows.Forms.PictureBox();
            this.cmbGodinaStudija = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ofdOdabirSlike = new System.Windows.Forms.OpenFileDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbSpol = new System.Windows.Forms.ComboBox();
            this.clbUloge = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaStudenta)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(151, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Fakultet informacijskih tehnologija";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(151, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Univerzitet \"Džemal Bijedić\"";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(151, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "www.fit.ba";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DLWMS.WinForms.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(27, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // cbAktivan
            // 
            this.cbAktivan.AutoSize = true;
            this.cbAktivan.Location = new System.Drawing.Point(520, 282);
            this.cbAktivan.Name = "cbAktivan";
            this.cbAktivan.Size = new System.Drawing.Size(62, 17);
            this.cbAktivan.TabIndex = 6;
            this.cbAktivan.Text = "Aktivan";
            this.cbAktivan.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Datum rođenja:";
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(354, 202);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(228, 20);
            this.dtpDatumRodjenja.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Prezime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ime:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(354, 177);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(228, 20);
            this.txtPrezime.TabIndex = 2;
            this.txtPrezime.TextChanged += new System.EventHandler(this.txtPrezime_TextChanged);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(354, 152);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(228, 20);
            this.txtIme.TabIndex = 1;
            this.txtIme.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Email:";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(742, 282);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvaj.TabIndex = 7;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(354, 253);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(228, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Indeks:";
            // 
            // txtIndeks
            // 
            this.txtIndeks.Location = new System.Drawing.Point(354, 127);
            this.txtIndeks.Name = "txtIndeks";
            this.txtIndeks.Size = new System.Drawing.Size(228, 20);
            this.txtIndeks.TabIndex = 0;
            // 
            // pbSlikaStudenta
            // 
            this.pbSlikaStudenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbSlikaStudenta.Location = new System.Drawing.Point(27, 127);
            this.pbSlikaStudenta.Name = "pbSlikaStudenta";
            this.pbSlikaStudenta.Size = new System.Drawing.Size(187, 172);
            this.pbSlikaStudenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlikaStudenta.TabIndex = 39;
            this.pbSlikaStudenta.TabStop = false;
            this.pbSlikaStudenta.Click += new System.EventHandler(this.pbSlikaStudenta_Click);
            // 
            // cmbGodinaStudija
            // 
            this.cmbGodinaStudija.FormattingEnabled = true;
            this.cmbGodinaStudija.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbGodinaStudija.Location = new System.Drawing.Point(354, 278);
            this.cmbGodinaStudija.Name = "cmbGodinaStudija";
            this.cmbGodinaStudija.Size = new System.Drawing.Size(99, 21);
            this.cmbGodinaStudija.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(238, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Godina studija:";
            // 
            // ofdOdabirSlike
            // 
            this.ofdOdabirSlike.FileName = "openFileDialog1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(238, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Spol:";
            // 
            // cmbSpol
            // 
            this.cmbSpol.FormattingEnabled = true;
            this.cmbSpol.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbSpol.Location = new System.Drawing.Point(354, 227);
            this.cmbSpol.Name = "cmbSpol";
            this.cmbSpol.Size = new System.Drawing.Size(99, 21);
            this.cmbSpol.TabIndex = 42;
            // 
            // clbUloge
            // 
            this.clbUloge.FormattingEnabled = true;
            this.clbUloge.Location = new System.Drawing.Point(588, 127);
            this.clbUloge.Name = "clbUloge";
            this.clbUloge.Size = new System.Drawing.Size(233, 124);
            this.clbUloge.TabIndex = 44;
            // 
            // frmNoviStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 316);
            this.Controls.Add(this.clbUloge);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbSpol);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbGodinaStudija);
            this.Controls.Add(this.pbSlikaStudenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIndeks);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbAktivan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDatumRodjenja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtEmail);
            this.Name = "frmNoviStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podaci o studentu";
            this.Load += new System.EventHandler(this.frmNoviStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaStudenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbAktivan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIndeks;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbGodinaStudija;
        private System.Windows.Forms.PictureBox pbSlikaStudenta;
        private System.Windows.Forms.OpenFileDialog ofdOdabirSlike;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbSpol;
        private System.Windows.Forms.CheckedListBox clbUloge;
    }
}