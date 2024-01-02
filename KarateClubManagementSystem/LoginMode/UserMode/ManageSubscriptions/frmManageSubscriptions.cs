using System;
using System.Windows.Forms;

namespace KarateClub.ManageSubscriptions
{
    public partial class frmManageSubscriptions : Form
    {
        public frmManageSubscriptions()
        {
            InitializeComponent();
        }

        private void _FillPanelContainerWithForm(Form form)
        {
            Form myForm = form;

            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Dock = DockStyle.Fill;

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(myForm);
            myForm.Show();
        }

        private void frmManageSubscriptions_Load(object sender, EventArgs e)
        {
            btnSubscriptionsList.PerformClick();
        }

        private void btnSubscriptionsList_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmSubscriptionsList());
        }

        private void btnAddSubscription_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmAddSubscription());
        }

        private void btnEditSubscription_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmUpdateSubscription());
        }

        private void btnDeleteSubscription_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmDeleteSubscription());
        }

        private void btnFindSubscription_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmFindSubscription());

        }
    }
}
