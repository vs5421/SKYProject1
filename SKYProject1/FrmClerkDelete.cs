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
    public partial class FrmClerkDelete : Form
    {
        public FrmClerkDelete()
        {
            InitializeComponent();
        }

        public FrmClerkDelete(string uid)
        {
            InitializeComponent();
            this.uid = uid;
        }
        //string strCon = @"server=.\SQL2014;database=SkyProject;uid=sa;password=123";
        //string strCon = @"server=DESKTOP-CBE5RT7;database=SkyProject;uid=sa;password=123";
        DBHelper helper = new DBHelper();
        private string uid;

        private void FrmDeleteClerk_Load(object sender, EventArgs e)
        {
            string strSQL = "select Uid,ClerkName,Sex,Telephone,IDNumber,Address from Clerk where Uid=@Uid";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text
               , new SqlParameter("@Uid", uid)
               );
            //using (SqlConnection con = new SqlConnection(strCon))
            //{
            //    SqlCommand cmd = new SqlCommand(strSQL, con);
            //    cmd.Parameters.AddWithValue("@Uid", uid);
            //    con.Open();
            //    SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string Uid = reader.GetString(reader.GetOrdinal("Uid"));
                string ClerkName = reader.GetString(reader.GetOrdinal("ClerkName"));
                string sex = reader.GetString(reader.GetOrdinal("sex"));
                string TelePhone = reader.GetString(reader.GetOrdinal("TelePhone"));
                string IDNumber = reader.GetString(reader.GetOrdinal("IDNumber"));
                string Address = reader.GetString(reader.GetOrdinal("Address"));
                lblUid.Text = Uid;
                lblClerkName.Text = ClerkName;
                lblsex.Text = sex;
                lblTelePhone.Text = TelePhone;
                lblNumber.Text = IDNumber;
                lblAddress.Text = Address;
            }
            reader.Close();
            //    con.Close();
            //}
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string strSQL = "delete from Clerk where Uid=@Uid";
            int rows = helper.ExecuteNonQuery(strSQL, CommandType.Text,
                   new SqlParameter("@Uid", uid)
               );
            //using (SqlConnection con = new SqlConnection(strCon))
            //{
            //    SqlCommand cmd = new SqlCommand(strSQL, con);
            //    cmd.Parameters.AddWithValue("@Uid", uid);
            //    con.Open();
            //    int rows= cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show("删除成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("删除失败");
            }
            //    con.Close();
            //}
        }
    }
}
