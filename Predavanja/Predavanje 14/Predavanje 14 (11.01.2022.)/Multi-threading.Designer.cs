namespace Predavanje_14__11._01._2022._
{
    partial class MT
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
            this.btnPokreni = new System.Windows.Forms.Button();
            this.txtBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPokreni
            // 
            this.btnPokreni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPokreni.Location = new System.Drawing.Point(657, 25);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(131, 27);
            this.btnPokreni.TabIndex = 0;
            this.btnPokreni.Text = "Pokreni";
            this.btnPokreni.UseVisualStyleBackColor = true;
            this.btnPokreni.Click += new System.EventHandler(this.btnPokreni_Click);
            // 
            // txtBoxResult
            // 
            this.txtBoxResult.Location = new System.Drawing.Point(12, 58);
            this.txtBoxResult.Multiline = true;
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxResult.Size = new System.Drawing.Size(776, 380);
            this.txtBoxResult.TabIndex = 1;
            // 
            // MT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 440);
            this.Controls.Add(this.txtBoxResult);
            this.Controls.Add(this.btnPokreni);
            this.Name = "MT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi Threading";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPokreni;
        private System.Windows.Forms.TextBox txtBoxResult;
    }
}

