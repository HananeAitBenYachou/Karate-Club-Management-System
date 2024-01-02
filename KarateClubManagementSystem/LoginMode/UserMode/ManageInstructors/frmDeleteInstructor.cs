using KarateClubBusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace KarateClub.ManageInstructors
{
    public partial class frmDeleteInstructor : Form
    {
        private int _InstructorID;
        public frmDeleteInstructor()
        {
            InitializeComponent();
        }

        private void _Refresh()
        {
            tbSearchValue.ResetText();
            errorProvider1.Clear();
        }

        private void _DeleteInstructor()
        {
            if (!clsInstructor.IsInstructorExist(_InstructorID))
            {
                MessageBox.Show($"No Instructor with InstructorID : [{_InstructorID}] is found !", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (clsInstructor.DeleteInstructor(_InstructorID))
                {
                    MessageBox.Show($"Instructor with InstructorID : [{_InstructorID}] is deleted successfully !", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                    MessageBox.Show($"Failed to delete Instructor with InstructorID : [{_InstructorID}]", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _Refresh();
        }

        private void tbSearchValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchValue.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbSearchValue, "Please enter InstructorID to delete !");
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
                _InstructorID = Convert.ToInt32(tbSearchValue.Text.ToString());

                if (!clsInstructor.IsInstructorExist(_InstructorID))
                {
                    MessageBox.Show($"No Instructor with InstructorID : [{_InstructorID}] is found !");
                }

                else
                {
                    MessageBox.Show($"Instructor with InstructorID : [{_InstructorID}] is found !");
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
                _DeleteInstructor();
        }
    }
}
