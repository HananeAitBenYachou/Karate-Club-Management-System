using KarateClubBusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace KarateClub.ManageBeltRanks
{
    public partial class frmFindBeltRank : Form
    {
        private enum enBeltRankIDMode { ExternalID, InternalID };

        private enBeltRankIDMode _Mode;

        private clsBeltRank _BeltRank;

        private int _BeltRankID;

        public frmFindBeltRank()
        {
            InitializeComponent();
            _Mode = enBeltRankIDMode.InternalID;
        }

        public frmFindBeltRank(int BeltRankID)
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
            _BeltRank = clsBeltRank.Find(_BeltRankID);

            tbBeltRankID.Text = _BeltRank.RankID.ToString();
            tbName.Text = _BeltRank.RankName;
            tbTestFees.Text = _BeltRank.TestFees.ToString();

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
                _LoadData();
            }
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

        private void pbSearch_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                _BeltRankID = Convert.ToInt32(tbSearchValue.Text.ToString());

                if (!clsBeltRank.IsBeltRankExist(_BeltRankID))
                {
                    MessageBox.Show($"No BeltRank with BeltRankID : [{_BeltRankID}] is found !");
                    _Refresh();
                }

                else
                    _LoadData();
            }
        }

        private void frmFindBeltRank_Load(object sender, EventArgs e)
        {
            _Refresh();
        }
    }
}
