using KarateClubBusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace KarateClub.ManageUsers
{
    public partial class frmFindUser : Form
    {
        private enum enUserIDMode { ExternalID, InternalID };

        private enUserIDMode _Mode;

        private clsUser _User;

        private int _UserID;

        public frmFindUser()
        {
            InitializeComponent();
            _Mode = enUserIDMode.InternalID;
        }

        public frmFindUser(int UserID)
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

        private void cbAllPermissions_CheckedChanged(object sender, EventArgs e)
        {
            pnlPermissions.Enabled = cbAllPermissions.Checked ? false : true;

            foreach (CheckBox checkBox in pnlPermissions.Controls)
            {
                checkBox.Checked = cbAllPermissions.Checked ? true : false;
            }
        }

        private void _LoadData()
        {
            _User = clsUser.Find(_UserID);

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
            }

            else
            {
                picture.ImageLocation = @"C:\Users\hanan\source\repos\KarateClub\Resources\employee.png";
            }
        }

        private void _Refresh()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            _FillGendersInComboBox();
            picture.ImageLocation = @"C:\Users\hanan\source\repos\KarateClub\Resources\employee.png";

            if (_Mode == enUserIDMode.ExternalID)
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

        private void pbSearch_Click(object sender, EventArgs e)
        {
            cbAllPermissions.Checked = false;

            if (ValidateChildren())
            {
                _UserID = Convert.ToInt32(tbSearchValue.Text.ToString());

                if (!clsUser.IsUserExist(_UserID))
                {
                    MessageBox.Show($"No User with UserID : [{_UserID}] is found !");
                    _Refresh();
                }

                else
                    _LoadData();
            }
        }

        private void frmFindUser_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

    }
}
