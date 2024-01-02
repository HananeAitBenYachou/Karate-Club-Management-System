namespace KarateClub.ManageInstructors
{
    partial class frmManageInstructors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageInstructors));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnFindInstructor = new System.Windows.Forms.Button();
            this.btnEditInstructor = new System.Windows.Forms.Button();
            this.btnDeleteInstructor = new System.Windows.Forms.Button();
            this.btnInstructorsList = new System.Windows.Forms.Button();
            this.btnAddInstructor = new System.Windows.Forms.Button();
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
            // btnFindInstructor
            // 
            this.btnFindInstructor.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnFindInstructor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFindInstructor.FlatAppearance.BorderSize = 0;
            this.btnFindInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindInstructor.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindInstructor.ForeColor = System.Drawing.Color.White;
            this.btnFindInstructor.ImageKey = "user (4).png";
            this.btnFindInstructor.ImageList = this.imageList1;
            this.btnFindInstructor.Location = new System.Drawing.Point(836, 63);
            this.btnFindInstructor.Name = "btnFindInstructor";
            this.btnFindInstructor.Size = new System.Drawing.Size(185, 78);
            this.btnFindInstructor.TabIndex = 11;
            this.btnFindInstructor.Text = "Find Instructor";
            this.btnFindInstructor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindInstructor.UseVisualStyleBackColor = false;
            this.btnFindInstructor.Click += new System.EventHandler(this.btnFindInstructor_Click);
            // 
            // btnEditInstructor
            // 
            this.btnEditInstructor.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEditInstructor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditInstructor.FlatAppearance.BorderSize = 0;
            this.btnEditInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditInstructor.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditInstructor.ForeColor = System.Drawing.Color.White;
            this.btnEditInstructor.ImageKey = "user (2).png";
            this.btnEditInstructor.ImageList = this.imageList1;
            this.btnEditInstructor.Location = new System.Drawing.Point(603, 63);
            this.btnEditInstructor.Name = "btnEditInstructor";
            this.btnEditInstructor.Size = new System.Drawing.Size(185, 78);
            this.btnEditInstructor.TabIndex = 10;
            this.btnEditInstructor.Text = "Edit Instructor";
            this.btnEditInstructor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditInstructor.UseVisualStyleBackColor = false;
            this.btnEditInstructor.Click += new System.EventHandler(this.btnEditInstructor_Click);
            // 
            // btnDeleteInstructor
            // 
            this.btnDeleteInstructor.BackColor = System.Drawing.Color.Red;
            this.btnDeleteInstructor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteInstructor.FlatAppearance.BorderSize = 0;
            this.btnDeleteInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteInstructor.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteInstructor.ForeColor = System.Drawing.Color.White;
            this.btnDeleteInstructor.ImageKey = "user.png";
            this.btnDeleteInstructor.ImageList = this.imageList1;
            this.btnDeleteInstructor.Location = new System.Drawing.Point(1069, 63);
            this.btnDeleteInstructor.Name = "btnDeleteInstructor";
            this.btnDeleteInstructor.Size = new System.Drawing.Size(185, 78);
            this.btnDeleteInstructor.TabIndex = 9;
            this.btnDeleteInstructor.Text = "Delete Instructor";
            this.btnDeleteInstructor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteInstructor.UseVisualStyleBackColor = false;
            this.btnDeleteInstructor.Click += new System.EventHandler(this.btnDeleteInstructor_Click);
            // 
            // btnInstructorsList
            // 
            this.btnInstructorsList.BackColor = System.Drawing.Color.SeaGreen;
            this.btnInstructorsList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInstructorsList.FlatAppearance.BorderSize = 0;
            this.btnInstructorsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstructorsList.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructorsList.ForeColor = System.Drawing.Color.White;
            this.btnInstructorsList.ImageKey = "group (2).png";
            this.btnInstructorsList.ImageList = this.imageList1;
            this.btnInstructorsList.Location = new System.Drawing.Point(137, 63);
            this.btnInstructorsList.Name = "btnInstructorsList";
            this.btnInstructorsList.Size = new System.Drawing.Size(185, 78);
            this.btnInstructorsList.TabIndex = 8;
            this.btnInstructorsList.Text = "Instructors List ";
            this.btnInstructorsList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInstructorsList.UseVisualStyleBackColor = false;
            this.btnInstructorsList.Click += new System.EventHandler(this.btnInstructorsList_Click);
            // 
            // btnAddInstructor
            // 
            this.btnAddInstructor.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddInstructor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddInstructor.FlatAppearance.BorderSize = 0;
            this.btnAddInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddInstructor.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInstructor.ForeColor = System.Drawing.Color.White;
            this.btnAddInstructor.ImageIndex = 0;
            this.btnAddInstructor.ImageList = this.imageList1;
            this.btnAddInstructor.Location = new System.Drawing.Point(370, 63);
            this.btnAddInstructor.Name = "btnAddInstructor";
            this.btnAddInstructor.Size = new System.Drawing.Size(185, 78);
            this.btnAddInstructor.TabIndex = 7;
            this.btnAddInstructor.Text = "Add Instructor";
            this.btnAddInstructor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddInstructor.UseVisualStyleBackColor = false;
            this.btnAddInstructor.Click += new System.EventHandler(this.btnAddInstructor_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelContainer.Location = new System.Drawing.Point(0, 83);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1409, 554);
            this.panelContainer.TabIndex = 12;
            // 
            // frmManageInstructors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1409, 637);
            this.Controls.Add(this.btnFindInstructor);
            this.Controls.Add(this.btnEditInstructor);
            this.Controls.Add(this.btnDeleteInstructor);
            this.Controls.Add(this.btnInstructorsList);
            this.Controls.Add(this.btnAddInstructor);
            this.Controls.Add(this.panelContainer);
            this.Name = "frmManageInstructors";
            this.Text = "frmManageInstructors";
            this.Load += new System.EventHandler(this.frmManageInstructors_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnFindInstructor;
        private System.Windows.Forms.Button btnEditInstructor;
        private System.Windows.Forms.Button btnDeleteInstructor;
        private System.Windows.Forms.Button btnInstructorsList;
        private System.Windows.Forms.Button btnAddInstructor;
        private System.Windows.Forms.Panel panelContainer;
    }
}