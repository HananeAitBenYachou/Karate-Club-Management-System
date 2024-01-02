using System;
using System.Windows.Forms;

namespace KarateClub
{
    public partial class frmAccessDenied : Form
    {
        public frmAccessDenied()
        {
            InitializeComponent();
        }

        private void btnOkClick_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
