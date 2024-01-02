using KarateClubBusinessLayer;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace KarateClub.ManagePayments
{
    public partial class frmAddPayment : Form
    {
        clsPayment _Payment = new clsPayment();

        public frmAddPayment()
        {
            InitializeComponent();
        }

        private void frmAddPayment_Load(object sender, EventArgs e)
        {
            _Refresh();

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

        private void _Refresh()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            _FillMembersInListBox();
        }

        private bool _SaveData()
        {
            int MemberID = clsMember.GetMemberID(lbMembers.SelectedItem.ToString());
            _Payment.Date = dtpPaymentDate.Value;
            _Payment.MemberID = MemberID;
            _Payment.Amount = Convert.ToDouble(nUDAmountPaid.Value);

            return _Payment.Save();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (_SaveData())
                {
                    MessageBox.Show($"New Payment is added successfully with PaymentID  : [{_Payment.PaymentID}]",
                   "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Failed to add the new Payment ",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                _Refresh();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void ListBox_Validating(object sender, CancelEventArgs e)
        {
            ListBox listBox = (ListBox)sender;

            if (listBox.SelectedItems.Count == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(listBox, "Please select an Item");
                listBox.Focus();
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(listBox, "");
            }
        }
    }
}
