using KarateClubBusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace KarateClub.ManageBeltRanks
{
    public partial class frmAddBeltRank : Form
    {
        clsBeltRank _BeltRank = new clsBeltRank();

        public frmAddBeltRank()
        {
            InitializeComponent();
        }

        private void frmAddBeltRank_Load(object sender, EventArgs e)
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
            errorProvider1.Clear();
            picture.ImageLocation = @"C:\Users\hanan\source\repos\KarateClub\Resources\Belts.png";
        }

        private bool _SaveData()
        {
            _BeltRank.RankName = tbName.Text.ToString();
            _BeltRank.TestFees = Convert.ToDouble(tbTestFees.Text.ToString());
            return _BeltRank.Save();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (_SaveData())
                {
                    MessageBox.Show($"New BeltRank is added successfully with BeltRankID  : [{_BeltRank.RankID}]",
                   "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Failed to add the new BeltRank ",
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
