namespace KarateClub.ManageSubscriptions
{
    partial class frmManageSubscriptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageSubscriptions));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnFindSubscription = new System.Windows.Forms.Button();
            this.btnEditSubscription = new System.Windows.Forms.Button();
            this.btnDeleteSubscription = new System.Windows.Forms.Button();
            this.btnSubscriptionsList = new System.Windows.Forms.Button();
            this.btnAddSubscription = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "payment.png");
            // 
            // btnFindSubscription
            // 
            this.btnFindSubscription.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnFindSubscription.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFindSubscription.FlatAppearance.BorderSize = 0;
            this.btnFindSubscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindSubscription.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindSubscription.ForeColor = System.Drawing.Color.White;
            this.btnFindSubscription.ImageIndex = 0;
            this.btnFindSubscription.ImageList = this.imageList1;
            this.btnFindSubscription.Location = new System.Drawing.Point(836, 61);
            this.btnFindSubscription.Name = "btnFindSubscription";
            this.btnFindSubscription.Size = new System.Drawing.Size(185, 78);
            this.btnFindSubscription.TabIndex = 29;
            this.btnFindSubscription.Text = "Find Subscription";
            this.btnFindSubscription.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindSubscription.UseVisualStyleBackColor = false;
            this.btnFindSubscription.Click += new System.EventHandler(this.btnFindSubscription_Click);
            // 
            // btnEditSubscription
            // 
            this.btnEditSubscription.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEditSubscription.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditSubscription.FlatAppearance.BorderSize = 0;
            this.btnEditSubscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSubscription.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSubscription.ForeColor = System.Drawing.Color.White;
            this.btnEditSubscription.ImageIndex = 0;
            this.btnEditSubscription.ImageList = this.imageList1;
            this.btnEditSubscription.Location = new System.Drawing.Point(603, 61);
            this.btnEditSubscription.Name = "btnEditSubscription";
            this.btnEditSubscription.Size = new System.Drawing.Size(185, 78);
            this.btnEditSubscription.TabIndex = 28;
            this.btnEditSubscription.Text = "Edit Subscription";
            this.btnEditSubscription.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditSubscription.UseVisualStyleBackColor = false;
            this.btnEditSubscription.Click += new System.EventHandler(this.btnEditSubscription_Click);
            // 
            // btnDeleteSubscription
            // 
            this.btnDeleteSubscription.BackColor = System.Drawing.Color.Red;
            this.btnDeleteSubscription.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteSubscription.FlatAppearance.BorderSize = 0;
            this.btnDeleteSubscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSubscription.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSubscription.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSubscription.ImageIndex = 0;
            this.btnDeleteSubscription.ImageList = this.imageList1;
            this.btnDeleteSubscription.Location = new System.Drawing.Point(1069, 64);
            this.btnDeleteSubscription.Name = "btnDeleteSubscription";
            this.btnDeleteSubscription.Size = new System.Drawing.Size(185, 78);
            this.btnDeleteSubscription.TabIndex = 27;
            this.btnDeleteSubscription.Text = "Delete Subscription";
            this.btnDeleteSubscription.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteSubscription.UseVisualStyleBackColor = false;
            this.btnDeleteSubscription.Click += new System.EventHandler(this.btnDeleteSubscription_Click);
            // 
            // btnSubscriptionsList
            // 
            this.btnSubscriptionsList.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSubscriptionsList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSubscriptionsList.FlatAppearance.BorderSize = 0;
            this.btnSubscriptionsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubscriptionsList.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubscriptionsList.ForeColor = System.Drawing.Color.White;
            this.btnSubscriptionsList.ImageIndex = 0;
            this.btnSubscriptionsList.ImageList = this.imageList1;
            this.btnSubscriptionsList.Location = new System.Drawing.Point(137, 61);
            this.btnSubscriptionsList.Name = "btnSubscriptionsList";
            this.btnSubscriptionsList.Size = new System.Drawing.Size(185, 78);
            this.btnSubscriptionsList.TabIndex = 26;
            this.btnSubscriptionsList.Text = "Subscriptions List";
            this.btnSubscriptionsList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubscriptionsList.UseVisualStyleBackColor = false;
            this.btnSubscriptionsList.Click += new System.EventHandler(this.btnSubscriptionsList_Click);
            // 
            // btnAddSubscription
            // 
            this.btnAddSubscription.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddSubscription.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddSubscription.FlatAppearance.BorderSize = 0;
            this.btnAddSubscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSubscription.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSubscription.ForeColor = System.Drawing.Color.White;
            this.btnAddSubscription.ImageIndex = 0;
            this.btnAddSubscription.ImageList = this.imageList1;
            this.btnAddSubscription.Location = new System.Drawing.Point(370, 61);
            this.btnAddSubscription.Name = "btnAddSubscription";
            this.btnAddSubscription.Size = new System.Drawing.Size(185, 78);
            this.btnAddSubscription.TabIndex = 25;
            this.btnAddSubscription.Text = "Add Subscription";
            this.btnAddSubscription.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddSubscription.UseVisualStyleBackColor = false;
            this.btnAddSubscription.Click += new System.EventHandler(this.btnAddSubscription_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelContainer.Location = new System.Drawing.Point(0, 83);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1409, 554);
            this.panelContainer.TabIndex = 30;
            // 
            // frmManageSubscriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1409, 637);
            this.Controls.Add(this.btnFindSubscription);
            this.Controls.Add(this.btnEditSubscription);
            this.Controls.Add(this.btnDeleteSubscription);
            this.Controls.Add(this.btnSubscriptionsList);
            this.Controls.Add(this.btnAddSubscription);
            this.Controls.Add(this.panelContainer);
            this.Name = "frmManageSubscriptions";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmManageSubscriptions_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnFindSubscription;
        private System.Windows.Forms.Button btnEditSubscription;
        private System.Windows.Forms.Button btnDeleteSubscription;
        private System.Windows.Forms.Button btnSubscriptionsList;
        private System.Windows.Forms.Button btnAddSubscription;
        private System.Windows.Forms.Panel panelContainer;
    }
}