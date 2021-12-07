
namespace Predavanje9__07._12._2021._
{
    partial class frmDodajStudenta
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
            this.grpBoxRegistracija = new System.Windows.Forms.GroupBox();
            this.lblSpol = new System.Windows.Forms.Label();
            this.cmbSpol = new System.Windows.Forms.ComboBox();
            this.btnDodajStudenta = new System.Windows.Forms.Button();
            this.lblGodina = new System.Windows.Forms.Label();
            this.cmbGodina = new System.Windows.Forms.ComboBox();
            this.btnUcitajSliku = new System.Windows.Forms.Button();
            this.pbSlikaStudenta = new System.Windows.Forms.PictureBox();
            this.cbAktivan = new System.Windows.Forms.CheckBox();
            this.dtPickerRodjenje = new System.Windows.Forms.DateTimePicker();
            this.txtBoxLozinka = new System.Windows.Forms.TextBox();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRodjen = new System.Windows.Forms.Label();
            this.txtBoxIndeks = new System.Windows.Forms.TextBox();
            this.lblIndeks = new System.Windows.Forms.Label();
            this.txtBoxPrezime = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtBoxIme = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.ofdUcitajSliku = new System.Windows.Forms.OpenFileDialog();
            this.errorDodajStudenta = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpBoxRegistracija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaStudenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDodajStudenta)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxRegistracija
            // 
            this.grpBoxRegistracija.Controls.Add(this.lblSpol);
            this.grpBoxRegistracija.Controls.Add(this.cmbSpol);
            this.grpBoxRegistracija.Controls.Add(this.btnDodajStudenta);
            this.grpBoxRegistracija.Controls.Add(this.lblGodina);
            this.grpBoxRegistracija.Controls.Add(this.cmbGodina);
            this.grpBoxRegistracija.Controls.Add(this.btnUcitajSliku);
            this.grpBoxRegistracija.Controls.Add(this.pbSlikaStudenta);
            this.grpBoxRegistracija.Controls.Add(this.cbAktivan);
            this.grpBoxRegistracija.Controls.Add(this.dtPickerRodjenje);
            this.grpBoxRegistracija.Controls.Add(this.txtBoxLozinka);
            this.grpBoxRegistracija.Controls.Add(this.lblLozinka);
            this.grpBoxRegistracija.Controls.Add(this.txtBoxEmail);
            this.grpBoxRegistracija.Controls.Add(this.lblEmail);
            this.grpBoxRegistracija.Controls.Add(this.lblRodjen);
            this.grpBoxRegistracija.Controls.Add(this.txtBoxIndeks);
            this.grpBoxRegistracija.Controls.Add(this.lblIndeks);
            this.grpBoxRegistracija.Controls.Add(this.txtBoxPrezime);
            this.grpBoxRegistracija.Controls.Add(this.lblPrezime);
            this.grpBoxRegistracija.Controls.Add(this.txtBoxIme);
            this.grpBoxRegistracija.Controls.Add(this.lblIme);
            this.grpBoxRegistracija.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpBoxRegistracija.Location = new System.Drawing.Point(12, 12);
            this.grpBoxRegistracija.Name = "grpBoxRegistracija";
            this.grpBoxRegistracija.Size = new System.Drawing.Size(751, 435);
            this.grpBoxRegistracija.TabIndex = 1;
            this.grpBoxRegistracija.TabStop = false;
            this.grpBoxRegistracija.Text = "Registruj se:";
            // 
            // lblSpol
            // 
            this.lblSpol.AutoSize = true;
            this.lblSpol.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSpol.Location = new System.Drawing.Point(512, 273);
            this.lblSpol.Name = "lblSpol";
            this.lblSpol.Size = new System.Drawing.Size(62, 26);
            this.lblSpol.TabIndex = 19;
            this.lblSpol.Text = "Spol:";
            // 
            // cmbSpol
            // 
            this.cmbSpol.FormattingEnabled = true;
            this.cmbSpol.Location = new System.Drawing.Point(580, 270);
            this.cmbSpol.Name = "cmbSpol";
            this.cmbSpol.Size = new System.Drawing.Size(121, 33);
            this.cmbSpol.TabIndex = 18;
            // 
            // btnDodajStudenta
            // 
            this.btnDodajStudenta.Location = new System.Drawing.Point(393, 395);
            this.btnDodajStudenta.Name = "btnDodajStudenta";
            this.btnDodajStudenta.Size = new System.Drawing.Size(143, 34);
            this.btnDodajStudenta.TabIndex = 9;
            this.btnDodajStudenta.Text = "Dodaj";
            this.btnDodajStudenta.UseVisualStyleBackColor = true;
            this.btnDodajStudenta.Click += new System.EventHandler(this.btnDodajStudenta_Click);
            // 
            // lblGodina
            // 
            this.lblGodina.AutoSize = true;
            this.lblGodina.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGodina.Location = new System.Drawing.Point(286, 269);
            this.lblGodina.Name = "lblGodina";
            this.lblGodina.Size = new System.Drawing.Size(88, 26);
            this.lblGodina.TabIndex = 17;
            this.lblGodina.Text = "Godina:";
            // 
            // cmbGodina
            // 
            this.cmbGodina.FormattingEnabled = true;
            this.cmbGodina.Location = new System.Drawing.Point(385, 266);
            this.cmbGodina.Name = "cmbGodina";
            this.cmbGodina.Size = new System.Drawing.Size(121, 33);
            this.cmbGodina.TabIndex = 7;
            // 
            // btnUcitajSliku
            // 
            this.btnUcitajSliku.Location = new System.Drawing.Point(223, 395);
            this.btnUcitajSliku.Name = "btnUcitajSliku";
            this.btnUcitajSliku.Size = new System.Drawing.Size(143, 34);
            this.btnUcitajSliku.TabIndex = 8;
            this.btnUcitajSliku.Text = "Ucitaj sliku";
            this.btnUcitajSliku.UseVisualStyleBackColor = true;
            this.btnUcitajSliku.Click += new System.EventHandler(this.btnUcitajSliku_Click);
            // 
            // pbSlikaStudenta
            // 
            this.pbSlikaStudenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSlikaStudenta.Location = new System.Drawing.Point(7, 295);
            this.pbSlikaStudenta.Name = "pbSlikaStudenta";
            this.pbSlikaStudenta.Size = new System.Drawing.Size(208, 134);
            this.pbSlikaStudenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlikaStudenta.TabIndex = 14;
            this.pbSlikaStudenta.TabStop = false;
            // 
            // cbAktivan
            // 
            this.cbAktivan.AutoSize = true;
            this.cbAktivan.Location = new System.Drawing.Point(111, 266);
            this.cbAktivan.Name = "cbAktivan";
            this.cbAktivan.Size = new System.Drawing.Size(96, 29);
            this.cbAktivan.TabIndex = 6;
            this.cbAktivan.Text = "Aktivan";
            this.cbAktivan.UseVisualStyleBackColor = true;
            // 
            // dtPickerRodjenje
            // 
            this.dtPickerRodjenje.Location = new System.Drawing.Point(179, 121);
            this.dtPickerRodjenje.Name = "dtPickerRodjenje";
            this.dtPickerRodjenje.Size = new System.Drawing.Size(327, 30);
            this.dtPickerRodjenje.TabIndex = 2;
            // 
            // txtBoxLozinka
            // 
            this.txtBoxLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxLozinka.Location = new System.Drawing.Point(111, 234);
            this.txtBoxLozinka.Name = "txtBoxLozinka";
            this.txtBoxLozinka.Size = new System.Drawing.Size(395, 26);
            this.txtBoxLozinka.TabIndex = 5;
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLozinka.Location = new System.Drawing.Point(16, 234);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(93, 26);
            this.lblLozinka.TabIndex = 10;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxEmail.Location = new System.Drawing.Point(111, 195);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(395, 26);
            this.txtBoxEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmail.Location = new System.Drawing.Point(16, 195);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(74, 26);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // lblRodjen
            // 
            this.lblRodjen.AutoSize = true;
            this.lblRodjen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRodjen.Location = new System.Drawing.Point(16, 121);
            this.lblRodjen.Name = "lblRodjen";
            this.lblRodjen.Size = new System.Drawing.Size(166, 26);
            this.lblRodjen.TabIndex = 6;
            this.lblRodjen.Text = "Datum rodjenja:";
            // 
            // txtBoxIndeks
            // 
            this.txtBoxIndeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxIndeks.Location = new System.Drawing.Point(111, 157);
            this.txtBoxIndeks.Name = "txtBoxIndeks";
            this.txtBoxIndeks.Size = new System.Drawing.Size(395, 26);
            this.txtBoxIndeks.TabIndex = 3;
            // 
            // lblIndeks
            // 
            this.lblIndeks.AutoSize = true;
            this.lblIndeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIndeks.Location = new System.Drawing.Point(16, 158);
            this.lblIndeks.Name = "lblIndeks";
            this.lblIndeks.Size = new System.Drawing.Size(82, 26);
            this.lblIndeks.TabIndex = 4;
            this.lblIndeks.Text = "Indeks:";
            // 
            // txtBoxPrezime
            // 
            this.txtBoxPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxPrezime.Location = new System.Drawing.Point(111, 79);
            this.txtBoxPrezime.Name = "txtBoxPrezime";
            this.txtBoxPrezime.Size = new System.Drawing.Size(395, 26);
            this.txtBoxPrezime.TabIndex = 1;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrezime.Location = new System.Drawing.Point(16, 78);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(99, 26);
            this.lblPrezime.TabIndex = 2;
            this.lblPrezime.Text = "Prezime:";
            // 
            // txtBoxIme
            // 
            this.txtBoxIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxIme.Location = new System.Drawing.Point(111, 39);
            this.txtBoxIme.Name = "txtBoxIme";
            this.txtBoxIme.Size = new System.Drawing.Size(395, 26);
            this.txtBoxIme.TabIndex = 0;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIme.Location = new System.Drawing.Point(16, 39);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(55, 26);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime:";
            // 
            // ofdUcitajSliku
            // 
            this.ofdUcitajSliku.FileName = "openFileDialog1";
            // 
            // errorDodajStudenta
            // 
            this.errorDodajStudenta.ContainerControl = this;
            // 
            // frmDodajStudenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBoxRegistracija);
            this.Name = "frmDodajStudenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDodajStudenta";
            this.Load += new System.EventHandler(this.frmDodajStudenta_Load);
            this.grpBoxRegistracija.ResumeLayout(false);
            this.grpBoxRegistracija.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaStudenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDodajStudenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxRegistracija;
        private System.Windows.Forms.Button btnDodajStudenta;
        private System.Windows.Forms.Label lblGodina;
        private System.Windows.Forms.ComboBox cmbGodina;
        private System.Windows.Forms.Button btnUcitajSliku;
        private System.Windows.Forms.PictureBox pbSlikaStudenta;
        private System.Windows.Forms.CheckBox cbAktivan;
        private System.Windows.Forms.DateTimePicker dtPickerRodjenje;
        private System.Windows.Forms.TextBox txtBoxLozinka;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRodjen;
        private System.Windows.Forms.TextBox txtBoxIndeks;
        private System.Windows.Forms.Label lblIndeks;
        private System.Windows.Forms.TextBox txtBoxPrezime;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtBoxIme;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblSpol;
        private System.Windows.Forms.ComboBox cmbSpol;
        private System.Windows.Forms.OpenFileDialog ofdUcitajSliku;
        private System.Windows.Forms.ErrorProvider errorDodajStudenta;
    }
}