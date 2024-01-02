using System;
using System.Windows.Forms;

namespace KarateClub.ManageInstructors
{
    public partial class frmManageInstructors : Form
    {
        public frmManageInstructors()
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

        private void frmManageInstructors_Load(object sender, EventArgs e)
        {
            btnInstructorsList.PerformClick();
        }

        private void btnInstructorsList_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmInstructorsList());
        }

        private void btnAddInstructor_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmAddInstructor());
        }

        private void btnEditInstructor_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmUpdateInstructor());
        }

        private void btnDeleteInstructor_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmDeleteInstructor());
        }

        private void btnFindInstructor_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmFindInstructor());

        }
    }
}
