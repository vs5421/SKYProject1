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
    public partial class FrmCommandInsert : Form
    {
        public FrmCommandInsert()
        {
            InitializeComponent();
        }
        private string strCon = "server=DESKTOP-HB10IB3;database=SkyProject;uid=sa;password=123;";

        private void btnSure_Click(object sender, EventArgs e)
        {   string commandNo = this.txtNo.Text.Trim();
            int commandNum = Convert.ToInt32(this.txtNum.Text.Trim());
            string commandName = this.txtName.Text.Trim();
            string commandUnit = this.txtUnit.Text.Trim();

            string strSQL = "select * from Command where CommandNo=@commandNo ";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@commandNo", commandNo);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reader.Close();
                    strSQL = "update Command set CommandNum=CommandNum+@commandNum where  CommandNo=@commandNo";
                    cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@commandNum",commandNum);
                    cmd.Parameters.AddWithValue("@commandNo", commandNo);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        con.Close();
                        MessageBox.Show("入库成功");
                        return;
                    }
                }
                reader.Close();
                strSQL = "insert into Command(CommandNo,CommandName,CommandNum,CommandUnit)values(@commandNo,@commandName,@commandNum,@commandUnit)";
                cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@commandNum", commandNum);
                cmd.Parameters.AddWithValue("@commandNo", commandNo);
                cmd.Parameters.AddWithValue("@commandName", commandName);
                cmd.Parameters.AddWithValue("@commandUnit", commandUnit);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    con.Close();
                    MessageBox.Show("入库成功");
                }
            }
        }

        private void txtNo_TextChanged(object sender, EventArgs e)
        {
            this.txtName.Text = "";
            this.txtUnit.Text = "";
            this.txtName.Enabled = true;
            this.txtUnit.Enabled = true;
            string commandNo = this.txtNo.Text.Trim() ;
            string strSQL = "select * from Command where CommandNo=@commandNo";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@commandNo", commandNo);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    this.txtName.Enabled = false;
                    this.txtUnit.Enabled = false;
                    this.txtName.Text = reader.GetString(reader.GetOrdinal("CommandName"));
                        this.txtUnit.Text = reader.GetString(reader.GetOrdinal("CommandUnit"));
                }
                reader.Close();
                con.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
