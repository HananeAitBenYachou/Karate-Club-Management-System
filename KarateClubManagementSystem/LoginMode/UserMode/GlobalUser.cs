using KarateClubBusinessLayer;
using System.Windows.Forms;

namespace KarateClub
{
    public static class clsGlobalUser
    {
        private static clsUser _CurrentUser = clsUser.Find("", "");

        public static clsUser CurrentUser
        {
            set
            {
                _CurrentUser = value;
            }

            get
            {
                return _CurrentUser;
            }
        }

        public static bool CheckAccessRights(clsUser.enUsersPermissions Permission)
        {
            if (!CurrentUser.CheckAccessPermissions(Permission))
            {
                //MessageBox.Show("Access Denied! Please contact your Admin", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Form frm = new frmAccessDenied();
                frm.Show();
                return false;
            }

            return true;
        }

    }
}
