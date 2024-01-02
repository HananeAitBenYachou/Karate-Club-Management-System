using KarateClubBusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace KarateClub.ManageInstructors
{
    public partial class frmAddInstructor : Form
    {
        public frmAddInstructor()
        {
            InitializeComponent();
        }

        clsInstructor _Instructor = new clsInstructor();

        private void frmAddInstructor_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void _ResetTextBoxes()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.ResetText();
                }
            }
        }

        private void _Refresh()
        {
            _ResetTextBoxes();
            cbGender.Items.Clear();
            _FillGendersInComboBox();
            errorProvider1.Clear();
            picture.ImageLocation = @"C:\Users\hanan\source\repos\KarateClub\Resources\Instructor (2).png";
            lbSetImage.Visible = true;
            lbRemove.Visible = false;
            cbGender.SelectedIndex = 0;
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

        private void tb_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrEmpty(textBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, "This field cannot be left empty !");
                textBox.Focus();
                return;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (_SaveData())
                {
                    MessageBox.Show($"New instructor is added successfully with MemberID  : [{_Instructor.InstructorID}]",
                   "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Failed to add the new instructor ",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                _Refresh();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _Refresh();
        }
    }
}
