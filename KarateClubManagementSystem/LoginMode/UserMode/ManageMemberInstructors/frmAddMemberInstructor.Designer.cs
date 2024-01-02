namespace KarateClub.ManageMemberInstructors
{
    partial class frmAddMemberInstructor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddMemberInstructor));
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMemberInstructorID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpAssignDate = new System.Windows.Forms.DateTimePicker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbMembers = new System.Windows.Forms.ListBox();
            this.lbInstructors = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(754, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 28);
            this.label9.TabIndex = 77;
            this.label9.Text = "Instructors";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(184, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 28);
            this.label4.TabIndex = 76;
            this.label4.Text = "Members";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 28);
            this.label1.TabIndex = 73;
            this.label1.Text = "MemberInstructor ID ";
            // 
            // tbMemberInstructorID
            // 
            this.tbMemberInstructorID.BackColor = System.Drawing.SystemColors.Window;
            this.tbMemberInstructorID.Enabled = false;
            this.tbMemberInstructorID.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMemberInstructorID.Location = new System.Drawing.Point(340, 57);
            this.tbMemberInstructorID.Name = "tbMemberInstructorID";
            this.tbMemberInstructorID.Size = new System.Drawing.Size(264, 35);
            this.tbMemberInstructorID.TabIndex = 72;
            this.tbMemberInstructorID.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(751, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 28);
            this.label2.TabIndex = 79;
            this.label2.Text = "Assign Date";
            // 
            // dtpAssignDate
            // 
            this.dtpAssignDate.CalendarMonthBackground = System.Drawing.SystemColors.ActiveBorder;
            this.dtpAssignDate.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpAssignDate.CalendarTrailingForeColor = System.Drawing.SystemColors.Highlight;
            this.dtpAssignDate.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAssignDate.Location = new System.Drawing.Point(885, 57);
            this.dtpAssignDate.Name = "dtpAssignDate";
            this.dtpAssignDate.Size = new System.Drawing.Size(264, 35);
            this.dtpAssignDate.TabIndex = 80;
            this.dtpAssignDate.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.White;
            this.imageList1.Images.SetKeyName(0, "close.png");
            this.imageList1.Images.SetKeyName(1, "checkmark.png");
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSave.ImageIndex = 1;
            this.btnSave.ImageList = this.imageList1;
            this.btnSave.Location = new System.Drawing.Point(746, 425);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(158, 48);
            this.btnSave.TabIndex = 84;
            this.btnSave.Text = " Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SeaShell;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCancel.ImageIndex = 0;
            this.btnCancel.ImageList = this.imageList1;
            this.btnCancel.Location = new System.Drawing.Point(555, 425);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(158, 48);
            this.btnCancel.TabIndex = 83;
            this.btnCancel.Text = " Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbMembers
            // 
            this.lbMembers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbMembers.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.2F);
            this.lbMembers.FormattingEnabled = true;
            this.lbMembers.HorizontalScrollbar = true;
            this.lbMembers.ItemHeight = 27;
            this.lbMembers.Location = new System.Drawing.Point(340, 146);
            this.lbMembers.Name = "lbMembers";
            this.lbMembers.ScrollAlwaysVisible = true;
            this.lbMembers.Size = new System.Drawing.Size(264, 216);
            this.lbMembers.TabIndex = 85;
            this.lbMembers.SelectedIndexChanged += new System.EventHandler(this.lbMembers_SelectedIndexChanged);
            this.lbMembers.Validating += new System.ComponentModel.CancelEventHandler(this.ListBox_Validating);
            // 
            // lbInstructors
            // 
            this.lbInstructors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbInstructors.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.2F);
            this.lbInstructors.FormattingEnabled = true;
            this.lbInstructors.HorizontalScrollbar = true;
            this.lbInstructors.ItemHeight = 27;
            this.lbInstructors.Location = new System.Drawing.Point(885, 146);
            this.lbInstructors.Name = "lbInstructors";
            this.lbInstructors.ScrollAlwaysVisible = true;
            this.lbInstructors.Size = new System.Drawing.Size(264, 216);
            this.lbInstructors.TabIndex = 86;
            this.lbInstructors.Validating += new System.ComponentModel.CancelEventHandler(this.ListBox_Validating);
            // 
            // frmAddMemberInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1383, 507);
            this.Controls.Add(this.lbInstructors);
            this.Controls.Add(this.lbMembers);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dtpAssignDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMemberInstructorID);
            this.Name = "frmAddMemberInstructor";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmAddMemberInstructor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMemberInstructorID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpAssignDate;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ListBox lbMembers;
        private System.Windows.Forms.ListBox lbInstructors;
    }
}