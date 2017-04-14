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
    public partial class FrmKeeperUpdate : Form
    {
        public FrmKeeperUpdate()
        {
            InitializeComponent();
        }
        public FrmKeeperUpdate(string uid)
        {
            this.uid = uid;
            InitializeComponent();
        }
        private string uid = null;
        private string strSQL = null;
        private DBHelper helper = new DBHelper();
        private void FrmUpdateKeeper_Load(object sender, EventArgs e)
        {
            strSQL = "select Uid,KeeperName,Sex,Telephone,IDNumber,Address from Keeper where Uid=@uid ";
            using (SqlDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text,
                new SqlParameter("@uid", uid)))
            {
                if (reader.Read())
                {
                    this.txtUid.Text = reader.GetString(reader.GetOrdinal("Uid"));
                    this.txtKeeperName.Text = reader.GetString(reader.GetOrdinal("KeeperName"));
                    string sex = reader.GetString(reader.GetOrdinal("Sex"));
                    if(sex=="男")
                    {
                        this.rboMale.Checked = true;
                    }
                    else
                    {
                        this.rboFeMale.Checked = true;
                    }
                    this.txtTelephone.Text = reader.GetString(reader.GetOrdinal("Telephone"));
                    this.txtIDNumber.Text = reader.GetString(reader.GetOrdinal("IDNumber"));
                    this.txtAddress.Text = reader.GetString(reader.GetOrdinal("Address")); 
                }
                reader.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            strSQL = "Update Keeper set KeeperName=@keeperName,Sex=@sex,Telephone=@telephone,IDNumber=@idNumber,Address=@address where Uid=@uid";
            int num = helper.ExecuteNonQuery(strSQL,CommandType.Text,
                new SqlParameter("@uid", this.txtUid.Text.Trim()),
                new SqlParameter("@keeperName", this.txtKeeperName.Text.Trim()),
                new SqlParameter("@sex", this.rboMale.Checked?this.rboMale.Text:this.rboFeMale.Text),
                new SqlParameter("@telephone", this.txtTelephone.Text.Trim()),
                new SqlParameter("@idNumber", this.txtIDNumber.Text.Trim()),
                new SqlParameter("@address", this.txtAddress.Text.Trim()));
            if (num > 0)
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
