using KarateClubBusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace KarateClub.ManageSubscriptions
{
    public partial class frmDeleteSubscription : Form
    {
        public frmDeleteSubscription()
        {
            InitializeComponent();
        }

        private int _SubscriptionPeriodID;

        private void _Refresh()
        {
            tbSearchValue.ResetText();
            errorProvider1.Clear();
        }

        private void _DeleteSubscriptionPeriod()
        {
            if (!clsSubscriptionPeriod.IsSubscriptionPeriodExist(_SubscriptionPeriodID))
            {
                MessageBox.Show($"No SubscriptionPeriod with SubscriptionPeriodID : [{_SubscriptionPeriodID}] is found !", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (clsPayment.DeletePayment(_SubscriptionPeriodID))
                {
                    MessageBox.Show($"SubscriptionPeriod with SubscriptionPeriodID : [{_SubscriptionPeriodID}] is deleted successfully !", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                    MessageBox.Show($"Failed to delete SubscriptionPeriod with SubscriptionPeriodID : [{_SubscriptionPeriodID}]", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _Refresh();
        }

        private void tbSearchValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchValue.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbSearchValue, "Please enter _SubscriptionPeriodID to delete !");
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
                _SubscriptionPeriodID = Convert.ToInt32(tbSearchValue.Text.ToString());

                if (!clsSubscriptionPeriod.IsSubscriptionPeriodExist(_SubscriptionPeriodID))
                {
                    MessageBox.Show($"No SubscriptionPeriod with SubscriptionPeriodID : [{_SubscriptionPeriodID}] is found !");
                }

                else
                {
                    MessageBox.Show($"SubscriptionPeriod with SubscriptionPeriodID : [{_SubscriptionPeriodID}] is found !");
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
                _DeleteSubscriptionPeriod();
        }

    }
}
