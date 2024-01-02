using KarateClubBusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace KarateClub.ManageUsers
{
    public partial class frmUpdateUser : Form
    {

        private clsUser _User;

        private int _UserID;
        private enum enUserIDMode { ExternalID, InternalID };

        private enUserIDMode _Mode;

        public frmUpdateUser()
        {
            InitializeComponent();
            _Mode = enUserIDMode.InternalID;
        }

        public frmUpdateUser(int UserID)
        {
            InitializeComponent();
            _Mode = enUserIDMode.ExternalID;
            _UserID = UserID;
        }

        private void _CheckPermissionCheckBox(clsUser.enUsersPermissions Permission, CheckBox checkBox)
        {
            if (clsUser.CheckAccessPermissions(Permission, _User.Permissions))
                checkBox.Checked = true;

        }

        private void _CheckPermissionsCheckBoxes()
        {
            if (clsUser.CheckAccessPermissions(clsUser.enUsersPermissions.eAll, _User.Permissions))
            {
                cbAllPermissions.Checked = true;
                return;
            }

            else
            {
                _CheckPermissionCheckBox(clsUser.enUsersPermissions.eManageMembers, cbManageMembers);
                _CheckPermissionCheckBox(clsUser.enUsersPermissions.eManageUsers, cbManageUsers);
                _CheckPermissionCheckBox(clsUser.enUsersPermissions.eManageInstructors, cbManageInstructors);
                _CheckPermissionCheckBox(clsUser.enUsersPermissions.eManageMemberInstructors, cbManageMemberInstructors);
                _CheckPermissionCheckBox(clsUser.enUsersPermissions.eManageBeltTests, cbManageBeltTests);
                _CheckPermissionCheckBox(clsUser.enUsersPermissions.eManageSubscriptions, cbManageSubscriptions);
                _CheckPermissionCheckBox(clsUser.enUsersPermissions.eManageBeltTests, cbManageBeltTests);
                _CheckPermissionCheckBox(clsUser.enUsersPermissions.eManagePayments, cbManagePayments);
            }
        }

        private void _LoadUserPermissions()
        {
            _CheckPermissionsCheckBoxes();
        }

        private void _LoadData()
        {
            panel.Enabled = true;

            _User = clsUser.Find(_UserID);

            if (_User.UserName == "Admin")
                gbPermissions.Enabled = false;

            else
                gbPermissions.Enabled = true;

            tbUserID.Text = _User.UserID.ToString();
            tbName.Text = _User.Name;
            tbUserName.Text = _User.UserName;
            tbAddress.Text = _User.Address;
            tbPhone.Text = _User.Phone;
            tbEmail.Text = _User.Email;
            tbPassword.Text = _User.Password;
            dtpDateOfBirth.Value = _User.DateOfBirth;
            _LoadUserPermissions();

            if (_User.Gender == 'M')
                cbGender.SelectedItem = "Male";
            else
                cbGender.SelectedItem = "Female";

            if (_User.ImagePath != "")
            {
                picture.ImageLocation = _User.ImagePath;
                lbRemove.Visible = true;
            }

            else
            {
                picture.ImageLocation = @"C:\Users\hanan\source\repos\KarateClub\Resources\employee.png";
                lbRemove.Visible = false;
            }
        }

        private void _Refresh()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            _FillGendersInComboBox();

            picture.ImageLocation = @"C:\Users\hanan\source\repos\KarateClub\Resources\employee.png";
            lbSetImage.Visible = true;
            lbRemove.Visible = false;

            if (_Mode == enUserIDMode.ExternalID)
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

        private bool _SaveData()
        {
            _User.Name = tbName.Text.ToString();
            _User.Address = tbAddress.Text.ToString();
            _User.Phone = tbPhone.Text.ToString();
            _User.Email = tbEmail.Text.ToString();
            _User.Password = tbPassword.Text.ToString();
            _User.DateOfBirth = dtpDateOfBirth.Value;
            _User.Permissions = _SetUserPermissions();
            if (cbGender.SelectedItem.ToString() == "Male")
                _User.Gender = 'M';
            else
                _User.Gender = 'F';

            if (picture.ImageLocation != @"C:\Users\hanan\source\repos\KarateClub\Resources\Instructor (2).png")
                _User.ImagePath = picture.ImageLocation;
            else
                _User.ImagePath = "";

            return _User.Save();
        }

        private void tbSearchValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchValue.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbSearchValue, "Please enter UserID to update !");
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

        private void tbUserName_Validating(object sender, CancelEventArgs e)
        {
            string UserName = tbUserName.Text.ToString();

            if (clsUser.IsUserExist(UserName, _User.UserID))
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

        private void cbAllPermissions_CheckedChanged(object sender, EventArgs e)
        {
            pnlPermissions.Enabled = cbAllPermissions.Checked ? false : true;

            foreach (CheckBox checkBox in pnlPermissions.Controls)
            {
                checkBox.Checked = cbAllPermissions.Checked ? true : false;
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

        private void pbSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchValue.Text))
            {
                errorProvider1.SetError(tbSearchValue, "Please enter UserID to update !");
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

            cbAllPermissions.Checked = false;

            _UserID = Convert.ToInt32(tbSearchValue.Text.ToString());

            if (!clsUser.IsUserExist(_UserID))
            {
                MessageBox.Show($"No User with UserID : [{_UserID}] is found !");
                _Refresh();
            }

            else
                _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((_Mode == enUserIDMode.InternalID && ValidateChildren()) || _Mode == enUserIDMode.ExternalID)
            {
                if (_SaveData())
                {
                    MessageBox.Show($"User with UserID : [{_User.UserID}] is updated successfully !",
                   "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Failed to update User with UserID : [{_User.UserID}]",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                _Refresh();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void frmUpdateUser_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

    }
}
