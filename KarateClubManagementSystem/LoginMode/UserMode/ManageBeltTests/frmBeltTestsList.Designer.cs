namespace KarateClub.ManageBeltTests
{
    partial class frmBeltTestsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeltTestsList));
            this.dgvBeltTestsList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.tbSearchValue = new System.Windows.Forms.TextBox();
            this.cbSearchByOptions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeltTestsList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBeltTestsList
            // 
            this.dgvBeltTestsList.AllowUserToAddRows = false;
            this.dgvBeltTestsList.AllowUserToDeleteRows = false;
            this.dgvBeltTestsList.AllowUserToOrderColumns = true;
            this.dgvBeltTestsList.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgvBeltTestsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBeltTestsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBeltTestsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeltTestsList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvBeltTestsList.Location = new System.Drawing.Point(177, 197);
            this.dgvBeltTestsList.MultiSelect = false;
            this.dgvBeltTestsList.Name = "dgvBeltTestsList";
            this.dgvBeltTestsList.ReadOnly = true;
            this.dgvBeltTestsList.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBeltTestsList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBeltTestsList.RowTemplate.Height = 24;
            this.dgvBeltTestsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBeltTestsList.Size = new System.Drawing.Size(1001, 262);
            this.dgvBeltTestsList.TabIndex = 15;
            this.dgvBeltTestsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBeltTestsList_CellClick);
            this.dgvBeltTestsList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvBeltTestsList_CellPainting);
            this.dgvBeltTestsList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvBeltTestsList_DataBindingComplete);
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
            // pbSearch
            // 
            this.pbSearch.BackColor = System.Drawing.Color.Bisque;
            this.pbSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbSearch.BackgroundImage")));
            this.pbSearch.Image = global::KarateClub.Properties.Resources.search;
            this.pbSearch.Location = new System.Drawing.Point(777, 119);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(39, 32);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 19;
            this.pbSearch.TabStop = false;
            // 
            // tbSearchValue
            // 
            this.tbSearchValue.BackColor = System.Drawing.Color.Bisque;
            this.tbSearchValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearchValue.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchValue.Location = new System.Drawing.Point(506, 114);
            this.tbSearchValue.Multiline = true;
            this.tbSearchValue.Name = "tbSearchValue";
            this.tbSearchValue.Size = new System.Drawing.Size(319, 42);
            this.tbSearchValue.TabIndex = 18;
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
            "BeltTestID",
            "MemberName",
            "InstructorName",
            "BeltRankName",
            "Result"});
            this.cbSearchByOptions.Location = new System.Drawing.Point(607, 49);
            this.cbSearchByOptions.Name = "cbSearchByOptions";
            this.cbSearchByOptions.Size = new System.Drawing.Size(224, 32);
            this.cbSearchByOptions.TabIndex = 17;
            this.cbSearchByOptions.SelectedIndexChanged += new System.EventHandler(this.cbSearchByOptions_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F);
            this.label1.Location = new System.Drawing.Point(493, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "Search By :";
            // 
            // frmBeltTestsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1383, 507);
            this.Controls.Add(this.dgvBeltTestsList);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.tbSearchValue);
            this.Controls.Add(this.cbSearchByOptions);
            this.Controls.Add(this.label1);
            this.Name = "frmBeltTestsList";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmBeltTestsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeltTestsList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBeltTestsList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayDetailsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.TextBox tbSearchValue;
        private System.Windows.Forms.ComboBox cbSearchByOptions;
        private System.Windows.Forms.Label label1;
    }
}