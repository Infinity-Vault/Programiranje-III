
namespace StudentService
{
    partial class FrmRegistrujStudenta
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
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblSemestar = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblIndeks = new System.Windows.Forms.Label();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.grpBoxStudentRegistracija = new System.Windows.Forms.GroupBox();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.dtpDatumrodjenja = new System.Windows.Forms.DateTimePicker();
            this.txtBoxPrezime = new System.Windows.Forms.TextBox();
            this.txtBoxSemestar = new System.Windows.Forms.TextBox();
            this.txtBoxLozinka = new System.Windows.Forms.TextBox();
            this.txtBoxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtBoxIndeks = new System.Windows.Forms.TextBox();
            this.txtBoxIme = new System.Windows.Forms.TextBox();
            this.errorRegistracijaStudent = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpBoxStudentRegistracija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorRegistracijaStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIme.Location = new System.Drawing.Point(6, 51);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(59, 29);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrezime.Location = new System.Drawing.Point(6, 88);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(108, 29);
            this.lblPrezime.TabIndex = 1;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblSemestar
            // 
            this.lblSemestar.AutoSize = true;
            this.lblSemestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSemestar.Location = new System.Drawing.Point(6, 123);
            this.lblSemestar.Name = "lblSemestar";
            this.lblSemestar.Size = new System.Drawing.Size(122, 29);
            this.lblSemestar.TabIndex = 2;
            this.lblSemestar.Text = "Semestar:";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatum.Location = new System.Drawing.Point(6, 160);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(182, 29);
            this.lblDatum.TabIndex = 3;
            this.lblDatum.Text = "Datum rodjenja:";
            // 
            // lblIndeks
            // 
            this.lblIndeks.AutoSize = true;
            this.lblIndeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIndeks.Location = new System.Drawing.Point(6, 194);
            this.lblIndeks.Name = "lblIndeks";
            this.lblIndeks.Size = new System.Drawing.Size(90, 29);
            this.lblIndeks.TabIndex = 4;
            this.lblIndeks.Text = "Indeks:";
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKorisnickoIme.Location = new System.Drawing.Point(6, 229);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(178, 29);
            this.lblKorisnickoIme.TabIndex = 5;
            this.lblKorisnickoIme.Text = "Korisnicko ime:";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLozinka.Location = new System.Drawing.Point(6, 269);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(101, 29);
            this.lblLozinka.TabIndex = 6;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // grpBoxStudentRegistracija
            // 
            this.grpBoxStudentRegistracija.Controls.Add(this.btnRegistracija);
            this.grpBoxStudentRegistracija.Controls.Add(this.dtpDatumrodjenja);
            this.grpBoxStudentRegistracija.Controls.Add(this.txtBoxPrezime);
            this.grpBoxStudentRegistracija.Controls.Add(this.txtBoxSemestar);
            this.grpBoxStudentRegistracija.Controls.Add(this.txtBoxLozinka);
            this.grpBoxStudentRegistracija.Controls.Add(this.txtBoxKorisnickoIme);
            this.grpBoxStudentRegistracija.Controls.Add(this.txtBoxIndeks);
            this.grpBoxStudentRegistracija.Controls.Add(this.txtBoxIme);
            this.grpBoxStudentRegistracija.Controls.Add(this.lblIme);
            this.grpBoxStudentRegistracija.Controls.Add(this.lblLozinka);
            this.grpBoxStudentRegistracija.Controls.Add(this.lblPrezime);
            this.grpBoxStudentRegistracija.Controls.Add(this.lblKorisnickoIme);
            this.grpBoxStudentRegistracija.Controls.Add(this.lblSemestar);
            this.grpBoxStudentRegistracija.Controls.Add(this.lblIndeks);
            this.grpBoxStudentRegistracija.Controls.Add(this.lblDatum);
            this.grpBoxStudentRegistracija.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpBoxStudentRegistracija.Location = new System.Drawing.Point(12, 12);
            this.grpBoxStudentRegistracija.Name = "grpBoxStudentRegistracija";
            this.grpBoxStudentRegistracija.Size = new System.Drawing.Size(503, 379);
            this.grpBoxStudentRegistracija.TabIndex = 7;
            this.grpBoxStudentRegistracija.TabStop = false;
            this.grpBoxStudentRegistracija.Text = "Registruj se !";
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRegistracija.Location = new System.Drawing.Point(309, 332);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(161, 37);
            this.btnRegistracija.TabIndex = 15;
            this.btnRegistracija.Text = "Registruj se";
            this.btnRegistracija.UseVisualStyleBackColor = true;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click);
            // 
            // dtpDatumrodjenja
            // 
            this.dtpDatumrodjenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpDatumrodjenja.Location = new System.Drawing.Point(270, 162);
            this.dtpDatumrodjenja.Name = "dtpDatumrodjenja";
            this.dtpDatumrodjenja.Size = new System.Drawing.Size(200, 29);
            this.dtpDatumrodjenja.TabIndex = 14;
            // 
            // txtBoxPrezime
            // 
            this.txtBoxPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxPrezime.Location = new System.Drawing.Point(127, 88);
            this.txtBoxPrezime.Name = "txtBoxPrezime";
            this.txtBoxPrezime.Size = new System.Drawing.Size(343, 29);
            this.txtBoxPrezime.TabIndex = 13;
            // 
            // txtBoxSemestar
            // 
            this.txtBoxSemestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxSemestar.Location = new System.Drawing.Point(127, 128);
            this.txtBoxSemestar.Name = "txtBoxSemestar";
            this.txtBoxSemestar.Size = new System.Drawing.Size(343, 29);
            this.txtBoxSemestar.TabIndex = 12;
            // 
            // txtBoxLozinka
            // 
            this.txtBoxLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxLozinka.Location = new System.Drawing.Point(124, 269);
            this.txtBoxLozinka.Name = "txtBoxLozinka";
            this.txtBoxLozinka.Size = new System.Drawing.Size(346, 29);
            this.txtBoxLozinka.TabIndex = 11;
            // 
            // txtBoxKorisnickoIme
            // 
            this.txtBoxKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxKorisnickoIme.Location = new System.Drawing.Point(185, 232);
            this.txtBoxKorisnickoIme.Name = "txtBoxKorisnickoIme";
            this.txtBoxKorisnickoIme.Size = new System.Drawing.Size(285, 29);
            this.txtBoxKorisnickoIme.TabIndex = 10;
            // 
            // txtBoxIndeks
            // 
            this.txtBoxIndeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxIndeks.Location = new System.Drawing.Point(202, 196);
            this.txtBoxIndeks.Name = "txtBoxIndeks";
            this.txtBoxIndeks.Size = new System.Drawing.Size(268, 29);
            this.txtBoxIndeks.TabIndex = 9;
            // 
            // txtBoxIme
            // 
            this.txtBoxIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxIme.Location = new System.Drawing.Point(124, 51);
            this.txtBoxIme.Name = "txtBoxIme";
            this.txtBoxIme.Size = new System.Drawing.Size(346, 29);
            this.txtBoxIme.TabIndex = 7;
            // 
            // errorRegistracijaStudent
            // 
            this.errorRegistracijaStudent.ContainerControl = this;
            // 
            // FrmRegistrujStudenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 393);
            this.Controls.Add(this.grpBoxStudentRegistracija);
            this.Name = "FrmRegistrujStudenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registracija";
            this.grpBoxStudentRegistracija.ResumeLayout(false);
            this.grpBoxStudentRegistracija.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorRegistracijaStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblSemestar;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblIndeks;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.GroupBox grpBoxStudentRegistracija;
        private System.Windows.Forms.DateTimePicker dtpDatumrodjenja;
        private System.Windows.Forms.TextBox txtBoxPrezime;
        private System.Windows.Forms.TextBox txtBoxSemestar;
        private System.Windows.Forms.TextBox txtBoxLozinka;
        private System.Windows.Forms.TextBox txtBoxKorisnickoIme;
        private System.Windows.Forms.TextBox txtBoxIndeks;
        private System.Windows.Forms.TextBox txtBoxIme;
        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.ErrorProvider errorRegistracijaStudent;
    }
}