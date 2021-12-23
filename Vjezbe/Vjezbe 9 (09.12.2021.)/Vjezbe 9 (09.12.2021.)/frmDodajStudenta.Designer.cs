namespace Vjezbe_9__09._12._2021._  
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
            this.lblIme = new System.Windows.Forms.Label();
            this.txtBoxIme = new System.Windows.Forms.TextBox();
            this.txtBoxPrezime = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblGodina = new System.Windows.Forms.Label();
            this.cmbGodina = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIme.Location = new System.Drawing.Point(43, 56);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(67, 31);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime:";
            // 
            // txtBoxIme
            // 
            this.txtBoxIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxIme.Location = new System.Drawing.Point(170, 56);
            this.txtBoxIme.Name = "txtBoxIme";
            this.txtBoxIme.Size = new System.Drawing.Size(272, 30);
            this.txtBoxIme.TabIndex = 1;
            // 
            // txtBoxPrezime
            // 
            this.txtBoxPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxPrezime.Location = new System.Drawing.Point(170, 114);
            this.txtBoxPrezime.Name = "txtBoxPrezime";
            this.txtBoxPrezime.Size = new System.Drawing.Size(272, 30);
            this.txtBoxPrezime.TabIndex = 3;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrezime.Location = new System.Drawing.Point(43, 111);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(121, 31);
            this.lblPrezime.TabIndex = 2;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblGodina
            // 
            this.lblGodina.AutoSize = true;
            this.lblGodina.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGodina.Location = new System.Drawing.Point(43, 170);
            this.lblGodina.Name = "lblGodina";
            this.lblGodina.Size = new System.Drawing.Size(101, 31);
            this.lblGodina.TabIndex = 4;
            this.lblGodina.Text = "Godina";
            // 
            // cmbGodina
            // 
            this.cmbGodina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGodina.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbGodina.FormattingEnabled = true;
            this.cmbGodina.Location = new System.Drawing.Point(170, 180);
            this.cmbGodina.Name = "cmbGodina";
            this.cmbGodina.Size = new System.Drawing.Size(272, 33);
            this.cmbGodina.TabIndex = 5;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(331, 219);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(111, 23);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj studenta";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // frmDodajStudenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 261);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cmbGodina);
            this.Controls.Add(this.lblGodina);
            this.Controls.Add(this.txtBoxPrezime);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.txtBoxIme);
            this.Controls.Add(this.lblIme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDodajStudenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj studenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtBoxIme;
        private System.Windows.Forms.TextBox txtBoxPrezime;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblGodina;
        private System.Windows.Forms.ComboBox cmbGodina;
        private System.Windows.Forms.Button btnDodaj;
    }
}