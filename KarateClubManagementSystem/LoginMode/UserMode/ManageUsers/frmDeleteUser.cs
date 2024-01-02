using KarateClubBusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace KarateClub.ManageUsers
{
    public partial class frmDeleteUser : Form
    {
        public frmDeleteUser()
        {
            InitializeComponent();
        }

        private int _UserID;

        private void _Refresh()
        {
            tbSearchValue.ResetText();
            errorProvider1.Clear();
        }

        private void _DeleteUser()
        {
            if (!clsUser.IsUserExist(_UserID))
            {
                MessageBox.Show($"No User with UserID : [{_UserID}] is found !", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (clsUser.DeleteUser(_UserID))
                {
                    MessageBox.Show($"User with UserID : [{_UserID}] is deleted successfully !", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                    MessageBox.Show($"Failed to delete User with UserID : [{_UserID}]", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _Refresh();
        }

        private void tbSearchValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchValue.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbSearchValue, "Please enter UserID to delete !");
                tbSearchValue.Focus();
            }

            else if (!int.TryParse(tbSearchValue.Text.ToString(), out int _))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbSearchValue, "Please enter Numbers only !");
                tbSearchValue.Focus();
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbSearchValue, "");
            }
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                _UserID = Convert.ToInt32(tbSearchValue.Text.ToString());

                if (!clsUser.IsUserExist(_UserID))
                {
                    MessageBox.Show($"No User with UserID : [{_UserID}] is found !");
                }

                else
                {
                    MessageBox.Show($"User with UserID : [{_UserID}] is found !");
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                _DeleteUser();
            }
        }
    }
}
