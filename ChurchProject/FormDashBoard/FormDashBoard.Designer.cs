namespace ChurchProject.FormDashBoard
{
    partial class FormDashBoard
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
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SearchMemberButton = new System.Windows.Forms.Button();
            this.AddMemberButton = new System.Windows.Forms.Button();
            this.AttendanceButton = new System.Windows.Forms.Button();
            this.ManageAccountButton = new System.Windows.Forms.Button();
            this.labelCOC = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoutButton
            // 
            this.LogoutButton.AccessibleName = "";
            this.LogoutButton.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.LogoutButton, 2);
            this.LogoutButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoutButton.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.Black;
            this.LogoutButton.Location = new System.Drawing.Point(3, 441);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(656, 40);
            this.LogoutButton.TabIndex = 2;
            this.LogoutButton.Text = "Log Out";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // SearchMemberButton
            // 
            this.SearchMemberButton.AccessibleName = "";
            this.SearchMemberButton.BackColor = System.Drawing.Color.White;
            this.SearchMemberButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchMemberButton.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchMemberButton.ForeColor = System.Drawing.Color.Black;
            this.SearchMemberButton.Image = global::ChurchProject.Properties.Resources.icons8_search_96;
            this.SearchMemberButton.Location = new System.Drawing.Point(3, 3);
            this.SearchMemberButton.Name = "SearchMemberButton";
            this.SearchMemberButton.Size = new System.Drawing.Size(325, 213);
            this.SearchMemberButton.TabIndex = 1;
            this.SearchMemberButton.Text = "SEARCH MEMBER";
            this.SearchMemberButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SearchMemberButton.UseVisualStyleBackColor = false;
            this.SearchMemberButton.Click += new System.EventHandler(this.SearchMemberButton_Click);
            // 
            // AddMemberButton
            // 
            this.AddMemberButton.AccessibleName = "";
            this.AddMemberButton.BackColor = System.Drawing.Color.White;
            this.AddMemberButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddMemberButton.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMemberButton.ForeColor = System.Drawing.Color.Black;
            this.AddMemberButton.Image = global::ChurchProject.Properties.Resources.icons8_plus_96;
            this.AddMemberButton.Location = new System.Drawing.Point(334, 3);
            this.AddMemberButton.Name = "AddMemberButton";
            this.AddMemberButton.Size = new System.Drawing.Size(325, 213);
            this.AddMemberButton.TabIndex = 1;
            this.AddMemberButton.Text = "ADD MEMBER";
            this.AddMemberButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddMemberButton.UseVisualStyleBackColor = false;
            this.AddMemberButton.Click += new System.EventHandler(this.AddMemberButton_Click);
            // 
            // AttendanceButton
            // 
            this.AttendanceButton.AccessibleName = "";
            this.AttendanceButton.BackColor = System.Drawing.Color.White;
            this.AttendanceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttendanceButton.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceButton.ForeColor = System.Drawing.Color.Black;
            this.AttendanceButton.Image = global::ChurchProject.Properties.Resources.icons8_contacts_96__1_;
            this.AttendanceButton.Location = new System.Drawing.Point(3, 222);
            this.AttendanceButton.Name = "AttendanceButton";
            this.AttendanceButton.Size = new System.Drawing.Size(325, 213);
            this.AttendanceButton.TabIndex = 1;
            this.AttendanceButton.Text = "ATTENDANCE";
            this.AttendanceButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AttendanceButton.UseVisualStyleBackColor = false;
            // 
            // ManageAccountButton
            // 
            this.ManageAccountButton.AccessibleName = "";
            this.ManageAccountButton.BackColor = System.Drawing.Color.White;
            this.ManageAccountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ManageAccountButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManageAccountButton.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageAccountButton.ForeColor = System.Drawing.Color.Black;
            this.ManageAccountButton.Image = global::ChurchProject.Properties.Resources.icons8_settings_96__1_;
            this.ManageAccountButton.Location = new System.Drawing.Point(334, 222);
            this.ManageAccountButton.Name = "ManageAccountButton";
            this.ManageAccountButton.Size = new System.Drawing.Size(325, 213);
            this.ManageAccountButton.TabIndex = 1;
            this.ManageAccountButton.Text = "MANAGE ACCOUNT";
            this.ManageAccountButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ManageAccountButton.UseVisualStyleBackColor = false;
            this.ManageAccountButton.Click += new System.EventHandler(this.ManageAccountButton_Click);
            // 
            // labelCOC
            // 
            this.labelCOC.BackColor = System.Drawing.Color.PowderBlue;
            this.labelCOC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCOC.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCOC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelCOC.Font = new System.Drawing.Font("Cambria", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCOC.Location = new System.Drawing.Point(0, 0);
            this.labelCOC.Name = "labelCOC";
            this.labelCOC.Size = new System.Drawing.Size(662, 63);
            this.labelCOC.TabIndex = 3;
            this.labelCOC.Text = "CHURCH OF CHRIST , TAMSO";
            this.labelCOC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.SearchMemberButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AddMemberButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LogoutButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.AttendanceButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ManageAccountButton, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(662, 484);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // FormDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(662, 547);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelCOC);
            this.Name = "FormDashBoard";
            this.Text = "FormDashBoard";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SearchMemberButton;
        private System.Windows.Forms.Button ManageAccountButton;
        private System.Windows.Forms.Button AttendanceButton;
        private System.Windows.Forms.Button AddMemberButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label labelCOC;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}