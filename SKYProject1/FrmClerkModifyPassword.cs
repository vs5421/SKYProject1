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
using System.Text.RegularExpressions;

namespace SKYProject1
{
    public partial class FrmClerkModifyPassword : Form
    {
        public FrmClerkModifyPassword()
        {
            InitializeComponent();
        }
        public FrmClerkModifyPassword(string Uid)
        {
            InitializeComponent();
            this.Uid = Uid;
        }
        string Uid;
        DBHelper helper = new DBHelper();

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
            if (Regex.IsMatch(txtPasswordNew.Text.Trim(), @"^[ ]*$") == true)
            {
                this.errorProvider1.SetError(txtPasswordNew, "不能空！");
                this.txtPasswordNew.Focus();
                return;
            }
            if (txtPasswordNewss.Text != txtPasswordNew.Text)
            {
                this.errorProvider1.SetError(txtPasswordNew, "两次密码不一致！");
                this.txtPasswordNewss.Focus();
                return;
            }
            string strSQL = "select Password from Clerk where Uid=@Uid";
            object obj = helper.ExecuteScalar(strSQL, CommandType.Text, new SqlParameter("@Uid", Uid));
            if(obj.ToString()==txtPasswordOld.Text)
            {
                strSQL = "update Clerk set Password=@Password where Uid=@uid";
                int rows = helper.ExecuteNonQuery(strSQL, CommandType.Text, new SqlParameter("@Uid", Uid), new SqlParameter("@Password", txtPasswordNew.Text));
                if (rows > 0)
                {
                    MessageBox.Show("修改成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
        }
    }
}
