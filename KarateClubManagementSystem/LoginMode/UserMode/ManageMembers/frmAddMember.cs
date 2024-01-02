using KarateClubBusinessLayer;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace KarateClub
{
    public partial class frmAddMember : Form
    {
        clsMember _Member = new clsMember();

        public frmAddMember()
        {
            InitializeComponent();
        }

        private void frmAddMember_Load(object sender, EventArgs e)
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
            cbGender.Items.Clear();
            cbBeltRanks.Items.Clear();
            _FillGendersInComboBox();
            _FillBeltRanksInComboBox();
            errorProvider1.Clear();
            _ResetTextBoxes();
            picture.ImageLocation = @"C:\Users\hanan\source\repos\KarateClub\Resources\boy.png";
            lbSetImage.Visible = true;
            lbRemove.Visible = false;
            rbActive.Select();
            cbGender.SelectedIndex = 0;
            cbBeltRanks.SelectedIndex = 0;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (_SaveData())
                {
                    MessageBox.Show($"New member is added successfully with MemberID  : [{_Member.MemberID}]",
                   "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Failed to add the new member ",
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
