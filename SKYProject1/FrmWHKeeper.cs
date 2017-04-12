using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SKYProject1
{
    public partial class FrmWHKeeper : Form
    {
        public FrmWHKeeper()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddWHKeeper fa = new FrmAddWHKeeper();
            fa.Show();
        }
        private string strCon = @"server=.\SQL2014;database=SkyProject;uid=sa;password=123";
        private string strSQL = null;
        private void FrmWHKeeper_Load(object sender, EventArgs e)
        {
          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string uid = this.cboUid.Text.Trim();
            MessageBox.Show(uid);
            FrmDelectWHKeeper fdk = new FrmDelectWHKeeper(uid);
            fdk.Show();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            FrmSelectKeeper fsk=new FrmSelectKeeper();
            fsk.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmUpdateKeeper fuk = new FrmUpdateKeeper();
            fuk.Show();
        }

        private void FrmWHKeeper_Activated(object sender, EventArgs e)
        {
            strSQL = "select uid from Keeper";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    this.cboUid.Items.Add(reader.GetString(reader.GetOrdinal("Uid")));
                }
            }
        }
    }
}
