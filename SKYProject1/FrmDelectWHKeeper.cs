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
    public partial class FrmDelectWHKeeper : Form
    {
        public FrmDelectWHKeeper()
        {
            InitializeComponent();
        }
        public FrmDelectWHKeeper(string uid)
        {
            this.uid = uid;
            InitializeComponent();
        }
        private string uid = null;
        private string strCon = @"server=.\SQL2014;database=SkyProject;uid=sa;password=123";
        private string strSQL = null;
        private void btnSave_Click(object sender, EventArgs e)
        {
            strSQL = "delect from  Keeper where uid=@uid";
            using (SqlConnection con=new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL,con);
                con.Open();
                cmd.Parameters.AddWithValue("@uid",uid);
                int num = cmd.ExecuteNonQuery();
                if(num>0)
                {
                    MessageBox.Show("操作成功！");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("操作失败！");
                }
            }
        }

        private void FrmDelectWHKeeper_Load(object sender, EventArgs e)
        {
            strSQL = "select * from Keeper where Uid=@uid";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@uid", uid);
                SqlDataReader reader = cmd.ExecuteReader();
                this.lblUid.Text = reader.GetString(reader.GetOrdinal("Uid"));
                this.lblPassword.Text = reader.GetString(reader.GetOrdinal("Password"));
                this.lblKeeperName.Text = reader.GetString(reader.GetOrdinal("KeeperName"));
                this.lblSex.Text = reader.GetString(reader.GetOrdinal("Sex"));
                this.lblTelephone.Text = reader.GetString(reader.GetOrdinal("Telephone"));
                this.lblIDNumber.Text = reader.GetString(reader.GetOrdinal("IDNumber"));
                this.lblAddress.Text = reader.GetString(reader.GetOrdinal("Address"));
                reader.Close();
                con.Close();
            }
        }
    }
}
