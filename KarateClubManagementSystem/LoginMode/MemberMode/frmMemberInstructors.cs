using KarateClub.ManageMemberInstructors;
using KarateClubBusinessLayer;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KarateClub.LoginMode.MemberMode
{
    public partial class frmMemberInstructors : Form
    {
        public frmMemberInstructors()
        {
            InitializeComponent();
        }
        private enum enSearchByOptions { eMemberInstructorID, eInstructorName };

        private enSearchByOptions _SearchByOption;

        private string _SearchFilter;

        private enSearchByOptions _GetSearchByOption()
        {
            switch (cbSearchByOptions.SelectedItem)
            {
                case "MemberInstructorID":
                    return enSearchByOptions.eMemberInstructorID;
                case "InstructorName":
                    return enSearchByOptions.eInstructorName;
            }
            return enSearchByOptions.eMemberInstructorID;

        }

        private void dgvMemberInstructorsList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                e.Graphics.FillRectangle(Brushes.DarkOrange, e.CellBounds);
                e.PaintContent(e.CellBounds);
                e.Handled = true;
            }
        }

        private void frmMemberInstructorsList_Load(object sender, EventArgs e)
        {
            cbSearchByOptions.SelectedItem = "MemberInstructorID";
            _Refresh();
        }

        private void _RefreshMemberInstructorsList()
        {
            DataView dataView = clsMemberInstructor.ListMemberInstructors().DefaultView;
            dataView.RowFilter = "MemberName = '" + clsGlobalMember.CurrentMember.Name + "'";
            dgvMemberInstructorsList.DataSource = dataView;
            dgvMemberInstructorsList.ClearSelection();
        }

        private void _Refresh()
        {
            tbSearchValue.ResetText();
            _RefreshMemberInstructorsList();
        }

        private void _SearchMemberInstructor()
        {
            DataView dataView = clsMemberInstructor.ListMemberInstructors().DefaultView;

            switch (_SearchByOption)
            {
                case enSearchByOptions.eMemberInstructorID:

                    if (!int.TryParse(_SearchFilter, out int _))
                    {
                        MessageBox.Show("Please Enter Numbers Only ! ", "Invalid Input ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _Refresh();
                        return;
                    }

                    dataView.RowFilter = "MemberInstructorID = " + _SearchFilter + "AND MemberName = '" + clsGlobalMember.CurrentMember.Name + "'";
                    break;

                case enSearchByOptions.eInstructorName:
                    dataView.RowFilter = "InstructorName LIKE '%" + _SearchFilter + "%'" + "AND MemberName = '" + clsGlobalMember.CurrentMember.Name + "'";
                    break;
            }

            dgvMemberInstructorsList.DataSource = dataView;
        }

        private void tbSearchValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchValue.Text.ToString()))
            {
                _Refresh();
                return;
            }

            else
                _SearchFilter = tbSearchValue.Text.ToString();
            _SearchMemberInstructor();

        }

        private void cbSearchByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SearchByOption = _GetSearchByOption();
        }

        private void dgvMemberInstructorsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMemberInstructorsList.SelectedRows.Count > 0)
            {
                int MemberInstructorID = Convert.ToInt32(dgvMemberInstructorsList.SelectedRows[0].Cells[0].Value);

                Form myForm = new frmFindMemberInstructor(MemberInstructorID);

                myForm.ShowDialog();
            }
        }

        private void displayDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvMemberInstructorsList.SelectedRows.Count > 0)
            {
                int MemberInstructorID = Convert.ToInt32(dgvMemberInstructorsList.SelectedRows[0].Cells[0].Value);

                Form myForm = new frmFindMemberInstructor(MemberInstructorID);

                myForm.ShowDialog();
            }
        }

        private void dgvMemberInstructorsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvMemberInstructorsList.Columns)
            {
                column.Width = 230;
            }
        }

    }
}

