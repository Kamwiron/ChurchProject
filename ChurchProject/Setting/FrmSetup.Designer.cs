using System;
using System.Windows.Forms;

namespace ChurchProject.Setting
{
    partial class FrmSetup
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
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.IdNameZoneLabel = new System.Windows.Forms.Label();
            this.tabPage14ZoneHead = new System.Windows.Forms.TabPage();
            this.dataGridViewZoneHead = new System.Windows.Forms.DataGridView();
            this.tabPage13ZoneDetail = new System.Windows.Forms.TabPage();
            this.dataGridViewZoneDetail = new System.Windows.Forms.DataGridView();
            this.tabPage12Zone = new System.Windows.Forms.TabPage();
            this.dataGridViewZone = new System.Windows.Forms.DataGridView();
            this.tabPage11Town = new System.Windows.Forms.TabPage();
            this.dataGridViewTown = new System.Windows.Forms.DataGridView();
            this.tabPage10Title = new System.Windows.Forms.TabPage();
            this.dataGridViewTitle = new System.Windows.Forms.DataGridView();
            this.tabPage9Occupation = new System.Windows.Forms.TabPage();
            this.dataGridViewOccupation = new System.Windows.Forms.DataGridView();
            this.tabPage7MemberType = new System.Windows.Forms.TabPage();
            this.dataGridViewMemberType = new System.Windows.Forms.DataGridView();
            this.tabPage6MembershipStatus = new System.Windows.Forms.TabPage();
            this.dataGridViewMembership = new System.Windows.Forms.DataGridView();
            this.tabPage3MaritalStatus = new System.Windows.Forms.TabPage();
            this.dataGridViewMarital = new System.Windows.Forms.DataGridView();
            this.tabPage1AttendanceType = new System.Windows.Forms.TabPage();
            this.dataGridViewAttendanceType = new System.Windows.Forms.DataGridView();
            this.tabPage2Attendance = new System.Windows.Forms.TabPage();
            this.dataGridViewAttendance = new System.Windows.Forms.DataGridView();
            this.tabControlAttendanceType = new System.Windows.Forms.TabControl();
            this.tabPage14ZoneHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZoneHead)).BeginInit();
            this.tabPage13ZoneDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZoneDetail)).BeginInit();
            this.tabPage12Zone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZone)).BeginInit();
            this.tabPage11Town.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTown)).BeginInit();
            this.tabPage10Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTitle)).BeginInit();
            this.tabPage9Occupation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOccupation)).BeginInit();
            this.tabPage7MemberType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMemberType)).BeginInit();
            this.tabPage6MembershipStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembership)).BeginInit();
            this.tabPage3MaritalStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarital)).BeginInit();
            this.tabPage1AttendanceType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendanceType)).BeginInit();
            this.tabPage2Attendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).BeginInit();
            this.tabControlAttendanceType.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(12, 34);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(872, 24);
            this.textBoxSearch.TabIndex = 9;
            // 
            // ButtonClose
            // 
            this.ButtonClose.AccessibleName = "";
            this.ButtonClose.BackColor = System.Drawing.Color.White;
            this.ButtonClose.Location = new System.Drawing.Point(813, 478);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 10;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = false;
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.AccessibleName = "";
            this.ButtonEdit.BackColor = System.Drawing.Color.White;
            this.ButtonEdit.Location = new System.Drawing.Point(594, 478);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.ButtonEdit.TabIndex = 11;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = false;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.AccessibleName = "";
            this.ButtonDelete.BackColor = System.Drawing.Color.White;
            this.ButtonDelete.Location = new System.Drawing.Point(703, 478);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 12;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            // 
            // IdNameZoneLabel
            // 
            this.IdNameZoneLabel.AccessibleDescription = "";
            this.IdNameZoneLabel.AutoSize = true;
            this.IdNameZoneLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.IdNameZoneLabel.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdNameZoneLabel.Location = new System.Drawing.Point(13, 9);
            this.IdNameZoneLabel.Name = "IdNameZoneLabel";
            this.IdNameZoneLabel.Size = new System.Drawing.Size(50, 17);
            this.IdNameZoneLabel.TabIndex = 2;
            this.IdNameZoneLabel.Text = "Search\r\n";
            // 
            // tabPage14ZoneHead
            // 
            this.tabPage14ZoneHead.Controls.Add(this.dataGridViewZoneHead);
            this.tabPage14ZoneHead.Location = new System.Drawing.Point(4, 22);
            this.tabPage14ZoneHead.Name = "tabPage14ZoneHead";
            this.tabPage14ZoneHead.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage14ZoneHead.Size = new System.Drawing.Size(872, 361);
            this.tabPage14ZoneHead.TabIndex = 14;
            this.tabPage14ZoneHead.Text = "Zone Head";
            this.tabPage14ZoneHead.UseVisualStyleBackColor = true;
            // 
            // dataGridViewZoneHead
            // 
            this.dataGridViewZoneHead.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewZoneHead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZoneHead.Location = new System.Drawing.Point(14, 16);
            this.dataGridViewZoneHead.Name = "dataGridViewZoneHead";
            this.dataGridViewZoneHead.Size = new System.Drawing.Size(844, 329);
            this.dataGridViewZoneHead.TabIndex = 1;
            // 
            // tabPage13ZoneDetail
            // 
            this.tabPage13ZoneDetail.Controls.Add(this.dataGridViewZoneDetail);
            this.tabPage13ZoneDetail.Location = new System.Drawing.Point(4, 22);
            this.tabPage13ZoneDetail.Name = "tabPage13ZoneDetail";
            this.tabPage13ZoneDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage13ZoneDetail.Size = new System.Drawing.Size(872, 361);
            this.tabPage13ZoneDetail.TabIndex = 13;
            this.tabPage13ZoneDetail.Text = "Zone Detail";
            this.tabPage13ZoneDetail.UseVisualStyleBackColor = true;
            // 
            // dataGridViewZoneDetail
            // 
            this.dataGridViewZoneDetail.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewZoneDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZoneDetail.Location = new System.Drawing.Point(14, 14);
            this.dataGridViewZoneDetail.Name = "dataGridViewZoneDetail";
            this.dataGridViewZoneDetail.Size = new System.Drawing.Size(844, 330);
            this.dataGridViewZoneDetail.TabIndex = 1;
            // 
            // tabPage12Zone
            // 
            this.tabPage12Zone.Controls.Add(this.dataGridViewZone);
            this.tabPage12Zone.Location = new System.Drawing.Point(4, 22);
            this.tabPage12Zone.Name = "tabPage12Zone";
            this.tabPage12Zone.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12Zone.Size = new System.Drawing.Size(872, 361);
            this.tabPage12Zone.TabIndex = 12;
            this.tabPage12Zone.Text = "Zone";
            this.tabPage12Zone.UseVisualStyleBackColor = true;
            // 
            // dataGridViewZone
            // 
            this.dataGridViewZone.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewZone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZone.Location = new System.Drawing.Point(14, 15);
            this.dataGridViewZone.Name = "dataGridViewZone";
            this.dataGridViewZone.Size = new System.Drawing.Size(844, 331);
            this.dataGridViewZone.TabIndex = 1;
            // 
            // tabPage11Town
            // 
            this.tabPage11Town.Controls.Add(this.dataGridViewTown);
            this.tabPage11Town.Location = new System.Drawing.Point(4, 22);
            this.tabPage11Town.Name = "tabPage11Town";
            this.tabPage11Town.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11Town.Size = new System.Drawing.Size(872, 361);
            this.tabPage11Town.TabIndex = 11;
            this.tabPage11Town.Text = "Town";
            this.tabPage11Town.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTown
            // 
            this.dataGridViewTown.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTown.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTown.Location = new System.Drawing.Point(14, 16);
            this.dataGridViewTown.Name = "dataGridViewTown";
            this.dataGridViewTown.Size = new System.Drawing.Size(844, 328);
            this.dataGridViewTown.TabIndex = 1;
            // 
            // tabPage10Title
            // 
            this.tabPage10Title.Controls.Add(this.dataGridViewTitle);
            this.tabPage10Title.Location = new System.Drawing.Point(4, 22);
            this.tabPage10Title.Name = "tabPage10Title";
            this.tabPage10Title.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10Title.Size = new System.Drawing.Size(872, 361);
            this.tabPage10Title.TabIndex = 10;
            this.tabPage10Title.Text = "Title";
            this.tabPage10Title.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTitle
            // 
            this.dataGridViewTitle.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTitle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTitle.Location = new System.Drawing.Point(14, 16);
            this.dataGridViewTitle.Name = "dataGridViewTitle";
            this.dataGridViewTitle.Size = new System.Drawing.Size(844, 327);
            this.dataGridViewTitle.TabIndex = 1;
            // 
            // tabPage9Occupation
            // 
            this.tabPage9Occupation.Controls.Add(this.dataGridViewOccupation);
            this.tabPage9Occupation.Location = new System.Drawing.Point(4, 22);
            this.tabPage9Occupation.Name = "tabPage9Occupation";
            this.tabPage9Occupation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9Occupation.Size = new System.Drawing.Size(872, 361);
            this.tabPage9Occupation.TabIndex = 9;
            this.tabPage9Occupation.Text = "Occupation";
            this.tabPage9Occupation.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOccupation
            // 
            this.dataGridViewOccupation.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOccupation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOccupation.Location = new System.Drawing.Point(14, 15);
            this.dataGridViewOccupation.Name = "dataGridViewOccupation";
            this.dataGridViewOccupation.Size = new System.Drawing.Size(844, 331);
            this.dataGridViewOccupation.TabIndex = 2;
            // 
            // tabPage7MemberType
            // 
            this.tabPage7MemberType.Controls.Add(this.dataGridViewMemberType);
            this.tabPage7MemberType.Location = new System.Drawing.Point(4, 22);
            this.tabPage7MemberType.Name = "tabPage7MemberType";
            this.tabPage7MemberType.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7MemberType.Size = new System.Drawing.Size(872, 361);
            this.tabPage7MemberType.TabIndex = 7;
            this.tabPage7MemberType.Text = "Member Type";
            this.tabPage7MemberType.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMemberType
            // 
            this.dataGridViewMemberType.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMemberType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMemberType.Location = new System.Drawing.Point(14, 14);
            this.dataGridViewMemberType.Name = "dataGridViewMemberType";
            this.dataGridViewMemberType.Size = new System.Drawing.Size(844, 331);
            this.dataGridViewMemberType.TabIndex = 1;
            // 
            // tabPage6MembershipStatus
            // 
            this.tabPage6MembershipStatus.Controls.Add(this.dataGridViewMembership);
            this.tabPage6MembershipStatus.Location = new System.Drawing.Point(4, 22);
            this.tabPage6MembershipStatus.Name = "tabPage6MembershipStatus";
            this.tabPage6MembershipStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6MembershipStatus.Size = new System.Drawing.Size(872, 361);
            this.tabPage6MembershipStatus.TabIndex = 6;
            this.tabPage6MembershipStatus.Text = "Membership Status";
            this.tabPage6MembershipStatus.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMembership
            // 
            this.dataGridViewMembership.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMembership.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMembership.Location = new System.Drawing.Point(14, 14);
            this.dataGridViewMembership.Name = "dataGridViewMembership";
            this.dataGridViewMembership.Size = new System.Drawing.Size(844, 330);
            this.dataGridViewMembership.TabIndex = 1;
            // 
            // tabPage3MaritalStatus
            // 
            this.tabPage3MaritalStatus.Controls.Add(this.dataGridViewMarital);
            this.tabPage3MaritalStatus.Location = new System.Drawing.Point(4, 22);
            this.tabPage3MaritalStatus.Name = "tabPage3MaritalStatus";
            this.tabPage3MaritalStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3MaritalStatus.Size = new System.Drawing.Size(872, 361);
            this.tabPage3MaritalStatus.TabIndex = 3;
            this.tabPage3MaritalStatus.Text = "Marital Status";
            this.tabPage3MaritalStatus.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMarital
            // 
            this.dataGridViewMarital.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMarital.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarital.Location = new System.Drawing.Point(14, 14);
            this.dataGridViewMarital.Name = "dataGridViewMarital";
            this.dataGridViewMarital.Size = new System.Drawing.Size(844, 331);
            this.dataGridViewMarital.TabIndex = 1;
            // 
            // tabPage1AttendanceType
            // 
            this.tabPage1AttendanceType.Controls.Add(this.dataGridViewAttendanceType);
            this.tabPage1AttendanceType.Location = new System.Drawing.Point(4, 22);
            this.tabPage1AttendanceType.Name = "tabPage1AttendanceType";
            this.tabPage1AttendanceType.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1AttendanceType.Size = new System.Drawing.Size(872, 361);
            this.tabPage1AttendanceType.TabIndex = 2;
            this.tabPage1AttendanceType.Text = "Attendance Type";
            this.tabPage1AttendanceType.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAttendanceType
            // 
            this.dataGridViewAttendanceType.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAttendanceType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAttendanceType.Location = new System.Drawing.Point(14, 15);
            this.dataGridViewAttendanceType.Name = "dataGridViewAttendanceType";
            this.dataGridViewAttendanceType.Size = new System.Drawing.Size(844, 331);
            this.dataGridViewAttendanceType.TabIndex = 1;
            // 
            // tabPage2Attendance
            // 
            this.tabPage2Attendance.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage2Attendance.Controls.Add(this.dataGridViewAttendance);
            this.tabPage2Attendance.Location = new System.Drawing.Point(4, 22);
            this.tabPage2Attendance.Name = "tabPage2Attendance";
            this.tabPage2Attendance.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2Attendance.Size = new System.Drawing.Size(872, 361);
            this.tabPage2Attendance.TabIndex = 1;
            this.tabPage2Attendance.Text = "Attendance";
            // 
            // dataGridViewAttendance
            // 
            this.dataGridViewAttendance.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAttendance.Location = new System.Drawing.Point(14, 13);
            this.dataGridViewAttendance.Name = "dataGridViewAttendance";
            this.dataGridViewAttendance.Size = new System.Drawing.Size(844, 332);
            this.dataGridViewAttendance.TabIndex = 0;
            this.dataGridViewAttendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewAttendance_CellContentClick);
            // 
            // tabControlAttendanceType
            // 
            this.tabControlAttendanceType.Controls.Add(this.tabPage2Attendance);
            this.tabControlAttendanceType.Controls.Add(this.tabPage1AttendanceType);
            this.tabControlAttendanceType.Controls.Add(this.tabPage3MaritalStatus);
            this.tabControlAttendanceType.Controls.Add(this.tabPage6MembershipStatus);
            this.tabControlAttendanceType.Controls.Add(this.tabPage7MemberType);
            this.tabControlAttendanceType.Controls.Add(this.tabPage9Occupation);
            this.tabControlAttendanceType.Controls.Add(this.tabPage10Title);
            this.tabControlAttendanceType.Controls.Add(this.tabPage11Town);
            this.tabControlAttendanceType.Controls.Add(this.tabPage12Zone);
            this.tabControlAttendanceType.Controls.Add(this.tabPage13ZoneDetail);
            this.tabControlAttendanceType.Controls.Add(this.tabPage14ZoneHead);
            this.tabControlAttendanceType.Location = new System.Drawing.Point(12, 73);
            this.tabControlAttendanceType.Name = "tabControlAttendanceType";
            this.tabControlAttendanceType.SelectedIndex = 0;
            this.tabControlAttendanceType.Size = new System.Drawing.Size(880, 387);
            this.tabControlAttendanceType.TabIndex = 0;
            this.tabControlAttendanceType.Tag = "Marital Status";
            // 
            // FrmSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 513);
            this.Controls.Add(this.IdNameZoneLabel);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.tabControlAttendanceType);
            this.Name = "FrmSetup";
            this.Text = "FrmSetup";
            this.tabPage14ZoneHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZoneHead)).EndInit();
            this.tabPage13ZoneDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZoneDetail)).EndInit();
            this.tabPage12Zone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZone)).EndInit();
            this.tabPage11Town.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTown)).EndInit();
            this.tabPage10Title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTitle)).EndInit();
            this.tabPage9Occupation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOccupation)).EndInit();
            this.tabPage7MemberType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMemberType)).EndInit();
            this.tabPage6MembershipStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembership)).EndInit();
            this.tabPage3MaritalStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarital)).EndInit();
            this.tabPage1AttendanceType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendanceType)).EndInit();
            this.tabPage2Attendance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).EndInit();
            this.tabControlAttendanceType.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void DataGridViewAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Label IdNameZoneLabel;
        private System.Windows.Forms.TabPage tabPage14ZoneHead;
        private System.Windows.Forms.TabPage tabPage13ZoneDetail;
        private System.Windows.Forms.TabPage tabPage12Zone;
        private System.Windows.Forms.TabPage tabPage11Town;
        private System.Windows.Forms.TabPage tabPage10Title;
        private System.Windows.Forms.TabPage tabPage9Occupation;
        private System.Windows.Forms.TabPage tabPage7MemberType;
        private System.Windows.Forms.TabPage tabPage6MembershipStatus;
        private System.Windows.Forms.TabPage tabPage3MaritalStatus;
        private System.Windows.Forms.TabPage tabPage1AttendanceType;
        private System.Windows.Forms.TabPage tabPage2Attendance;
        private System.Windows.Forms.DataGridView dataGridViewAttendance;
        private System.Windows.Forms.TabControl tabControlAttendanceType;
        private System.Windows.Forms.DataGridView dataGridViewZoneHead;
        private System.Windows.Forms.DataGridView dataGridViewZoneDetail;
        private System.Windows.Forms.DataGridView dataGridViewZone;
        private System.Windows.Forms.DataGridView dataGridViewTown;
        private System.Windows.Forms.DataGridView dataGridViewTitle;
        private System.Windows.Forms.DataGridView dataGridViewMemberType;
        private System.Windows.Forms.DataGridView dataGridViewMembership;
        private System.Windows.Forms.DataGridView dataGridViewMarital;
        private System.Windows.Forms.DataGridView dataGridViewAttendanceType;
        private DataGridView dataGridViewOccupation;
    }
}