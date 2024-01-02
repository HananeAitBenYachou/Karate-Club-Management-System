using KarateClubBusinessLayer;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KarateClub.ManageUsers
{
    public partial class frmUsersList : Form
    {
        private enum enSearchByOptions { eUserID, eUserName, eGender, eEmail, ePhone };

        private enSearchByOptions _SearchByOption;

        private string _SearchFilter;

        public frmUsersList()
        {
            InitializeComponent();
        }

        private enSearchByOptions _GetSearchByOption()
        {
            switch (cbSearchByOptions.SelectedItem)
            {
                case "UserID":
                    return enSearchByOptions.eUserID;
                case "UserName":
                    return enSearchByOptions.eUserName;
                case "Gender":
                    return enSearchByOptions.eGender;
                case "Email":
                    return enSearchByOptions.eEmail;
                case "Phone":
                    return enSearchByOptions.ePhone;
            }
            return enSearchByOptions.eUserID;

        }

        private void dgvUsersList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                e.Graphics.FillRectangle(Brushes.DarkOrange, e.CellBounds);
                e.PaintContent(e.CellBounds);
                e.Handled = true;
            }
        }

        private void frmUsersList_Load(object sender, EventArgs e)
        {
            cbSearchByOptions.SelectedItem = "UserID";
            _Refresh();
        }

        private void _RefreshUsersList()
        {
            dgvUsersList.DataSource = clsUser.ListUsers();
            dgvUsersList.ClearSelection();
        }

        private void _Refresh()
        {
            tbSearchValue.ResetText();
            _RefreshUsersList();
        }

        private void _SearchUser()
        {
            DataView dataView = clsUser.ListUsers().DefaultView;

            switch (_SearchByOption)
            {
                case enSearchByOptions.eUserID:

                    if (!int.TryParse(_SearchFilter, out int _))
                    {
                        MessageBox.Show("Please Enter Numbers Only ! ", "Invalid Input ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _Refresh();
                        return;
                    }

                    dataView.RowFilter = "UserID = " + _SearchFilter;
                    break;
                case enSearchByOptions.eUserName:
                    dataView.RowFilter = "UserName LIKE '%" + _SearchFilter + "%'";
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

            dgvUsersList.DataSource = dataView;
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
            _SearchUser();

        }

        private void cbSearchByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SearchByOption = _GetSearchByOption();
        }

        private void _DeleteUser(int UserID)
        {
            if (!clsUser.IsUserExist(UserID))
            {
                MessageBox.Show($"No User with UserID : [{UserID}] is found !", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (clsUser.DeleteUser(UserID))
                {
                    MessageBox.Show($"User with UserID : [{UserID}] is deleted successfully !", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                    MessageBox.Show($"Failed to delete User with UserID : [{UserID}]", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void editInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUsersList.SelectedRows.Count > 0)
            {
                int UserID = Convert.ToInt32(dgvUsersList.SelectedRows[0].Cells[0].Value);

                Form myForm = new frmUpdateUser(UserID);

                myForm.ShowDialog();

                _Refresh();
            }
        }

        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUsersList.SelectedRows.Count > 0)
            {
                int UserID = Convert.ToInt32(dgvUsersList.SelectedRows[0].Cells[0].Value);

                if (MessageBox.Show($"Are you sure to delete User with UserID : [{UserID}]",
                    "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    _DeleteUser(UserID);
                    _Refresh();
                }
            }
        }

        private void dgvUsersList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsersList.SelectedRows.Count > 0)
            {
                int UserID = Convert.ToInt32(dgvUsersList.SelectedRows[0].Cells[0].Value);

                Form myForm = new frmFindUser(UserID);

                myForm.ShowDialog();
            }
        }

        private void displayDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUsersList.SelectedRows.Count > 0)
            {
                int UserID = Convert.ToInt32(dgvUsersList.SelectedRows[0].Cells[0].Value);

                Form myForm = new frmFindUser(UserID);

                myForm.ShowDialog();
            }
        }

        private void dgvUsersList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvUsersList.Columns)
            {
                column.Width = 150;
            }
        }

    }
}
