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
    public partial class FrmCommandDelete : Form
    {
        public FrmCommandDelete()
        {
            InitializeComponent();
        }
        public FrmCommandDelete(string commandNo)
        {
            InitializeComponent();
            this.commandNo = commandNo;
        }
        private string commandNo = null;
        private string strCon = "server=DESKTOP-HB10IB3;database=SkyProject;uid=sa;password=123;";
        private void FrmCommandDelete_Load(object sender, EventArgs e)
        { 
            string strSQL = "select * from Command where CommandNo=@commandNo";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@commandNo", commandNo);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string commandNo = reader.GetString(reader.GetOrdinal("CommandNo"));
                    string commandNum = reader.GetInt32(reader.GetOrdinal("CommandNum")).ToString();
                    string commandName = reader.GetString(reader.GetOrdinal("CommandName"));
                    string commandUnit = reader.GetString(reader.GetOrdinal("CommandUnit"));
                    this.lblCommandNo.Text = commandNo;
                    this.lblCommandName.Text = commandNum;
                    this.lblCommandNum.Text = commandName;
                    this.lblCommandUnit.Text = commandUnit;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string strSQL = "delete from  Command where  CommandNo=@commandNo";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@commandNo", commandNo);
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    con.Close();
                    MessageBox.Show("删除成功！");
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
