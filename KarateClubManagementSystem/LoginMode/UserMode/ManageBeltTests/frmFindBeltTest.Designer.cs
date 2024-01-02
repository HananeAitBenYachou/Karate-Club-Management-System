namespace KarateClub.ManageBeltTests
{
    partial class frmFindBeltTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindBeltTest));
            this.tbSearchValue = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.lbBeltRanks = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbInstructors = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbFailed = new System.Windows.Forms.RadioButton();
            this.rbPassed = new System.Windows.Forms.RadioButton();
            this.lbMembers = new System.Windows.Forms.ListBox();
            this.dtpTestDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTestID = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearchValue
            // 
            this.tbSearchValue.BackColor = System.Drawing.Color.Bisque;
            this.tbSearchValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearchValue.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchValue.Location = new System.Drawing.Point(544, 18);
            this.tbSearchValue.Multiline = true;
            this.tbSearchValue.Name = "tbSearchValue";
            this.tbSearchValue.Size = new System.Drawing.Size(319, 42);
            this.tbSearchValue.TabIndex = 120;
            this.tbSearchValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSearchValue.Validating += new System.ComponentModel.CancelEventHandler(this.tbSearchValue_Validating);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(432, 28);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(96, 28);
            this.lbl.TabIndex = 122;
            this.lbl.Text = "Belt Test ID";
            // 
            // pbSearch
            // 
            this.pbSearch.BackColor = System.Drawing.Color.Bisque;
            this.pbSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbSearch.BackgroundImage")));
            this.pbSearch.Image = global::KarateClub.Properties.Resources.search;
            this.pbSearch.Location = new System.Drawing.Point(815, 25);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(39, 32);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 121;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // lbBeltRanks
            // 
            this.lbBeltRanks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbBeltRanks.Enabled = false;
            this.lbBeltRanks.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.2F);
            this.lbBeltRanks.FormattingEnabled = true;
            this.lbBeltRanks.HorizontalScrollbar = true;
            this.lbBeltRanks.ItemHeight = 27;
            this.lbBeltRanks.Location = new System.Drawing.Point(1071, 213);
            this.lbBeltRanks.Name = "lbBeltRanks";
            this.lbBeltRanks.ScrollAlwaysVisible = true;
            this.lbBeltRanks.Size = new System.Drawing.Size(203, 216);
            this.lbBeltRanks.TabIndex = 159;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(954, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 28);
            this.label3.TabIndex = 158;
            this.label3.Text = "BeltRanks";
            // 
            // lbInstructors
            // 
            this.lbInstructors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbInstructors.Enabled = false;
            this.lbInstructors.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.2F);
            this.lbInstructors.FormattingEnabled = true;
            this.lbInstructors.HorizontalScrollbar = true;
            this.lbInstructors.ItemHeight = 27;
            this.lbInstructors.Location = new System.Drawing.Point(641, 213);
            this.lbInstructors.Name = "lbInstructors";
            this.lbInstructors.ScrollAlwaysVisible = true;
            this.lbInstructors.Size = new System.Drawing.Size(203, 216);
            this.lbInstructors.TabIndex = 157;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(528, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 28);
            this.label6.TabIndex = 156;
            this.label6.Text = "Instructors";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(969, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 28);
            this.label5.TabIndex = 155;
            this.label5.Text = "Result";
            // 
            // rbFailed
            // 
            this.rbFailed.AutoSize = true;
            this.rbFailed.Enabled = false;
            this.rbFailed.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFailed.Location = new System.Drawing.Point(1183, 132);
            this.rbFailed.Name = "rbFailed";
            this.rbFailed.Size = new System.Drawing.Size(91, 38);
            this.rbFailed.TabIndex = 154;
            this.rbFailed.TabStop = true;
            this.rbFailed.Text = "Failed";
            this.rbFailed.UseVisualStyleBackColor = true;
            // 
            // rbPassed
            // 
            this.rbPassed.AutoSize = true;
            this.rbPassed.Enabled = false;
            this.rbPassed.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPassed.Location = new System.Drawing.Point(1076, 132);
            this.rbPassed.Name = "rbPassed";
            this.rbPassed.Size = new System.Drawing.Size(100, 38);
            this.rbPassed.TabIndex = 153;
            this.rbPassed.TabStop = true;
            this.rbPassed.Text = "Passed";
            this.rbPassed.UseVisualStyleBackColor = true;
            // 
            // lbMembers
            // 
            this.lbMembers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbMembers.Enabled = false;
            this.lbMembers.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.2F);
            this.lbMembers.FormattingEnabled = true;
            this.lbMembers.HorizontalScrollbar = true;
            this.lbMembers.ItemHeight = 27;
            this.lbMembers.Location = new System.Drawing.Point(235, 213);
            this.lbMembers.Name = "lbMembers";
            this.lbMembers.ScrollAlwaysVisible = true;
            this.lbMembers.Size = new System.Drawing.Size(203, 216);
            this.lbMembers.TabIndex = 152;
            // 
            // dtpTestDate
            // 
            this.dtpTestDate.CalendarMonthBackground = System.Drawing.SystemColors.ActiveBorder;
            this.dtpTestDate.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpTestDate.CalendarTrailingForeColor = System.Drawing.SystemColors.Highlight;
            this.dtpTestDate.Enabled = false;
            this.dtpTestDate.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTestDate.Location = new System.Drawing.Point(651, 135);
            this.dtpTestDate.MaxDate = new System.DateTime(2025, 7, 23, 0, 0, 0, 0);
            this.dtpTestDate.Name = "dtpTestDate";
            this.dtpTestDate.Size = new System.Drawing.Size(203, 35);
            this.dtpTestDate.TabIndex = 149;
            this.dtpTestDate.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(532, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 28);
            this.label2.TabIndex = 148;
            this.label2.Text = "Test Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 28);
            this.label4.TabIndex = 147;
            this.label4.Text = "Members";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 28);
            this.label1.TabIndex = 146;
            this.label1.Text = "Belt Test ID ";
            // 
            // tbTestID
            // 
            this.tbTestID.BackColor = System.Drawing.SystemColors.Window;
            this.tbTestID.Enabled = false;
            this.tbTestID.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTestID.Location = new System.Drawing.Point(235, 135);
            this.tbTestID.Name = "tbTestID";
            this.tbTestID.Size = new System.Drawing.Size(203, 35);
            this.tbTestID.TabIndex = 145;
            this.tbTestID.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmFindBeltTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1383, 507);
            this.Controls.Add(this.lbBeltRanks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbInstructors);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbFailed);
            this.Controls.Add(this.rbPassed);
            this.Controls.Add(this.lbMembers);
            this.Controls.Add(this.dtpTestDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTestID);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.tbSearchValue);
            this.Controls.Add(this.lbl);
            this.Name = "frmFindBeltTest";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmFindBeltTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.TextBox tbSearchValue;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ListBox lbBeltRanks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbInstructors;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbFailed;
        private System.Windows.Forms.RadioButton rbPassed;
        private System.Windows.Forms.ListBox lbMembers;
        private System.Windows.Forms.DateTimePicker dtpTestDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTestID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}