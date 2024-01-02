using KarateClubBusinessLayer;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KarateClub.ManageInstructors
{
    public partial class frmInstructorsList : Form
    {
        public frmInstructorsList()
        {
            InitializeComponent();
        }

        private enum enSearchByOptions { eInstructorID, eName, eGender, eEmail, ePhone };

        private enSearchByOptions _SearchByOption;

        private string _SearchFilter;

        private enSearchByOptions _GetSearchByOption()
        {
            switch (cbSearchByOptions.SelectedItem)
            {
                case "InstructorID":
                    return enSearchByOptions.eInstructorID;
                case "Name":
                    return enSearchByOptions.eName;
                case "Gender":
                    return enSearchByOptions.eGender;
                case "Email":
                    return enSearchByOptions.eEmail;
                case "Phone":
                    return enSearchByOptions.ePhone;
            }
            return enSearchByOptions.eInstructorID;

        }

        private void dgvInstructorsList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                e.Graphics.FillRectangle(Brushes.DarkOrange, e.CellBounds);
                e.PaintContent(e.CellBounds);
                e.Handled = true;
            }
        }

        private void frmInstructorsList_Load(object sender, EventArgs e)
        {
            cbSearchByOptions.SelectedItem = "InstructorID";
            _Refresh();
        }

        private void _RefreshInstructorsList()
        {
            dgvInstructorsList.DataSource = clsInstructor.ListInstructors();
            dgvInstructorsList.ClearSelection();
        }

        private void _Refresh()
        {
            tbSearchValue.ResetText();
            _RefreshInstructorsList();
        }

        private void _SearchInstructor()
        {
            DataView dataView = clsInstructor.ListInstructors().DefaultView;

            switch (_SearchByOption)
            {
                case enSearchByOptions.eInstructorID:

                    if (!int.TryParse(_SearchFilter, out int _))
                    {
                        MessageBox.Show("Please Enter Numbers Only ! ", "Invalid Input ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _Refresh();
                        return;
                    }

                    dataView.RowFilter = "InstructorID = " + _SearchFilter;
                    break;
                case enSearchByOptions.eName:
                    dataView.RowFilter = "Name LIKE '%" + _SearchFilter + "%'";
                    break;
                case enSearchByOptions.eGender:
                    dataView.RowFilter = "Gender LIKE '%" + _SearchFilter + "%'";
                    break;
                case enSearchByOptions.ePhone:
                    dataView.RowFilter = "Phone LIKE '%" + _SearchFilter + "%'";
                    break;
                case enSearchByOptions.eEmail:
                    dataView.RowFilter = "Email LIKE '%" + _SearchFilter + "%'";
                    break;
            }

            dgvInstructorsList.DataSource = dataView;
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
            _SearchInstructor();

        }

        private void cbSearchByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SearchByOption = _GetSearchByOption();
        }

        private void _DeleteInstructor(int InstructorID)
        {
            if (!clsInstructor.IsInstructorExist(InstructorID))
            {
                MessageBox.Show($"No Instructor with InstructorID : [{InstructorID}] is found !", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (clsInstructor.DeleteInstructor(InstructorID))
                {
                    MessageBox.Show($"Instructor with InstructorID : [{InstructorID}] is deleted successfully !", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                    MessageBox.Show($"Failed to delete Instructor with InstructorID : [{InstructorID}]", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void editInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvInstructorsList.SelectedRows.Count > 0)
            {
                int InstructorID = Convert.ToInt32(dgvInstructorsList.SelectedRows[0].Cells[0].Value);

                Form myForm = new frmUpdateInstructor(InstructorID);

                myForm.ShowDialog();

                _Refresh();
            }
        }

        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvInstructorsList.SelectedRows.Count > 0)
            {
                int InstructorID = Convert.ToInt32(dgvInstructorsList.SelectedRows[0].Cells[0].Value);

                if (MessageBox.Show($"Are you sure to delete Instructor with InstructorID : [{InstructorID}]",
                    "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    _DeleteInstructor(InstructorID);
                    _Refresh();
                }
            }
        }

        private void dgvInstructorsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvInstructorsList.SelectedRows.Count > 0)
            {
                int InstructorID = Convert.ToInt32(dgvInstructorsList.SelectedRows[0].Cells[0].Value);

                Form myForm = new frmFindInstructor(InstructorID);

                myForm.ShowDialog();
            }
        }

        private void displayDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvInstructorsList.SelectedRows.Count > 0)
            {
                int InstructorID = Convert.ToInt32(dgvInstructorsList.SelectedRows[0].Cells[0].Value);

                Form myForm = new frmFindInstructor(InstructorID);

                myForm.ShowDialog();
            }
        }

        private void dgvInstructorsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvInstructorsList.Columns)
            {
                column.Width = 150;
            }
        }
    }
}
