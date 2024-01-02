using KarateClub.ManageMembers;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace KarateClub.LoginMode.MemberMode.Main
{
    public partial class frmMemberHome : Form
    {
        private Panel[] _InactivePanels = new Panel[5];

        public frmMemberHome()
        {
            InitializeComponent();
            _InactivePanels[0] = pnlProfile; _InactivePanels[1] = pnlMemberInstructors;
            _InactivePanels[2] = pnlPayments; _InactivePanels[3] = pnlSubscriptions;
            _InactivePanels[4] = pnlBeltTests;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            lblLoggedInMember.Text = clsGlobalMember.CurrentMember.Name.ToString();

            btnMemberProfile.PerformClick();
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

        private void btnMemberInstructors_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmMemberInstructors());
            _ChangePanelsVisibility(pnlMemberInstructors);
        }

        private void btnMemberPayments_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmMemberPayments());
            _ChangePanelsVisibility(pnlPayments);
        }

        private void btnMemberProfile_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmFindMember(clsGlobalMember.CurrentMember.MemberID));
            _ChangePanelsVisibility(pnlProfile);
        }

        private void btnMemberSubscriptions_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmMemberSubscriptions());
            _ChangePanelsVisibility(pnlSubscriptions);
        }

        private void btnMemberBeltTests_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmMemberBeltTests());
            _ChangePanelsVisibility(pnlBeltTests);
        }

        private void editInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myForm = new frmUpdateMember(clsGlobalMember.CurrentMember.MemberID);

            myForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form frm = new frmMemberLogin();
            this.Hide();
            frm.Show();

        }

    }
}
