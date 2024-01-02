using KarateClubBusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace KarateClub.ManageMemberInstructors
{
    public partial class frmDeleteMemberInstructor : Form
    {
        public frmDeleteMemberInstructor()
        {
            InitializeComponent();
        }

        private int _MemberInstructorID;

        private void _Refresh()
        {
            tbSearchValue.ResetText();
            errorProvider1.Clear();
        }

        private void _DeleteUser()
        {
            if (!clsMemberInstructor.IsMemberInstructorExist(_MemberInstructorID))
            {
                MessageBox.Show($"No MemberInstructor with MemberInstructorID : [{_MemberInstructorID}] is found !", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (clsMemberInstructor.DeleteMemberInstructor(_MemberInstructorID))
                {
                    MessageBox.Show($"MemberInstructor with MemberInstructorID : [{_MemberInstructorID}] is deleted successfully !", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                    MessageBox.Show($"Failed to delete MemberInstructor with MemberInstructorID : [{_MemberInstructorID}]", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _Refresh();
        }

        private void tbSearchValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchValue.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbSearchValue, "Please enter MemberInstructorID to delete !");
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
                _MemberInstructorID = Convert.ToInt32(tbSearchValue.Text.ToString());

                if (!clsMemberInstructor.IsMemberInstructorExist(_MemberInstructorID))
                {
                    MessageBox.Show($"No MemberInstructor with MemberInstructorID : [{_MemberInstructorID}] is found !");
                }

                else
                {
                    MessageBox.Show($"MemberInstructor with MemberInstructorID : [{_MemberInstructorID}] is found !");
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
