using KarateClubBusinessLayer;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KarateClub.ManageBeltRanks
{
    public partial class frmBeltRanksList : Form
    {
        public frmBeltRanksList()
        {
            InitializeComponent();
        }

        private enum enSearchByOptions { eRankID, eRankName, eTestFees };

        private enSearchByOptions _SearchByOption;

        private string _SearchFilter;

        private enSearchByOptions _GetSearchByOption()
        {
            switch (cbSearchByOptions.SelectedItem)
            {
                case "RankID":
                    return enSearchByOptions.eRankID;
                case "RankName":
                    return enSearchByOptions.eRankName;
                case "TestFees":
                    return enSearchByOptions.eTestFees;
            }
            return enSearchByOptions.eRankID;

        }

        private void dgvBeltRanksList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                e.Graphics.FillRectangle(Brushes.DarkOrange, e.CellBounds);
                e.PaintContent(e.CellBounds);
                e.Handled = true;
            }
        }

        private void frmBeltRanksList_Load(object sender, EventArgs e)
        {
            cbSearchByOptions.SelectedItem = "RankID";
            _Refresh();
        }

        private void _RefreshBeltRanksList()
        {
            dgvBeltRanksList.DataSource = clsBeltRank.ListBeltRanks();
            dgvBeltRanksList.ClearSelection();
        }

        private void _Refresh()
        {
            tbSearchValue.ResetText();
            _RefreshBeltRanksList();
        }

        private void _SearchBeltRank()
        {
            DataView dataView = clsBeltRank.ListBeltRanks().DefaultView;

            switch (_SearchByOption)
            {
                case enSearchByOptions.eRankID:

                    if (!int.TryParse(_SearchFilter, out int _))
                    {
                        MessageBox.Show("Please Enter Numbers Only ! ", "Invalid Input ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _Refresh();
                        return;
                    }
                    dataView.RowFilter = "RankID = " + _SearchFilter;
                    break;

                case enSearchByOptions.eRankName:
                    dataView.RowFilter = "RankName LIKE '%" + _SearchFilter + "%'";
                    break;

                case enSearchByOptions.eTestFees:
                    if (!int.TryParse(_SearchFilter, out int _))
                    {
                        MessageBox.Show("Please Enter Numbers Only ! ", "Invalid Input ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _Refresh();
                        return;
                    }
                    dataView.RowFilter = "TestFees  = " + _SearchFilter;
                    break;
            }

            dgvBeltRanksList.DataSource = dataView;
        }

        private void tbSearchValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchValue.Text.ToString()))
            {
                _Refresh();
                return;
            }

            else
                _SearchFilter = tbSearchValue.Text.ToString();
            _SearchBeltRank();

        }

        private void cbSearchByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SearchByOption = _GetSearchByOption();
        }

        private void _DeleteBeltRank(int BeltRank)
        {
            if (!clsBeltRank.IsBeltRankExist(BeltRank))
            {
                MessageBox.Show($"No BeltRank with BeltRankID : [{BeltRank}] is found !", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (clsBeltRank.DeleteBeltRank(BeltRank))
                {
                    MessageBox.Show($"BeltRank with BeltRankID : [{BeltRank}] is deleted successfully !", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                    MessageBox.Show($"Failed to delete BeltRank with BeltRankID : [{BeltRank}]", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void editInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvBeltRanksList.SelectedRows.Count > 0)
            {
                int BeltRankID = Convert.ToInt32(dgvBeltRanksList.SelectedRows[0].Cells[0].Value);

                Form myForm = new frmUpdateBeltRank(BeltRankID);

                myForm.ShowDialog();

                _Refresh();
            }
        }

        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvBeltRanksList.SelectedRows.Count > 0)
            {
                int BeltRankID = Convert.ToInt32(dgvBeltRanksList.SelectedRows[0].Cells[0].Value);

                if (MessageBox.Show($"Are you sure to delete BeltRank with BeltRankID : [{BeltRankID}]",
                    "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    _DeleteBeltRank(BeltRankID);
                    _Refresh();
                }
            }
        }

        private void dgvBeltRanksList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBeltRanksList.SelectedRows.Count > 0)
            {
                int BeltRankID = Convert.ToInt32(dgvBeltRanksList.SelectedRows[0].Cells[0].Value);

                Form myForm = new frmFindBeltRank(BeltRankID);

                myForm.ShowDialog();
            }
        }

        private void displayDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvBeltRanksList.SelectedRows.Count > 0)
            {
                int BeltRankID = Convert.ToInt32(dgvBeltRanksList.SelectedRows[0].Cells[0].Value);

                Form myForm = new frmFindBeltRank(BeltRankID);

                myForm.ShowDialog();
            }
        }

        private void dgvBeltRanksList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvBeltRanksList.Columns)
            {
                column.Width = 300;
            }
        }
    }
}
