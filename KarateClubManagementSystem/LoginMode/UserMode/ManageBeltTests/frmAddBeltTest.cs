using KarateClubBusinessLayer;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace KarateClub.ManageBeltTests
{
    public partial class frmAddBeltTest : Form
    {
        clsBeltTest _Test = new clsBeltTest();

        public frmAddBeltTest()
        {
            InitializeComponent();
        }

        private void frmAddBeltTest_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void _FillMembersInListBox()
        {
            lbMembers.Items.Clear();

            DataView MembersDataView = clsMember.ListMembers().DefaultView;

            MembersDataView.RowFilter = "IsActive = 1";

            foreach (DataRowView row in MembersDataView)
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

        private void _FillBeltRanksInListBox()
        {
            lbBeltRanks.Items.Clear();

            DataTable BeltRanksDataTable = clsBeltRank.ListBeltRanks();

            foreach (DataRow row in BeltRanksDataTable.Rows)
            {
                lbBeltRanks.Items.Add(row["RankName"]);
            }
        }

        private void _Refresh()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            _FillInstructorsInListBox();
            _FillBeltRanksInListBox();
            _FillMembersInListBox();
            rbPassed.Checked = true;
        }

        private bool _SaveData()
        {
            int MemberID = clsMember.GetMemberID(lbMembers.SelectedItem.ToString());
            int InstructorID = clsInstructor.GetInstructorID(lbInstructors.SelectedItem.ToString());
            int BeltRankID = clsBeltRank.GetBeltRankID(lbBeltRanks.SelectedItem.ToString());

            _Test.Date = dtpTestDate.Value;
            _Test.MemberID = MemberID;
            _Test.TestedByInstructorID = InstructorID;
            _Test.RankID = BeltRankID;
            _Test.Result = rbPassed.Checked;

            return _Test.Save();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (_SaveData())
                {
                    MessageBox.Show($"New BeltTest is added successfully with BeltTestID  : [{_Test.TestID}]",
                   "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Failed to add the new BeltTest ",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                _Refresh();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
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
