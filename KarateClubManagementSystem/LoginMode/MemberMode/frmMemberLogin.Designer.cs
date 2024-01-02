namespace KarateClub
{
    partial class frmMemberLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMemberLogin));
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblFailedLoginMsg = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnUserLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbMemberEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbErrorIcon = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbErrorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbPassword.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13F, System.Drawing.FontStyle.Bold);
            this.tbPassword.Location = new System.Drawing.Point(745, 254);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(296, 48);
            this.tbPassword.TabIndex = 44;
            this.tbPassword.TabStop = false;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            // 
            // lblFailedLoginMsg
            // 
            this.lblFailedLoginMsg.AutoSize = true;
            this.lblFailedLoginMsg.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.lblFailedLoginMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblFailedLoginMsg.Location = new System.Drawing.Point(705, 362);
            this.lblFailedLoginMsg.Name = "lblFailedLoginMsg";
            this.lblFailedLoginMsg.Size = new System.Drawing.Size(105, 24);
            this.lblFailedLoginMsg.TabIndex = 42;
            this.lblFailedLoginMsg.Text = "Error Message";
            this.lblFailedLoginMsg.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnUserLogin
            // 
            this.btnUserLogin.BackColor = System.Drawing.Color.SkyBlue;
            this.btnUserLogin.FlatAppearance.BorderSize = 0;
            this.btnUserLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserLogin.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.5F, System.Drawing.FontStyle.Bold);
            this.btnUserLogin.Location = new System.Drawing.Point(711, 492);
            this.btnUserLogin.Name = "btnUserLogin";
            this.btnUserLogin.Size = new System.Drawing.Size(337, 67);
            this.btnUserLogin.TabIndex = 40;
            this.btnUserLogin.Text = "Login as User";
            this.btnUserLogin.UseVisualStyleBackColor = false;
            this.btnUserLogin.Click += new System.EventHandler(this.btnUserLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 26F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(760, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 53);
            this.label1.TabIndex = 32;
            this.label1.Text = "Welcome Back !";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.SkyBlue;
            this.label7.Location = new System.Drawing.Point(937, 592);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 29);
            this.label7.TabIndex = 38;
            this.label7.Text = "Sign up";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(697, 592);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 29);
            this.label6.TabIndex = 37;
            this.label6.Text = "Don\'t have an account yet ? ";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SkyBlue;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.5F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Location = new System.Drawing.Point(711, 407);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(337, 67);
            this.btnLogin.TabIndex = 36;
            this.btnLogin.Text = "Login ";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbMemberEmail
            // 
            this.tbMemberEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbMemberEmail.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13F, System.Drawing.FontStyle.Bold);
            this.tbMemberEmail.ForeColor = System.Drawing.Color.Black;
            this.tbMemberEmail.Location = new System.Drawing.Point(745, 181);
            this.tbMemberEmail.Multiline = true;
            this.tbMemberEmail.Name = "tbMemberEmail";
            this.tbMemberEmail.Size = new System.Drawing.Size(296, 48);
            this.tbMemberEmail.TabIndex = 33;
            this.tbMemberEmail.TabStop = false;
            this.tbMemberEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMemberEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(495, 93);
            this.label2.TabIndex = 2;
            this.label2.Text = "\"Unleash your inner warrior and learn\r\n                the art of karate \r\n      " +
    "                 with us! \"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.SkyBlue;
            this.label4.Location = new System.Drawing.Point(906, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "Forgot Password ? ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 679);
            this.panel1.TabIndex = 31;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KarateClub.Properties.Resources.Personajes_deportivos_taekwondo_player___Vector_Premium_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(48, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(441, 477);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pbErrorIcon
            // 
            this.pbErrorIcon.Image = global::KarateClub.Properties.Resources.exclamation_mark;
            this.pbErrorIcon.Location = new System.Drawing.Point(672, 355);
            this.pbErrorIcon.Name = "pbErrorIcon";
            this.pbErrorIcon.Size = new System.Drawing.Size(31, 34);
            this.pbErrorIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbErrorIcon.TabIndex = 43;
            this.pbErrorIcon.TabStop = false;
            this.pbErrorIcon.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::KarateClub.Properties.Resources.close__1_;
            this.btnClose.Location = new System.Drawing.Point(1208, -3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 39);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 41;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(695, 261);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(695, 188);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // frmMemberLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1247, 679);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.pbErrorIcon);
            this.Controls.Add(this.lblFailedLoginMsg);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUserLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbMemberEmail);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMemberLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbErrorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.PictureBox pbErrorIcon;
        private System.Windows.Forms.Label lblFailedLoginMsg;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnUserLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbMemberEmail;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}