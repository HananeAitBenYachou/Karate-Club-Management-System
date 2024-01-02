using KarateClubBusinessLayer;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace KarateClub.ManageMemberInstructors
{
    public partial class frmFindMemberInstructor : Form
    {
        private enum enMemberInstructorID { ExternalID, InternalID };

        private enMemberInstructorID _Mode;

        private clsMemberInstructor _MemberInstructor;

        private int _MemberInstructorID;

        public frmFindMemberInstructor()
        {
            InitializeComponent();
            _Mode = enMemberInstructorID.InternalID;
        }

        public frmFindMemberInstructor(int MemberInstructorID)
        {
            InitializeComponent();
            _Mode = enMemberInstructorID.ExternalID;
            _MemberInstructorID = MemberInstructorID;
        }

        private void _FillMembersInListBox()
        {
            lbMembers.Items.Clear();
            DataTable MembersDataTable = clsMember.ListMembers();

            foreach (DataRow row in MembersDataTable.Rows)
            {
                lbMembers.Items.Add(row["Name"]);
            }
        }

        private void _FillInstructorsInListBox()
        {
            lbInstructors.Items.Clear();

            DataTable InstructorsDataTable = clsInstructor.ListInstructors();

            foreach (DataRow row in InstructorsDataTable.Rows)
            {
                lbInstructors.Items.Add(row["Name"]);
            }
        }

        private void _LoadData()
        {
            _MemberInstructor = clsMemberInstructor.Find(_MemberInstructorID);

            tbMemberInstructorID.Text = _MemberInstructor.MemberInstructorID.ToString();
            dtpAssignDate.Value = _MemberInstructor.AssignDate;
            lbMembers.SelectedIndex = lbMembers.FindString(clsMember.Find(_MemberInstructor.MemberID).Name);
            lbInstructors.SelectedIndex = lbInstructors.FindString(clsInstructor.Find(_MemberInstructor.InstructorID).Name);

        }

        private void _Refresh()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            _FillMembersInListBox();
            _FillInstructorsInListBox();

            if (_Mode == enMemberInstructorID.ExternalID)
            {
                tbSearchValue.Visible = false;
                pbSearch.Visible = false;
                lbl.Visible = false;
                _LoadData();
            }
        }

        private void tbSearchValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchValue.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbSearchValue, "Please enter UserID to update !");
                tbSearchValue.Focus();
            }

            else if (!int.TryParse(tbSearchValue.Text.ToString(), out int _))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbSearchValue, "Please enter Numbers only !");
                tbSearchValue.Focus();
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbSearchValue, "");
            }
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                _MemberInstructorID = Convert.ToInt32(tbSearchValue.Text.ToString());

                if (!clsMemberInstructor.IsMemberInstructorExist(_MemberInstructorID))
                {
                    MessageBox.Show($"No MemberInstructor with MemberInstructorID : [{_MemberInstructorID}] is found !");
                    _Refresh();
                }

                else
                    _LoadData();
            }
        }

        private void frmFindMemberInstructor_Load(object sender, EventArgs e)
        {
            _Refresh();
        }
    }
}
