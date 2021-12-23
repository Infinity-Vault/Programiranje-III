namespace Vjezbe_9__09._12._2021._
{
    partial class fmrDodajPredmetUDB
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
            this.btnDodajPredmet = new System.Windows.Forms.Button();
            this.cmbGodina = new System.Windows.Forms.ComboBox();
            this.lblGodina = new System.Windows.Forms.Label();
            this.txtBoxOcjena = new System.Windows.Forms.TextBox();
            this.lblOcjena = new System.Windows.Forms.Label();
            this.txtBoxNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDodajPredmet
            // 
            this.btnDodajPredmet.Location = new System.Drawing.Point(308, 185);
            this.btnDodajPredmet.Name = "btnDodajPredmet";
            this.btnDodajPredmet.Size = new System.Drawing.Size(111, 23);
            this.btnDodajPredmet.TabIndex = 13;
            this.btnDodajPredmet.Text = "Dodaj predmet:";
            this.btnDodajPredmet.UseVisualStyleBackColor = true;
            this.btnDodajPredmet.Click += new System.EventHandler(this.btnDodajPredmet_Click);
            // 
            // cmbGodina
            // 
            this.cmbGodina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGodina.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbGodina.FormattingEnabled = true;
            this.cmbGodina.Location = new System.Drawing.Point(147, 139);
            this.cmbGodina.Name = "cmbGodina";
            this.cmbGodina.Size = new System.Drawing.Size(272, 33);
            this.cmbGodina.TabIndex = 12;
            // 
            // lblGodina
            // 
            this.lblGodina.AutoSize = true;
            this.lblGodina.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGodina.Location = new System.Drawing.Point(20, 136);
            this.lblGodina.Name = "lblGodina";
            this.lblGodina.Size = new System.Drawing.Size(109, 31);
            this.lblGodina.TabIndex = 11;
            this.lblGodina.Text = "Godina:";
            // 
            // txtBoxOcjena
            // 
            this.txtBoxOcjena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxOcjena.Location = new System.Drawing.Point(147, 80);
            this.txtBoxOcjena.Name = "txtBoxOcjena";
            this.txtBoxOcjena.Size = new System.Drawing.Size(272, 30);
            this.txtBoxOcjena.TabIndex = 10;
            // 
            // lblOcjena
            // 
            this.lblOcjena.AutoSize = true;
            this.lblOcjena.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOcjena.Location = new System.Drawing.Point(20, 77);
            this.lblOcjena.Name = "lblOcjena";
            this.lblOcjena.Size = new System.Drawing.Size(108, 31);
            this.lblOcjena.TabIndex = 9;
            this.lblOcjena.Text = "Ocjena:";
            // 
            // txtBoxNaziv
            // 
            this.txtBoxNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxNaziv.Location = new System.Drawing.Point(147, 22);
            this.txtBoxNaziv.Name = "txtBoxNaziv";
            this.txtBoxNaziv.Size = new System.Drawing.Size(272, 30);
            this.txtBoxNaziv.TabIndex = 8;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaziv.Location = new System.Drawing.Point(20, 22);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(91, 31);
            this.lblNaziv.TabIndex = 7;
            this.lblNaziv.Text = "Naziv:";
            // 
            // fmrDodajPredmetUDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 212);
            this.Controls.Add(this.btnDodajPredmet);
            this.Controls.Add(this.cmbGodina);
            this.Controls.Add(this.lblGodina);
            this.Controls.Add(this.txtBoxOcjena);
            this.Controls.Add(this.lblOcjena);
            this.Controls.Add(this.txtBoxNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Name = "fmrDodajPredmetUDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj Predmet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajPredmet;
        private System.Windows.Forms.ComboBox cmbGodina;
        private System.Windows.Forms.Label lblGodina;
        private System.Windows.Forms.TextBox txtBoxOcjena;
        private System.Windows.Forms.Label lblOcjena;
        private System.Windows.Forms.TextBox txtBoxNaziv;
        private System.Windows.Forms.Label lblNaziv;
    }
}