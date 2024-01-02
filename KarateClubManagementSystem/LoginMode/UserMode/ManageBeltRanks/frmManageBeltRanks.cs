using System;
using System.Windows.Forms;

namespace KarateClub.ManageBeltRanks
{
    public partial class frmManageBeltRanks : Form
    {
        public frmManageBeltRanks()
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

        private void frmManageBeltRanks_Load(object sender, EventArgs e)
        {
            btnBeltRanksList.PerformClick();
        }

        private void btnBeltRanksList_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmBeltRanksList());
        }

        private void btnAddBeltRank_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmAddBeltRank());
        }

        private void btnEditBeltRank_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmUpdateBeltRank());
        }

        private void btnDeleteBeltRank_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmDeleteBeltRank());
        }

        private void btnFindBeltRank_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmFindBeltRank());

        }
    }
}
