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
    public partial class FrmClerkModify : Form
    {
        public FrmClerkModify()
        {
            InitializeComponent();
        }

        public FrmClerkModify(string Uid)
        {
            InitializeComponent();
            this.Uid = Uid;
        }
        string Uid;
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //string strCon = @"server=.\SQL2014;database=SkyProject;uid=sa;password=123";
        //string strCon = @"server=DESKTOP-CBE5RT7;database=SkyProject;uid=sa;password=123";
        DBHelp helper = new DBHelp();

        private void FrmModifyClerk_Load(object sender, EventArgs e)
        {
           
            string strSQL = "select ClerkName,sex,TelePhone,IDNumber,Address from Clerk where Uid=@Uid";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text, new SqlParameter("@Uid", Uid));
            //using (SqlConnection con = new SqlConnection(strCon))
            //{
            //    SqlCommand cmd = new SqlCommand(strSQL, con);
            //    cmd.Parameters.AddWithValue("@Uid", Uid);
            //    con.Open();
            //    SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string ClerkName = reader.GetString(reader.GetOrdinal("ClerkName"));
                string sex = reader.GetString(reader.GetOrdinal("sex"));
                string TelePhone = reader.GetString(reader.GetOrdinal("TelePhone"));
                string IDNumber = reader.GetString(reader.GetOrdinal("IDNumber"));
                string Address = reader.GetString(reader.GetOrdinal("Address"));
                this.txtUid.Text = Uid;
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
            reader.Close();
        }

        private void cboUid_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string ClerkName = txtClerkName.Text.Trim();
            string Sex = rabMan.Checked ? rabMan.Text : rabWoman.Text;
            string Telephone = txtTelephone.Text.Trim();
            string IDNumber = txtIDNumber.Text.Trim();
            string Address = txtAddress.Text.Trim();
            string strSQL = "update clerk set ClerkName=@ClerkName,Sex=@Sex,Telephone=@Telephone,IDNumber=@IDNumber,Address=@Address where Uid=@Uid";
            int rows = helper.ExecuteNonQuery(strSQL, CommandType.Text,
                  new SqlParameter("@Uid", Uid),
                  new SqlParameter("@ClerkName", ClerkName),
                  new SqlParameter("@Sex", Sex),
                  new SqlParameter("@Telephone", Telephone),
                  new SqlParameter("@IDNumber", IDNumber),
                  new SqlParameter("@Address", Address)
              );
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
