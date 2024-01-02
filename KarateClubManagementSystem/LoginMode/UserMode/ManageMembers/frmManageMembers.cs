using KarateClub.ManageMembers;
using System;
using System.Windows.Forms;

namespace KarateClub
{
    public partial class frmManageMembers : Form
    {
        public frmManageMembers()
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

        private void frmManageMembers_Load(object sender, EventArgs e)
        {
            btnMembersList.PerformClick();
        }

        private void btnMembersList_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmMembersList());
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmAddMember());
        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmUpdateMember());
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmDeleteMember());
        }

        private void btnFindMember_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmFindMember());

        }
    }
}
