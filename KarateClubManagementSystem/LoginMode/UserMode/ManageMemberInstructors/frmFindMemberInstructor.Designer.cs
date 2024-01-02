namespace KarateClub.ManageMemberInstructors
{
    partial class frmFindMemberInstructor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindMemberInstructor));
            this.lbInstructors = new System.Windows.Forms.ListBox();
            this.lbMembers = new System.Windows.Forms.ListBox();
            this.dtpAssignDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMemberInstructorID = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.tbSearchValue = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbInstructors
            // 
            this.lbInstructors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbInstructors.Enabled = false;
            this.lbInstructors.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.2F);
            this.lbInstructors.FormattingEnabled = true;
            this.lbInstructors.HorizontalScrollbar = true;
            this.lbInstructors.ItemHeight = 27;
            this.lbInstructors.Location = new System.Drawing.Point(904, 206);
            this.lbInstructors.Name = "lbInstructors";
            this.lbInstructors.ScrollAlwaysVisible = true;
            this.lbInstructors.Size = new System.Drawing.Size(264, 216);
            this.lbInstructors.TabIndex = 96;
            // 
            // lbMembers
            // 
            this.lbMembers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbMembers.Enabled = false;
            this.lbMembers.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.2F);
            this.lbMembers.FormattingEnabled = true;
            this.lbMembers.HorizontalScrollbar = true;
            this.lbMembers.ItemHeight = 27;
            this.lbMembers.Location = new System.Drawing.Point(359, 206);
            this.lbMembers.Name = "lbMembers";
            this.lbMembers.ScrollAlwaysVisible = true;
            this.lbMembers.Size = new System.Drawing.Size(264, 216);
            this.lbMembers.TabIndex = 95;
            // 
            // dtpAssignDate
            // 
            this.dtpAssignDate.CalendarMonthBackground = System.Drawing.SystemColors.ActiveBorder;
            this.dtpAssignDate.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpAssignDate.CalendarTrailingForeColor = System.Drawing.SystemColors.Highlight;
            this.dtpAssignDate.Enabled = false;
            this.dtpAssignDate.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAssignDate.Location = new System.Drawing.Point(904, 117);
            this.dtpAssignDate.Name = "dtpAssignDate";
            this.dtpAssignDate.Size = new System.Drawing.Size(264, 35);
            this.dtpAssignDate.TabIndex = 92;
            this.dtpAssignDate.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(770, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 28);
            this.label2.TabIndex = 91;
            this.label2.Text = "Assign Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(773, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 28);
            this.label9.TabIndex = 90;
            this.label9.Text = "Instructors";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 28);
            this.label4.TabIndex = 89;
            this.label4.Text = "Members";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 28);
            this.label1.TabIndex = 88;
            this.label1.Text = "MemberInstructor ID ";
            // 
            // tbMemberInstructorID
            // 
            this.tbMemberInstructorID.BackColor = System.Drawing.SystemColors.Window;
            this.tbMemberInstructorID.Enabled = false;
            this.tbMemberInstructorID.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMemberInstructorID.Location = new System.Drawing.Point(359, 117);
            this.tbMemberInstructorID.Name = "tbMemberInstructorID";
            this.tbMemberInstructorID.Size = new System.Drawing.Size(264, 35);
            this.tbMemberInstructorID.TabIndex = 87;
            this.tbMemberInstructorID.TabStop = false;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(354, 34);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(176, 28);
            this.lbl.TabIndex = 99;
            this.lbl.Text = "MemberInstructor ID :";
            // 
            // pbSearch
            // 
            this.pbSearch.BackColor = System.Drawing.Color.Bisque;
            this.pbSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbSearch.BackgroundImage")));
            this.pbSearch.Image = global::KarateClub.Properties.Resources.search;
            this.pbSearch.Location = new System.Drawing.Point(823, 30);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(39, 32);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 98;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // tbSearchValue
            // 
            this.tbSearchValue.BackColor = System.Drawing.Color.Bisque;
            this.tbSearchValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearchValue.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchValue.Location = new System.Drawing.Point(552, 23);
            this.tbSearchValue.Multiline = true;
            this.tbSearchValue.Name = "tbSearchValue";
            this.tbSearchValue.Size = new System.Drawing.Size(319, 42);
            this.tbSearchValue.TabIndex = 97;
            this.tbSearchValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSearchValue.Validating += new System.ComponentModel.CancelEventHandler(this.tbSearchValue_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmFindMemberInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1383, 507);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.tbSearchValue);
            this.Controls.Add(this.lbInstructors);
            this.Controls.Add(this.lbMembers);
            this.Controls.Add(this.dtpAssignDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMemberInstructorID);
            this.Name = "frmFindMemberInstructor";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmFindMemberInstructor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbInstructors;
        private System.Windows.Forms.ListBox lbMembers;
        private System.Windows.Forms.DateTimePicker dtpAssignDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMemberInstructorID;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.TextBox tbSearchValue;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}