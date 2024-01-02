using KarateClubBusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace KarateClub.ManageBeltTests
{
    public partial class frmDeleteBeltTest : Form
    {
        public frmDeleteBeltTest()
        {
            InitializeComponent();
        }

        private int _TestID;

        private void _Refresh()
        {
            tbSearchValue.ResetText();
            errorProvider1.Clear();
        }

        private void _DeleteBeltTest()
        {
            if (!clsBeltTest.IsBeltTestExist(_TestID))
            {
                MessageBox.Show($"No Test with TestID : [{_TestID}] is found !", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (clsBeltTest.DeleteBeltTest(_TestID))
                {
                    MessageBox.Show($"Test with TestID : [{_TestID}] is deleted successfully !", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                    MessageBox.Show($"Failed to delete Test with TestID : [{_TestID}]", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _Refresh();
        }

        private void tbSearchValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchValue.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbSearchValue, "Please enter TestID to delete !");
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
                _TestID = Convert.ToInt32(tbSearchValue.Text.ToString());

                if (!clsBeltTest.IsBeltTestExist(_TestID))
                {
                    MessageBox.Show($"No Test with TestID : [{_TestID}] is found !");
                }

                else
                {
                    MessageBox.Show($"Test with TestID : [{_TestID}] is found !");
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
                _DeleteBeltTest();
        }
    }
}
