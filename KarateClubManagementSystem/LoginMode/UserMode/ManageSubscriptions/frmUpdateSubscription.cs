using KarateClubBusinessLayer;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace KarateClub.ManageSubscriptions
{
    public partial class frmUpdateSubscription : Form
    {
        private clsSubscriptionPeriod _SubscriptionPeriod;

        private int _SubscriptionPeriodID;
        private enum enSubscriptionIDMode { ExternalID, InternalID };

        private enSubscriptionIDMode _Mode;

        public frmUpdateSubscription()
        {
            InitializeComponent();
            _Mode = enSubscriptionIDMode.InternalID;
        }

        public frmUpdateSubscription(int SubscriptionPeriodID)
        {
            InitializeComponent();
            _Mode = enSubscriptionIDMode.ExternalID;
            _SubscriptionPeriodID = SubscriptionPeriodID;
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
            panel.Enabled = true;

            _SubscriptionPeriod = clsSubscriptionPeriod.Find(_SubscriptionPeriodID);
            dtpStartDate.Value = _SubscriptionPeriod.StartDate;
            dtpEndDate.Value = _SubscriptionPeriod.EndDate;
            tbSubscriptionPeriodID.Text = _SubscriptionPeriod.PeriodID.ToString();
            nUDFees.Value = Convert.ToDecimal(_SubscriptionPeriod.Fees);

            if (_SubscriptionPeriod.Paid)
            {
                rbPaid.Checked = true;
                rbPaid.Enabled = false;
            }
            else
                rbNotPaid.Checked = true;

            lbMembers.SelectedIndex = lbMembers.FindString(clsMember.GetMemberName(_SubscriptionPeriod.MemberID));
        }

        private void _Refresh()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            _FillMembersInListBox();
            if (_Mode == enSubscriptionIDMode.ExternalID)
            {
                tbSearchValue.Visible = false;
                pbSearch.Visible = false;
                lbl.Visible = false;
                panel.Enabled = true;
                _LoadData();
            }

            else
                panel.Enabled = false;
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

        private void tbSearchValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchValue.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbSearchValue, "Please enter SubscriptionPeriodID to update !");
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
            if (string.IsNullOrEmpty(tbSearchValue.Text))
            {
                errorProvider1.SetError(tbSearchValue, "Please enter SubscriptionPeriodID to update !");
                tbSearchValue.Focus();
            }

            else if (!int.TryParse(tbSearchValue.Text.ToString(), out int _))
            {
                errorProvider1.SetError(tbSearchValue, "Please enter Numbers only !");
                tbSearchValue.Focus();
            }

            else
            {
                errorProvider1.SetError(tbSearchValue, "");
            }

            _SubscriptionPeriodID = Convert.ToInt32(tbSearchValue.Text.ToString());

            if (!clsSubscriptionPeriod.IsSubscriptionPeriodExist(_SubscriptionPeriodID))
            {
                MessageBox.Show($"No SubscriptionPeriod with SubscriptionPeriodID : [{_SubscriptionPeriodID}] is found !");
                _Refresh();
            }

            else
                _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((_Mode == enSubscriptionIDMode.InternalID && ValidateChildren()) || _Mode == enSubscriptionIDMode.ExternalID)
            {
                if (_SaveData())
                {
                    MessageBox.Show($"SubscriptionPeriod with SubscriptionPeriodID : [{_SubscriptionPeriod.PeriodID}] is updated successfully !",
                   "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Failed to update SubscriptionPeriod with SubscriptionPeriodID : [{_SubscriptionPeriod.PeriodID}]",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                _Refresh();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _Refresh();
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

        private void frmUpdateSubscription_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

    }
}
