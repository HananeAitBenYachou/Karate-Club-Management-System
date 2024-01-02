using KarateClubBusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace KarateClub
{
    public partial class frmDeleteMember : Form
    {

        private int _MemberID;

        public frmDeleteMember()
        {
            InitializeComponent();
        }

        private void _Refresh()
        {
            tbSearchValue.ResetText();
            errorProvider1.Clear();
        }

        private void _DeleteMember()
        {
            if (!clsMember.IsMemberExist(_MemberID))
            {
                MessageBox.Show($"No Member with MemberID : [{_MemberID}] is found !", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (clsMember.DeleteMember(_MemberID))
                {
                    MessageBox.Show($"Member with MemberID : [{_MemberID}] is deleted successfully !", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                    MessageBox.Show($"Failed to delete Member with MemberID : [{_MemberID}]", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _Refresh();
        }

        private void tbSearchValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchValue.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbSearchValue, "Please enter MemberID to delete !");
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
                _MemberID = Convert.ToInt32(tbSearchValue.Text.ToString());

                if (!clsMember.IsMemberExist(_MemberID))
                {
                    MessageBox.Show($"No Member with MemberID : [{_MemberID}] is found !");
                }

                else
                {
                    MessageBox.Show($"Member with MemberID : [{_MemberID}] is found !");
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
                _DeleteMember();
        }
    }
}
