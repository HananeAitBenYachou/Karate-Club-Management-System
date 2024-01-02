using System;
using System.Windows.Forms;

namespace KarateClub.ManageBeltTests
{
    public partial class frmManageBeltTests : Form
    {
        public frmManageBeltTests()
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

        private void frmManageBeltTests_Load(object sender, EventArgs e)
        {
            btnBeltTestsList.PerformClick();
        }

        private void btnBeltTestsList_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmBeltTestsList());
        }

        private void btnAddBeltTest_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmAddBeltTest());
        }

        private void btnEditBeltTest_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmUpdateBeltTest());
        }

        private void btnDeleteBeltTest_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmDeleteBeltTest());
        }

        private void btnFindBeltTest_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmFindBeltTest());

        }
    }
}
