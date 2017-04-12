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
    public partial class FrmAddWHKeeper : Form
    {
        public FrmAddWHKeeper()
        {
            InitializeComponent();
        }

        private void FrmAddWHKeeper_Load(object sender, EventArgs e)
        {

        }
        private void MyClear()
        {
            this.txtUid.Clear();
            this.txtPassword.Clear();
            this.txtKeeperName.Clear();
            this.cboSex.Text = "男";
            this.txtTelephone.Clear();
            this.txtIDNumber.Clear();
            this.txtAddress.Clear();
        }

        private string strCon = @"server=.\SQL2014;database=SkyProject;uid=sa;password=123";
        private string strSQL = null;
        private void btnSave_Click(object sender, EventArgs e)
        {
            string userName = this.txtUid.Text.Trim();
            string passWord = this.txtPassword.Text.Trim();
            string name = this.txtKeeperName.Text.Trim();
            string sex = this.cboSex.Text;
            string phoneNo = this.txtTelephone.Text.Trim();
            string cardId = this.txtIDNumber.Text.Trim();
            string address = this.txtAddress.Text.Trim();
            //非空判断
            if (!string.IsNullOrWhiteSpace(userName))
            {
                if (!string.IsNullOrWhiteSpace(passWord))
                {
                    if (!string.IsNullOrWhiteSpace(name))
                    {
                        if (!string.IsNullOrWhiteSpace(phoneNo))
                        {
                            if (!string.IsNullOrWhiteSpace(cardId))
                            {
                                if (!string.IsNullOrWhiteSpace(address))
                                { 
                                    //连接数据库
                                    using (SqlConnection con = new SqlConnection(strCon))
                                    {
                                        strSQL = "insert into Keeper(Uid,PassWord,KeeperName,Sex,Telephone,IDNumber,Address )" +
                                            " values(@Uid,@Password,@KeeperName,@Sex,@Telephone,@IDNumber,@Address) ";
                                        SqlCommand cmd = new SqlCommand(strSQL, con);
                                        con.Open();
                                        cmd.Parameters.AddWithValue("@Uid", userName);
                                        cmd.Parameters.AddWithValue("@Password", passWord);
                                        cmd.Parameters.AddWithValue("@KeeperName", name);
                                        cmd.Parameters.AddWithValue("@Sex", sex);
                                        cmd.Parameters.AddWithValue("@Telephone", phoneNo);
                                        cmd.Parameters.AddWithValue("@IDNumber", cardId);
                                        cmd.Parameters.AddWithValue("@Address", address);
                                        int row = cmd.ExecuteNonQuery();
                                        if (row > 0)
                                        {
                                            MessageBox.Show("操作成功！");
                                            this.Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("操作失败！");
                                            MyClear();
                                        }
                                        con.Close(); 
                                    }
                                }
                                else
                                {
                                    this.erpTest.SetError(this.txtAddress, "家庭住址不能为空！");
                                    this.txtAddress.Focus();
                                }
                            }
                            else
                            {
                                this.erpTest.SetError(this.txtIDNumber, "身份证不能为空！");
                                this.txtIDNumber.Focus();
                            }
                        }
                        else
                        {
                            this.erpTest.SetError(this.txtTelephone, "电话不能为空！");
                            this.txtTelephone.Focus();
                        }
                    }
                    else
                    {
                        this.erpTest.SetError(this.txtKeeperName, "姓名不能为空！");
                        this.txtKeeperName.Focus();
                    }
                }
                else
                {
                    this.erpTest.SetError(this.txtPassword, "密码不能为空！");
                    this.txtPassword.Focus();
                }
            }
            else
            {
                this.erpTest.SetError(this.txtUid, "用户名不能为空！");
                this.txtUid.Focus();
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if(Regex.IsMatch(this.txtUid.Text, @"^\w+$") == false)
            {
                this.erpTest.SetError(this.txtUid,"含非法字符，请重新输入！");
                this.txtUid.Focus();
            }
        }

        private void txtPassWord_Leave(object sender, EventArgs e)
        {

        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(this.txtKeeperName.Text, @"^\w+$") == false)
            {
                this.erpTest.SetError(this.txtKeeperName, "含非法字符，请重新输入！");
                this.txtUid.Focus();
            }
        }

        private void txtPhoneNo_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtCardID_Leave(object sender, EventArgs e)
        {
            if(Regex.IsMatch(this.txtIDNumber.Text.Trim(), @"^[1-9][0-9]{16}[0-9Xx]$") == false)
            {
                this.erpTest.SetError(this.txtIDNumber, "含非法字符，请重新输入！");
                this.txtUid.Focus();
            }
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
           this.erpTest.Clear();
        }

        private void txtPassWord_Enter(object sender, EventArgs e)
        {
            this.erpTest.Clear();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            //this.erpTest.Clear();
        }

        private void txtPhoneNo_Enter(object sender, EventArgs e)
        {
            //this.erpTest.Clear();
        }

        private void txtCardID_Enter(object sender, EventArgs e)
        {
           // this.erpTest.Clear();
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
           // this.erpTest.Clear();
        }
    }
}
