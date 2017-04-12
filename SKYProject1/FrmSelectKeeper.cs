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
    public partial class FrmSelectKeeper : Form
    {
        public FrmSelectKeeper()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private string strCon = @"server=.\SQL2014;database=SkyProject;uid=sa;password=123";
        private string strSQL = null;
        private void FrmSelectKeeper_Load(object sender, EventArgs e)
        {
            strSQL = "select Uid,KeeperName,Sex,Telephone,IDNumber,Address from Keeper";
            using (SqlConnection con =new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL,con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    string uid = reader.GetString(reader.GetOrdinal("Uid"));
                    string keeperName = reader.GetString(reader.GetOrdinal("KeeperName"));
                    string sex = reader.GetString(reader.GetOrdinal("Sex"));
                    string telePhone = reader.GetString(reader.GetOrdinal("TelePhone"));
                    string idNumber = reader.GetString(reader.GetOrdinal("IDNumber"));
                    string address = reader.GetString(reader.GetOrdinal("Address"));

                    ListViewItem list = new ListViewItem(uid);
                    list.SubItems.Add(keeperName);
                    list.SubItems.Add(sex);
                    list.SubItems.Add(telePhone);
                    list.SubItems.Add(idNumber);
                    list.SubItems.Add(address);
                    this.livShow.Items.Add(list);
                }
            }
        }
    }
}
