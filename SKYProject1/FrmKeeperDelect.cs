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
    public partial class FrmKeeperDelect : Form
    {
        public FrmKeeperDelect()
        {
            InitializeComponent();
        }
        public FrmKeeperDelect(string uid)
        {
            this.uid = uid;
            InitializeComponent();
        }
        private string uid = null;
        private string strSQL = null;
        private DBHelper helper = new DBHelper();

        private void btnSave_Click(object sender, EventArgs e)
        {
            strSQL = "delete from  Keeper where uid=@uid";
            int num = helper.ExecuteNonQuery(strSQL, CommandType.Text,
                new SqlParameter("@uid", uid));
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

        private void FrmDelectWHKeeper_Load(object sender, EventArgs e)
        {
            strSQL = "select * from Keeper where Uid=@uid";
            using (SqlDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text,
                new SqlParameter("@uid", uid)))
            {
                if (reader.Read())
                {
                    this.lblUid.Text = reader.GetString(reader.GetOrdinal("Uid"));
                    this.lblKeeperName.Text = reader.GetString(reader.GetOrdinal("KeeperName"));
                    this.lblSex.Text = reader.GetString(reader.GetOrdinal("Sex"));
                    this.lblTelephone.Text = reader.GetString(reader.GetOrdinal("Telephone"));
                    this.lblIDNumber.Text = reader.GetString(reader.GetOrdinal("IDNumber"));
                    this.lblAddress.Text = reader.GetString(reader.GetOrdinal("Address"));
                }
                reader.Close();
            }
        }
    }
}
