using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKYProject1
{
    public partial class FrmShop : Form
    {
        public FrmShop()
        {
            InitializeComponent();
        }

        private void ChangeThePasswordTSMI_Click(object sender, EventArgs e)
        {
            FrmClerkModifyPassword f = new FrmClerkModifyPassword();
            f.MdiParent = this;
            f.Show();
        }

        private void ClerkManagementTSMI_Click(object sender, EventArgs e)
        {
            FrmClerkPrint f = new FrmClerkPrint();
            f.MdiParent = this;
            f.Show();
        }

        private void ClientManagementTSMI_Click(object sender, EventArgs e)
        {
            FrmClient f = new FrmClient();
            f.MdiParent = this;
            f.Show();
        }
    }
}
