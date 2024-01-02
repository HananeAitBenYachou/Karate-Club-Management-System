using KarateClubBusinessLayer;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace KarateClub
{
    public partial class frmUpdateMember : Form
    {

        private clsMember _Member;

        private int _MemberID;
        private enum enMemberIDMode { ExternalID, InternalID };

        private enMemberIDMode _Mode;

        public frmUpdateMember()
        {
            InitializeComponent();
            _Mode = enMemberIDMode.InternalID;
        }

        public frmUpdateMember(int MemberID)
        {
            InitializeComponent();
            _Mode = enMemberIDMode.ExternalID;
            _MemberID = MemberID;
        }

        private void _LoadData()
        {
            panel.Enabled = true;

            _Member = clsMember.Find(_MemberID);

            tbMemberID.Text = _Member.MemberID.ToString();
            tbName.Text = _Member.Name;
            tbAddress.Text = _Member.Address;
            tbPhone.Text = _Member.Phone;
            tbEmergencyContact.Text = _Member.EmergencyContact;
            tbEmail.Text = _Member.Email;
            tbPassword.Text = _Member.Password;
            dtpDateOfBirth.Value = _Member.DateOfBirth;
            cbBeltRanks.SelectedIndex = cbBeltRanks.FindString(clsBeltRank.Find(_Member.LastBeltRankID).RankName);

            if (_Member.IsActive)
                rbActive.Checked = true;
            else
                rbInactive.Checked = true;

            if (_Member.Gender == 'M')
                cbGender.SelectedItem = "Male";
            else
                cbGender.SelectedItem = "Female";

            if (_Member.ImagePath != "")
            {
                picture.ImageLocation = _Member.ImagePath;
                lbRemove.Visible = true;
            }

            else
            {
                picture.ImageLocation = @"C:\Users\hanan\source\repos\KarateClub\Resources\boy.png";
                lbRemove.Visible = false;
            }
        }

        private void _Refresh()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            _FillGendersInComboBox();
            _FillBeltRanksInComboBox();
            picture.ImageLocation = @"C:\Users\hanan\source\repos\KarateClub\Resources\boy.png";
            lbSetImage.Visible = true;
            lbRemove.Visible = false;

            if (_Mode == enMemberIDMode.ExternalID)
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

        private void _FillBeltRanksInComboBox()
        {
            DataTable dataTable = clsBeltRank.ListBeltRanks();

            foreach (DataRow row in dataTable.Rows)
            {
                cbBeltRanks.Items.Add(row["RankName"]);
            }
        }

        private void _FillGendersInComboBox()
        {
            cbGender.Items.Add("Male");
            cbGender.Items.Add("Female");
        }

        private bool _SaveData()
        {
            int BeltRankID = clsBeltRank.Find(cbBeltRanks.Text.ToString()).RankID;

            _Member.Name = tbName.Text.ToString();
            _Member.Address = tbAddress.Text.ToString();
            _Member.Phone = tbPhone.Text.ToString();
            _Member.EmergencyContact = tbEmergencyContact.Text.ToString();
            _Member.Email = tbEmail.Text.ToString();
            _Member.Password = tbPassword.Text.ToString();
            _Member.DateOfBirth = dtpDateOfBirth.Value;
            _Member.IsActive = rbActive.Checked;
            _Member.LastBeltRankID = BeltRankID;

            if (cbGender.SelectedItem.ToString() == "Male")
                _Member.Gender = 'M';
            else
                _Member.Gender = 'F';

            if (picture.ImageLocation != @"C:\Users\hanan\source\repos\KarateClub\Resources\boy.png")
                _Member.ImagePath = picture.ImageLocation;
            else
                _Member.ImagePath = "";

            return _Member.Save();
        }

        private void tbSearchValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchValue.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbSearchValue, "Please enter MemberID to update !");
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
            picture.ImageLocation = @"C:\Users\hanan\source\repos\KarateClub\Resources\boy.png";
            lbRemove.Visible = false;
            lbSetImage.Visible = true;
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchValue.Text))
            {
                errorProvider1.SetError(tbSearchValue, "Please enter MemberID to update !");
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


            _MemberID = Convert.ToInt32(tbSearchValue.Text.ToString());

            if (!clsMember.IsMemberExist(_MemberID))
            {
                MessageBox.Show($"No Member with MemberID : [{_MemberID}] is found !");
                _Refresh();
            }

            else
                _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((_Mode == enMemberIDMode.InternalID && ValidateChildren()) || _Mode == enMemberIDMode.ExternalID)
            {
                if (_SaveData())
                {
                    MessageBox.Show($"Member with MemberID : [{_Member.MemberID}] is updated successfully !",
                   "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Failed to update Member with MemberID : [{_Member.MemberID}]",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                _Refresh();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void frmUpdateMember_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

    }
}
