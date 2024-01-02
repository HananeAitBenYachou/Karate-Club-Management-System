using KarateClubBusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace KarateClub.ManagePayments
{
    public partial class frmDeletePayment : Form
    {
        private int _PaymentID;

        public frmDeletePayment()
        {
            InitializeComponent();
        }

        private void _Refresh()
        {
            tbSearchValue.ResetText();
            errorProvider1.Clear();
        }

        private void _DeletePayment()
        {
            if (!clsPayment.IsPaymentExist(_PaymentID))
            {
                MessageBox.Show($"No Payment with PaymentID : [{_PaymentID}] is found !", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (clsPayment.DeletePayment(_PaymentID))
                {
                    MessageBox.Show($"Payment with PaymentID : [{_PaymentID}] is deleted successfully !", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                    MessageBox.Show($"Failed to delete Payment with PaymentID : [{_PaymentID}]", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _Refresh();
        }

        private void tbSearchValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchValue.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbSearchValue, "Please enter PaymentID to delete !");
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
                _PaymentID = Convert.ToInt32(tbSearchValue.Text.ToString());

                if (!clsPayment.IsPaymentExist(_PaymentID))
                {
                    MessageBox.Show($"No Payment with PaymentID : [{_PaymentID}] is found !");
                }

                else
                {
                    MessageBox.Show($"Payment with PaymentID : [{_PaymentID}] is found !");
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
                _DeletePayment();
        }
    }
}
