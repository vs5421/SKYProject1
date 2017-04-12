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
    public partial class FrmAddClerk : Form
    {
        public FrmAddClerk()
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
        string strCon = @"server=DESKTOP-CBE5RT7;database=SkyProject;uid=sa;password=123";
        private void btnADD_Click(object sender, EventArgs e)
        {
            string UID = txtUid.Text.Trim();
            string Password = txtPassword.Text.Trim();
            string ClerkName = txtClerkName.Text.Trim();
            string Sex = rabMan.Checked ? rabMan.Text : rabWoman.Text;
            string Telephone = txtTelephone.Text.Trim();
            string IDNumber = txtIDNumber.Text.Trim();
            string Address = txtAddress.Text.Trim();
            string strSQL = "insert into Clerk(Uid,Password,ClerkName,sex,TelePhone,IDNumber,Address)" +
                " values(@Uid,@Password,@ClerkName,@sex,@TelePhone,@IDNumber,@Address)";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                con.Open();
                cmd.Parameters.AddWithValue("@Uid", UID);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@ClerkName", ClerkName);
                cmd.Parameters.AddWithValue("@sex", Sex);
                cmd.Parameters.AddWithValue("@TelePhone", Telephone);
                cmd.Parameters.AddWithValue("@IDNumber", IDNumber);
                cmd.Parameters.AddWithValue("@Address", Address);
                int rows = cmd.ExecuteNonQuery();
                if(rows > 0)
                {
                    MessageBox.Show("添加成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
                con.Close();
            }
        }

        private void txtUid_Leave(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
            if (Regex.IsMatch(txtUid.Text.Trim(),@"^[ ]*$")==true)
            {
                this.errorProvider1.SetError(txtUid, "不能空！");
                this.txtUid.Focus();
                return;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
            if (Regex.IsMatch(txtPassword.Text.Trim(), @"^[ ]*$") == true)
            {
                this.errorProvider1.SetError(txtPassword, "不能空！");
                this.txtPassword.Focus();
                return;
            }
        }

        private void txtPasswordss_Leave(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
            if (txtPasswordss.Text!=txtPassword.Text)
            {
                this.errorProvider1.SetError(txtPasswordss, "两次密码不一致！");
                this.txtPasswordss.Focus();
                return;
            }
        }

        private void txtClerkName_Leave(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
            if (Regex.IsMatch(txtClerkName.Text.Trim(), @"^[ ]*$") == true)
            {
                this.errorProvider1.SetError(txtClerkName, "不能空！");
                this.txtClerkName.Focus();
                return;
            }
        }

        private void txtTelephone_Leave(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
            if (Regex.IsMatch(txtTelephone.Text.Trim(),@"^[\d]{11}$")==false)
            {
                this.errorProvider1.SetError(txtTelephone, "手机号码输入不规范！");
                this.txtTelephone.Focus();
                return;
            }
        }

        private void txtIDNumber_Leave(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
            if (Regex.IsMatch(txtIDNumber.Text.Trim(), @"(^[\d]{18}$)|(^[\d]{17}[X]$)") == false)
            {
                this.errorProvider1.SetError(txtIDNumber, "身份证号码输入不规范！");
                this.txtIDNumber.Focus();
                return;
            }
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
            if (Regex.IsMatch(txtAddress.Text.Trim(), @"^[ ]*$") == true)
            {
                this.errorProvider1.SetError(txtAddress, "不能空！");
                this.txtAddress.Focus();
                return;
            }
        }
    }
}
