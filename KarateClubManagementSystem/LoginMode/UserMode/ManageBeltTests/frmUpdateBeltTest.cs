using KarateClubBusinessLayer;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace KarateClub.ManageBeltTests
{
    public partial class frmUpdateBeltTest : Form
    {

        private clsBeltTest _Test;

        private int _TestID;
        private enum enBeltTestIDMode { ExternalID, InternalID };

        private enBeltTestIDMode _Mode;

        public frmUpdateBeltTest()
        {
            InitializeComponent();
            _Mode = enBeltTestIDMode.InternalID;
        }

        public frmUpdateBeltTest(int TestID)
        {
            InitializeComponent();
            _Mode = enBeltTestIDMode.ExternalID;
            _TestID = TestID;
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

        private void _FillBeltRanksInListBox()
        {
            lbBeltRanks.Items.Clear();

            DataTable BeltRanksDataTable = clsBeltRank.ListBeltRanks();

            foreach (DataRow row in BeltRanksDataTable.Rows)
            {
                lbBeltRanks.Items.Add(row["RankName"]);
            }
        }

        private void _LoadData()
        {
            panel.Enabled = true;

            _Test = clsBeltTest.Find(_TestID);
            tbTestID.Text = _Test.TestID.ToString();
            dtpTestDate.Value = _Test.Date;

            if (_Test.Result)
            {
                rbPassed.Checked = true;
            }
            else
                rbFailed.Checked = true;

            lbMembers.SelectedIndex = lbMembers.FindString(clsMember.GetMemberName(_Test.MemberID));
            lbInstructors.SelectedIndex = lbInstructors.FindString(clsInstructor.GetInstructorName(_Test.TestedByInstructorID));
            lbBeltRanks.SelectedIndex = lbBeltRanks.FindString(clsBeltRank.GetBeltRankName(_Test.RankID));
        }

        private void _Refresh()
        {
            this.Controls.Clear();
            this.InitializeComponent();

            _FillMembersInListBox();
            _FillInstructorsInListBox();
            _FillBeltRanksInListBox();

            if (_Mode == enBeltTestIDMode.ExternalID)
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
            int BeltRankID = clsBeltRank.GetBeltRankID(lbBeltRanks.SelectedItem.ToString());

            _Test.Date = dtpTestDate.Value;
            _Test.MemberID = MemberID;
            _Test.TestedByInstructorID = InstructorID;
            _Test.RankID = BeltRankID;
            _Test.Result = rbPassed.Checked;

            return _Test.Save();
        }

        private void tbSearchValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchValue.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbSearchValue, "Please enter BeltTestID to update !");
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
                errorProvider1.SetError(tbSearchValue, "Please enter BeltTestID to update !");
                tbSearchValue.Focus();
            }

            else if (!int.TryParse(tbSearchValue.Text.ToString(), out int _))
            {
                errorProvider1.SetError(tbSearchValue, "Please enter Numbers only !");
                tbSearchValue.Focus();
            }

            else
            {
                errorProvider1.SetError(tbSearchValue, "");
            }

            _TestID = Convert.ToInt32(tbSearchValue.Text.ToString());

            if (!clsBeltTest.IsBeltTestExist(_TestID))
            {
                MessageBox.Show($"No BeltTest with BeltTestID : [{_TestID}] is found !");
                _Refresh();
            }

            else
                _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((_Mode == enBeltTestIDMode.InternalID && ValidateChildren()) || _Mode == enBeltTestIDMode.ExternalID)
            {
                if (_SaveData())
                {
                    MessageBox.Show($"BeltTest with BeltTestID : [{_Test.TestID}] is updated successfully !",
                   "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Failed to update BeltTest with BeltTestID : [{_Test.TestID}]",
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

        private void frmUpdateBeltTest_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

    }
}
