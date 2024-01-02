namespace KarateClub
{
    partial class frmManageMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageMembers));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnEditMember = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnMembersList = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnFindMember = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "user (1).png");
            this.imageList1.Images.SetKeyName(1, "user.png");
            this.imageList1.Images.SetKeyName(2, "group (2).png");
            this.imageList1.Images.SetKeyName(3, "user (2).png");
            this.imageList1.Images.SetKeyName(4, "user (4).png");
            // 
            // btnEditMember
            // 
            this.btnEditMember.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEditMember.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditMember.FlatAppearance.BorderSize = 0;
            this.btnEditMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMember.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMember.ForeColor = System.Drawing.Color.White;
            this.btnEditMember.ImageKey = "user (2).png";
            this.btnEditMember.ImageList = this.imageList1;
            this.btnEditMember.Location = new System.Drawing.Point(603, 63);
            this.btnEditMember.Name = "btnEditMember";
            this.btnEditMember.Size = new System.Drawing.Size(185, 78);
            this.btnEditMember.TabIndex = 4;
            this.btnEditMember.Text = "Edit Member";
            this.btnEditMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditMember.UseVisualStyleBackColor = false;
            this.btnEditMember.Click += new System.EventHandler(this.btnEditMember_Click);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.BackColor = System.Drawing.Color.Red;
            this.btnDeleteMember.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteMember.FlatAppearance.BorderSize = 0;
            this.btnDeleteMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMember.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMember.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMember.ImageKey = "user.png";
            this.btnDeleteMember.ImageList = this.imageList1;
            this.btnDeleteMember.Location = new System.Drawing.Point(1069, 63);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(185, 78);
            this.btnDeleteMember.TabIndex = 3;
            this.btnDeleteMember.Text = "Delete Member";
            this.btnDeleteMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteMember.UseVisualStyleBackColor = false;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // btnMembersList
            // 
            this.btnMembersList.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMembersList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMembersList.FlatAppearance.BorderSize = 0;
            this.btnMembersList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembersList.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembersList.ForeColor = System.Drawing.Color.White;
            this.btnMembersList.ImageKey = "group (2).png";
            this.btnMembersList.ImageList = this.imageList1;
            this.btnMembersList.Location = new System.Drawing.Point(137, 63);
            this.btnMembersList.Name = "btnMembersList";
            this.btnMembersList.Size = new System.Drawing.Size(185, 78);
            this.btnMembersList.TabIndex = 2;
            this.btnMembersList.Text = "Members List";
            this.btnMembersList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMembersList.UseVisualStyleBackColor = false;
            this.btnMembersList.Click += new System.EventHandler(this.btnMembersList_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddMember.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddMember.FlatAppearance.BorderSize = 0;
            this.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMember.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.ForeColor = System.Drawing.Color.White;
            this.btnAddMember.ImageIndex = 0;
            this.btnAddMember.ImageList = this.imageList1;
            this.btnAddMember.Location = new System.Drawing.Point(370, 63);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(185, 78);
            this.btnAddMember.TabIndex = 1;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddMember.UseVisualStyleBackColor = false;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnFindMember
            // 
            this.btnFindMember.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnFindMember.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFindMember.FlatAppearance.BorderSize = 0;
            this.btnFindMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindMember.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindMember.ForeColor = System.Drawing.Color.White;
            this.btnFindMember.ImageKey = "user (4).png";
            this.btnFindMember.ImageList = this.imageList1;
            this.btnFindMember.Location = new System.Drawing.Point(836, 63);
            this.btnFindMember.Name = "btnFindMember";
            this.btnFindMember.Size = new System.Drawing.Size(185, 78);
            this.btnFindMember.TabIndex = 5;
            this.btnFindMember.Text = "Find Member";
            this.btnFindMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindMember.UseVisualStyleBackColor = false;
            this.btnFindMember.Click += new System.EventHandler(this.btnFindMember_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelContainer.Location = new System.Drawing.Point(0, 83);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1409, 554);
            this.panelContainer.TabIndex = 6;
            // 
            // frmManageMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1409, 637);
            this.Controls.Add(this.btnFindMember);
            this.Controls.Add(this.btnEditMember);
            this.Controls.Add(this.btnDeleteMember);
            this.Controls.Add(this.btnMembersList);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.panelContainer);
            this.Name = "frmManageMembers";
            this.Text = "frmManageMembers";
            this.Load += new System.EventHandler(this.frmManageMembers_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnMembersList;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnEditMember;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnFindMember;
        private System.Windows.Forms.Panel panelContainer;
    }
}