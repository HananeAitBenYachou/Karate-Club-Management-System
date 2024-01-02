using KarateClub.ManageBeltTests;
using KarateClubBusinessLayer;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KarateClub.LoginMode.MemberMode
{
    public partial class frmMemberBeltTests : Form
    {
        public frmMemberBeltTests()
        {
            InitializeComponent();
        }

        private enum enSearchByOptions { eBeltTestID, eBeltRankName, eInstructorName, eResult };

        private enSearchByOptions _SearchByOption;

        private string _SearchFilter;

        private enSearchByOptions _GetSearchByOption()
        {
            switch (cbSearchByOptions.SelectedItem)
            {
                case "BeltTestID":
                    return enSearchByOptions.eBeltTestID;
                case "InstructorName":
                    return enSearchByOptions.eInstructorName;
                case "BeltRankName":
                    return enSearchByOptions.eBeltRankName;
                case "Result":
                    return enSearchByOptions.eResult;
            }
            return enSearchByOptions.eBeltTestID;

        }

        private void dgvBeltTestsList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                e.Graphics.FillRectangle(Brushes.DarkOrange, e.CellBounds);
                e.PaintContent(e.CellBounds);
                e.Handled = true;
            }
        }

        private void frmMemberBeltTestsList_Load(object sender, EventArgs e)
        {
            cbSearchByOptions.SelectedItem = "BeltTestID";
            _Refresh();
        }

        private void _RefreshBeltTestsList()
        {
            DataView dataView = clsBeltTest.ListBeltTests().DefaultView;
            dataView.RowFilter = "MemberName = '" + clsGlobalMember.CurrentMember.Name + "'";
            dgvBeltTestsList.DataSource = dataView;
            dgvBeltTestsList.ClearSelection();
        }

        private void _Refresh()
        {
            tbSearchValue.ResetText();
            _RefreshBeltTestsList();
        }

        private void _SearchBeltTest()
        {
            DataView dataView = clsBeltTest.ListBeltTests().DefaultView;

            switch (_SearchByOption)
            {
                case enSearchByOptions.eBeltTestID:

                    if (!int.TryParse(_SearchFilter, out int _))
                    {
                        MessageBox.Show("Please Enter Numbers Only ! ", "Invalid Input ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _Refresh();
                        return;
                    }
                    dataView.RowFilter = "TestID = " + _SearchFilter + "AND MemberName = '" + clsGlobalMember.CurrentMember.Name + "'";
                    break;

                case enSearchByOptions.eInstructorName:
                    dataView.RowFilter = "InstructorName LIKE '%" + _SearchFilter + "%'" + "AND MemberName = '" + clsGlobalMember.CurrentMember.Name + "'";
                    break;

                case enSearchByOptions.eBeltRankName:
                    dataView.RowFilter = "RankName LIKE '%" + _SearchFilter + "%'" + "AND MemberName = '" + clsGlobalMember.CurrentMember.Name + "'";
                    break;

                case enSearchByOptions.eResult:
                    if (!int.TryParse(_SearchFilter, out int _))
                    {
                        MessageBox.Show("Please Enter 1 for Passed , 0 for Failed", "Invalid Input ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _Refresh();
                        return;
                    }
                    dataView.RowFilter = "Result  = " + _SearchFilter + "AND MemberName = '" + clsGlobalMember.CurrentMember.Name + "'";
                    break;
            }

            dgvBeltTestsList.DataSource = dataView;
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
            _SearchBeltTest();

        }

        private void cbSearchByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SearchByOption = _GetSearchByOption();
        }

        private void dgvBeltTestsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBeltTestsList.SelectedRows.Count > 0)
            {
                int BeltTestID = Convert.ToInt32(dgvBeltTestsList.SelectedRows[0].Cells[0].Value);

                Form myForm = new frmFindBeltTest(BeltTestID);

                myForm.ShowDialog();
            }
        }

        private void displayDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvBeltTestsList.SelectedRows.Count > 0)
            {
                int BeltTestID = Convert.ToInt32(dgvBeltTestsList.SelectedRows[0].Cells[0].Value);

                Form myForm = new frmFindBeltTest(BeltTestID);

                myForm.ShowDialog();
            }
        }

        private void dgvBeltTestsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvBeltTestsList.Columns)
            {
                column.Width = 150;
            }
        }

    }
}
