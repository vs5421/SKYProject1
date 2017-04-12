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
    public partial class FrmCommandUpdate : Form
    {
        public FrmCommandUpdate()
        {
            InitializeComponent();
        }
        public FrmCommandUpdate(string commandNo)
        {
            InitializeComponent();
            this.commandNo = commandNo;
        }
        private string commandNo = null;
        private string strCon = "server=DESKTOP-HB10IB3;database=SkyProject;uid=sa;password=123;";
        private void FrmCommandUpdate_Load(object sender, EventArgs e)
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
                    this.txtNo.Text = commandNo;
                    this.txtNum.Text = commandNum;
                    this.txtName.Text = commandName;
                    this.txtUnit.Text = commandUnit;
                }
            }
                }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            string commandNo = this.txtNo.Text.Trim();
            int commandNum = Convert.ToInt32(this.txtNum.Text.Trim());
            string commandName = this.txtName.Text.Trim();
            string commandUnit = this.txtUnit.Text.Trim();
            string strSQL = "update Command set CommandNo=@commandNo,CommandNum=@commandNum,CommandName=@commandName,CommandUnit=@commandUnit where CommandNo=@commandNo";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@commandNo", commandNo);
                cmd.Parameters.AddWithValue("@commandNum", commandNum);
                cmd.Parameters.AddWithValue("@commandName", commandName);
                cmd.Parameters.AddWithValue("@commandUnit", commandUnit);
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    con.Close();
                    MessageBox.Show("编辑成功！");
                    this.Close();
                    
                }
            }
        }
    }
}
