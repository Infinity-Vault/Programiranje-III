
namespace DLWMS.frm
{
    partial class frmLogin
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
            this.lblPrvi = new System.Windows.Forms.Label();
            this.lblDrugi = new System.Windows.Forms.Label();
            this.txtBoxPrvi = new System.Windows.Forms.TextBox();
            this.txtBoxDrugi = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrvi
            // 
            this.lblPrvi.AutoSize = true;
            this.lblPrvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrvi.Location = new System.Drawing.Point(21, 48);
            this.lblPrvi.Name = "lblPrvi";
            this.lblPrvi.Size = new System.Drawing.Size(87, 20);
            this.lblPrvi.TabIndex = 0;
            this.lblPrvi.Text = "Prvi igrac:";
            // 
            // lblDrugi
            // 
            this.lblDrugi.AutoSize = true;
            this.lblDrugi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDrugi.Location = new System.Drawing.Point(21, 80);
            this.lblDrugi.Name = "lblDrugi";
            this.lblDrugi.Size = new System.Drawing.Size(101, 20);
            this.lblDrugi.TabIndex = 1;
            this.lblDrugi.Text = "Drugi igrac:";
            // 
            // txtBoxPrvi
            // 
            this.txtBoxPrvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxPrvi.Location = new System.Drawing.Point(114, 50);
            this.txtBoxPrvi.Name = "txtBoxPrvi";
            this.txtBoxPrvi.Size = new System.Drawing.Size(238, 26);
            this.txtBoxPrvi.TabIndex = 2;
            // 
            // txtBoxDrugi
            // 
            this.txtBoxDrugi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxDrugi.Location = new System.Drawing.Point(128, 82);
            this.txtBoxDrugi.Name = "txtBoxDrugi";
            this.txtBoxDrugi.Size = new System.Drawing.Size(238, 26);
            this.txtBoxDrugi.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStart.Location = new System.Drawing.Point(128, 131);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(143, 40);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Pokreni igru !";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 217);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtBoxDrugi);
            this.Controls.Add(this.txtBoxPrvi);
            this.Controls.Add(this.lblDrugi);
            this.Controls.Add(this.lblPrvi);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrvi;
        private System.Windows.Forms.Label lblDrugi;
        private System.Windows.Forms.TextBox txtBoxPrvi;
        private System.Windows.Forms.TextBox txtBoxDrugi;
        private System.Windows.Forms.Button btnStart;
    }
}