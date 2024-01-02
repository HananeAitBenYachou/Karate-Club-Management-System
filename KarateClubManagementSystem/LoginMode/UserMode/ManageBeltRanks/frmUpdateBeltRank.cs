using KarateClubBusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace KarateClub.ManageBeltRanks
{
    public partial class frmUpdateBeltRank : Form
    {

        private clsBeltRank _BeltRank;

        private int _BeltRankID;
        private enum enBeltRankIDMode { ExternalID, InternalID };

        private enBeltRankIDMode _Mode;

        public frmUpdateBeltRank()
        {
            InitializeComponent();
            _Mode = enBeltRankIDMode.InternalID;
        }

        public frmUpdateBeltRank(int BeltRankID)
        {
            InitializeComponent();
            _Mode = enBeltRankIDMode.ExternalID;
            _BeltRankID = BeltRankID;
        }

        private void _FillPictureBoxWithImageBelt(string BeltRankName)
        {
            BeltRankName = BeltRankName.Replace(" ", "");
            string ImagePath = $@"C:\Users\hanan\source\repos\KarateClub\Resources\BeltRanksImages\{BeltRankName}.png";
            pictureBox.Load(ImagePath);

        }

        private void _LoadData()
        {
            panel.Enabled = true;
            _BeltRank = clsBeltRank.Find(_BeltRankID);

            tbBeltRankID.Text = _BeltRank.RankID.ToString();
            tbTestFees.Text = _BeltRank.TestFees.ToString();
            tbName.Text = _BeltRank.RankName;
            _FillPictureBoxWithImageBelt(_BeltRank.RankName);
        }

        private void _Refresh()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            _FillPictureBoxWithImageBelt("question");

            if (_Mode == enBeltRankIDMode.ExternalID)
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

        private bool _SaveData()
        {
            _BeltRank.TestFees = Convert.ToDouble(tbTestFees.Text.ToString());
            return _BeltRank.Save();
        }

        private void tbSearchValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchValue.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbSearchValue, "Please enter BeltRankID to update !");
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

        private void pbSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchValue.Text))
            {
                errorProvider1.SetError(tbSearchValue, "Please enter BeltRankID to update !");
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


            _BeltRankID = Convert.ToInt32(tbSearchValue.Text.ToString());

            if (!clsBeltRank.IsBeltRankExist(_BeltRankID))
            {
                MessageBox.Show($"No BeltRank with BeltRankID : [{_BeltRankID}] is found !");
                _Refresh();
            }

            else
                _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((_Mode == enBeltRankIDMode.InternalID && ValidateChildren()) || _Mode == enBeltRankIDMode.ExternalID)
            {
                if (_SaveData())
                {
                    MessageBox.Show($"BeltRank with BeltRankID : [{_BeltRank.RankID}] is updated successfully !",
                   "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Failed to update BeltRank with BeltRankID : [{_BeltRank.RankID}]",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                _Refresh();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void frmUpdateBeltRank_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

    }
}
