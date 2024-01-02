using KarateClubBusinessLayer;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace KarateClub.ManageMemberInstructors
{
    public partial class frmUpdateMemberInstructor : Form
    {

        private clsMemberInstructor _MemberInstructor;

        private int _MemberInstructorID;
        private enum enMemberInstructorIDMode { ExternalID, InternalID };

        private enMemberInstructorIDMode _Mode;

        public frmUpdateMemberInstructor()
        {
            InitializeComponent();
            _Mode = enMemberInstructorIDMode.InternalID;
        }

        public frmUpdateMemberInstructor(int MemberInstructorID)
        {
            InitializeComponent();
            _Mode = enMemberInstructorIDMode.ExternalID;
            _MemberInstructorID = MemberInstructorID;
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

            lbInstructors.Items.Add(clsInstructor.GetInstructorName(_MemberInstructor.InstructorID));
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
            panel.Enabled = true;

            _MemberInstructor = clsMemberInstructor.Find(_MemberInstructorID);

            _FillInstructorsInListBox(clsMember.GetMemberName(_MemberInstructor.MemberID));

            tbMemberInstructorID.Text = _MemberInstructor.MemberInstructorID.ToString();
            dtpAssignDate.Value = _MemberInstructor.AssignDate;
            lbMembers.SelectedIndex = lbMembers.FindString(clsMember.GetMemberName(_MemberInstructor.MemberID));
            lbInstructors.SelectedIndex = lbInstructors.FindString(clsInstructor.GetInstructorName(_MemberInstructor.InstructorID));
        }

        private void _Refresh()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            _FillMembersInListBox();
            _FillInstructorsInListBox();

            if (_Mode == enMemberInstructorIDMode.ExternalID)
            {
                tbSearchValue.Visible = false;
                pbSearch.Visible = false;
                lbl.Visible = false;
                panel.Enabled = true;
                _LoadData();
            }

            else
                panel.Enabled = false;

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

        private void tbSearchValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchValue.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbSearchValue, "Please enter MemberInstructorID to update !");
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
            if (string.IsNullOrEmpty(tbSearchValue.Text))
            {
                errorProvider1.SetError(tbSearchValue, "Please enter MemberInstructorID to update !");
                tbSearchValue.Focus();
                return;
            }

            else if (!int.TryParse(tbSearchValue.Text, out int _))
            {
                errorProvider1.SetError(tbSearchValue, "Please enter Numbers only !");
                tbSearchValue.Focus();
                return;
            }

            else
                errorProvider1.SetError(tbSearchValue, "");


            _MemberInstructorID = Convert.ToInt32(tbSearchValue.Text.ToString());

            if (!clsMemberInstructor.IsMemberInstructorExist(_MemberInstructorID))
            {
                MessageBox.Show($"No MemberInstructor with MemberInstructorID : [{_MemberInstructorID}] is found !");
                _Refresh();
            }

            else
                _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((_Mode == enMemberInstructorIDMode.InternalID && ValidateChildren()) || _Mode == enMemberInstructorIDMode.ExternalID)
            {
                if (_SaveData())
                {
                    MessageBox.Show($"MemberInstructor with MemberInstructorID : [{_MemberInstructor.MemberInstructorID}] is updated successfully !",
                   "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Failed to update MemberInstructor with MemberInstructorID : [{_MemberInstructor.MemberInstructorID}]",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                _Refresh();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void frmUpdateMemberInstructor_Load(object sender, EventArgs e)
        {
            _Refresh();
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
