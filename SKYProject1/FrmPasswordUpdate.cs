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
    public partial class FrmPasswordUpdate : Form
    {
        public FrmPasswordUpdate()
        {
            InitializeComponent();
        }
        private string uid = null;
        string passWord = null;
        private DBHelper helper = new DBHelper();
        private string strSQL = null;
        private void MyClear()
        {
            this.txtPassword.Clear();
            this.txtPasswordOld.Clear();
            this.txtPasswordSure.Clear();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            strSQL = "select password from Keeper where Uid=@uid";
            using (SqlDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text,
                new SqlParameter("@uid", uid)))
            {
                if(reader.Read())
                {
                     passWord = reader.GetString(reader.GetOrdinal("PassWord"));
                }
            }
            if(this.txtPasswordOld.Text.Trim()==passWord)
            {
                if(this.txtPassword.Text.Trim()==this.txtPasswordSure.Text.Trim())
                {
                    strSQL = "update Keeper set passWord=@passWord";
                    int num = helper.ExecuteNonQuery(strSQL,CommandType.Text,
                        new SqlParameter("@passWord",this.txtPasswordSure.Text.Trim()));
                    if(num>0)
                    {
                        MessageBox.Show("操作成功！");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("操作失败！");
                        MyClear();
                    }
                }
            }
            else
            {
                this.erpTest.SetError(this.txtPasswordOld,"密码错误，请重新输入!");
                this.txtPasswordOld.Focus();
                return;
            }
        }
    }
}
