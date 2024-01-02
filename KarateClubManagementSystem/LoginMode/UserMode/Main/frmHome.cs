using KarateClub.ManageBeltRanks;
using KarateClub.ManageBeltTests;
using KarateClub.ManageInstructors;
using KarateClub.ManageMemberInstructors;
using KarateClub.ManagePayments;
using KarateClub.ManageSubscriptions;
using KarateClub.ManageUsers;
using KarateClubBusinessLayer;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace KarateClub
{
    public partial class frmHome : Form
    {

        private Panel[] _InactivePanels = new Panel[9];

        public frmHome()
        {
            InitializeComponent();
            _InactivePanels[0] = pnlDashboard; _InactivePanels[1] = pnlMembers;
            _InactivePanels[2] = pnlInstructors; _InactivePanels[3] = pnlBeltRanks;
            _InactivePanels[4] = pnlUsers; _InactivePanels[5] = pnlMemberInstructors;
            _InactivePanels[6] = pnlPayments; _InactivePanels[7] = pnlSubscriptions;
            _InactivePanels[8] = pnlBeltTests;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            lblLoggedInUser.Text = clsGlobalUser.CurrentUser.Name.ToString();

            btnDashboard.PerformClick();

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.DarkOrange, Color.FromArgb(38, 33, 37), LinearGradientMode.Horizontal);

            g.FillRectangle(brush, rect);
            brush.Dispose();
        }

        private void _ChangePanelsVisibility(Panel ActivePanel)
        {
            ActivePanel.Visible = true;

            foreach (Panel pnl in _InactivePanels)
            {
                if (ActivePanel != pnl)
                    pnl.Visible = false;
            }
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmDashboard());
            _ChangePanelsVisibility(pnlDashboard);
        }

        private void btnManageMembers_Click(object sender, EventArgs e)
        {
            if (!clsGlobalUser.CheckAccessRights(clsUser.enUsersPermissions.eManageMembers))
                return;

            _FillPanelContainerWithForm(new frmManageMembers());
            _ChangePanelsVisibility(pnlMembers);
        }

        private void btnManageInstructors_Click(object sender, EventArgs e)
        {
            if (!clsGlobalUser.CheckAccessRights(clsUser.enUsersPermissions.eManageInstructors))
                return;

            _FillPanelContainerWithForm(new frmManageInstructors());
            _ChangePanelsVisibility(pnlInstructors);
        }

        private void btnManageBeltRanks_Click(object sender, EventArgs e)
        {
            if (!clsGlobalUser.CheckAccessRights(clsUser.enUsersPermissions.eManageBeltRanks))
                return;
            _FillPanelContainerWithForm(new frmManageBeltRanks());
            _ChangePanelsVisibility(pnlBeltRanks);
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            if (!clsGlobalUser.CheckAccessRights(clsUser.enUsersPermissions.eManageUsers))
                return;
            _FillPanelContainerWithForm(new frmManageUsers());
            _ChangePanelsVisibility(pnlUsers);
        }

        private void btnManageMemberInstructors_Click(object sender, EventArgs e)
        {
            if (!clsGlobalUser.CheckAccessRights(clsUser.enUsersPermissions.eManageMemberInstructors))
                return;
            _FillPanelContainerWithForm(new frmManageMemberInstructors());
            _ChangePanelsVisibility(pnlMemberInstructors);
        }

        private void btnManagePayments_Click(object sender, EventArgs e)
        {
            if (!clsGlobalUser.CheckAccessRights(clsUser.enUsersPermissions.eManagePayments))
                return;
            _FillPanelContainerWithForm(new frmManagePayments());
            _ChangePanelsVisibility(pnlPayments);
        }

        private void btnManageSubscriptions_Click(object sender, EventArgs e)
        {
            if (!clsGlobalUser.CheckAccessRights(clsUser.enUsersPermissions.eManageSubscriptions))
                return;
            _FillPanelContainerWithForm(new frmManageSubscriptions());
            _ChangePanelsVisibility(pnlSubscriptions);
        }

        private void btnManageBeltTests_Click(object sender, EventArgs e)
        {
            if (!clsGlobalUser.CheckAccessRights(clsUser.enUsersPermissions.eManageBeltTests))
                return;
            _FillPanelContainerWithForm(new frmManageBeltTests());
            _ChangePanelsVisibility(pnlBeltTests);
        }

        private void editInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myForm = new frmUpdateUser(clsGlobalUser.CurrentUser.UserID);

            myForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form frm = new frmUserLogin();
            this.Hide();
            frm.Show();
        }

    }
}
