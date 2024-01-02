using System;
using System.Windows.Forms;

namespace KarateClub.ManageMemberInstructors
{
    public partial class frmManageMemberInstructors : Form
    {
        public frmManageMemberInstructors()
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

        private void frmManageMemberInstructors_Load(object sender, EventArgs e)
        {
            btnMemberInstructorsList.PerformClick();
        }

        private void btnMemberInstructorsList_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmMemberInstructorsList());
        }

        private void btnAddMemberInstructor_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmAddMemberInstructor());
        }

        private void btnEditMemberInstructor_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmUpdateMemberInstructor());
        }

        private void btnDeleteMemberInstructor_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmDeleteMemberInstructor());
        }

        private void btnFindMemberInstructor_Click(object sender, EventArgs e)
        {
            _FillPanelContainerWithForm(new frmFindMemberInstructor());

        }
    }
}
