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
    public partial class FrmClerkADD : Form
    {
        public FrmClerkADD()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //string strCon = @"server=.\SQL2014;database=SkyProject;uid=sa;password=123";
        //string strCon = @"server=DESKTOP-CBE5RT7;database=SkyProject;uid=sa;password=123";
        DBHelp helper = new DBHelp();
        private void btnADD_Click(object sender, EventArgs e)
        {
            string UID = txtUid.Text.Trim();
            string Password = txtPassword.Text.Trim();
            string ClerkName = txtClerkName.Text.Trim();
            string Sex = rabMan.Checked ? rabMan.Text : rabWoman.Text;
            string Telephone = txtTelephone.Text.Trim();
            string IDNumber = txtIDNumber.Text.Trim();
            string Address = txtAddress.Text.Trim();
            this.errorProvider1.Clear();
            if (Regex.IsMatch(txtUid.Text.Trim(), @"^[ ]*$") == true)
            {
                this.errorProvider1.SetError(txtUid, "不能空！");
                this.txtUid.Focus();
                return;
            }
            if (Regex.IsMatch(txtPassword.Text.Trim(), @"^[ ]*$") == true)
            {
                this.errorProvider1.SetError(txtPassword, "不能空！");
                this.txtPassword.Focus();
                return;
            }
            if (txtPasswordss.Text != txtPassword.Text)
            {
                this.errorProvider1.SetError(txtPasswordss, "两次密码不一致！");
                this.txtPasswordss.Focus();
                return;
            }
            if (Regex.IsMatch(txtClerkName.Text.Trim(), @"^[ ]*$") == true)
            {
                this.errorProvider1.SetError(txtClerkName, "不能空！");
                this.txtClerkName.Focus();
                return;
            }
            if (Regex.IsMatch(txtTelephone.Text.Trim(), @"^[\d]{11}$") == false)
            {
                this.errorProvider1.SetError(txtTelephone, "手机号码输入不规范！");
                this.txtTelephone.Focus();
                return;
            }
            if (Regex.IsMatch(txtIDNumber.Text.Trim(), @"(^[\d]{18}$)|(^[\d]{17}[X]$)") == false)
            {
                this.errorProvider1.SetError(txtIDNumber, "身份证号码输入不规范！");
                this.txtIDNumber.Focus();
                return;
            }
            if (Regex.IsMatch(txtAddress.Text.Trim(), @"^[ ]*$") == true)
            {
                this.errorProvider1.SetError(txtAddress, "不能空！");
                this.txtAddress.Focus();
                return;
            }
            string strSQL = "insert into Clerk(Uid,Password,ClerkName,sex,TelePhone,IDNumber,Address)" +
                        " values(@Uid,@Password,@ClerkName,@sex,@TelePhone,@IDNumber,@Address)";
                int rows = helper.ExecuteNonQuery(strSQL, CommandType.Text,
                   new SqlParameter("@Uid", UID),
                   new SqlParameter("@Password", Password),
                   new SqlParameter("@ClerkName", ClerkName),
                   new SqlParameter("@sex", Sex),
                   new SqlParameter("@TelePhone", Telephone),
                   new SqlParameter("@IDNumber", IDNumber),
                   new SqlParameter("@Address", Address)
               );

                if (rows > 0)
                {
                    MessageBox.Show("添加成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
        }
        
    }
}
