using KarateClub.ManagePayments;
using KarateClubBusinessLayer;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KarateClub.LoginMode.MemberMode
{
    public partial class frmMemberPayments : Form
    {
        public frmMemberPayments()
        {
            InitializeComponent();
        }
        private enum enSearchByOptions { ePaymentID };

        private enSearchByOptions _SearchByOption;

        private string _SearchFilter;

        private enSearchByOptions _GetSearchByOption()
        {
            switch (cbSearchByOptions.SelectedItem)
            {
                case "PaymentID":
                    return enSearchByOptions.ePaymentID;
            }
            return enSearchByOptions.ePaymentID;

        }

        private void dgvPaymentsList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                e.Graphics.FillRectangle(Brushes.DarkOrange, e.CellBounds);
                e.PaintContent(e.CellBounds);
                e.Handled = true;
            }
        }

        private void frmPaymentsList_Load(object sender, EventArgs e)
        {
            cbSearchByOptions.SelectedItem = "PaymentID";
            _Refresh();
        }

        private void _RefreshPaymentsList()
        {
            DataView dataView = clsPayment.ListPayments().DefaultView;
            dataView.RowFilter = "MemberName = '" + clsGlobalMember.CurrentMember.Name + "'";
            dgvPaymentsList.DataSource = dataView;
            dgvPaymentsList.ClearSelection();
        }

        private void _Refresh()
        {
            tbSearchValue.ResetText();
            _RefreshPaymentsList();
        }

        private void _SearchPayment()
        {
            DataView dataView = clsPayment.ListPayments().DefaultView;

            switch (_SearchByOption)
            {
                case enSearchByOptions.ePaymentID:

                    if (!int.TryParse(_SearchFilter, out int _))
                    {
                        MessageBox.Show("Please Enter Numbers Only ! ", "Invalid Input ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _Refresh();
                        return;
                    }
                    dataView.RowFilter = "PaymentID = " + _SearchFilter + "AND MemberName = '" + clsGlobalMember.CurrentMember.Name + "'";
                    break;

            }

            dgvPaymentsList.DataSource = dataView;
        }

        private void tbSearchValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchValue.Text.ToString()))
            {
                _Refresh();
                return;
            }

            else
                _SearchFilter = tbSearchValue.Text.ToString();
            _SearchPayment();

        }

        private void cbSearchByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SearchByOption = _GetSearchByOption();
        }

        private void dgvPaymentsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPaymentsList.SelectedRows.Count > 0)
            {
                int PaymentID = Convert.ToInt32(dgvPaymentsList.SelectedRows[0].Cells[0].Value);

                Form myForm = new frmFindPayment(PaymentID);

                myForm.ShowDialog();
            }
        }

        private void displayDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPaymentsList.SelectedRows.Count > 0)
            {
                int PaymentID = Convert.ToInt32(dgvPaymentsList.SelectedRows[0].Cells[0].Value);

                Form myForm = new frmFindPayment(PaymentID);

                myForm.ShowDialog();
            }
        }

        private void dgvPaymentsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvPaymentsList.Columns)
            {
                column.Width = 250;
            }
        }
    }
}
