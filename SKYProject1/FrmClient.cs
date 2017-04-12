using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace SKYProject1
{
    public partial class FrmClient : Form
    {
        public FrmClient()
        {
            InitializeComponent();
        }

        private string myCon = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        

        private void FrmClient_Load(object sender, EventArgs e)
        {

        }
        private void ShowInformation()
        {

        }

        private void tsmiQuery_Click(object sender, EventArgs e)
        {

        }
    }
}
