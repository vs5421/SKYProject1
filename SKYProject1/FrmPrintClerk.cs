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
    public partial class FrmPrintClerk : Form
    {
        public FrmPrintClerk()
        {
            InitializeComponent();
        }
        string strCon = @"server=.\SQL2014;database=SkyProject;uid=sa;password=123";
        private void FrmPrintClerk_EnabledChanged(object sender, EventArgs e)
        {
           
        }

        private void FrmPrintClerk_Load(object sender, EventArgs e)
        {
            string strSQL = "select Uid,ClerkName,Sex,Telephone,IDNumber,Address from Clerk";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string Uid = reader.GetString(reader.GetOrdinal("Uid"));
                    string ClerkName = reader.GetString(reader.GetOrdinal("ClerkName"));
                    string sex = reader.GetString(reader.GetOrdinal("sex"));
                    string TelePhone = reader.GetString(reader.GetOrdinal("TelePhone"));
                    string IDNumber = reader.GetString(reader.GetOrdinal("IDNumber"));
                    string Address = reader.GetString(reader.GetOrdinal("Address"));
                    ListViewItem list = new ListViewItem(Uid);
                    list.SubItems.Add(ClerkName);
                    list.SubItems.Add(sex);
                    list.SubItems.Add(TelePhone);
                    list.SubItems.Add(IDNumber);
                    list.SubItems.Add(Address);
                    this.listView1.Items.Add(list);
                }
                reader.Close();
                con.Close();
            }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            FrmAddClerk f = new FrmAddClerk();
            f.ShowDialog();
            FrmPrintClerk_Load(sender, e);
        }

        private void 修改详细信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmModifyClerk f = new FrmModifyClerk();
            f.ShowDialog();
            FrmPrintClerk_Load(sender, e);
        }
    }
}
