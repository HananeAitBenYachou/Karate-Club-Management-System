namespace KarateClub.ManageInstructors
{
    partial class frmUpdateInstructor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateInstructor));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl = new System.Windows.Forms.Label();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.tbSearchValue = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lbRemove = new System.Windows.Forms.LinkLabel();
            this.lbSetImage = new System.Windows.Forms.LinkLabel();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbInstructorID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.White;
            this.imageList1.Images.SetKeyName(0, "close.png");
            this.imageList1.Images.SetKeyName(1, "checkmark.png");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(461, 25);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(115, 28);
            this.lbl.TabIndex = 107;
            this.lbl.Text = "Instructor ID :";
            // 
            // pbSearch
            // 
            this.pbSearch.BackColor = System.Drawing.Color.Bisque;
            this.pbSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbSearch.BackgroundImage")));
            this.pbSearch.Image = global::KarateClub.Properties.Resources.search;
            this.pbSearch.Location = new System.Drawing.Point(865, 25);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(39, 32);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 106;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // tbSearchValue
            // 
            this.tbSearchValue.BackColor = System.Drawing.Color.Bisque;
            this.tbSearchValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearchValue.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchValue.Location = new System.Drawing.Point(594, 18);
            this.tbSearchValue.Multiline = true;
            this.tbSearchValue.Name = "tbSearchValue";
            this.tbSearchValue.Size = new System.Drawing.Size(319, 42);
            this.tbSearchValue.TabIndex = 105;
            this.tbSearchValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSearchValue.Validating += new System.ComponentModel.CancelEventHandler(this.tbSearchValue_Validating);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.cbGender);
            this.panel.Controls.Add(this.lbRemove);
            this.panel.Controls.Add(this.lbSetImage);
            this.panel.Controls.Add(this.dtpDateOfBirth);
            this.panel.Controls.Add(this.btnSave);
            this.panel.Controls.Add(this.btnCancel);
            this.panel.Controls.Add(this.picture);
            this.panel.Controls.Add(this.tbEmail);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.tbPhone);
            this.panel.Controls.Add(this.label10);
            this.panel.Controls.Add(this.label9);
            this.panel.Controls.Add(this.tbPassword);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.tbAddress);
            this.panel.Controls.Add(this.tbName);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.tbInstructorID);
            this.panel.Controls.Add(this.label8);
            this.panel.Controls.Add(this.label6);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Enabled = false;
            this.panel.Location = new System.Drawing.Point(0, 60);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1383, 447);
            this.panel.TabIndex = 108;
            // 
            // cbGender
            // 
            this.cbGender.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F);
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(911, 37);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(180, 36);
            this.cbGender.TabIndex = 125;
            this.cbGender.TabStop = false;
            // 
            // lbRemove
            // 
            this.lbRemove.AutoSize = true;
            this.lbRemove.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRemove.Location = new System.Drawing.Point(212, 379);
            this.lbRemove.Name = "lbRemove";
            this.lbRemove.Size = new System.Drawing.Size(72, 28);
            this.lbRemove.TabIndex = 123;
            this.lbRemove.TabStop = true;
            this.lbRemove.Text = "Remove";
            this.lbRemove.Visible = false;
            this.lbRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbRemove_LinkClicked);
            // 
            // lbSetImage
            // 
            this.lbSetImage.AutoSize = true;
            this.lbSetImage.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSetImage.Location = new System.Drawing.Point(109, 379);
            this.lbSetImage.Name = "lbSetImage";
            this.lbSetImage.Size = new System.Drawing.Size(87, 28);
            this.lbSetImage.TabIndex = 122;
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
            this.dtpDateOfBirth.Location = new System.Drawing.Point(911, 275);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(180, 35);
            this.dtpDateOfBirth.TabIndex = 124;
            this.dtpDateOfBirth.TabStop = false;
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
            this.btnSave.Location = new System.Drawing.Point(805, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(158, 48);
            this.btnSave.TabIndex = 121;
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
            this.btnCancel.Location = new System.Drawing.Point(614, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(158, 48);
            this.btnCancel.TabIndex = 120;
            this.btnCancel.Text = " Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.Transparent;
            this.picture.Image = global::KarateClub.Properties.Resources.Instructor__2_;
            this.picture.Location = new System.Drawing.Point(62, 3);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(285, 373);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 119;
            this.picture.TabStop = false;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(911, 117);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(180, 35);
            this.tbEmail.TabIndex = 113;
            this.tbEmail.TabStop = false;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(800, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 28);
            this.label5.TabIndex = 112;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(459, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 28);
            this.label4.TabIndex = 111;
            this.label4.Text = "Name";
            // 
            // tbPhone
            // 
            this.tbPhone.BackColor = System.Drawing.SystemColors.Window;
            this.tbPhone.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(560, 277);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(180, 35);
            this.tbPhone.TabIndex = 110;
            this.tbPhone.TabStop = false;
            this.tbPhone.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(456, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 28);
            this.label10.TabIndex = 118;
            this.label10.Text = "Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(450, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 28);
            this.label9.TabIndex = 117;
            this.label9.Text = "Address";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(911, 196);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(180, 35);
            this.tbPassword.TabIndex = 115;
            this.tbPassword.TabStop = false;
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(806, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 28);
            this.label3.TabIndex = 109;
            this.label3.Text = "Email";
            // 
            // tbAddress
            // 
            this.tbAddress.BackColor = System.Drawing.SystemColors.Window;
            this.tbAddress.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(560, 196);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(180, 35);
            this.tbAddress.TabIndex = 108;
            this.tbAddress.TabStop = false;
            this.tbAddress.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.Window;
            this.tbName.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(560, 115);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(180, 35);
            this.tbName.TabIndex = 107;
            this.tbName.TabStop = false;
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 106;
            this.label1.Text = "Instructor ID";
            // 
            // tbInstructorID
            // 
            this.tbInstructorID.BackColor = System.Drawing.SystemColors.Window;
            this.tbInstructorID.Enabled = false;
            this.tbInstructorID.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInstructorID.Location = new System.Drawing.Point(560, 34);
            this.tbInstructorID.Name = "tbInstructorID";
            this.tbInstructorID.Size = new System.Drawing.Size(180, 35);
            this.tbInstructorID.TabIndex = 105;
            this.tbInstructorID.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(783, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 28);
            this.label8.TabIndex = 116;
            this.label8.Text = "DateOfBirth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(791, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 28);
            this.label6.TabIndex = 114;
            this.label6.Text = "Password";
            // 
            // frmUpdateInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1383, 507);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.tbSearchValue);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lbl);
            this.Name = "frmUpdateInstructor";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmUpdateInstructor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.TextBox tbSearchValue;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.LinkLabel lbRemove;
        private System.Windows.Forms.LinkLabel lbSetImage;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInstructorID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
    }
}