namespace KarateClub.LoginMode.MemberMode.Main
{
    partial class frmMemberHome
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLoggedInMember = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlMemberInstructors = new System.Windows.Forms.Panel();
            this.pnlLogout = new System.Windows.Forms.Panel();
            this.pnlPayments = new System.Windows.Forms.Panel();
            this.pnlBeltTests = new System.Windows.Forms.Panel();
            this.pnlSubscriptions = new System.Windows.Forms.Panel();
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMemberInstructors = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMemberPayments = new System.Windows.Forms.Button();
            this.btnMemberBeltTests = new System.Windows.Forms.Button();
            this.btnMemberSubscriptions = new System.Windows.Forms.Button();
            this.btnMemberProfile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(150)))), ((int)(((byte)(11)))));
            this.panelHeader.Controls.Add(this.btnEditProfile);
            this.panelHeader.Controls.Add(this.lblLoggedInMember);
            this.panelHeader.Controls.Add(this.pictureBox2);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(286, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1434, 74);
            this.panelHeader.TabIndex = 5;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnEditProfile.ContextMenuStrip = this.contextMenuStrip1;
            this.btnEditProfile.FlatAppearance.BorderSize = 0;
            this.btnEditProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEditProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProfile.Image = global::KarateClub.Properties.Resources.drop_down_menu__1_;
            this.btnEditProfile.Location = new System.Drawing.Point(1367, 9);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(65, 59);
            this.btnEditProfile.TabIndex = 1;
            this.btnEditProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditProfile.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editInfoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowItemToolTips = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(180, 30);
            // 
            // editInfoToolStripMenuItem
            // 
            this.editInfoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.editInfoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editInfoToolStripMenuItem.Image = global::KarateClub.Properties.Resources.pencil;
            this.editInfoToolStripMenuItem.Name = "editInfoToolStripMenuItem";
            this.editInfoToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.editInfoToolStripMenuItem.Text = "Edit My Profile";
            this.editInfoToolStripMenuItem.Click += new System.EventHandler(this.editInfoToolStripMenuItem_Click);
            // 
            // lblLoggedInMember
            // 
            this.lblLoggedInMember.AutoSize = true;
            this.lblLoggedInMember.BackColor = System.Drawing.Color.Transparent;
            this.lblLoggedInMember.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14F, System.Drawing.FontStyle.Bold);
            this.lblLoggedInMember.ForeColor = System.Drawing.Color.White;
            this.lblLoggedInMember.Location = new System.Drawing.Point(86, 25);
            this.lblLoggedInMember.Name = "lblLoggedInMember";
            this.lblLoggedInMember.Size = new System.Drawing.Size(89, 29);
            this.lblLoggedInMember.TabIndex = 2;
            this.lblLoggedInMember.Text = "Member";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::KarateClub.Properties.Resources.login;
            this.pictureBox2.Location = new System.Drawing.Point(-35, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pnlMemberInstructors
            // 
            this.pnlMemberInstructors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(150)))), ((int)(((byte)(11)))));
            this.pnlMemberInstructors.Location = new System.Drawing.Point(1, 264);
            this.pnlMemberInstructors.Name = "pnlMemberInstructors";
            this.pnlMemberInstructors.Size = new System.Drawing.Size(10, 43);
            this.pnlMemberInstructors.TabIndex = 21;
            this.pnlMemberInstructors.Visible = false;
            // 
            // pnlLogout
            // 
            this.pnlLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(150)))), ((int)(((byte)(11)))));
            this.pnlLogout.Location = new System.Drawing.Point(1, 749);
            this.pnlLogout.Name = "pnlLogout";
            this.pnlLogout.Size = new System.Drawing.Size(10, 43);
            this.pnlLogout.TabIndex = 19;
            this.pnlLogout.Visible = false;
            // 
            // pnlPayments
            // 
            this.pnlPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(150)))), ((int)(((byte)(11)))));
            this.pnlPayments.Location = new System.Drawing.Point(1, 453);
            this.pnlPayments.Name = "pnlPayments";
            this.pnlPayments.Size = new System.Drawing.Size(10, 43);
            this.pnlPayments.TabIndex = 17;
            this.pnlPayments.Visible = false;
            // 
            // pnlBeltTests
            // 
            this.pnlBeltTests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(150)))), ((int)(((byte)(11)))));
            this.pnlBeltTests.Location = new System.Drawing.Point(1, 390);
            this.pnlBeltTests.Name = "pnlBeltTests";
            this.pnlBeltTests.Size = new System.Drawing.Size(10, 43);
            this.pnlBeltTests.TabIndex = 15;
            this.pnlBeltTests.Visible = false;
            // 
            // pnlSubscriptions
            // 
            this.pnlSubscriptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(150)))), ((int)(((byte)(11)))));
            this.pnlSubscriptions.Location = new System.Drawing.Point(1, 327);
            this.pnlSubscriptions.Name = "pnlSubscriptions";
            this.pnlSubscriptions.Size = new System.Drawing.Size(10, 43);
            this.pnlSubscriptions.TabIndex = 13;
            this.pnlSubscriptions.Visible = false;
            // 
            // pnlProfile
            // 
            this.pnlProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(150)))), ((int)(((byte)(11)))));
            this.pnlProfile.Location = new System.Drawing.Point(1, 201);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(10, 43);
            this.pnlProfile.TabIndex = 7;
            this.pnlProfile.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Brush Script MT", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Karate Club";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.pnlMemberInstructors);
            this.panel1.Controls.Add(this.btnMemberInstructors);
            this.panel1.Controls.Add(this.pnlLogout);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.pnlPayments);
            this.panel1.Controls.Add(this.btnMemberPayments);
            this.panel1.Controls.Add(this.pnlBeltTests);
            this.panel1.Controls.Add(this.btnMemberBeltTests);
            this.panel1.Controls.Add(this.pnlSubscriptions);
            this.panel1.Controls.Add(this.btnMemberSubscriptions);
            this.panel1.Controls.Add(this.pnlProfile);
            this.panel1.Controls.Add(this.btnMemberProfile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 822);
            this.panel1.TabIndex = 4;
            // 
            // btnMemberInstructors
            // 
            this.btnMemberInstructors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnMemberInstructors.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnMemberInstructors.FlatAppearance.BorderSize = 0;
            this.btnMemberInstructors.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(158)))), ((int)(((byte)(1)))));
            this.btnMemberInstructors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberInstructors.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberInstructors.ForeColor = System.Drawing.Color.White;
            this.btnMemberInstructors.Image = global::KarateClub.Properties.Resources.people__3_;
            this.btnMemberInstructors.Location = new System.Drawing.Point(0, 257);
            this.btnMemberInstructors.Name = "btnMemberInstructors";
            this.btnMemberInstructors.Size = new System.Drawing.Size(286, 54);
            this.btnMemberInstructors.TabIndex = 20;
            this.btnMemberInstructors.Text = "     My Instructors";
            this.btnMemberInstructors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMemberInstructors.UseVisualStyleBackColor = false;
            this.btnMemberInstructors.Click += new System.EventHandler(this.btnMemberInstructors_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(158)))), ((int)(((byte)(1)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::KarateClub.Properties.Resources.logout;
            this.btnLogout.Location = new System.Drawing.Point(-1, 743);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(286, 54);
            this.btnLogout.TabIndex = 18;
            this.btnLogout.Text = "   Log Out";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMemberPayments
            // 
            this.btnMemberPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnMemberPayments.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnMemberPayments.FlatAppearance.BorderSize = 0;
            this.btnMemberPayments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(158)))), ((int)(((byte)(1)))));
            this.btnMemberPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberPayments.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberPayments.ForeColor = System.Drawing.Color.White;
            this.btnMemberPayments.Image = global::KarateClub.Properties.Resources.payment_method__1_;
            this.btnMemberPayments.Location = new System.Drawing.Point(-1, 446);
            this.btnMemberPayments.Name = "btnMemberPayments";
            this.btnMemberPayments.Size = new System.Drawing.Size(286, 54);
            this.btnMemberPayments.TabIndex = 16;
            this.btnMemberPayments.Text = "    My Payments";
            this.btnMemberPayments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMemberPayments.UseVisualStyleBackColor = false;
            this.btnMemberPayments.Click += new System.EventHandler(this.btnMemberPayments_Click);
            // 
            // btnMemberBeltTests
            // 
            this.btnMemberBeltTests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnMemberBeltTests.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnMemberBeltTests.FlatAppearance.BorderSize = 0;
            this.btnMemberBeltTests.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(158)))), ((int)(((byte)(1)))));
            this.btnMemberBeltTests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberBeltTests.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberBeltTests.ForeColor = System.Drawing.Color.White;
            this.btnMemberBeltTests.Image = global::KarateClub.Properties.Resources.karate__6_;
            this.btnMemberBeltTests.Location = new System.Drawing.Point(0, 383);
            this.btnMemberBeltTests.Name = "btnMemberBeltTests";
            this.btnMemberBeltTests.Size = new System.Drawing.Size(286, 54);
            this.btnMemberBeltTests.TabIndex = 14;
            this.btnMemberBeltTests.Text = "     My Belt Tests";
            this.btnMemberBeltTests.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMemberBeltTests.UseVisualStyleBackColor = false;
            this.btnMemberBeltTests.Click += new System.EventHandler(this.btnMemberBeltTests_Click);
            // 
            // btnMemberSubscriptions
            // 
            this.btnMemberSubscriptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnMemberSubscriptions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnMemberSubscriptions.FlatAppearance.BorderSize = 0;
            this.btnMemberSubscriptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(158)))), ((int)(((byte)(1)))));
            this.btnMemberSubscriptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberSubscriptions.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberSubscriptions.ForeColor = System.Drawing.Color.White;
            this.btnMemberSubscriptions.Image = global::KarateClub.Properties.Resources.calendar__1_;
            this.btnMemberSubscriptions.Location = new System.Drawing.Point(0, 320);
            this.btnMemberSubscriptions.Name = "btnMemberSubscriptions";
            this.btnMemberSubscriptions.Size = new System.Drawing.Size(286, 54);
            this.btnMemberSubscriptions.TabIndex = 12;
            this.btnMemberSubscriptions.Text = "   My Subscriptions";
            this.btnMemberSubscriptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMemberSubscriptions.UseVisualStyleBackColor = false;
            this.btnMemberSubscriptions.Click += new System.EventHandler(this.btnMemberSubscriptions_Click);
            // 
            // btnMemberProfile
            // 
            this.btnMemberProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnMemberProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.btnMemberProfile.FlatAppearance.BorderSize = 0;
            this.btnMemberProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(158)))), ((int)(((byte)(1)))));
            this.btnMemberProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberProfile.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberProfile.ForeColor = System.Drawing.Color.White;
            this.btnMemberProfile.Image = global::KarateClub.Properties.Resources.user__6_;
            this.btnMemberProfile.Location = new System.Drawing.Point(0, 194);
            this.btnMemberProfile.Name = "btnMemberProfile";
            this.btnMemberProfile.Size = new System.Drawing.Size(286, 54);
            this.btnMemberProfile.TabIndex = 3;
            this.btnMemberProfile.Text = "          Profile";
            this.btnMemberProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMemberProfile.UseVisualStyleBackColor = false;
            this.btnMemberProfile.Click += new System.EventHandler(this.btnMemberProfile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::KarateClub.Properties.Resources.Personajes_deportivos_taekwondo_player___Vector_Premium_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(-10, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Location = new System.Drawing.Point(292, 151);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1417, 613);
            this.panelContainer.TabIndex = 6;
            // 
            // frmMemberHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1720, 822);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMemberHome";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editInfoToolStripMenuItem;
        private System.Windows.Forms.Label lblLoggedInMember;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlMemberInstructors;
        private System.Windows.Forms.Button btnMemberInstructors;
        private System.Windows.Forms.Panel pnlLogout;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlPayments;
        private System.Windows.Forms.Button btnMemberPayments;
        private System.Windows.Forms.Panel pnlBeltTests;
        private System.Windows.Forms.Button btnMemberBeltTests;
        private System.Windows.Forms.Panel pnlSubscriptions;
        private System.Windows.Forms.Button btnMemberSubscriptions;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Button btnMemberProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContainer;
    }
}