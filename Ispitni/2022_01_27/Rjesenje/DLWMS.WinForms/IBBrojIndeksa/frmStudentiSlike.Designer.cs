
namespace DLWMS.WinForms.IBBrojIndeksa
{
    partial class frmStudentiSlike
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
            this.label1 = new System.Windows.Forms.Label();
            this.pcTrenutna = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLijevo = new System.Windows.Forms.Button();
            this.btnDesno = new System.Windows.Forms.Button();
            this.lblRedniBroj = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblOpisTrenutno = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pcTrenutna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Slika:";
            // 
            // pcTrenutna
            // 
            this.pcTrenutna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcTrenutna.Location = new System.Drawing.Point(16, 38);
            this.pcTrenutna.Name = "pcTrenutna";
            this.pcTrenutna.Size = new System.Drawing.Size(100, 127);
            this.pcTrenutna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcTrenutna.TabIndex = 1;
            this.pcTrenutna.TabStop = false;
            this.pcTrenutna.DoubleClick += new System.EventHandler(this.pcTrenutna_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opis:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 47);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 93);
            this.textBox1.TabIndex = 3;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(424, 155);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj sliku";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pregled slike: ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(123, 215);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(253, 229);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btnLijevo
            // 
            this.btnLijevo.Location = new System.Drawing.Point(16, 295);
            this.btnLijevo.Name = "btnLijevo";
            this.btnLijevo.Size = new System.Drawing.Size(75, 23);
            this.btnLijevo.TabIndex = 7;
            this.btnLijevo.Text = "<=";
            this.btnLijevo.UseVisualStyleBackColor = true;
            this.btnLijevo.Click += new System.EventHandler(this.btnLijevo_Click);
            // 
            // btnDesno
            // 
            this.btnDesno.Location = new System.Drawing.Point(412, 295);
            this.btnDesno.Name = "btnDesno";
            this.btnDesno.Size = new System.Drawing.Size(75, 23);
            this.btnDesno.TabIndex = 8;
            this.btnDesno.Text = "=>";
            this.btnDesno.UseVisualStyleBackColor = true;
            this.btnDesno.Click += new System.EventHandler(this.btnDesno_Click);
            // 
            // lblRedniBroj
            // 
            this.lblRedniBroj.AutoSize = true;
            this.lblRedniBroj.Location = new System.Drawing.Point(210, 199);
            this.lblRedniBroj.Name = "lblRedniBroj";
            this.lblRedniBroj.Size = new System.Drawing.Size(0, 13);
            this.lblRedniBroj.TabIndex = 9;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(227, 451);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(38, 13);
            this.lblDatum.TabIndex = 10;
            this.lblDatum.Text = "Datum";
            // 
            // lblOpisTrenutno
            // 
            this.lblOpisTrenutno.AutoSize = true;
            this.lblOpisTrenutno.Location = new System.Drawing.Point(230, 484);
            this.lblOpisTrenutno.Name = "lblOpisTrenutno";
            this.lblOpisTrenutno.Size = new System.Drawing.Size(81, 13);
            this.lblOpisTrenutno.TabIndex = 11;
            this.lblOpisTrenutno.Text = "lblOpisTrenutno";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmStudentiSlike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 645);
            this.Controls.Add(this.lblOpisTrenutno);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblRedniBroj);
            this.Controls.Add(this.btnDesno);
            this.Controls.Add(this.btnLijevo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pcTrenutna);
            this.Controls.Add(this.label1);
            this.Name = "frmStudentiSlike";
            this.Text = "frmStudentiSlike";
            this.Load += new System.EventHandler(this.frmStudentiSlike_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcTrenutna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcTrenutna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLijevo;
        private System.Windows.Forms.Button btnDesno;
        private System.Windows.Forms.Label lblRedniBroj;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblOpisTrenutno;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}