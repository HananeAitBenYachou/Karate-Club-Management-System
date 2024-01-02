namespace KarateClub.ManageUsers
{
    partial class frmAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUser));
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lbRemove = new System.Windows.Forms.LinkLabel();
            this.lbSetImage = new System.Windows.Forms.LinkLabel();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.gbPermissions = new System.Windows.Forms.GroupBox();
            this.pnlPermissions = new System.Windows.Forms.Panel();
            this.cbManagePayments = new System.Windows.Forms.CheckBox();
            this.cbManageBeltTests = new System.Windows.Forms.CheckBox();
            this.cbManageBeltRanks = new System.Windows.Forms.CheckBox();
            this.cbManageSubscriptions = new System.Windows.Forms.CheckBox();
            this.cbManageMemberInstructors = new System.Windows.Forms.CheckBox();
            this.cbManageInstructors = new System.Windows.Forms.CheckBox();
            this.cbManageUsers = new System.Windows.Forms.CheckBox();
            this.cbManageMembers = new System.Windows.Forms.CheckBox();
            this.cbAllPermissions = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.gbPermissions.SuspendLayout();
            this.pnlPermissions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // cbGender
            // 
            this.cbGender.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F);
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(1116, 62);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(180, 36);
            this.cbGender.TabIndex = 83;
            this.cbGender.TabStop = false;
            // 
            // lbRemove
            // 
            this.lbRemove.AutoSize = true;
            this.lbRemove.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRemove.Location = new System.Drawing.Point(123, 355);
            this.lbRemove.Name = "lbRemove";
            this.lbRemove.Size = new System.Drawing.Size(72, 28);
            this.lbRemove.TabIndex = 77;
            this.lbRemove.TabStop = true;
            this.lbRemove.Text = "Remove";
            this.lbRemove.Visible = false;
            this.lbRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbRemove_LinkClicked);
            // 
            // lbSetImage
            // 
            this.lbSetImage.AutoSize = true;
            this.lbSetImage.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSetImage.Location = new System.Drawing.Point(30, 355);
            this.lbSetImage.Name = "lbSetImage";
            this.lbSetImage.Size = new System.Drawing.Size(87, 28);
            this.lbSetImage.TabIndex = 76;
            this.lbSetImage.TabStop = true;
            this.lbSetImage.Text = "Set Image";
            this.lbSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbSetImage_LinkClicked);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CalendarMonthBackground = System.Drawing.SystemColors.ActiveBorder;
            this.dtpDateOfBirth.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpDateOfBirth.CalendarTrailingForeColor = System.Drawing.SystemColors.Highlight;
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.Location = new System.Drawing.Point(743, 306);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(180, 35);
            this.dtpDateOfBirth.TabIndex = 78;
            this.dtpDateOfBirth.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.White;
            this.imageList1.Images.SetKeyName(0, "close.png");
            this.imageList1.Images.SetKeyName(1, "checkmark.png");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(288, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 28);
            this.label10.TabIndex = 72;
            this.label10.Text = "Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(282, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 28);
            this.label9.TabIndex = 71;
            this.label9.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(615, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 28);
            this.label8.TabIndex = 70;
            this.label8.Text = "DateOfBirth";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(743, 225);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(180, 35);
            this.tbPassword.TabIndex = 68;
            this.tbPassword.TabStop = false;
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(623, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 28);
            this.label6.TabIndex = 67;
            this.label6.Text = "Password";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(743, 144);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(180, 35);
            this.tbEmail.TabIndex = 66;
            this.tbEmail.TabStop = false;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(981, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 28);
            this.label5.TabIndex = 65;
            this.label5.Text = "Gender";
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.Location = new System.Drawing.Point(743, 63);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(180, 35);
            this.tbUserName.TabIndex = 64;
            this.tbUserName.TabStop = false;
            this.tbUserName.Validating += new System.ComponentModel.CancelEventHandler(this.tbUserName_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 28);
            this.label4.TabIndex = 63;
            this.label4.Text = "Name";
            // 
            // tbPhone
            // 
            this.tbPhone.BackColor = System.Drawing.SystemColors.Window;
            this.tbPhone.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(392, 306);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(180, 35);
            this.tbPhone.TabIndex = 62;
            this.tbPhone.TabStop = false;
            this.tbPhone.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(638, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 28);
            this.label3.TabIndex = 61;
            this.label3.Text = "Email";
            // 
            // tbAddress
            // 
            this.tbAddress.BackColor = System.Drawing.SystemColors.Window;
            this.tbAddress.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(392, 225);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(180, 35);
            this.tbAddress.TabIndex = 60;
            this.tbAddress.TabStop = false;
            this.tbAddress.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(614, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 28);
            this.label2.TabIndex = 59;
            this.label2.Text = "User Name";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.Window;
            this.tbName.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(392, 144);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(180, 35);
            this.tbName.TabIndex = 58;
            this.tbName.TabStop = false;
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 28);
            this.label1.TabIndex = 57;
            this.label1.Text = "User ID";
            // 
            // tbUserID
            // 
            this.tbUserID.BackColor = System.Drawing.SystemColors.Window;
            this.tbUserID.Enabled = false;
            this.tbUserID.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserID.Location = new System.Drawing.Point(392, 63);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.Size = new System.Drawing.Size(180, 35);
            this.tbUserID.TabIndex = 56;
            this.tbUserID.TabStop = false;
            // 
            // gbPermissions
            // 
            this.gbPermissions.Controls.Add(this.pnlPermissions);
            this.gbPermissions.Controls.Add(this.cbAllPermissions);
            this.gbPermissions.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F);
            this.gbPermissions.Location = new System.Drawing.Point(986, 114);
            this.gbPermissions.Name = "gbPermissions";
            this.gbPermissions.Size = new System.Drawing.Size(366, 381);
            this.gbPermissions.TabIndex = 85;
            this.gbPermissions.TabStop = false;
            this.gbPermissions.Text = "Permissions";
            // 
            // pnlPermissions
            // 
            this.pnlPermissions.Controls.Add(this.cbManagePayments);
            this.pnlPermissions.Controls.Add(this.cbManageBeltTests);
            this.pnlPermissions.Controls.Add(this.cbManageBeltRanks);
            this.pnlPermissions.Controls.Add(this.cbManageSubscriptions);
            this.pnlPermissions.Controls.Add(this.cbManageMemberInstructors);
            this.pnlPermissions.Controls.Add(this.cbManageInstructors);
            this.pnlPermissions.Controls.Add(this.cbManageUsers);
            this.pnlPermissions.Controls.Add(this.cbManageMembers);
            this.pnlPermissions.Location = new System.Drawing.Point(18, 63);
            this.pnlPermissions.Name = "pnlPermissions";
            this.pnlPermissions.Size = new System.Drawing.Size(325, 310);
            this.pnlPermissions.TabIndex = 1;
            // 
            // cbManagePayments
            // 
            this.cbManagePayments.AutoSize = true;
            this.cbManagePayments.Location = new System.Drawing.Point(13, 265);
            this.cbManagePayments.Name = "cbManagePayments";
            this.cbManagePayments.Size = new System.Drawing.Size(172, 32);
            this.cbManagePayments.TabIndex = 7;
            this.cbManagePayments.Tag = "128";
            this.cbManagePayments.Text = "Manage Payments";
            this.cbManagePayments.UseVisualStyleBackColor = true;
            // 
            // cbManageBeltTests
            // 
            this.cbManageBeltTests.AutoSize = true;
            this.cbManageBeltTests.Location = new System.Drawing.Point(13, 229);
            this.cbManageBeltTests.Name = "cbManageBeltTests";
            this.cbManageBeltTests.Size = new System.Drawing.Size(166, 32);
            this.cbManageBeltTests.TabIndex = 6;
            this.cbManageBeltTests.Tag = "64";
            this.cbManageBeltTests.Text = "Manage BeltTests";
            this.cbManageBeltTests.UseVisualStyleBackColor = true;
            // 
            // cbManageBeltRanks
            // 
            this.cbManageBeltRanks.AutoSize = true;
            this.cbManageBeltRanks.Location = new System.Drawing.Point(13, 193);
            this.cbManageBeltRanks.Name = "cbManageBeltRanks";
            this.cbManageBeltRanks.Size = new System.Drawing.Size(174, 32);
            this.cbManageBeltRanks.TabIndex = 5;
            this.cbManageBeltRanks.Tag = "32";
            this.cbManageBeltRanks.Text = "Manage BeltRanks";
            this.cbManageBeltRanks.UseVisualStyleBackColor = true;
            // 
            // cbManageSubscriptions
            // 
            this.cbManageSubscriptions.AutoSize = true;
            this.cbManageSubscriptions.Location = new System.Drawing.Point(13, 157);
            this.cbManageSubscriptions.Name = "cbManageSubscriptions";
            this.cbManageSubscriptions.Size = new System.Drawing.Size(202, 32);
            this.cbManageSubscriptions.TabIndex = 4;
            this.cbManageSubscriptions.Tag = "16";
            this.cbManageSubscriptions.Text = "Manage Subscriptions";
            this.cbManageSubscriptions.UseVisualStyleBackColor = true;
            // 
            // cbManageMemberInstructors
            // 
            this.cbManageMemberInstructors.AutoSize = true;
            this.cbManageMemberInstructors.Location = new System.Drawing.Point(13, 121);
            this.cbManageMemberInstructors.Name = "cbManageMemberInstructors";
            this.cbManageMemberInstructors.Size = new System.Drawing.Size(248, 32);
            this.cbManageMemberInstructors.TabIndex = 3;
            this.cbManageMemberInstructors.Tag = "8";
            this.cbManageMemberInstructors.Text = "Manage Member/Instructors";
            this.cbManageMemberInstructors.UseVisualStyleBackColor = true;
            // 
            // cbManageInstructors
            // 
            this.cbManageInstructors.AutoSize = true;
            this.cbManageInstructors.Location = new System.Drawing.Point(13, 85);
            this.cbManageInstructors.Name = "cbManageInstructors";
            this.cbManageInstructors.Size = new System.Drawing.Size(181, 32);
            this.cbManageInstructors.TabIndex = 2;
            this.cbManageInstructors.Tag = "4";
            this.cbManageInstructors.Text = "Manage Instructors";
            this.cbManageInstructors.UseVisualStyleBackColor = true;
            // 
            // cbManageUsers
            // 
            this.cbManageUsers.AutoSize = true;
            this.cbManageUsers.Location = new System.Drawing.Point(13, 49);
            this.cbManageUsers.Name = "cbManageUsers";
            this.cbManageUsers.Size = new System.Drawing.Size(139, 32);
            this.cbManageUsers.TabIndex = 1;
            this.cbManageUsers.Tag = "2";
            this.cbManageUsers.Text = "Manage Users";
            this.cbManageUsers.UseVisualStyleBackColor = true;
            // 
            // cbManageMembers
            // 
            this.cbManageMembers.AutoSize = true;
            this.cbManageMembers.Location = new System.Drawing.Point(13, 13);
            this.cbManageMembers.Name = "cbManageMembers";
            this.cbManageMembers.Size = new System.Drawing.Size(167, 32);
            this.cbManageMembers.TabIndex = 0;
            this.cbManageMembers.Tag = "1";
            this.cbManageMembers.Text = "Manage Members";
            this.cbManageMembers.UseVisualStyleBackColor = true;
            // 
            // cbAllPermissions
            // 
            this.cbAllPermissions.AutoSize = true;
            this.cbAllPermissions.ForeColor = System.Drawing.Color.Green;
            this.cbAllPermissions.Location = new System.Drawing.Point(31, 32);
            this.cbAllPermissions.Name = "cbAllPermissions";
            this.cbAllPermissions.Size = new System.Drawing.Size(151, 32);
            this.cbAllPermissions.TabIndex = 0;
            this.cbAllPermissions.Tag = "-1";
            this.cbAllPermissions.Text = "All Permissions";
            this.cbAllPermissions.UseVisualStyleBackColor = true;
            this.cbAllPermissions.CheckedChanged += new System.EventHandler(this.cbAllPermissions_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.btnSave.Location = new System.Drawing.Point(643, 395);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(158, 48);
            this.btnSave.TabIndex = 75;
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
            this.btnCancel.Location = new System.Drawing.Point(452, 395);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(158, 48);
            this.btnCancel.TabIndex = 74;
            this.btnCancel.Text = " Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.Transparent;
            this.picture.Image = global::KarateClub.Properties.Resources.employee;
            this.picture.Location = new System.Drawing.Point(12, 48);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(210, 300);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 73;
            this.picture.TabStop = false;
            // 
            // frmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1383, 507);
            this.Controls.Add(this.gbPermissions);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.lbRemove);
            this.Controls.Add(this.lbSetImage);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUserID);
            this.Name = "frmAddUser";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmAddUser_Load);
            this.gbPermissions.ResumeLayout(false);
            this.gbPermissions.PerformLayout();
            this.pnlPermissions.ResumeLayout(false);
            this.pnlPermissions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.LinkLabel lbRemove;
        private System.Windows.Forms.LinkLabel lbSetImage;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.GroupBox gbPermissions;
        private System.Windows.Forms.CheckBox cbAllPermissions;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel pnlPermissions;
        private System.Windows.Forms.CheckBox cbManagePayments;
        private System.Windows.Forms.CheckBox cbManageBeltTests;
        private System.Windows.Forms.CheckBox cbManageBeltRanks;
        private System.Windows.Forms.CheckBox cbManageSubscriptions;
        private System.Windows.Forms.CheckBox cbManageMemberInstructors;
        private System.Windows.Forms.CheckBox cbManageInstructors;
        private System.Windows.Forms.CheckBox cbManageUsers;
        private System.Windows.Forms.CheckBox cbManageMembers;
        private System.Windows.Forms.ImageList imageList1;
    }
}