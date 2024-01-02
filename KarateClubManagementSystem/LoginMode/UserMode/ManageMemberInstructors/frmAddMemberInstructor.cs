using KarateClubBusinessLayer;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace KarateClub.ManageMemberInstructors
{
    public partial class frmAddMemberInstructor : Form
    {
        clsMemberInstructor _MemberInstructor = new clsMemberInstructor();

        public frmAddMemberInstructor()
        {
            InitializeComponent();
        }

        private void frmAddMemberInstructor_Load(object sender, EventArgs e)
        {
            _Refresh();

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

        private void _FillInstructorsInListBox(string MemberName)
        {
            int MemberID = clsMember.GetMemberID(MemberName);

            DataTable InstructorsDataTable = clsInstructor.ListInstructors(MemberID);

            lbInstructors.Items.Clear();

            foreach (DataRow row in InstructorsDataTable.Rows)
            {
                lbInstructors.Items.Add(row["Name"]);
            }

        }

        private void _Refresh()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            _FillMembersInListBox();
            _FillInstructorsInListBox();
        }

        private bool _SaveData()
        {
            int MemberID = clsMember.GetMemberID(lbMembers.SelectedItem.ToString());
            int InstructorID = clsInstructor.GetInstructorID(lbInstructors.SelectedItem.ToString());

            _MemberInstructor.AssignDate = dtpAssignDate.Value;
            _MemberInstructor.MemberID = MemberID;
            _MemberInstructor.InstructorID = InstructorID;

            return _MemberInstructor.Save();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (_SaveData())
                {
                    MessageBox.Show($"Instructor with InstructorID : [{_MemberInstructor.InstructorID}] is assigned to Member with MemberID : [{_MemberInstructor.MemberID}] " +
                        $"At : [{_MemberInstructor.AssignDate}]",
                   "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Failed to assign Instructor with InstructorID : [{_MemberInstructor.InstructorID}] to Member with MemberID : [{_MemberInstructor.MemberID}] ",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                _Refresh();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void lbMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbMembers.SelectedItem != null)
            {
                _FillInstructorsInListBox(lbMembers.SelectedItem.ToString());
            }
        }

        private void ListBox_Validating(object sender, CancelEventArgs e)
        {
            ListBox listBox = (ListBox)sender;

            if (listBox.SelectedItems.Count == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(listBox, "Please select an Item");
                listBox.Focus();
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(listBox, "");
            }
        }

    }

}
