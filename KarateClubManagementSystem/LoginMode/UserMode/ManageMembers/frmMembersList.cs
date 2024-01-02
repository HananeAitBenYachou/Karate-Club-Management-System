using KarateClub.ManageMembers;
using KarateClubBusinessLayer;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KarateClub
{
    public partial class frmMembersList : Form
    {
        private enum enSearchByOptions { eMemberID, eName, eGender, eEmail, ePhone };

        private enSearchByOptions _SearchByOption;

        private string _SearchFilter;

        public frmMembersList()
        {
            InitializeComponent();
        }

        private enSearchByOptions _GetSearchByOption()
        {
            switch (cbSearchByOptions.SelectedItem)
            {
                case "MemberID":
                    return enSearchByOptions.eMemberID;
                case "Name":
                    return enSearchByOptions.eName;
                case "Gender":
                    return enSearchByOptions.eGender;
                case "Email":
                    return enSearchByOptions.eEmail;
                case "Phone":
                    return enSearchByOptions.ePhone;
            }
            return enSearchByOptions.eMemberID;

        }

        private void dgvMembersList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                e.Graphics.FillRectangle(Brushes.DarkOrange, e.CellBounds);
                e.PaintContent(e.CellBounds);
                e.Handled = true;
            }
        }

        private void frmMembersList_Load(object sender, EventArgs e)
        {
            cbSearchByOptions.SelectedItem = "MemberID";
            _Refresh();
        }

        private void _RefreshMembersList()
        {
            dgvMembersList.DataSource = clsMember.ListMembers();
            dgvMembersList.ClearSelection();
        }

        private void _Refresh()
        {
            tbSearchValue.ResetText();
            _RefreshMembersList();
        }

        private void _SearchMember()
        {
            DataView dataView = clsMember.ListMembers().DefaultView;

            switch (_SearchByOption)
            {
                case enSearchByOptions.eMemberID:

                    if (!int.TryParse(_SearchFilter, out int _))
                    {
                        MessageBox.Show("Please Enter Numbers Only ! ", "Invalid Input ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _Refresh();
                        return;
                    }

                    dataView.RowFilter = "MemberID = " + _SearchFilter;
                    break;
                case enSearchByOptions.eName:
                    dataView.RowFilter = "Name LIKE '%" + _SearchFilter + "%'";
                    break;
                case enSearchByOptions.eGender:
                    dataView.RowFilter = "Gender LIKE '%" + _SearchFilter + "%'";
                    break;
                case enSearchByOptions.ePhone:
                    dataView.RowFilter = "Phone LIKE '%" + _SearchFilter + "%'";
                    break;
                case enSearchByOptions.eEmail:
                    dataView.RowFilter = "Email LIKE '%" + _SearchFilter + "%'";
                    break;
            }

            dgvMembersList.DataSource = dataView;
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
            _SearchMember();

        }

        private void cbSearchByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SearchByOption = _GetSearchByOption();
        }

        private void _DeleteMember(int MemberID)
        {
            if (!clsMember.IsMemberExist(MemberID))
            {
                MessageBox.Show($"No Member with MemberID : [{MemberID}] is found !", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (clsMember.DeleteMember(MemberID))
                {
                    MessageBox.Show($"Member with MemberID : [{MemberID}] is deleted successfully !", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                    MessageBox.Show($"Failed to delete Member with MemberID : [{MemberID}]", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void editInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvMembersList.SelectedRows.Count > 0)
            {
                int MemberID = Convert.ToInt32(dgvMembersList.SelectedRows[0].Cells[0].Value);

                Form myForm = new frmUpdateMember(MemberID);

                myForm.ShowDialog();

                _Refresh();
            }
        }

        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvMembersList.SelectedRows.Count > 0)
            {
                int MemberID = Convert.ToInt32(dgvMembersList.SelectedRows[0].Cells[0].Value);

                if (MessageBox.Show($"Are you sure to delete Member with MemberID : [{MemberID}]",
                    "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    _DeleteMember(MemberID);
                    _Refresh();
                }
            }
        }

        private void dgvMembersList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMembersList.SelectedRows.Count > 0)
            {
                int MemberID = Convert.ToInt32(dgvMembersList.SelectedRows[0].Cells[0].Value);

                Form myForm = new frmFindMember(MemberID);

                myForm.ShowDialog();
            }
        }

        private void displayDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvMembersList.SelectedRows.Count > 0)
            {
                int MemberID = Convert.ToInt32(dgvMembersList.SelectedRows[0].Cells[0].Value);

                Form myForm = new frmFindMember(MemberID);

                myForm.ShowDialog();
            }
        }

        private void dgvMembersList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvMembersList.Columns)
            {
                column.Width = 150;
            }
        }
    }
}
