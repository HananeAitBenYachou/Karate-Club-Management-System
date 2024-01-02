using KarateClubBusinessLayer;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace KarateClub.ManagePayments
{
    public partial class frmFindPayment : Form
    {
        private enum enPaymentIDMode { ExternalID, InternalID };

        private enPaymentIDMode _Mode;

        private clsPayment _Payment;

        private int _PaymentID;

        public frmFindPayment()
        {
            InitializeComponent();
            _Mode = enPaymentIDMode.InternalID;
        }

        public frmFindPayment(int PaymentID)
        {
            InitializeComponent();
            _Mode = enPaymentIDMode.ExternalID;
            _PaymentID = PaymentID;
        }

        private void _FillMembersInListBox()
        {
            lbMembers.Items.Clear();

            DataTable MembersDataTable = clsMember.ListMembers();

            foreach (DataRow row in MembersDataTable.Rows)
            {
                lbMembers.Items.Add(row["Name"]);
            }
        }

        private void _LoadData()
        {
            _Payment = clsPayment.Find(_PaymentID);

            tbPaymentID.Text = _Payment.PaymentID.ToString();
            nUDAmountPaid.Value = Convert.ToDecimal(_Payment.Amount);
            dtpPaymentDate.Value = _Payment.Date;
            lbMembers.SelectedIndex = lbMembers.FindString(clsMember.GetMemberName(_Payment.MemberID));
        }

        private void _Refresh()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            _FillMembersInListBox();
            if (_Mode == enPaymentIDMode.ExternalID)
            {
                tbSearchValue.Visible = false;
                pbSearch.Visible = false;
                lbl.Visible = false;
                _LoadData();
            }
        }

        private void tbSearchValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchValue.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbSearchValue, "Please enter PaymentID to update !");
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
                    _Refresh();
                }

                else
                    _LoadData();
            }
        }

        private void frmFindPayment_Load(object sender, EventArgs e)
        {
            _Refresh();
        }
    }
}
