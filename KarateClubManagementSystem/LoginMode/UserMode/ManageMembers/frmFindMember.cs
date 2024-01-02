using KarateClubBusinessLayer;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace KarateClub.ManageMembers
{
    public partial class frmFindMember : Form
    {
        private enum enMemberIDMode { ExternalID, InternalID };

        private enMemberIDMode _Mode;

        private clsMember _Member;

        private int _MemberID;

        public frmFindMember()
        {
            InitializeComponent();
            _Mode = enMemberIDMode.InternalID;
        }

        public frmFindMember(int MemberID)
        {
            InitializeComponent();
            _Mode = enMemberIDMode.ExternalID;
            _MemberID = MemberID;
        }

        private void _LoadData()
        {
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
            }

            else
            {
                picture.ImageLocation = @"C:\Users\hanan\source\repos\KarateClub\Resources\boy.png";
            }
        }

        private void _Refresh()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            _FillGendersInComboBox();
            _FillBeltRanksInComboBox();
            picture.ImageLocation = @"C:\Users\hanan\source\repos\KarateClub\Resources\boy.png";

            if (_Mode == enMemberIDMode.ExternalID)
            {
                tbSearchValue.Visible = false;
                pbSearch.Visible = false;
                lbl.Visible = false;
                _LoadData();
            }
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

        private void pbSearch_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                _MemberID = Convert.ToInt32(tbSearchValue.Text.ToString());

                if (!clsMember.IsMemberExist(_MemberID))
                {
                    MessageBox.Show($"No Member with MemberID : [{_MemberID}] is found !");
                    _Refresh();
                }

                else
                    _LoadData();
            }
        }

        private void frmFindMember_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

    }
}
