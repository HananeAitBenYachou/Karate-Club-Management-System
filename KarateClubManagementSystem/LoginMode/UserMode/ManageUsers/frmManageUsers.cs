using System;
using System.Windows.Forms;

namespace KarateClub.ManageUsers
{
    public partial class frmManageUsers : Form
    {
        public frmManageUsers()
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

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            btnUsersList.PerformClick();
        }

        private void btnUsersList_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmUsersList());
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmAddUser());
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmUpdateUser());
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmDeleteUser());
        }

        private void btnFindUser_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmFindUser());

        }
    }
}
