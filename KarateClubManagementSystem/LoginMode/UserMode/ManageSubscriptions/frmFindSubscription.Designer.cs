namespace KarateClub.ManageSubscriptions
{
    partial class frmFindSubscription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindSubscription));
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.tbSearchValue = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbNotPaid = new System.Windows.Forms.RadioButton();
            this.rbPaid = new System.Windows.Forms.RadioButton();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSubscriptionPeriodID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nUDFees = new System.Windows.Forms.NumericUpDown();
            this.lbMembers = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSearch
            // 
            this.pbSearch.BackColor = System.Drawing.Color.Bisque;
            this.pbSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbSearch.BackgroundImage")));
            this.pbSearch.Image = global::KarateClub.Properties.Resources.search;
            this.pbSearch.Location = new System.Drawing.Point(775, 18);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(39, 32);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 118;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // tbSearchValue
            // 
            this.tbSearchValue.BackColor = System.Drawing.Color.Bisque;
            this.tbSearchValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearchValue.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchValue.Location = new System.Drawing.Point(504, 8);
            this.tbSearchValue.Multiline = true;
            this.tbSearchValue.Name = "tbSearchValue";
            this.tbSearchValue.Size = new System.Drawing.Size(319, 42);
            this.tbSearchValue.TabIndex = 117;
            this.tbSearchValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSearchValue.Validating += new System.ComponentModel.CancelEventHandler(this.tbSearchValue_Validating);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(362, 18);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(127, 28);
            this.lbl.TabIndex = 119;
            this.lbl.Text = "Subscription ID";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarMonthBackground = System.Drawing.SystemColors.ActiveBorder;
            this.dtpEndDate.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpEndDate.CalendarTrailingForeColor = System.Drawing.SystemColors.Highlight;
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(690, 242);
            this.dtpEndDate.MaxDate = new System.DateTime(2025, 7, 23, 0, 0, 0, 0);
            this.dtpEndDate.MinDate = new System.DateTime(2023, 7, 23, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(203, 35);
            this.dtpEndDate.TabIndex = 140;
            this.dtpEndDate.TabStop = false;
            this.dtpEndDate.Value = new System.DateTime(2023, 7, 23, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(584, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 28);
            this.label6.TabIndex = 139;
            this.label6.Text = "End Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1034, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 28);
            this.label5.TabIndex = 138;
            this.label5.Text = "Is Paid ";
            // 
            // rbNotPaid
            // 
            this.rbNotPaid.AutoSize = true;
            this.rbNotPaid.Enabled = false;
            this.rbNotPaid.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNotPaid.Location = new System.Drawing.Point(1214, 245);
            this.rbNotPaid.Name = "rbNotPaid";
            this.rbNotPaid.Size = new System.Drawing.Size(59, 38);
            this.rbNotPaid.TabIndex = 137;
            this.rbNotPaid.TabStop = true;
            this.rbNotPaid.Text = "No";
            this.rbNotPaid.UseVisualStyleBackColor = true;
            // 
            // rbPaid
            // 
            this.rbPaid.AutoSize = true;
            this.rbPaid.Enabled = false;
            this.rbPaid.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPaid.Location = new System.Drawing.Point(1129, 245);
            this.rbPaid.Name = "rbPaid";
            this.rbPaid.Size = new System.Drawing.Size(66, 38);
            this.rbPaid.TabIndex = 136;
            this.rbPaid.TabStop = true;
            this.rbPaid.Text = "Yes";
            this.rbPaid.UseVisualStyleBackColor = true;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarMonthBackground = System.Drawing.SystemColors.ActiveBorder;
            this.dtpStartDate.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpStartDate.CalendarTrailingForeColor = System.Drawing.SystemColors.Highlight;
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(690, 101);
            this.dtpStartDate.MaxDate = new System.DateTime(2025, 7, 23, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(2023, 7, 23, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(203, 35);
            this.dtpStartDate.TabIndex = 132;
            this.dtpStartDate.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(579, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 28);
            this.label2.TabIndex = 131;
            this.label2.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 28);
            this.label4.TabIndex = 130;
            this.label4.Text = "Members";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 28);
            this.label1.TabIndex = 129;
            this.label1.Text = "Subscription Period ID ";
            // 
            // tbSubscriptionPeriodID
            // 
            this.tbSubscriptionPeriodID.BackColor = System.Drawing.SystemColors.Window;
            this.tbSubscriptionPeriodID.Enabled = false;
            this.tbSubscriptionPeriodID.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubscriptionPeriodID.Location = new System.Drawing.Point(291, 101);
            this.tbSubscriptionPeriodID.Name = "tbSubscriptionPeriodID";
            this.tbSubscriptionPeriodID.Size = new System.Drawing.Size(203, 35);
            this.tbSubscriptionPeriodID.TabIndex = 128;
            this.tbSubscriptionPeriodID.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1034, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 28);
            this.label3.TabIndex = 135;
            this.label3.Text = "Fees";
            // 
            // nUDFees
            // 
            this.nUDFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nUDFees.Enabled = false;
            this.nUDFees.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUDFees.Location = new System.Drawing.Point(1119, 96);
            this.nUDFees.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nUDFees.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nUDFees.Name = "nUDFees";
            this.nUDFees.Size = new System.Drawing.Size(176, 40);
            this.nUDFees.TabIndex = 134;
            this.nUDFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUDFees.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lbMembers
            // 
            this.lbMembers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbMembers.Enabled = false;
            this.lbMembers.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.2F);
            this.lbMembers.FormattingEnabled = true;
            this.lbMembers.HorizontalScrollbar = true;
            this.lbMembers.ItemHeight = 27;
            this.lbMembers.Location = new System.Drawing.Point(291, 195);
            this.lbMembers.Name = "lbMembers";
            this.lbMembers.ScrollAlwaysVisible = true;
            this.lbMembers.Size = new System.Drawing.Size(203, 216);
            this.lbMembers.TabIndex = 133;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmFindSubscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1383, 507);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbNotPaid);
            this.Controls.Add(this.rbPaid);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSubscriptionPeriodID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nUDFees);
            this.Controls.Add(this.lbMembers);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.tbSearchValue);
            this.Controls.Add(this.lbl);
            this.Name = "frmFindSubscription";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmFindSubscription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.TextBox tbSearchValue;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbNotPaid;
        private System.Windows.Forms.RadioButton rbPaid;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSubscriptionPeriodID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nUDFees;
        private System.Windows.Forms.ListBox lbMembers;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}