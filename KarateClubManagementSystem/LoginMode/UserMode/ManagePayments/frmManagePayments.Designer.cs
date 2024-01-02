namespace KarateClub.ManagePayments
{
    partial class frmManagePayments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagePayments));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnFindPayment = new System.Windows.Forms.Button();
            this.btnEditPayment = new System.Windows.Forms.Button();
            this.btnDeletePayment = new System.Windows.Forms.Button();
            this.btnPaymentsList = new System.Windows.Forms.Button();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "payment.png");
            // 
            // btnFindPayment
            // 
            this.btnFindPayment.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnFindPayment.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFindPayment.FlatAppearance.BorderSize = 0;
            this.btnFindPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindPayment.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindPayment.ForeColor = System.Drawing.Color.White;
            this.btnFindPayment.ImageIndex = 0;
            this.btnFindPayment.ImageList = this.imageList1;
            this.btnFindPayment.Location = new System.Drawing.Point(836, 61);
            this.btnFindPayment.Name = "btnFindPayment";
            this.btnFindPayment.Size = new System.Drawing.Size(185, 78);
            this.btnFindPayment.TabIndex = 23;
            this.btnFindPayment.Text = "Find Payment";
            this.btnFindPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindPayment.UseVisualStyleBackColor = false;
            this.btnFindPayment.Click += new System.EventHandler(this.btnFindPayment_Click);
            // 
            // btnEditPayment
            // 
            this.btnEditPayment.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEditPayment.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditPayment.FlatAppearance.BorderSize = 0;
            this.btnEditPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPayment.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPayment.ForeColor = System.Drawing.Color.White;
            this.btnEditPayment.ImageIndex = 0;
            this.btnEditPayment.ImageList = this.imageList1;
            this.btnEditPayment.Location = new System.Drawing.Point(603, 61);
            this.btnEditPayment.Name = "btnEditPayment";
            this.btnEditPayment.Size = new System.Drawing.Size(185, 78);
            this.btnEditPayment.TabIndex = 22;
            this.btnEditPayment.Text = "Edit Payment";
            this.btnEditPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditPayment.UseVisualStyleBackColor = false;
            this.btnEditPayment.Click += new System.EventHandler(this.btnEditPayment_Click);
            // 
            // btnDeletePayment
            // 
            this.btnDeletePayment.BackColor = System.Drawing.Color.Red;
            this.btnDeletePayment.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeletePayment.FlatAppearance.BorderSize = 0;
            this.btnDeletePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePayment.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePayment.ForeColor = System.Drawing.Color.White;
            this.btnDeletePayment.ImageIndex = 0;
            this.btnDeletePayment.ImageList = this.imageList1;
            this.btnDeletePayment.Location = new System.Drawing.Point(1069, 64);
            this.btnDeletePayment.Name = "btnDeletePayment";
            this.btnDeletePayment.Size = new System.Drawing.Size(185, 78);
            this.btnDeletePayment.TabIndex = 21;
            this.btnDeletePayment.Text = "Delete Payment";
            this.btnDeletePayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeletePayment.UseVisualStyleBackColor = false;
            this.btnDeletePayment.Click += new System.EventHandler(this.btnDeletePayment_Click);
            // 
            // btnPaymentsList
            // 
            this.btnPaymentsList.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPaymentsList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPaymentsList.FlatAppearance.BorderSize = 0;
            this.btnPaymentsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentsList.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentsList.ForeColor = System.Drawing.Color.White;
            this.btnPaymentsList.ImageIndex = 0;
            this.btnPaymentsList.ImageList = this.imageList1;
            this.btnPaymentsList.Location = new System.Drawing.Point(137, 61);
            this.btnPaymentsList.Name = "btnPaymentsList";
            this.btnPaymentsList.Size = new System.Drawing.Size(185, 78);
            this.btnPaymentsList.TabIndex = 20;
            this.btnPaymentsList.Text = "Payments List";
            this.btnPaymentsList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaymentsList.UseVisualStyleBackColor = false;
            this.btnPaymentsList.Click += new System.EventHandler(this.btnPaymentsList_Click);
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddPayment.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddPayment.FlatAppearance.BorderSize = 0;
            this.btnAddPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPayment.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPayment.ForeColor = System.Drawing.Color.White;
            this.btnAddPayment.ImageIndex = 0;
            this.btnAddPayment.ImageList = this.imageList1;
            this.btnAddPayment.Location = new System.Drawing.Point(370, 61);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(185, 78);
            this.btnAddPayment.TabIndex = 19;
            this.btnAddPayment.Text = "Add Payment";
            this.btnAddPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddPayment.UseVisualStyleBackColor = false;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelContainer.Location = new System.Drawing.Point(0, 83);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1409, 554);
            this.panelContainer.TabIndex = 24;
            // 
            // frmManagePayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1409, 637);
            this.Controls.Add(this.btnFindPayment);
            this.Controls.Add(this.btnEditPayment);
            this.Controls.Add(this.btnDeletePayment);
            this.Controls.Add(this.btnPaymentsList);
            this.Controls.Add(this.btnAddPayment);
            this.Controls.Add(this.panelContainer);
            this.Name = "frmManagePayments";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmManagePayments_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnFindPayment;
        private System.Windows.Forms.Button btnEditPayment;
        private System.Windows.Forms.Button btnDeletePayment;
        private System.Windows.Forms.Button btnPaymentsList;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.Panel panelContainer;
    }
}