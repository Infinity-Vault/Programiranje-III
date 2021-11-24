
namespace Predavanje8__23._11._2021._
{
    partial class frmPredavanje8
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
            this.txtBoxPrikaz = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxPrikaz
            // 
            this.txtBoxPrikaz.Location = new System.Drawing.Point(12, 12);
            this.txtBoxPrikaz.Multiline = true;
            this.txtBoxPrikaz.Name = "txtBoxPrikaz";
            this.txtBoxPrikaz.Size = new System.Drawing.Size(776, 426);
            this.txtBoxPrikaz.TabIndex = 0;
            // 
            // frmPredavanje8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxPrikaz);
            this.Name = "frmPredavanje8";
            this.Text = "Predavanje 8";
            this.Load += new System.EventHandler(this.frmPredavanje8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxPrikaz;
    }
}

