
namespace StudentService
{
    partial class FrmWelcome
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
            this.pbFitLogo = new System.Windows.Forms.PictureBox();
            this.lblFitOpis = new System.Windows.Forms.Label();
            this.grpBoxStudentPrijava = new System.Windows.Forms.GroupBox();
            this.linlblRegistracijaS = new System.Windows.Forms.LinkLabel();
            this.btnPrijavaS = new System.Windows.Forms.Button();
            this.txtBoxLozinkaS = new System.Windows.Forms.TextBox();
            this.txtBoxKorisnickoImeS = new System.Windows.Forms.TextBox();
            this.lblLozinkaS = new System.Windows.Forms.Label();
            this.lblKorisnickoImeS = new System.Windows.Forms.Label();
            this.grpBoxProfesorPrijava = new System.Windows.Forms.GroupBox();
            this.linlblRegistracijaP = new System.Windows.Forms.LinkLabel();
            this.btnPrijavaP = new System.Windows.Forms.Button();
            this.txtBoxLozinkaP = new System.Windows.Forms.TextBox();
            this.lblLozinkaP = new System.Windows.Forms.Label();
            this.txtBoxKorisnickoImeP = new System.Windows.Forms.TextBox();
            this.lblKorisnickoImeP = new System.Windows.Forms.Label();
            this.errorLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpBoxDodajPredmet = new System.Windows.Forms.GroupBox();
            this.txtBoxIdProfesora = new System.Windows.Forms.TextBox();
            this.lblIdProfesora = new System.Windows.Forms.Label();
            this.btnDodajPredmet = new System.Windows.Forms.Button();
            this.txtBoxNaziv = new System.Windows.Forms.TextBox();
            this.txtBoxSemestar = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblSemestar = new System.Windows.Forms.Label();
            this.errorDodajPredmet = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbFitLogo)).BeginInit();
            this.grpBoxStudentPrijava.SuspendLayout();
            this.grpBoxProfesorPrijava.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorLogin)).BeginInit();
            this.grpBoxDodajPredmet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorDodajPredmet)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFitLogo
            // 
            this.pbFitLogo.Location = new System.Drawing.Point(12, 12);
            this.pbFitLogo.Name = "pbFitLogo";
            this.pbFitLogo.Size = new System.Drawing.Size(236, 179);
            this.pbFitLogo.TabIndex = 0;
            this.pbFitLogo.TabStop = false;
            // 
            // lblFitOpis
            // 
            this.lblFitOpis.AutoSize = true;
            this.lblFitOpis.Location = new System.Drawing.Point(12, 194);
            this.lblFitOpis.Name = "lblFitOpis";
            this.lblFitOpis.Size = new System.Drawing.Size(220, 52);
            this.lblFitOpis.TabIndex = 1;
            this.lblFitOpis.Text = "Dobrodosli na StudentService FIT-a !\r\n\r\nFakultet Informacijskih Tehnologija u Mos" +
    "taru\r\nww.fit.ba\r\n";
            // 
            // grpBoxStudentPrijava
            // 
            this.grpBoxStudentPrijava.Controls.Add(this.linlblRegistracijaS);
            this.grpBoxStudentPrijava.Controls.Add(this.btnPrijavaS);
            this.grpBoxStudentPrijava.Controls.Add(this.txtBoxLozinkaS);
            this.grpBoxStudentPrijava.Controls.Add(this.txtBoxKorisnickoImeS);
            this.grpBoxStudentPrijava.Controls.Add(this.lblLozinkaS);
            this.grpBoxStudentPrijava.Controls.Add(this.lblKorisnickoImeS);
            this.grpBoxStudentPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpBoxStudentPrijava.Location = new System.Drawing.Point(286, 12);
            this.grpBoxStudentPrijava.Name = "grpBoxStudentPrijava";
            this.grpBoxStudentPrijava.Size = new System.Drawing.Size(493, 201);
            this.grpBoxStudentPrijava.TabIndex = 2;
            this.grpBoxStudentPrijava.TabStop = false;
            this.grpBoxStudentPrijava.Text = "Student Log in";
            // 
            // linlblRegistracijaS
            // 
            this.linlblRegistracijaS.AutoSize = true;
            this.linlblRegistracijaS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linlblRegistracijaS.Location = new System.Drawing.Point(6, 174);
            this.linlblRegistracijaS.Name = "linlblRegistracijaS";
            this.linlblRegistracijaS.Size = new System.Drawing.Size(148, 24);
            this.linlblRegistracijaS.TabIndex = 5;
            this.linlblRegistracijaS.TabStop = true;
            this.linlblRegistracijaS.Text = "Nisi registrovan?";
            this.linlblRegistracijaS.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linlblRegistracijaS_LinkClicked);
            // 
            // btnPrijavaS
            // 
            this.btnPrijavaS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrijavaS.Location = new System.Drawing.Point(369, 166);
            this.btnPrijavaS.Name = "btnPrijavaS";
            this.btnPrijavaS.Size = new System.Drawing.Size(84, 29);
            this.btnPrijavaS.TabIndex = 4;
            this.btnPrijavaS.Text = "Log in";
            this.btnPrijavaS.UseVisualStyleBackColor = true;
            this.btnPrijavaS.Click += new System.EventHandler(this.btnPrijavaS_Click);
            // 
            // txtBoxLozinkaS
            // 
            this.txtBoxLozinkaS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxLozinkaS.Location = new System.Drawing.Point(157, 73);
            this.txtBoxLozinkaS.Name = "txtBoxLozinkaS";
            this.txtBoxLozinkaS.PasswordChar = '*';
            this.txtBoxLozinkaS.Size = new System.Drawing.Size(296, 23);
            this.txtBoxLozinkaS.TabIndex = 3;
            // 
            // txtBoxKorisnickoImeS
            // 
            this.txtBoxKorisnickoImeS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxKorisnickoImeS.Location = new System.Drawing.Point(157, 44);
            this.txtBoxKorisnickoImeS.Name = "txtBoxKorisnickoImeS";
            this.txtBoxKorisnickoImeS.Size = new System.Drawing.Size(296, 23);
            this.txtBoxKorisnickoImeS.TabIndex = 2;
            // 
            // lblLozinkaS
            // 
            this.lblLozinkaS.AutoSize = true;
            this.lblLozinkaS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLozinkaS.Location = new System.Drawing.Point(6, 71);
            this.lblLozinkaS.Name = "lblLozinkaS";
            this.lblLozinkaS.Size = new System.Drawing.Size(86, 25);
            this.lblLozinkaS.TabIndex = 1;
            this.lblLozinkaS.Text = "Lozinka:";
            // 
            // lblKorisnickoImeS
            // 
            this.lblKorisnickoImeS.AutoSize = true;
            this.lblKorisnickoImeS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKorisnickoImeS.Location = new System.Drawing.Point(6, 42);
            this.lblKorisnickoImeS.Name = "lblKorisnickoImeS";
            this.lblKorisnickoImeS.Size = new System.Drawing.Size(145, 25);
            this.lblKorisnickoImeS.TabIndex = 0;
            this.lblKorisnickoImeS.Text = "Korisnicko ime:";
            // 
            // grpBoxProfesorPrijava
            // 
            this.grpBoxProfesorPrijava.Controls.Add(this.linlblRegistracijaP);
            this.grpBoxProfesorPrijava.Controls.Add(this.btnPrijavaP);
            this.grpBoxProfesorPrijava.Controls.Add(this.txtBoxLozinkaP);
            this.grpBoxProfesorPrijava.Controls.Add(this.lblLozinkaP);
            this.grpBoxProfesorPrijava.Controls.Add(this.txtBoxKorisnickoImeP);
            this.grpBoxProfesorPrijava.Controls.Add(this.lblKorisnickoImeP);
            this.grpBoxProfesorPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpBoxProfesorPrijava.Location = new System.Drawing.Point(286, 219);
            this.grpBoxProfesorPrijava.Name = "grpBoxProfesorPrijava";
            this.grpBoxProfesorPrijava.Size = new System.Drawing.Size(493, 227);
            this.grpBoxProfesorPrijava.TabIndex = 3;
            this.grpBoxProfesorPrijava.TabStop = false;
            this.grpBoxProfesorPrijava.Text = "Profesor Log in";
            // 
            // linlblRegistracijaP
            // 
            this.linlblRegistracijaP.AutoSize = true;
            this.linlblRegistracijaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linlblRegistracijaP.Location = new System.Drawing.Point(7, 200);
            this.linlblRegistracijaP.Name = "linlblRegistracijaP";
            this.linlblRegistracijaP.Size = new System.Drawing.Size(148, 24);
            this.linlblRegistracijaP.TabIndex = 6;
            this.linlblRegistracijaP.TabStop = true;
            this.linlblRegistracijaP.Text = "Nisi registrovan?";
            this.linlblRegistracijaP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linlblRegistracijaP_LinkClicked);
            // 
            // btnPrijavaP
            // 
            this.btnPrijavaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrijavaP.Location = new System.Drawing.Point(369, 195);
            this.btnPrijavaP.Name = "btnPrijavaP";
            this.btnPrijavaP.Size = new System.Drawing.Size(84, 29);
            this.btnPrijavaP.TabIndex = 5;
            this.btnPrijavaP.Text = "Log in";
            this.btnPrijavaP.UseVisualStyleBackColor = true;
            this.btnPrijavaP.Click += new System.EventHandler(this.btnPrijavaP_Click);
            // 
            // txtBoxLozinkaP
            // 
            this.txtBoxLozinkaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxLozinkaP.Location = new System.Drawing.Point(157, 75);
            this.txtBoxLozinkaP.Name = "txtBoxLozinkaP";
            this.txtBoxLozinkaP.PasswordChar = '*';
            this.txtBoxLozinkaP.Size = new System.Drawing.Size(296, 23);
            this.txtBoxLozinkaP.TabIndex = 5;
            // 
            // lblLozinkaP
            // 
            this.lblLozinkaP.AutoSize = true;
            this.lblLozinkaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLozinkaP.Location = new System.Drawing.Point(6, 71);
            this.lblLozinkaP.Name = "lblLozinkaP";
            this.lblLozinkaP.Size = new System.Drawing.Size(86, 25);
            this.lblLozinkaP.TabIndex = 3;
            this.lblLozinkaP.Text = "Lozinka:";
            // 
            // txtBoxKorisnickoImeP
            // 
            this.txtBoxKorisnickoImeP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxKorisnickoImeP.Location = new System.Drawing.Point(157, 46);
            this.txtBoxKorisnickoImeP.Name = "txtBoxKorisnickoImeP";
            this.txtBoxKorisnickoImeP.Size = new System.Drawing.Size(296, 23);
            this.txtBoxKorisnickoImeP.TabIndex = 4;
            // 
            // lblKorisnickoImeP
            // 
            this.lblKorisnickoImeP.AutoSize = true;
            this.lblKorisnickoImeP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKorisnickoImeP.Location = new System.Drawing.Point(6, 42);
            this.lblKorisnickoImeP.Name = "lblKorisnickoImeP";
            this.lblKorisnickoImeP.Size = new System.Drawing.Size(145, 25);
            this.lblKorisnickoImeP.TabIndex = 2;
            this.lblKorisnickoImeP.Text = "Korisnicko ime:";
            // 
            // errorLogin
            // 
            this.errorLogin.ContainerControl = this;
            // 
            // grpBoxDodajPredmet
            // 
            this.grpBoxDodajPredmet.Controls.Add(this.txtBoxIdProfesora);
            this.grpBoxDodajPredmet.Controls.Add(this.lblIdProfesora);
            this.grpBoxDodajPredmet.Controls.Add(this.btnDodajPredmet);
            this.grpBoxDodajPredmet.Controls.Add(this.txtBoxNaziv);
            this.grpBoxDodajPredmet.Controls.Add(this.txtBoxSemestar);
            this.grpBoxDodajPredmet.Controls.Add(this.lblNaziv);
            this.grpBoxDodajPredmet.Controls.Add(this.lblSemestar);
            this.grpBoxDodajPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpBoxDodajPredmet.Location = new System.Drawing.Point(12, 271);
            this.grpBoxDodajPredmet.Name = "grpBoxDodajPredmet";
            this.grpBoxDodajPredmet.Size = new System.Drawing.Size(255, 175);
            this.grpBoxDodajPredmet.TabIndex = 4;
            this.grpBoxDodajPredmet.TabStop = false;
            this.grpBoxDodajPredmet.Text = "Kreiraj predmet";
            // 
            // txtBoxIdProfesora
            // 
            this.txtBoxIdProfesora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxIdProfesora.Location = new System.Drawing.Point(103, 39);
            this.txtBoxIdProfesora.Name = "txtBoxIdProfesora";
            this.txtBoxIdProfesora.Size = new System.Drawing.Size(133, 22);
            this.txtBoxIdProfesora.TabIndex = 35;
            // 
            // lblIdProfesora
            // 
            this.lblIdProfesora.AutoSize = true;
            this.lblIdProfesora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIdProfesora.Location = new System.Drawing.Point(4, 39);
            this.lblIdProfesora.Name = "lblIdProfesora";
            this.lblIdProfesora.Size = new System.Drawing.Size(83, 16);
            this.lblIdProfesora.TabIndex = 34;
            this.lblIdProfesora.Text = "Id profesora:";
            // 
            // btnDodajPredmet
            // 
            this.btnDodajPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajPredmet.Location = new System.Drawing.Point(149, 128);
            this.btnDodajPredmet.Name = "btnDodajPredmet";
            this.btnDodajPredmet.Size = new System.Drawing.Size(87, 41);
            this.btnDodajPredmet.TabIndex = 33;
            this.btnDodajPredmet.Text = "Dodaj";
            this.btnDodajPredmet.UseVisualStyleBackColor = true;
            this.btnDodajPredmet.Click += new System.EventHandler(this.btnDodajPredmet_Click);
            // 
            // txtBoxNaziv
            // 
            this.txtBoxNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxNaziv.Location = new System.Drawing.Point(79, 67);
            this.txtBoxNaziv.Name = "txtBoxNaziv";
            this.txtBoxNaziv.Size = new System.Drawing.Size(157, 22);
            this.txtBoxNaziv.TabIndex = 32;
            // 
            // txtBoxSemestar
            // 
            this.txtBoxSemestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxSemestar.Location = new System.Drawing.Point(79, 103);
            this.txtBoxSemestar.Name = "txtBoxSemestar";
            this.txtBoxSemestar.Size = new System.Drawing.Size(157, 22);
            this.txtBoxSemestar.TabIndex = 31;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaziv.Location = new System.Drawing.Point(4, 71);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(45, 16);
            this.lblNaziv.TabIndex = 29;
            this.lblNaziv.Text = "Naziv:";
            // 
            // lblSemestar
            // 
            this.lblSemestar.AutoSize = true;
            this.lblSemestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSemestar.Location = new System.Drawing.Point(4, 106);
            this.lblSemestar.Name = "lblSemestar";
            this.lblSemestar.Size = new System.Drawing.Size(69, 16);
            this.lblSemestar.TabIndex = 30;
            this.lblSemestar.Text = "Semestar:";
            // 
            // errorDodajPredmet
            // 
            this.errorDodajPredmet.ContainerControl = this;
            // 
            // FrmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 455);
            this.Controls.Add(this.grpBoxDodajPredmet);
            this.Controls.Add(this.grpBoxProfesorPrijava);
            this.Controls.Add(this.grpBoxStudentPrijava);
            this.Controls.Add(this.lblFitOpis);
            this.Controls.Add(this.pbFitLogo);
            this.Name = "FrmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.pbFitLogo)).EndInit();
            this.grpBoxStudentPrijava.ResumeLayout(false);
            this.grpBoxStudentPrijava.PerformLayout();
            this.grpBoxProfesorPrijava.ResumeLayout(false);
            this.grpBoxProfesorPrijava.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorLogin)).EndInit();
            this.grpBoxDodajPredmet.ResumeLayout(false);
            this.grpBoxDodajPredmet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorDodajPredmet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFitLogo;
        private System.Windows.Forms.Label lblFitOpis;
        private System.Windows.Forms.GroupBox grpBoxStudentPrijava;
        private System.Windows.Forms.GroupBox grpBoxProfesorPrijava;
        private System.Windows.Forms.Button btnPrijavaS;
        private System.Windows.Forms.TextBox txtBoxLozinkaS;
        private System.Windows.Forms.TextBox txtBoxKorisnickoImeS;
        private System.Windows.Forms.Label lblLozinkaS;
        private System.Windows.Forms.Label lblKorisnickoImeS;
        private System.Windows.Forms.Button btnPrijavaP;
        private System.Windows.Forms.TextBox txtBoxLozinkaP;
        private System.Windows.Forms.Label lblLozinkaP;
        private System.Windows.Forms.TextBox txtBoxKorisnickoImeP;
        private System.Windows.Forms.Label lblKorisnickoImeP;
        private System.Windows.Forms.ErrorProvider errorLogin;
        private System.Windows.Forms.LinkLabel linlblRegistracijaS;
        private System.Windows.Forms.LinkLabel linlblRegistracijaP;
        private System.Windows.Forms.GroupBox grpBoxDodajPredmet;
        private System.Windows.Forms.TextBox txtBoxIdProfesora;
        private System.Windows.Forms.Label lblIdProfesora;
        private System.Windows.Forms.Button btnDodajPredmet;
        private System.Windows.Forms.TextBox txtBoxNaziv;
        private System.Windows.Forms.TextBox txtBoxSemestar;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblSemestar;
        private System.Windows.Forms.ErrorProvider errorDodajPredmet;
    }
}

