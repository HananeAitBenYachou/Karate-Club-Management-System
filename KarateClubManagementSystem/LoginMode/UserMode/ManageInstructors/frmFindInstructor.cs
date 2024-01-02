using KarateClubBusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace KarateClub.ManageInstructors
{
    public partial class frmFindInstructor : Form
    {
        private enum enInstructorIDMode { ExternalID, InternalID };

        private enInstructorIDMode _Mode;

        private clsInstructor _Instructor;

        private int _InstructorID;

        public frmFindInstructor()
        {
            InitializeComponent();
            _Mode = enInstructorIDMode.InternalID;
        }

        public frmFindInstructor(int InsctructorID)
        {
            InitializeComponent();
            _Mode = enInstructorIDMode.ExternalID;
            _InstructorID = InsctructorID;
        }

        private void _LoadData()
        {
            _Instructor = clsInstructor.Find(_InstructorID);

            tbInstructorID.Text = _Instructor.InstructorID.ToString();
            tbName.Text = _Instructor.Name;
            tbAddress.Text = _Instructor.Address;
            tbPhone.Text = _Instructor.Phone;
            tbEmail.Text = _Instructor.Email;
            tbPassword.Text = _Instructor.Password;
            dtpDateOfBirth.Value = _Instructor.DateOfBirth;

            if (_Instructor.Gender == 'M')
                cbGender.SelectedItem = "Male";
            else
                cbGender.SelectedItem = "Female";

            if (_Instructor.ImagePath != "")
            {
                picture.ImageLocation = _Instructor.ImagePath;
            }

            else
            {
                picture.ImageLocation = @"C:\Users\hanan\source\repos\KarateClub\Resources\Instructor (2).png";
            }
        }

        private void _Refresh()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            _FillGendersInComboBox();
            picture.ImageLocation = @"C:\Users\hanan\source\repos\KarateClub\Resources\Instructor (2).png";

            if (_Mode == enInstructorIDMode.ExternalID)
            {
                tbSearchValue.Visible = false;
                pbSearch.Visible = false;
                lbl.Visible = false;
                _LoadData();
            }
        }

        private void _FillGendersInComboBox()
        {
            cbGender.Items.Add("Male");
            cbGender.Items.Add("Female");
        }

        private void tbSearchValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchValue.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbSearchValue, "Please enter InstructorID to update !");
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
                _InstructorID = Convert.ToInt32(tbSearchValue.Text.ToString());

                if (!clsInstructor.IsInstructorExist(_InstructorID))
                {
                    MessageBox.Show($"No Instructor with InstructorID : [{_InstructorID}] is found !");
                    _Refresh();
                }

                else
                    _LoadData();
            }
        }

        private void frmFindInstructor_Load(object sender, EventArgs e)
        {
            _Refresh();
        }
    }
}
