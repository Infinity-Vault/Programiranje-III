namespace Vjezbe10__22._12._2021._
{
    partial class frmMain
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
            this.dgvPhonebook = new System.Windows.Forms.DataGridView();
            this.btnFetch = new System.Windows.Forms.Button();
            this.btnCreateDB = new System.Windows.Forms.Button();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.buttonAddRecord = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.btnSelectAllAndShow = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhonebook)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhonebook
            // 
            this.dgvPhonebook.AllowUserToDeleteRows = false;
            this.dgvPhonebook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhonebook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Number});
            this.dgvPhonebook.Location = new System.Drawing.Point(3, 3);
            this.dgvPhonebook.Name = "dgvPhonebook";
            this.dgvPhonebook.ReadOnly = true;
            this.dgvPhonebook.Size = new System.Drawing.Size(776, 236);
            this.dgvPhonebook.TabIndex = 0;
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(3, 254);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(75, 23);
            this.btnFetch.TabIndex = 1;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // btnCreateDB
            // 
            this.btnCreateDB.Location = new System.Drawing.Point(84, 254);
            this.btnCreateDB.Name = "btnCreateDB";
            this.btnCreateDB.Size = new System.Drawing.Size(119, 23);
            this.btnCreateDB.TabIndex = 2;
            this.btnCreateDB.Text = "Create DataBase";
            this.btnCreateDB.UseVisualStyleBackColor = true;
            this.btnCreateDB.Click += new System.EventHandler(this.btnCreateDB_Click);
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Location = new System.Drawing.Point(209, 254);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(75, 23);
            this.btnCreateTable.TabIndex = 3;
            this.btnCreateTable.Text = "Create table";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            this.btnCreateTable.Click += new System.EventHandler(this.btnCreateTable_Click);
            // 
            // buttonAddRecord
            // 
            this.buttonAddRecord.Location = new System.Drawing.Point(290, 254);
            this.buttonAddRecord.Name = "buttonAddRecord";
            this.buttonAddRecord.Size = new System.Drawing.Size(75, 23);
            this.buttonAddRecord.TabIndex = 4;
            this.buttonAddRecord.Text = "Add record";
            this.buttonAddRecord.UseVisualStyleBackColor = true;
            this.buttonAddRecord.Click += new System.EventHandler(this.buttonAddRecord_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(371, 254);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update record";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Location = new System.Drawing.Point(477, 254);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteRecord.TabIndex = 6;
            this.btnDeleteRecord.Text = "Delete record";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // btnSelectAllAndShow
            // 
            this.btnSelectAllAndShow.Location = new System.Drawing.Point(583, 254);
            this.btnSelectAllAndShow.Name = "btnSelectAllAndShow";
            this.btnSelectAllAndShow.Size = new System.Drawing.Size(196, 23);
            this.btnSelectAllAndShow.TabIndex = 7;
            this.btnSelectAllAndShow.Text = "Show PhoneBook";
            this.btnSelectAllAndShow.UseVisualStyleBackColor = true;
            this.btnSelectAllAndShow.Click += new System.EventHandler(this.btnSelectAllAndShow_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 289);
            this.Controls.Add(this.btnSelectAllAndShow);
            this.Controls.Add(this.btnDeleteRecord);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.buttonAddRecord);
            this.Controls.Add(this.btnCreateTable);
            this.Controls.Add(this.btnCreateDB);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.dgvPhonebook);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhonebook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhonebook;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.Button btnCreateDB;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.Button buttonAddRecord;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.Button btnSelectAllAndShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
    }
}

