using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKYProject1
{
    public partial class FrmModifyClerk : Form
    {
        public FrmModifyClerk()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string strCon = @"server=.\SQL2014;database=SkyProject;uid=sa;password=123";
        private void FrmModifyClerk_Load(object sender, EventArgs e)
        {
            string strSQL = "select Uid from Clerk";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string gradeName = reader.GetString(reader.GetOrdinal("Uid"));
                    this.cboUid.Items.Add(gradeName);
                }
                reader.Close();
                con.Close();
            }
        }

        private void cboUid_TextChanged(object sender, EventArgs e)
        {
            string strSQL = "select ClerkName,sex,TelePhone,IDNumber,Address from Clerk where Uid=@Uid";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Uid", cboUid.Text);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    string ClerkName= reader.GetString(reader.GetOrdinal("ClerkName"));
                    string sex = reader.GetString(reader.GetOrdinal("sex"));
                    string TelePhone = reader.GetString(reader.GetOrdinal("TelePhone"));
                    string IDNumber = reader.GetString(reader.GetOrdinal("IDNumber"));
                    string Address = reader.GetString(reader.GetOrdinal("Address"));
                    this.txtClerkName.Text = ClerkName;
                    if (sex == "男")
                    {
                        rabMan.Checked = true;
                    }
                    else
                    {
                        rabWoman.Checked = true;
                    }
                    this.txtTelephone.Text = TelePhone;
                    this.txtIDNumber.Text = IDNumber;
                    this.txtAddress.Text = Address;
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string ClerkName = txtClerkName.Text.Trim();
            string Sex = rabMan.Checked ? rabMan.Text : rabWoman.Text;
            string Telephone = txtTelephone.Text.Trim();
            string IDNumber = txtIDNumber.Text.Trim();
            string Address = txtAddress.Text.Trim();
            string strSQL = "update clerk set ClerkName=@ClerkName,Sex=@Sex,Telephone=@Telephone,IDNumber=@IDNumber,Address=@Address where Uid=@Uid";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                con.Open();
                cmd.Parameters.AddWithValue("@Uid", cboUid.Text);
                cmd.Parameters.AddWithValue("@ClerkName", ClerkName);
                cmd.Parameters.AddWithValue("@sex", Sex);
                cmd.Parameters.AddWithValue("@TelePhone", Telephone);
                cmd.Parameters.AddWithValue("@IDNumber", IDNumber);
                cmd.Parameters.AddWithValue("@Address", Address);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("修改成功");
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
                con.Close();
            }
        }
    }
}
