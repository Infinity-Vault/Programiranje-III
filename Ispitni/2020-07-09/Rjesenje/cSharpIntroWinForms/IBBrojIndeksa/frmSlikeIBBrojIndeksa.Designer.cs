namespace cSharpIntroWinForms.IBBrojIndeksa
{
    partial class frmSlikeIBBrojIndeksa
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLijevo = new System.Windows.Forms.Button();
            this.btnDesno = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(250, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 346);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnLijevo
            // 
            this.btnLijevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLijevo.Location = new System.Drawing.Point(77, 134);
            this.btnLijevo.Name = "btnLijevo";
            this.btnLijevo.Size = new System.Drawing.Size(75, 80);
            this.btnLijevo.TabIndex = 1;
            this.btnLijevo.Text = "<";
            this.btnLijevo.UseVisualStyleBackColor = true;
            this.btnLijevo.Click += new System.EventHandler(this.btnLijevo_Click);
            // 
            // btnDesno
            // 
            this.btnDesno.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesno.Location = new System.Drawing.Point(604, 134);
            this.btnDesno.Name = "btnDesno";
            this.btnDesno.Size = new System.Drawing.Size(75, 80);
            this.btnDesno.TabIndex = 2;
            this.btnDesno.Text = ">";
            this.btnDesno.UseVisualStyleBackColor = true;
            this.btnDesno.Click += new System.EventHandler(this.btnDesno_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmSlikeIBBrojIndeksa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 421);
            this.Controls.Add(this.btnDesno);
            this.Controls.Add(this.btnLijevo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmSlikeIBBrojIndeksa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slike korisnika";
            this.Load += new System.EventHandler(this.frmSlikeIBBrojIndeksa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLijevo;
        private System.Windows.Forms.Button btnDesno;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}