using KarateClubBusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace KarateClub
{
    public partial class frmUserLogin : Form
    {
        private bool _LoginFailed = false;
        private short _FailedLoginCount = 0;

        private string _UserName = "";
        private string _Password = "";
        public frmUserLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tb_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrEmpty(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                errorProvider1.SetError(textBox, "This field cannot be left blank !");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, "");
            }
        }

        private void _Refresh()
        {
            errorProvider1.Clear();
            tbUserName.ResetText();
            tbPassword.ResetText();
            lblFailedLoginMsg.ResetText();
            lblFailedLoginMsg.Visible = false;
            pbErrorIcon.Visible = false;
            _LoginFailed = false;
            _FailedLoginCount = 0;
        }

        private bool _Login(string UserName, string Password, ref short FailedLoginCount)
        {
            clsGlobalUser.CurrentUser = clsUser.Find(UserName, Password);

            if (clsGlobalUser.CurrentUser == null)
            {
                FailedLoginCount++;

                pbErrorIcon.Visible = true;
                lblFailedLoginMsg.Visible = true;
                lblFailedLoginMsg.Text = "Invalid Username / Password " + $"You have ({3 - FailedLoginCount}) Trail(s) to login !";
                return false;
            }

            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                _UserName = tbUserName.Text.Trim();
                _Password = tbPassword.Text.Trim();
                _LoginFailed = !(_Login(_UserName, _Password, ref _FailedLoginCount));

                if (!_LoginFailed)
                {
                    Form Main = new frmHome();
                    this.Hide();
                    Main.Show();
                }

                else
                {
                    if (_FailedLoginCount == 3)
                    {
                        MessageBox.Show("Your are Locked after 3 failed trails !", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        _Refresh();
                    }

                    else
                        return;
                }
            }
        }

        private void btnMemberLogin_Click(object sender, EventArgs e)
        {
            Form MemberLogin = new frmMemberLogin();
            this.Hide();
            MemberLogin.Show();
        }
    }
}
