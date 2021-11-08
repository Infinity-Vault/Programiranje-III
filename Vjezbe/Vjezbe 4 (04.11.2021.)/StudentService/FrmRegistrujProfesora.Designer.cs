
namespace StudentService
{
    partial class FrmRegistrujProfesora
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
            this.grpBoxRegustrujProfesora = new System.Windows.Forms.GroupBox();
            this.btnRegistrujProfesora = new System.Windows.Forms.Button();
            this.dtPickerDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.txtBoxPrezime = new System.Windows.Forms.TextBox();
            this.txtBoxSemestar = new System.Windows.Forms.TextBox();
            this.txtBoxLozinka = new System.Windows.Forms.TextBox();
            this.txtBoxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtBoxIme = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.lblSemestar = new System.Windows.Forms.Label();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.errorRegistrujProfesora = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtBoxSemestarPredmet = new System.Windows.Forms.TextBox();
            this.txtBoxNaziv = new System.Windows.Forms.TextBox();
            this.grpBoxDodajPredmet = new System.Windows.Forms.GroupBox();
            this.grpBoxRegustrujProfesora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorRegistrujProfesora)).BeginInit();
            this.grpBoxDodajPredmet.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxRegustrujProfesora
            // 
            this.grpBoxRegustrujProfesora.Controls.Add(this.grpBoxDodajPredmet);
            this.grpBoxRegustrujProfesora.Controls.Add(this.btnRegistrujProfesora);
            this.grpBoxRegustrujProfesora.Controls.Add(this.dtPickerDatumRodjenja);
            this.grpBoxRegustrujProfesora.Controls.Add(this.txtBoxPrezime);
            this.grpBoxRegustrujProfesora.Controls.Add(this.txtBoxSemestar);
            this.grpBoxRegustrujProfesora.Controls.Add(this.txtBoxLozinka);
            this.grpBoxRegustrujProfesora.Controls.Add(this.txtBoxKorisnickoIme);
            this.grpBoxRegustrujProfesora.Controls.Add(this.txtBoxIme);
            this.grpBoxRegustrujProfesora.Controls.Add(this.lblIme);
            this.grpBoxRegustrujProfesora.Controls.Add(this.lblLozinka);
            this.grpBoxRegustrujProfesora.Controls.Add(this.lblPrezime);
            this.grpBoxRegustrujProfesora.Controls.Add(this.lblKorisnickoIme);
            this.grpBoxRegustrujProfesora.Controls.Add(this.lblSemestar);
            this.grpBoxRegustrujProfesora.Controls.Add(this.lblDatumRodjenja);
            this.grpBoxRegustrujProfesora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpBoxRegustrujProfesora.Location = new System.Drawing.Point(12, 12);
            this.grpBoxRegustrujProfesora.Name = "grpBoxRegustrujProfesora";
            this.grpBoxRegustrujProfesora.Size = new System.Drawing.Size(520, 445);
            this.grpBoxRegustrujProfesora.TabIndex = 31;
            this.grpBoxRegustrujProfesora.TabStop = false;
            this.grpBoxRegustrujProfesora.Text = "Registruj se !";
            // 
            // btnRegistrujProfesora
            // 
            this.btnRegistrujProfesora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRegistrujProfesora.Location = new System.Drawing.Point(313, 402);
            this.btnRegistrujProfesora.Name = "btnRegistrujProfesora";
            this.btnRegistrujProfesora.Size = new System.Drawing.Size(161, 37);
            this.btnRegistrujProfesora.TabIndex = 30;
            this.btnRegistrujProfesora.Text = "Registruj se";
            this.btnRegistrujProfesora.UseVisualStyleBackColor = true;
            this.btnRegistrujProfesora.Click += new System.EventHandler(this.btnRegistrujProfesora_Click);
            // 
            // dtPickerDatumRodjenja
            // 
            this.dtPickerDatumRodjenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtPickerDatumRodjenja.Location = new System.Drawing.Point(270, 158);
            this.dtPickerDatumRodjenja.Name = "dtPickerDatumRodjenja";
            this.dtPickerDatumRodjenja.Size = new System.Drawing.Size(200, 29);
            this.dtPickerDatumRodjenja.TabIndex = 29;
            // 
            // txtBoxPrezime
            // 
            this.txtBoxPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxPrezime.Location = new System.Drawing.Point(127, 84);
            this.txtBoxPrezime.Name = "txtBoxPrezime";
            this.txtBoxPrezime.Size = new System.Drawing.Size(343, 29);
            this.txtBoxPrezime.TabIndex = 28;
            // 
            // txtBoxSemestar
            // 
            this.txtBoxSemestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxSemestar.Location = new System.Drawing.Point(127, 122);
            this.txtBoxSemestar.Name = "txtBoxSemestar";
            this.txtBoxSemestar.Size = new System.Drawing.Size(343, 29);
            this.txtBoxSemestar.TabIndex = 27;
            // 
            // txtBoxLozinka
            // 
            this.txtBoxLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxLozinka.Location = new System.Drawing.Point(128, 234);
            this.txtBoxLozinka.Name = "txtBoxLozinka";
            this.txtBoxLozinka.Size = new System.Drawing.Size(346, 29);
            this.txtBoxLozinka.TabIndex = 26;
            // 
            // txtBoxKorisnickoIme
            // 
            this.txtBoxKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxKorisnickoIme.Location = new System.Drawing.Point(189, 197);
            this.txtBoxKorisnickoIme.Name = "txtBoxKorisnickoIme";
            this.txtBoxKorisnickoIme.Size = new System.Drawing.Size(285, 29);
            this.txtBoxKorisnickoIme.TabIndex = 25;
            // 
            // txtBoxIme
            // 
            this.txtBoxIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxIme.Location = new System.Drawing.Point(124, 47);
            this.txtBoxIme.Name = "txtBoxIme";
            this.txtBoxIme.Size = new System.Drawing.Size(346, 29);
            this.txtBoxIme.TabIndex = 23;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIme.Location = new System.Drawing.Point(6, 47);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(59, 29);
            this.lblIme.TabIndex = 16;
            this.lblIme.Text = "Ime:";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLozinka.Location = new System.Drawing.Point(10, 234);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(101, 29);
            this.lblLozinka.TabIndex = 22;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrezime.Location = new System.Drawing.Point(6, 84);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(108, 29);
            this.lblPrezime.TabIndex = 17;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKorisnickoIme.Location = new System.Drawing.Point(10, 194);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(178, 29);
            this.lblKorisnickoIme.TabIndex = 21;
            this.lblKorisnickoIme.Text = "Korisnicko ime:";
            // 
            // lblSemestar
            // 
            this.lblSemestar.AutoSize = true;
            this.lblSemestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSemestar.Location = new System.Drawing.Point(6, 119);
            this.lblSemestar.Name = "lblSemestar";
            this.lblSemestar.Size = new System.Drawing.Size(122, 29);
            this.lblSemestar.TabIndex = 18;
            this.lblSemestar.Text = "Semestar:";
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatumRodjenja.Location = new System.Drawing.Point(6, 156);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(182, 29);
            this.lblDatumRodjenja.TabIndex = 19;
            this.lblDatumRodjenja.Text = "Datum rodjenja:";
            // 
            // errorRegistrujProfesora
            // 
            this.errorRegistrujProfesora.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Semestar:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaziv.Location = new System.Drawing.Point(17, 35);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(67, 25);
            this.lblNaziv.TabIndex = 29;
            this.lblNaziv.Text = "Naziv:";
            // 
            // txtBoxSemestarPredmet
            // 
            this.txtBoxSemestarPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxSemestarPredmet.Location = new System.Drawing.Point(124, 67);
            this.txtBoxSemestarPredmet.Name = "txtBoxSemestarPredmet";
            this.txtBoxSemestarPredmet.Size = new System.Drawing.Size(329, 29);
            this.txtBoxSemestarPredmet.TabIndex = 31;
            // 
            // txtBoxNaziv
            // 
            this.txtBoxNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxNaziv.Location = new System.Drawing.Point(81, 35);
            this.txtBoxNaziv.Name = "txtBoxNaziv";
            this.txtBoxNaziv.Size = new System.Drawing.Size(372, 29);
            this.txtBoxNaziv.TabIndex = 32;
            // 
            // grpBoxDodajPredmet
            // 
            this.grpBoxDodajPredmet.Controls.Add(this.txtBoxNaziv);
            this.grpBoxDodajPredmet.Controls.Add(this.txtBoxSemestarPredmet);
            this.grpBoxDodajPredmet.Controls.Add(this.lblNaziv);
            this.grpBoxDodajPredmet.Controls.Add(this.label1);
            this.grpBoxDodajPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpBoxDodajPredmet.Location = new System.Drawing.Point(11, 269);
            this.grpBoxDodajPredmet.Name = "grpBoxDodajPredmet";
            this.grpBoxDodajPredmet.Size = new System.Drawing.Size(472, 110);
            this.grpBoxDodajPredmet.TabIndex = 32;
            this.grpBoxDodajPredmet.TabStop = false;
            this.grpBoxDodajPredmet.Text = "Kreiraj predmet";
            // 
            // FrmRegistrujProfesora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 488);
            this.Controls.Add(this.grpBoxRegustrujProfesora);
            this.Name = "FrmRegistrujProfesora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registracija";
            this.grpBoxRegustrujProfesora.ResumeLayout(false);
            this.grpBoxRegustrujProfesora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorRegistrujProfesora)).EndInit();
            this.grpBoxDodajPredmet.ResumeLayout(false);
            this.grpBoxDodajPredmet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxRegustrujProfesora;
        private System.Windows.Forms.Button btnRegistrujProfesora;
        private System.Windows.Forms.DateTimePicker dtPickerDatumRodjenja;
        private System.Windows.Forms.TextBox txtBoxPrezime;
        private System.Windows.Forms.TextBox txtBoxSemestar;
        private System.Windows.Forms.TextBox txtBoxLozinka;
        private System.Windows.Forms.TextBox txtBoxKorisnickoIme;
        private System.Windows.Forms.TextBox txtBoxIme;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Label lblSemestar;
        private System.Windows.Forms.Label lblDatumRodjenja;
        private System.Windows.Forms.ErrorProvider errorRegistrujProfesora;
        private System.Windows.Forms.GroupBox grpBoxDodajPredmet;
        private System.Windows.Forms.TextBox txtBoxNaziv;
        private System.Windows.Forms.TextBox txtBoxSemestarPredmet;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label label1;
    }
}