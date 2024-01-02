using System;
using System.Windows.Forms;

namespace KarateClub.ManagePayments
{
    public partial class frmManagePayments : Form
    {
        public frmManagePayments()
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

        private void frmManagePayments_Load(object sender, EventArgs e)
        {
            btnPaymentsList.PerformClick();
        }

        private void btnPaymentsList_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmPaymentsList());
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmAddPayment());
        }

        private void btnEditPayment_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmUpdatePayment());
        }

        private void btnDeletePayment_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmDeletePayment());
        }

        private void btnFindPayment_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmFindPayment());

        }
    }
}
