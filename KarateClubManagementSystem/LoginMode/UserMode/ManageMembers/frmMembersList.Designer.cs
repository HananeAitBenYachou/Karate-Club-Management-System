namespace KarateClub
{
    partial class frmMembersList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMembersList));
            this.dgvMembersList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSearchByOptions = new System.Windows.Forms.ComboBox();
            this.tbSearchValue = new System.Windows.Forms.TextBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembersList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMembersList
            // 
            this.dgvMembersList.AllowUserToAddRows = false;
            this.dgvMembersList.AllowUserToDeleteRows = false;
            this.dgvMembersList.AllowUserToOrderColumns = true;
            this.dgvMembersList.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgvMembersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMembersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMembersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembersList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvMembersList.Location = new System.Drawing.Point(82, 213);
            this.dgvMembersList.MultiSelect = false;
            this.dgvMembersList.Name = "dgvMembersList";
            this.dgvMembersList.ReadOnly = true;
            this.dgvMembersList.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMembersList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMembersList.RowTemplate.Height = 24;
            this.dgvMembersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembersList.Size = new System.Drawing.Size(1229, 270);
            this.dgvMembersList.TabIndex = 0;
            this.dgvMembersList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembersList_CellClick);
            this.dgvMembersList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvMembersList_CellPainting);
            this.dgvMembersList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvMembersList_DataBindingComplete);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editInfoToolStripMenuItem,
            this.deleteRecordToolStripMenuItem,
            this.displayDetailsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowItemToolTips = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 82);
            // 
            // editInfoToolStripMenuItem
            // 
            this.editInfoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.editInfoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editInfoToolStripMenuItem.Image = global::KarateClub.Properties.Resources.pencil;
            this.editInfoToolStripMenuItem.Name = "editInfoToolStripMenuItem";
            this.editInfoToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.editInfoToolStripMenuItem.Text = "Edit Record";
            this.editInfoToolStripMenuItem.Click += new System.EventHandler(this.editInfoToolStripMenuItem_Click);
            // 
            // deleteRecordToolStripMenuItem
            // 
            this.deleteRecordToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.deleteRecordToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteRecordToolStripMenuItem.Image = global::KarateClub.Properties.Resources.trash_bin;
            this.deleteRecordToolStripMenuItem.Name = "deleteRecordToolStripMenuItem";
            this.deleteRecordToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.deleteRecordToolStripMenuItem.Text = "Delete Record";
            this.deleteRecordToolStripMenuItem.Click += new System.EventHandler(this.deleteRecordToolStripMenuItem_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F);
            this.label1.Location = new System.Drawing.Point(493, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search By :";
            // 
            // cbSearchByOptions
            // 
            this.cbSearchByOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cbSearchByOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchByOptions.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearchByOptions.ForeColor = System.Drawing.Color.Black;
            this.cbSearchByOptions.FormattingEnabled = true;
            this.cbSearchByOptions.Items.AddRange(new object[] {
            "MemberID",
            "Name",
            "Gender",
            "Email",
            "Phone"});
            this.cbSearchByOptions.Location = new System.Drawing.Point(607, 51);
            this.cbSearchByOptions.Name = "cbSearchByOptions";
            this.cbSearchByOptions.Size = new System.Drawing.Size(224, 32);
            this.cbSearchByOptions.TabIndex = 2;
            this.cbSearchByOptions.SelectedIndexChanged += new System.EventHandler(this.cbSearchByOptions_SelectedIndexChanged);
            // 
            // tbSearchValue
            // 
            this.tbSearchValue.BackColor = System.Drawing.Color.Bisque;
            this.tbSearchValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearchValue.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchValue.Location = new System.Drawing.Point(506, 116);
            this.tbSearchValue.Multiline = true;
            this.tbSearchValue.Name = "tbSearchValue";
            this.tbSearchValue.Size = new System.Drawing.Size(319, 42);
            this.tbSearchValue.TabIndex = 3;
            this.tbSearchValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSearchValue.TextChanged += new System.EventHandler(this.tbSearchValue_TextChanged);
            // 
            // pbSearch
            // 
            this.pbSearch.BackColor = System.Drawing.Color.Bisque;
            this.pbSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbSearch.BackgroundImage")));
            this.pbSearch.Image = global::KarateClub.Properties.Resources.search;
            this.pbSearch.Location = new System.Drawing.Point(777, 121);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(39, 32);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 4;
            this.pbSearch.TabStop = false;
            // 
            // frmMembersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1383, 507);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.tbSearchValue);
            this.Controls.Add(this.cbSearchByOptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMembersList);
            this.Name = "frmMembersList";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmMembersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembersList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMembersList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSearchByOptions;
        private System.Windows.Forms.TextBox tbSearchValue;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayDetailsToolStripMenuItem;
    }
}