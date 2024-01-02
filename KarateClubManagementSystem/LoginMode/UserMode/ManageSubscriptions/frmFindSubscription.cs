using KarateClubBusinessLayer;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace KarateClub.ManageSubscriptions
{
    public partial class frmFindSubscription : Form
    {
        private enum enSubscriptionIDMode { ExternalID, InternalID };

        private enSubscriptionIDMode _Mode;

        private clsSubscriptionPeriod _SubscriptionPeriod;

        private int _SubscriptionPeriodID;

        public frmFindSubscription()
        {
            InitializeComponent();
            _Mode = enSubscriptionIDMode.InternalID;
        }

        public frmFindSubscription(int SubscriptionPeriodID)
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
            _SubscriptionPeriod = clsSubscriptionPeriod.Find(_SubscriptionPeriodID);
            dtpStartDate.Value = _SubscriptionPeriod.StartDate;
            dtpEndDate.Value = _SubscriptionPeriod.EndDate;
            tbSubscriptionPeriodID.Text = _SubscriptionPeriod.PeriodID.ToString();
            nUDFees.Value = Convert.ToDecimal(_SubscriptionPeriod.Fees);

            if (_SubscriptionPeriod.Paid)
            {
                rbPaid.Checked = true;
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
                _LoadData();
            }
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
            if (ValidateChildren())
            {
                _SubscriptionPeriodID = Convert.ToInt32(tbSearchValue.Text.ToString());

                if (!clsSubscriptionPeriod.IsSubscriptionPeriodExist(_SubscriptionPeriodID))
                {
                    MessageBox.Show($"No SubscriptionPeriod with SubscriptionPeriod : [{_SubscriptionPeriodID}] is found !");
                    _Refresh();
                }

                else
                    _LoadData();
            }
        }

        private void frmFindSubscription_Load(object sender, EventArgs e)
        {
            _Refresh();
        }
    }
}
