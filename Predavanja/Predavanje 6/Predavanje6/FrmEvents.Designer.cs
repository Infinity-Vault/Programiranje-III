
namespace Predavanje6
{
    partial class FrmEvents
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
            this.txtBoxPrikaz = new System.Windows.Forms.RichTextBox();
            this.cbPrvaGodina = new System.Windows.Forms.CheckBox();
            this.cbDrugaGodina = new System.Windows.Forms.CheckBox();
            this.cbTrecaGodina = new System.Windows.Forms.CheckBox();
            this.cbCetvrtaGodina = new System.Windows.Forms.CheckBox();
            this.btnSendNotification = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxPrikaz
            // 
            this.txtBoxPrikaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxPrikaz.Location = new System.Drawing.Point(2, 2);
            this.txtBoxPrikaz.Name = "txtBoxPrikaz";
            this.txtBoxPrikaz.Size = new System.Drawing.Size(436, 215);
            this.txtBoxPrikaz.TabIndex = 0;
            this.txtBoxPrikaz.Text = "";
            // 
            // cbPrvaGodina
            // 
            this.cbPrvaGodina.AutoSize = true;
            this.cbPrvaGodina.Location = new System.Drawing.Point(10, 229);
            this.cbPrvaGodina.Name = "cbPrvaGodina";
            this.cbPrvaGodina.Size = new System.Drawing.Size(83, 17);
            this.cbPrvaGodina.TabIndex = 1;
            this.cbPrvaGodina.Text = "Prva godina";
            this.cbPrvaGodina.UseVisualStyleBackColor = true;
            this.cbPrvaGodina.CheckedChanged += new System.EventHandler(this.cbPrvaGodina_CheckedChanged);
            // 
            // cbDrugaGodina
            // 
            this.cbDrugaGodina.AutoSize = true;
            this.cbDrugaGodina.Location = new System.Drawing.Point(95, 229);
            this.cbDrugaGodina.Name = "cbDrugaGodina";
            this.cbDrugaGodina.Size = new System.Drawing.Size(90, 17);
            this.cbDrugaGodina.TabIndex = 2;
            this.cbDrugaGodina.Text = "Druga godina";
            this.cbDrugaGodina.UseVisualStyleBackColor = true;
            this.cbDrugaGodina.CheckedChanged += new System.EventHandler(this.cbDrugaGodina_CheckedChanged);
            // 
            // cbTrecaGodina
            // 
            this.cbTrecaGodina.AutoSize = true;
            this.cbTrecaGodina.Location = new System.Drawing.Point(183, 229);
            this.cbTrecaGodina.Name = "cbTrecaGodina";
            this.cbTrecaGodina.Size = new System.Drawing.Size(89, 17);
            this.cbTrecaGodina.TabIndex = 3;
            this.cbTrecaGodina.Text = "Treca godina";
            this.cbTrecaGodina.UseVisualStyleBackColor = true;
            this.cbTrecaGodina.CheckedChanged += new System.EventHandler(this.cbTrecaGodina_CheckedChanged);
            // 
            // cbCetvrtaGodina
            // 
            this.cbCetvrtaGodina.AutoSize = true;
            this.cbCetvrtaGodina.Location = new System.Drawing.Point(273, 229);
            this.cbCetvrtaGodina.Name = "cbCetvrtaGodina";
            this.cbCetvrtaGodina.Size = new System.Drawing.Size(95, 17);
            this.cbCetvrtaGodina.TabIndex = 4;
            this.cbCetvrtaGodina.Text = "Cetvrta godina";
            this.cbCetvrtaGodina.UseVisualStyleBackColor = true;
            this.cbCetvrtaGodina.CheckedChanged += new System.EventHandler(this.cbCetvrtaGodina_CheckedChanged);
            // 
            // btnSendNotification
            // 
            this.btnSendNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSendNotification.Location = new System.Drawing.Point(363, 225);
            this.btnSendNotification.Name = "btnSendNotification";
            this.btnSendNotification.Size = new System.Drawing.Size(75, 23);
            this.btnSendNotification.TabIndex = 5;
            this.btnSendNotification.Text = "Posalji";
            this.btnSendNotification.UseVisualStyleBackColor = true;
            this.btnSendNotification.Click += new System.EventHandler(this.btnSendNotification_Click);
            // 
            // FrmEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 258);
            this.Controls.Add(this.btnSendNotification);
            this.Controls.Add(this.cbCetvrtaGodina);
            this.Controls.Add(this.cbTrecaGodina);
            this.Controls.Add(this.cbDrugaGodina);
            this.Controls.Add(this.cbPrvaGodina);
            this.Controls.Add(this.txtBoxPrikaz);
            this.Name = "FrmEvents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikacija";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEvents_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmEvents_FormClosed);
            this.Load += new System.EventHandler(this.FrmEvents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtBoxPrikaz;
        private System.Windows.Forms.CheckBox cbPrvaGodina;
        private System.Windows.Forms.CheckBox cbDrugaGodina;
        private System.Windows.Forms.CheckBox cbTrecaGodina;
        private System.Windows.Forms.CheckBox cbCetvrtaGodina;
        private System.Windows.Forms.Button btnSendNotification;
    }
}

