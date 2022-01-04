namespace DLWMS.WinForms.P6
{
    partial class frmDogadjaji
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
            this.btnPosalji = new System.Windows.Forms.Button();
            this.txtObavijest = new System.Windows.Forms.TextBox();
            this.cbPrvaGodina = new System.Windows.Forms.CheckBox();
            this.cbDrugaGodina = new System.Windows.Forms.CheckBox();
            this.cbTrecaGodina = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(306, 121);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(75, 23);
            this.btnPosalji.TabIndex = 0;
            this.btnPosalji.Text = "Posalji";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtObavijest
            // 
            this.txtObavijest.Location = new System.Drawing.Point(12, 12);
            this.txtObavijest.Multiline = true;
            this.txtObavijest.Name = "txtObavijest";
            this.txtObavijest.Size = new System.Drawing.Size(369, 103);
            this.txtObavijest.TabIndex = 1;
            // 
            // cbPrvaGodina
            // 
            this.cbPrvaGodina.AutoSize = true;
            this.cbPrvaGodina.Location = new System.Drawing.Point(12, 125);
            this.cbPrvaGodina.Name = "cbPrvaGodina";
            this.cbPrvaGodina.Size = new System.Drawing.Size(83, 17);
            this.cbPrvaGodina.TabIndex = 2;
            this.cbPrvaGodina.Text = "Prva godina";
            this.cbPrvaGodina.UseVisualStyleBackColor = true;
            this.cbPrvaGodina.CheckedChanged += new System.EventHandler(this.cbPrvaGodina_CheckedChanged);
            // 
            // cbDrugaGodina
            // 
            this.cbDrugaGodina.AutoSize = true;
            this.cbDrugaGodina.Location = new System.Drawing.Point(101, 125);
            this.cbDrugaGodina.Name = "cbDrugaGodina";
            this.cbDrugaGodina.Size = new System.Drawing.Size(90, 17);
            this.cbDrugaGodina.TabIndex = 3;
            this.cbDrugaGodina.Text = "Druga godina";
            this.cbDrugaGodina.UseVisualStyleBackColor = true;
            this.cbDrugaGodina.CheckedChanged += new System.EventHandler(this.cbDrugaGodina_CheckedChanged);
            // 
            // cbTrecaGodina
            // 
            this.cbTrecaGodina.AutoSize = true;
            this.cbTrecaGodina.Location = new System.Drawing.Point(197, 125);
            this.cbTrecaGodina.Name = "cbTrecaGodina";
            this.cbTrecaGodina.Size = new System.Drawing.Size(89, 17);
            this.cbTrecaGodina.TabIndex = 4;
            this.cbTrecaGodina.Text = "Treca godina";
            this.cbTrecaGodina.UseVisualStyleBackColor = true;
            this.cbTrecaGodina.CheckedChanged += new System.EventHandler(this.cbTrecaGodina_CheckedChanged);
            // 
            // frmDogadjaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 160);
            this.Controls.Add(this.cbTrecaGodina);
            this.Controls.Add(this.cbDrugaGodina);
            this.Controls.Add(this.cbPrvaGodina);
            this.Controls.Add(this.txtObavijest);
            this.Controls.Add(this.btnPosalji);
            this.Name = "frmDogadjaji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDogadjaji";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDogadjaji_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDogadjaji_FormClosed);
            this.Load += new System.EventHandler(this.frmDogadjaji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.TextBox txtObavijest;
        private System.Windows.Forms.CheckBox cbPrvaGodina;
        private System.Windows.Forms.CheckBox cbDrugaGodina;
        private System.Windows.Forms.CheckBox cbTrecaGodina;
    }
}