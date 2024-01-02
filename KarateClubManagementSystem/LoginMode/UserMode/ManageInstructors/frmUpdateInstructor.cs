using KarateClubBusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace KarateClub.ManageInstructors
{
    public partial class frmUpdateInstructor : Form
    {
        private clsInstructor _Instructor;

        private int _InstructorID;
        private enum enInstructorIDMode { ExternalID, InternalID };

        private enInstructorIDMode _Mode;

        public frmUpdateInstructor()
        {
            InitializeComponent();
            _Mode = enInstructorIDMode.InternalID;
        }

        public frmUpdateInstructor(int InstructorID)
        {
            InitializeComponent();
            _Mode = enInstructorIDMode.ExternalID;
            _InstructorID = InstructorID;
        }

        private void _LoadData()
        {
            panel.Enabled = true;

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
                lbRemove.Visible = true;
            }

            else
            {
                picture.ImageLocation = @"C:\Users\hanan\source\repos\KarateClub\Resources\Instructor (2).png";
                lbRemove.Visible = false;
            }
        }

        private void _Refresh()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            _FillGendersInComboBox();
            picture.ImageLocation = @"C:\Users\hanan\source\repos\KarateClub\Resources\Instructor (2).png";
            lbSetImage.Visible = true;
            lbRemove.Visible = false;

            if (_Mode == enInstructorIDMode.ExternalID)
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

        private void _FillGendersInComboBox()
        {
            cbGender.Items.Add("Male");
            cbGender.Items.Add("Female");
        }

        private bool _SaveData()
        {
            _Instructor.Name = tbName.Text.ToString();
            _Instructor.Address = tbAddress.Text.ToString();
            _Instructor.Phone = tbPhone.Text.ToString();
            _Instructor.Email = tbEmail.Text.ToString();
            _Instructor.Password = tbPassword.Text.ToString();
            _Instructor.DateOfBirth = dtpDateOfBirth.Value;

            if (cbGender.SelectedItem.ToString() == "Male")
                _Instructor.Gender = 'M';
            else
                _Instructor.Gender = 'F';

            if (picture.ImageLocation != @"C:\Users\hanan\source\repos\KarateClub\Resources\Instructor (2).png")
                _Instructor.ImagePath = picture.ImageLocation;
            else
                _Instructor.ImagePath = "";

            return _Instructor.Save();
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

        private void tb_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrEmpty(textBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, "This field cannot be left empty !");
                textBox.Focus();
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, "");
            }
        }

        private void lbSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picture.Load(openFileDialog1.FileName);
                lbRemove.Visible = true;
                lbSetImage.Visible = false;
            }
        }

        private void lbRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picture.ImageLocation = @"C:\Users\hanan\source\repos\KarateClub\Resources\Instructor (2).png";
            lbRemove.Visible = false;
            lbSetImage.Visible = true;
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchValue.Text))
            {
                errorProvider1.SetError(tbSearchValue, "Please enter InstructorID to update !");
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


            _InstructorID = Convert.ToInt32(tbSearchValue.Text.ToString());

            if (!clsInstructor.IsInstructorExist(_InstructorID))
            {
                MessageBox.Show($"No Instructor with InstructorID : [{_InstructorID}] is found !");
                _Refresh();
            }

            else
                _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((_Mode == enInstructorIDMode.InternalID && ValidateChildren()) || _Mode == enInstructorIDMode.ExternalID)
            {
                if (_SaveData())
                {
                    MessageBox.Show($"Instructor with InstructorID : [{_Instructor.InstructorID}] is updated successfully !",
                   "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Failed to update Instructor with InstructorID : [{_Instructor.InstructorID}]",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                _Refresh();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void frmUpdateInstructor_Load(object sender, EventArgs e)
        {
            _Refresh();
        }
    }
}
