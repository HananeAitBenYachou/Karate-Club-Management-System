using KarateClubBusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;


namespace KarateClub.ManageUsers
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }


        clsUser _User = new clsUser();

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

        private short _SetUserPermissions()
        {
            short Permissions = 0;

            if (cbAllPermissions.Checked)
            {
                Permissions = Convert.ToInt16(cbAllPermissions.Tag);
                return Permissions;
            }

            foreach (CheckBox checkBox in pnlPermissions.Controls)
            {
                if (checkBox.Checked)
                {
                    Permissions += Convert.ToInt16(checkBox.Tag);
                }
            }

            return Permissions;
        }

        private void _Refresh()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            cbGender.Items.Clear();
            _FillGendersInComboBox();
            picture.ImageLocation = @"C:\Users\hanan\source\repos\KarateClub\Resources\employee.png";
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
            _User.Name = tbName.Text.ToString();
            _User.Address = tbAddress.Text.ToString();
            _User.Phone = tbPhone.Text.ToString();
            _User.UserName = tbUserName.Text.ToString();
            _User.Email = tbEmail.Text.ToString();
            _User.Password = tbPassword.Text.ToString();
            _User.DateOfBirth = dtpDateOfBirth.Value;
            _User.Permissions = _SetUserPermissions();

            if (cbGender.SelectedItem.ToString() == "Male")
                _User.Gender = 'M';
            else
                _User.Gender = 'F';

            if (picture.ImageLocation != @"C:\Users\hanan\source\repos\KarateClub\Resources\employee.png")
                _User.ImagePath = picture.ImageLocation;
            else
                _User.ImagePath = "";

            return _User.Save();
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

        private void tbUserName_Validating(object sender, CancelEventArgs e)
        {
            string UserName = tbUserName.Text.ToString();

            if (clsUser.IsUserExist(UserName))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbUserName, "This UserName is already existed");
                tbUserName.Focus();
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbUserName, "");
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
            picture.ImageLocation = @"C:\Users\hanan\source\repos\KarateClub\Resources\employee.png";
            lbRemove.Visible = false;
            lbSetImage.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (_SaveData())
                {
                    MessageBox.Show($"New User is added successfully with UserID  : [{_User.UserID}]",
                   "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Failed to add the new User ",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                _Refresh();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void cbAllPermissions_CheckedChanged(object sender, EventArgs e)
        {
            pnlPermissions.Enabled = cbAllPermissions.Checked ? false : true;

            foreach (CheckBox checkBox in pnlPermissions.Controls)
            {
                checkBox.Checked = cbAllPermissions.Checked ? true : false;
            }
        }

    }
}
