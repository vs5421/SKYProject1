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
    public partial class FrmUpdateKeeper : Form
    {
        public FrmUpdateKeeper()
        {
            InitializeComponent();
        }
        public FrmUpdateKeeper(string uid)
        {
            this.uid = uid;
            InitializeComponent();
        }
        private string uid = null;
        private string strCon = @"server=.\SQL2014;database=SkyProject;uid=sa;password=123";
        private string strSQL = null;
        private void FrmUpdateKeeper_Load(object sender, EventArgs e)
        {
            strSQL = "select Uid,KeeperName,Sex,Telephone,IDNumber,Address from Keeper where Uid=@uid ";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@uid", uid);
                SqlDataReader reader = cmd.ExecuteReader();
                this.lblUid.Text = reader.GetString(reader.GetOrdinal("Uid"));
                this.lblKeeperName.Text = reader.GetString(reader.GetOrdinal("KeeperName"));
                this.lblSex.Text = reader.GetString(reader.GetOrdinal("Sex"));
                this.lblTelephone.Text = reader.GetString(reader.GetOrdinal("Telephone"));
                this.lblIDNumber.Text = reader.GetString(reader.GetOrdinal("IDNumber"));
                this.lblAddress.Text = reader.GetString(reader.GetOrdinal("Address"));
                reader.Close();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            strSQL = "update Keeper set Uid=@uid,KeeperName=@keeperName,Sex=@sex,Telephone=@telephone,IDNumber=@idNumber,Address=@address from Keeper";
            using (SqlConnection con =new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL,con);
                con.Open();
                cmd.Parameters.AddWithValue("@uid",this.txtUid.Text.Trim());
                cmd.Parameters.AddWithValue("@keeperName", this.txtKeeperName.Text.Trim());
                cmd.Parameters.AddWithValue("@sex", this.cboSex.Text.Trim());
                cmd.Parameters.AddWithValue("@telephone", this.txtTelephone.Text.Trim());
                cmd.Parameters.AddWithValue("@idNumber", this.txtIDNumber.Text.Trim());
                cmd.Parameters.AddWithValue("@address", this.txtAddress.Text.Trim());
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
    }
}
