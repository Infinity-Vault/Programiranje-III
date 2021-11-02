
namespace Predavanje_5__02._011._2021._
{
    partial class frmRegistracija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistracija));
            this.gpBoxInfo = new System.Windows.Forms.GroupBox();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.dtPickerDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.cbAktivan = new System.Windows.Forms.CheckBox();
            this.txtBoxPrezime = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtBoxIme = new System.Windows.Forms.TextBox();
            this.txtBoxLozinka = new System.Windows.Forms.TextBox();
            this.txtBoxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.gpBoxCredentials = new System.Windows.Forms.GroupBox();
            this.btnRegistrujSe = new System.Windows.Forms.Button();
            this.errorRegister = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblOpis = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpBoxInfo.SuspendLayout();
            this.gpBoxCredentials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpBoxInfo
            // 
            this.gpBoxInfo.Controls.Add(this.lblDatumRodjenja);
            this.gpBoxInfo.Controls.Add(this.dtPickerDatumRodjenja);
            this.gpBoxInfo.Controls.Add(this.cbAktivan);
            this.gpBoxInfo.Controls.Add(this.txtBoxPrezime);
            this.gpBoxInfo.Controls.Add(this.lblIme);
            this.gpBoxInfo.Controls.Add(this.lblPrezime);
            this.gpBoxInfo.Controls.Add(this.txtBoxIme);
            this.gpBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gpBoxInfo.Location = new System.Drawing.Point(268, 12);
            this.gpBoxInfo.Name = "gpBoxInfo";
            this.gpBoxInfo.Size = new System.Drawing.Size(500, 216);
            this.gpBoxInfo.TabIndex = 0;
            this.gpBoxInfo.TabStop = false;
            this.gpBoxInfo.Text = "Personalne informacije:";
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.Location = new System.Drawing.Point(6, 173);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(149, 25);
            this.lblDatumRodjenja.TabIndex = 3;
            this.lblDatumRodjenja.Text = "Datum rodjenja:";
            // 
            // dtPickerDatumRodjenja
            // 
            this.dtPickerDatumRodjenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtPickerDatumRodjenja.Location = new System.Drawing.Point(161, 173);
            this.dtPickerDatumRodjenja.Name = "dtPickerDatumRodjenja";
            this.dtPickerDatumRodjenja.Size = new System.Drawing.Size(310, 29);
            this.dtPickerDatumRodjenja.TabIndex = 3;
            // 
            // cbAktivan
            // 
            this.cbAktivan.AutoSize = true;
            this.cbAktivan.Location = new System.Drawing.Point(144, 138);
            this.cbAktivan.Name = "cbAktivan";
            this.cbAktivan.Size = new System.Drawing.Size(107, 29);
            this.cbAktivan.TabIndex = 2;
            this.cbAktivan.Text = "Aktivan?";
            this.cbAktivan.UseVisualStyleBackColor = true;
            // 
            // txtBoxPrezime
            // 
            this.txtBoxPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxPrezime.Location = new System.Drawing.Point(144, 90);
            this.txtBoxPrezime.Name = "txtBoxPrezime";
            this.txtBoxPrezime.Size = new System.Drawing.Size(331, 30);
            this.txtBoxPrezime.TabIndex = 1;
            this.txtBoxPrezime.TextChanged += new System.EventHandler(this.GenerisiKorisnickoIme);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIme.Location = new System.Drawing.Point(17, 41);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(67, 31);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrezime.Location = new System.Drawing.Point(17, 87);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(121, 31);
            this.lblPrezime.TabIndex = 2;
            this.lblPrezime.Text = "Prezime:";
            // 
            // txtBoxIme
            // 
            this.txtBoxIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxIme.Location = new System.Drawing.Point(144, 41);
            this.txtBoxIme.Name = "txtBoxIme";
            this.txtBoxIme.Size = new System.Drawing.Size(331, 30);
            this.txtBoxIme.TabIndex = 0;
            this.txtBoxIme.TextChanged += new System.EventHandler(this.GenerisiKorisnickoIme);
            // 
            // txtBoxLozinka
            // 
            this.txtBoxLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxLozinka.Location = new System.Drawing.Point(203, 90);
            this.txtBoxLozinka.Name = "txtBoxLozinka";
            this.txtBoxLozinka.PasswordChar = '*';
            this.txtBoxLozinka.Size = new System.Drawing.Size(292, 30);
            this.txtBoxLozinka.TabIndex = 1;
            // 
            // txtBoxKorisnickoIme
            // 
            this.txtBoxKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxKorisnickoIme.Location = new System.Drawing.Point(202, 54);
            this.txtBoxKorisnickoIme.Name = "txtBoxKorisnickoIme";
            this.txtBoxKorisnickoIme.Size = new System.Drawing.Size(292, 30);
            this.txtBoxKorisnickoIme.TabIndex = 0;
            this.txtBoxKorisnickoIme.TextChanged += new System.EventHandler(this.ProvjeriDuplikateKorisnickihImena);
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLozinka.Location = new System.Drawing.Point(5, 82);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(116, 31);
            this.lblLozinka.TabIndex = 1;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKorisnickoIme.Location = new System.Drawing.Point(5, 51);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(198, 31);
            this.lblKorisnickoIme.TabIndex = 0;
            this.lblKorisnickoIme.Text = "Korisnicko ime:";
            // 
            // gpBoxCredentials
            // 
            this.gpBoxCredentials.Controls.Add(this.btnRegistrujSe);
            this.gpBoxCredentials.Controls.Add(this.txtBoxKorisnickoIme);
            this.gpBoxCredentials.Controls.Add(this.txtBoxLozinka);
            this.gpBoxCredentials.Controls.Add(this.lblKorisnickoIme);
            this.gpBoxCredentials.Controls.Add(this.lblLozinka);
            this.gpBoxCredentials.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gpBoxCredentials.Location = new System.Drawing.Point(268, 234);
            this.gpBoxCredentials.Name = "gpBoxCredentials";
            this.gpBoxCredentials.Size = new System.Drawing.Size(500, 185);
            this.gpBoxCredentials.TabIndex = 1;
            this.gpBoxCredentials.TabStop = false;
            this.gpBoxCredentials.Text = "Racun:";
            // 
            // btnRegistrujSe
            // 
            this.btnRegistrujSe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrujSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRegistrujSe.Location = new System.Drawing.Point(363, 126);
            this.btnRegistrujSe.Name = "btnRegistrujSe";
            this.btnRegistrujSe.Size = new System.Drawing.Size(131, 41);
            this.btnRegistrujSe.TabIndex = 2;
            this.btnRegistrujSe.Text = "Registruj se!";
            this.btnRegistrujSe.UseVisualStyleBackColor = true;
            this.btnRegistrujSe.Click += new System.EventHandler(this.btnRegistrujSe_Click);
            // 
            // errorRegister
            // 
            this.errorRegister.ContainerControl = this;
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis.Location = new System.Drawing.Point(5, 266);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(248, 68);
            this.lblOpis.TabIndex = 8;
            this.lblOpis.Text = "Univerzitet \"Dzemal Bijedic\" u Mostaru\r\n\r\nFakultet Informacijskih Tehnogija FIT\r\n" +
    "www.fit.ba\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmRegistracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(833, 422);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpBoxCredentials);
            this.Controls.Add(this.gpBoxInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistracija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registruj se";
            this.Load += new System.EventHandler(this.frmRegistracija_Load);
            this.gpBoxInfo.ResumeLayout(false);
            this.gpBoxInfo.PerformLayout();
            this.gpBoxCredentials.ResumeLayout(false);
            this.gpBoxCredentials.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpBoxInfo;
        private System.Windows.Forms.Label lblDatumRodjenja;
        private System.Windows.Forms.DateTimePicker dtPickerDatumRodjenja;
        private System.Windows.Forms.CheckBox cbAktivan;
        private System.Windows.Forms.TextBox txtBoxPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtBoxIme;
        private System.Windows.Forms.TextBox txtBoxLozinka;
        private System.Windows.Forms.TextBox txtBoxKorisnickoIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.GroupBox gpBoxCredentials;
        private System.Windows.Forms.Button btnRegistrujSe;
        private System.Windows.Forms.ErrorProvider errorRegister;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblOpis;
    }
}