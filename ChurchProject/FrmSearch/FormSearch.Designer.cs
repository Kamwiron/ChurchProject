namespace ChurchProject.FrmSearch
{
    partial class FormSearch
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
            this.IdNameZoneLabel = new System.Windows.Forms.Label();
            this.dataGridViewFormSearch = new System.Windows.Forms.DataGridView();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // IdNameZoneLabel
            // 
            this.IdNameZoneLabel.AccessibleDescription = "";
            this.IdNameZoneLabel.AutoSize = true;
            this.IdNameZoneLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.IdNameZoneLabel.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdNameZoneLabel.Location = new System.Drawing.Point(12, 19);
            this.IdNameZoneLabel.Name = "IdNameZoneLabel";
            this.IdNameZoneLabel.Size = new System.Drawing.Size(231, 17);
            this.IdNameZoneLabel.TabIndex = 1;
            this.IdNameZoneLabel.Text = "Search by Member Id , Name , Zones";
            // 
            // dataGridViewFormSearch
            // 
            this.dataGridViewFormSearch.AllowUserToAddRows = false;
            this.dataGridViewFormSearch.AllowUserToDeleteRows = false;
            this.dataGridViewFormSearch.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridViewFormSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFormSearch.GridColor = System.Drawing.Color.AliceBlue;
            this.dataGridViewFormSearch.Location = new System.Drawing.Point(12, 97);
            this.dataGridViewFormSearch.Name = "dataGridViewFormSearch";
            this.dataGridViewFormSearch.ReadOnly = true;
            this.dataGridViewFormSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFormSearch.Size = new System.Drawing.Size(776, 312);
            this.dataGridViewFormSearch.TabIndex = 2;
            // 
            // ButtonClose
            // 
            this.ButtonClose.AccessibleName = "";
            this.ButtonClose.BackColor = System.Drawing.Color.White;
            this.ButtonClose.Location = new System.Drawing.Point(713, 417);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 5;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.Close_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.AccessibleName = "";
            this.ButtonEdit.BackColor = System.Drawing.Color.White;
            this.ButtonEdit.Location = new System.Drawing.Point(494, 417);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.ButtonEdit.TabIndex = 6;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = false;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.AccessibleName = "";
            this.ButtonDelete.BackColor = System.Drawing.Color.White;
            this.ButtonDelete.Location = new System.Drawing.Point(603, 417);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 7;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(12, 53);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(776, 24);
            this.textBoxSearch.TabIndex = 8;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.dataGridViewFormSearch);
            this.Controls.Add(this.IdNameZoneLabel);
            this.Name = "FormSearch";
            this.Text = "FormSearch";
            this.Load += new System.EventHandler(this.FormSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label IdNameZoneLabel;
        private System.Windows.Forms.DataGridView dataGridViewFormSearch;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}