﻿using KarateClub.ManageSubscriptions;
using KarateClubBusinessLayer;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KarateClub.LoginMode.MemberMode
{
    public partial class frmMemberSubscriptions : Form
    {
        public frmMemberSubscriptions()
        {
            InitializeComponent();
        }

        private enum enSearchByOptions { eSubscriptionPeriodID, eFees, eIsPaid };

        private enSearchByOptions _SearchByOption;

        private string _SearchFilter;

        private enSearchByOptions _GetSearchByOption()
        {
            switch (cbSearchByOptions.SelectedItem)
            {
                case "PeriodID":
                    return enSearchByOptions.eSubscriptionPeriodID;
                case "Fees":
                    return enSearchByOptions.eFees;
                case "IsPaid":
                    return enSearchByOptions.eIsPaid;
            }
            return enSearchByOptions.eSubscriptionPeriodID;

        }

        private void dgvSubscriptionsList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                e.Graphics.FillRectangle(Brushes.DarkOrange, e.CellBounds);
                e.PaintContent(e.CellBounds);
                e.Handled = true;
            }
        }

        private void frmSubscriptionsList_Load(object sender, EventArgs e)
        {
            cbSearchByOptions.SelectedItem = "PeriodID";
            _Refresh();
        }

        private void _RefreshSubscriptionsList()
        {
            DataView dataView = clsSubscriptionPeriod.ListSubscriptionPeriods().DefaultView;
            dataView.RowFilter = "MemberName = '" + clsGlobalMember.CurrentMember.Name + "'";
            dgvSubscriptionsList.DataSource = dataView;
            dgvSubscriptionsList.ClearSelection();
        }

        private void _Refresh()
        {
            tbSearchValue.ResetText();
            _RefreshSubscriptionsList();
        }

        private void _SearchSubscription()
        {
            DataView dataView = clsSubscriptionPeriod.ListSubscriptionPeriods().DefaultView;

            switch (_SearchByOption)
            {
                case enSearchByOptions.eSubscriptionPeriodID:

                    if (!int.TryParse(_SearchFilter, out int _))
                    {
                        MessageBox.Show("Please Enter Numbers Only ! ", "Invalid Input ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _Refresh();
                        return;
                    }
                    dataView.RowFilter = "PeriodID = " + _SearchFilter + "AND MemberName = '" + clsGlobalMember.CurrentMember.Name + "'";
                    break;

                case enSearchByOptions.eFees:
                    if (!double.TryParse(_SearchFilter, out double _))
                    {
                        MessageBox.Show("Please Enter Numbers Only ! ", "Invalid Input ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _Refresh();
                        return;
                    }
                    dataView.RowFilter = "Fees = " + _SearchFilter + "AND MemberName = '" + clsGlobalMember.CurrentMember.Name + "'";
                    break;

                case enSearchByOptions.eIsPaid:
                    if (!int.TryParse(_SearchFilter, out int _))
                    {
                        MessageBox.Show("Please Enter 1 for Paid , 0 for UnPaid", "Invalid Input ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _Refresh();
                        return;
                    }
                    dataView.RowFilter = "IsPaid = " + _SearchFilter + "AND MemberName = '" + clsGlobalMember.CurrentMember.Name + "'";
                    break;
            }

            dgvSubscriptionsList.DataSource = dataView;
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
            _SearchSubscription();

        }

        private void cbSearchByOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SearchByOption = _GetSearchByOption();
        }

        private void _PaySubscriptionPeriodFees(int SubscriptionID)
        {
            clsSubscriptionPeriod subscriptionPeriod = clsSubscriptionPeriod.Find(SubscriptionID);
            subscriptionPeriod.Paid = true;

            if (subscriptionPeriod.Save())
            {
                MessageBox.Show($"SubscriptionPeriod with SubscriptionID : [{SubscriptionID}] 's Fees is Paid successfully !", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
                MessageBox.Show($"Failed to Pay Subscription Fees with SubscriptionID : [{SubscriptionID}]", "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgvSubscriptionsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSubscriptionsList.SelectedRows.Count > 0)
            {
                int SubscriptionID = Convert.ToInt32(dgvSubscriptionsList.SelectedRows[0].Cells[0].Value);

                Form myForm = new frmFindSubscription(SubscriptionID);

                myForm.ShowDialog();
            }
        }

        private void displayDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvSubscriptionsList.SelectedRows.Count > 0)
            {
                int SubscriptionID = Convert.ToInt32(dgvSubscriptionsList.SelectedRows[0].Cells[0].Value);

                Form myForm = new frmFindSubscription(SubscriptionID);

                myForm.ShowDialog();
            }
        }

        private void dgvSubscriptionsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgvSubscriptionsList.Columns)
            {
                column.Width = 250;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgvSubscriptionsList.SelectedRows.Count > 0)
            {
                int SubscriptionID = Convert.ToInt32(dgvSubscriptionsList.SelectedRows[0].Cells[0].Value);
                bool isPaid = clsSubscriptionPeriod.IsSubscriptionPeriodPaid(SubscriptionID);

                if (isPaid)
                    paySubscriptionFeesToolStripMenuItem.Visible = false;
                else
                    paySubscriptionFeesToolStripMenuItem.Visible = true;
            }
        }

        private void paySubscriptionFeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvSubscriptionsList.SelectedRows.Count > 0)
            {
                int SubscriptionID = Convert.ToInt32(dgvSubscriptionsList.SelectedRows[0].Cells[0].Value);

                if (MessageBox.Show($"Are you sure to perform this payment operation ?",
                    "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    _PaySubscriptionPeriodFees(SubscriptionID);
                    _Refresh();
                }
            }
        }
    }
}
