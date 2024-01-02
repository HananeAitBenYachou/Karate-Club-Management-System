using KarateClubBusinessLayer;
using System;
using System.Windows.Forms;

namespace KarateClub
{
    public partial class frmDashboard : Form
    {

        public frmDashboard()
        {
            InitializeComponent();

        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            lblMembersCount.Text = clsMember.GetMembersCount().ToString();
            lblUsersCount.Text = clsUser.GetUsersCount().ToString();
            lblInstructorsCount.Text = clsInstructor.GetInstructorsCount().ToString();
            lblPaymentsCount.Text = clsPayment.GetPaymentsCount().ToString();
            lblSubscriptionsCount.Text = clsSubscriptionPeriod.GetSubscriptionPeriodsCount().ToString();
            lblBeltTestsCount.Text = clsBeltTest.GetBeltTestsCount().ToString();
        }

    }
}
