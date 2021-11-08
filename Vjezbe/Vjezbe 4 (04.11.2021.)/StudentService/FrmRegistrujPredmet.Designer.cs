
namespace StudentService
{
    partial class FrmRegistrujPredmet
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
            this.grpBoxDodajPredmet = new System.Windows.Forms.GroupBox();
            this.btnDodajPredmet = new System.Windows.Forms.Button();
            this.txtBoxNaziv = new System.Windows.Forms.TextBox();
            this.txtBoxSemestar = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblSemestar = new System.Windows.Forms.Label();
            this.errorDodajPredmet = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtBoxIdProfesora = new System.Windows.Forms.TextBox();
            this.lblIdProfesora = new System.Windows.Forms.Label();
            this.grpBoxDodajPredmet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorDodajPredmet)).BeginInit();
            this.SuspendLayout();
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
            this.grpBoxDodajPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpBoxDodajPredmet.Location = new System.Drawing.Point(12, 12);
            this.grpBoxDodajPredmet.Name = "grpBoxDodajPredmet";
            this.grpBoxDodajPredmet.Size = new System.Drawing.Size(481, 186);
            this.grpBoxDodajPredmet.TabIndex = 0;
            this.grpBoxDodajPredmet.TabStop = false;
            this.grpBoxDodajPredmet.Text = "Kreiraj predmet";
            // 
            // btnDodajPredmet
            // 
            this.btnDodajPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajPredmet.Location = new System.Drawing.Point(333, 142);
            this.btnDodajPredmet.Name = "btnDodajPredmet";
            this.btnDodajPredmet.Size = new System.Drawing.Size(124, 38);
            this.btnDodajPredmet.TabIndex = 33;
            this.btnDodajPredmet.Text = "Dodaj";
            this.btnDodajPredmet.UseVisualStyleBackColor = true;
            this.btnDodajPredmet.Click += new System.EventHandler(this.btnDodajPredmet_Click);
            // 
            // txtBoxNaziv
            // 
            this.txtBoxNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxNaziv.Location = new System.Drawing.Point(114, 69);
            this.txtBoxNaziv.Name = "txtBoxNaziv";
            this.txtBoxNaziv.Size = new System.Drawing.Size(343, 29);
            this.txtBoxNaziv.TabIndex = 32;
            // 
            // txtBoxSemestar
            // 
            this.txtBoxSemestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxSemestar.Location = new System.Drawing.Point(114, 107);
            this.txtBoxSemestar.Name = "txtBoxSemestar";
            this.txtBoxSemestar.Size = new System.Drawing.Size(343, 29);
            this.txtBoxSemestar.TabIndex = 31;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaziv.Location = new System.Drawing.Point(-7, 69);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(78, 29);
            this.lblNaziv.TabIndex = 29;
            this.lblNaziv.Text = "Naziv:";
            // 
            // lblSemestar
            // 
            this.lblSemestar.AutoSize = true;
            this.lblSemestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSemestar.Location = new System.Drawing.Point(-7, 104);
            this.lblSemestar.Name = "lblSemestar";
            this.lblSemestar.Size = new System.Drawing.Size(122, 29);
            this.lblSemestar.TabIndex = 30;
            this.lblSemestar.Text = "Semestar:";
            // 
            // errorDodajPredmet
            // 
            this.errorDodajPredmet.ContainerControl = this;
            // 
            // txtBoxIdProfesora
            // 
            this.txtBoxIdProfesora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxIdProfesora.Location = new System.Drawing.Point(138, 37);
            this.txtBoxIdProfesora.Name = "txtBoxIdProfesora";
            this.txtBoxIdProfesora.Size = new System.Drawing.Size(319, 29);
            this.txtBoxIdProfesora.TabIndex = 35;
            // 
            // lblIdProfesora
            // 
            this.lblIdProfesora.AutoSize = true;
            this.lblIdProfesora.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIdProfesora.Location = new System.Drawing.Point(-7, 37);
            this.lblIdProfesora.Name = "lblIdProfesora";
            this.lblIdProfesora.Size = new System.Drawing.Size(148, 29);
            this.lblIdProfesora.TabIndex = 34;
            this.lblIdProfesora.Text = "Id profesora:";
            // 
            // FrmRegistrujPredmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 204);
            this.Controls.Add(this.grpBoxDodajPredmet);
            this.Name = "FrmRegistrujPredmet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registruj predmet";
            this.grpBoxDodajPredmet.ResumeLayout(false);
            this.grpBoxDodajPredmet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorDodajPredmet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxDodajPredmet;
        private System.Windows.Forms.Button btnDodajPredmet;
        private System.Windows.Forms.TextBox txtBoxNaziv;
        private System.Windows.Forms.TextBox txtBoxSemestar;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblSemestar;
        private System.Windows.Forms.ErrorProvider errorDodajPredmet;
        private System.Windows.Forms.TextBox txtBoxIdProfesora;
        private System.Windows.Forms.Label lblIdProfesora;
    }
}