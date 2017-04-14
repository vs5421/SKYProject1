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
    public partial class FrmKeeperInsert : Form
    {
        public FrmKeeperInsert()
        {
            InitializeComponent();
        }

        private void FrmAddWHKeeper_Load(object sender, EventArgs e)
        {
            this.rboMale.Checked = true;

        }
        private void MyClear()
        {
            this.txtUid.Clear();
            this.txtPassword.Clear();
            this.txtKeeperName.Clear();
            this.rboMale.Checked =true;
            this.txtTelephone.Clear();
            this.txtIDNumber.Clear();
            this.txtAddress.Clear();
        }

        private DBHelper helper = new DBHelper();
        private string strSQL = null;
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.erpTest.Clear();
            string userName = this.txtUid.Text.Trim();
            string passWord = this.txtPassword.Text.Trim();
            string name = this.txtKeeperName.Text.Trim();
            string sex = this.rboMale.Checked ? this.rboMale.Text : this.rboFeMale.Text;
            string phoneNo = this.txtTelephone.Text.Trim();
            string cardId = this.txtIDNumber.Text.Trim();
            string address = this.txtAddress.Text.Trim();
            //非空判断
            if (string.IsNullOrWhiteSpace(userName))
            {
                this.erpTest.SetError(this.txtUid, "用户名不能为空！");
                this.txtUid.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(passWord))
            {
                this.erpTest.SetError(this.txtPassword, "密码不能为空！");
                this.txtPassword.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                this.erpTest.SetError(this.txtKeeperName, "姓名不能为空！");
                this.txtKeeperName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(phoneNo))
            {
                this.erpTest.SetError(this.txtTelephone, "电话不能为空！");
                this.txtTelephone.Focus();
                return;
            }
            if (Regex.IsMatch(this.txtTelephone.Text, @"^[0-9]{11}$") == false)
            {
                this.erpTest.SetError(this.txtTelephone, "电话格式不正确！");
                this.txtTelephone.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cardId))
            {
                this.erpTest.SetError(this.txtIDNumber, "身份证不能为空！");
                this.txtIDNumber.Focus();
                return;
            }
            if (Regex.IsMatch(this.txtIDNumber.Text, @"^[1-9][0-9]{16}[0-9Xx]$") == false)
            {
                this.erpTest.SetError(this.txtIDNumber, "身份证格式不正确！");
                this.txtIDNumber.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(address))
            {
                this.erpTest.SetError(this.txtAddress, "家庭住址不能为空！");
                this.txtAddress.Focus();
                return;
            }
            strSQL = "select count(*) from Keeper where Uid=@uid";
            object obj = helper.ExecuteScalar(strSQL,CommandType.Text,new SqlParameter("@uid", userName));
            int row = int.Parse(obj.ToString());
            if(row!=0)
            {
                this.erpTest.SetError(this.txtUid,"已存在该用户！");
                this.txtKeeperName.Focus();
                return;
            }
            //连接数据库
            strSQL = "insert into Keeper(Uid,PassWord,KeeperName,Sex,Telephone,IDNumber,Address )" +
                    " values(@Uid,@Password,@KeeperName,@Sex,@Telephone,@IDNumber,@Address) ";
            int num = helper.ExecuteNonQuery(strSQL, CommandType.Text,
                new SqlParameter("@Uid", userName),
                new SqlParameter("@Password", passWord),
                new SqlParameter("@KeeperName", name),
                new SqlParameter("@Sex", sex),
                new SqlParameter("@Telephone", phoneNo),
                new SqlParameter("@IDNumber", cardId),
                new SqlParameter("@Address", address));
            if (num > 0)
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
}
