namespace KarateClub.LoginMode.MemberMode
{
    partial class frmMemberInstructors
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMemberInstructors));
            this.dgvMemberInstructorsList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.displayDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.tbSearchValue = new System.Windows.Forms.TextBox();
            this.cbSearchByOptions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberInstructorsList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMemberInstructorsList
            // 
            this.dgvMemberInstructorsList.AllowUserToAddRows = false;
            this.dgvMemberInstructorsList.AllowUserToDeleteRows = false;
            this.dgvMemberInstructorsList.AllowUserToOrderColumns = true;
            this.dgvMemberInstructorsList.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgvMemberInstructorsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMemberInstructorsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMemberInstructorsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberInstructorsList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvMemberInstructorsList.Location = new System.Drawing.Point(222, 197);
            this.dgvMemberInstructorsList.MultiSelect = false;
            this.dgvMemberInstructorsList.Name = "dgvMemberInstructorsList";
            this.dgvMemberInstructorsList.ReadOnly = true;
            this.dgvMemberInstructorsList.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMemberInstructorsList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMemberInstructorsList.RowTemplate.Height = 24;
            this.dgvMemberInstructorsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberInstructorsList.Size = new System.Drawing.Size(938, 270);
            this.dgvMemberInstructorsList.TabIndex = 10;
            this.dgvMemberInstructorsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberInstructorsList_CellClick);
            this.dgvMemberInstructorsList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvMemberInstructorsList_CellPainting);
            this.dgvMemberInstructorsList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvMemberInstructorsList_DataBindingComplete);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayDetailsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowItemToolTips = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 30);
            // 
            // displayDetailsToolStripMenuItem
            // 
            this.displayDetailsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.displayDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.displayDetailsToolStripMenuItem.Image = global::KarateClub.Properties.Resources.woman;
            this.displayDetailsToolStripMenuItem.Name = "displayDetailsToolStripMenuItem";
            this.displayDetailsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.displayDetailsToolStripMenuItem.Text = "Display Details";
            this.displayDetailsToolStripMenuItem.Click += new System.EventHandler(this.displayDetailsToolStripMenuItem_Click);
            // 
            // pbSearch
            // 
            this.pbSearch.BackColor = System.Drawing.Color.Bisque;
            this.pbSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbSearch.BackgroundImage")));
            this.pbSearch.Image = global::KarateClub.Properties.Resources.search;
            this.pbSearch.Location = new System.Drawing.Point(791, 110);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(39, 32);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 14;
            this.pbSearch.TabStop = false;
            // 
            // tbSearchValue
            // 
            this.tbSearchValue.BackColor = System.Drawing.Color.Bisque;
            this.tbSearchValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearchValue.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchValue.Location = new System.Drawing.Point(520, 105);
            this.tbSearchValue.Multiline = true;
            this.tbSearchValue.Name = "tbSearchValue";
            this.tbSearchValue.Size = new System.Drawing.Size(319, 42);
            this.tbSearchValue.TabIndex = 13;
            this.tbSearchValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSearchValue.TextChanged += new System.EventHandler(this.tbSearchValue_TextChanged);
            // 
            // cbSearchByOptions
            // 
            this.cbSearchByOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cbSearchByOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchByOptions.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearchByOptions.ForeColor = System.Drawing.Color.Black;
            this.cbSearchByOptions.FormattingEnabled = true;
            this.cbSearchByOptions.Items.AddRange(new object[] {
            "MemberInstructorID",
            "InstructorName"});
            this.cbSearchByOptions.Location = new System.Drawing.Point(621, 40);
            this.cbSearchByOptions.Name = "cbSearchByOptions";
            this.cbSearchByOptions.Size = new System.Drawing.Size(224, 32);
            this.cbSearchByOptions.TabIndex = 12;
            this.cbSearchByOptions.SelectedIndexChanged += new System.EventHandler(this.cbSearchByOptions_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F);
            this.label1.Location = new System.Drawing.Point(507, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search By :";
            // 
            // frmMemberInstructors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1383, 507);
            this.Controls.Add(this.dgvMemberInstructorsList);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.tbSearchValue);
            this.Controls.Add(this.cbSearchByOptions);
            this.Controls.Add(this.label1);
            this.Name = "frmMemberInstructors";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmMemberInstructorsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberInstructorsList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMemberInstructorsList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem displayDetailsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.TextBox tbSearchValue;
        private System.Windows.Forms.ComboBox cbSearchByOptions;
        private System.Windows.Forms.Label label1;
    }
}