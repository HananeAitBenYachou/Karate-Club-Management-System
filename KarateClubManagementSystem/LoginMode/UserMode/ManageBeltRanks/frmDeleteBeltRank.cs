using KarateClubBusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace KarateClub.ManageBeltRanks
{
    public partial class frmDeleteBeltRank : Form
    {
        private int _BeltRankID;

        public frmDeleteBeltRank()
        {
            InitializeComponent();
        }

        private void _Refresh()
        {
            tbSearchValue.ResetText();
            errorProvider1.Clear();
        }

        private void _DeleteBeltRank()
        {
            if (!clsBeltRank.IsBeltRankExist(_BeltRankID))
            {
                MessageBox.Show($"No BeltRank with BeltRankID : [{_BeltRankID}] is found !", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (clsBeltRank.DeleteBeltRank(_BeltRankID))
                {
                    MessageBox.Show($"BeltRank with BeltRankID : [{_BeltRankID}] is deleted successfully !", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                    MessageBox.Show($"Failed to delete BeltRank with BeltRankID : [{_BeltRankID}]", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _Refresh();
        }

        private void tbSearchValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchValue.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbSearchValue, "Please enter BeltRankID to delete !");
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
                _BeltRankID = Convert.ToInt32(tbSearchValue.Text.ToString());

                if (!clsInstructor.IsInstructorExist(_BeltRankID))
                {
                    MessageBox.Show($"No Instructor with InstructorID : [{_BeltRankID}] is found !");
                }

                else
                {
                    MessageBox.Show($"Instructor with InstructorID : [{_BeltRankID}] is found !");
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
                _DeleteBeltRank();
        }
    }
}
