using KarateClubBusinessLayer;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace KarateClub.ManageSubscriptions
{
    public partial class frmAddSubscription : Form
    {

        clsSubscriptionPeriod _SubscriptionPeriod = new clsSubscriptionPeriod();

        public frmAddSubscription()
        {
            InitializeComponent();
        }

        private void frmAddSubscription_Load(object sender, EventArgs e)
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
            rbPaid.Checked = true;
        }

        private bool _SaveData()
        {
            int MemberID = clsMember.GetMemberID(lbMembers.SelectedItem.ToString());
            _SubscriptionPeriod.StartDate = dtpStartDate.Value;
            _SubscriptionPeriod.EndDate = dtpEndDate.Value;
            _SubscriptionPeriod.MemberID = MemberID;
            _SubscriptionPeriod.Fees = Convert.ToDouble(nUDFees.Value);
            _SubscriptionPeriod.Paid = rbPaid.Checked;

            return _SubscriptionPeriod.Save();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (_SaveData())
                {
                    MessageBox.Show($"New SubscriptionPeriod is added successfully with PeriodID  : [{_SubscriptionPeriod.PeriodID}]",
                   "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Failed to add the new SubscriptionPeriod ",
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

        private void dtpEndDate_Validating(object sender, CancelEventArgs e)
        {
            if (dtpEndDate.Value <= dtpStartDate.Value)
            {
                e.Cancel = true;
                errorProvider1.SetError(dtpEndDate, "Subscription EndDate is not valid !");
                dtpEndDate.Focus();
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(dtpEndDate, "");
            }
        }
    }
}
