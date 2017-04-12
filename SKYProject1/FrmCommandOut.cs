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
    public partial class FrmCommandOut : Form
    {
        public FrmCommandOut()
        {
            InitializeComponent();
        }
        private string strCon = "server=DESKTOP-HB10IB3;database=SkyProject;uid=sa;password=123;";
        private void btnSure_Click(object sender, EventArgs e)
        {
            string commandNo = this.txtNo.Text.Trim();
            int commandNum = Convert.ToInt32(this.txtNum.Text.Trim());
            string strSQL = "select * from Command where CommandNo=@commandNo ";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@commandNo", commandNo);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int number = reader.GetInt32(reader.GetOrdinal("CommandNum"));
                    if (number > commandNum)
                    {
                        reader.Close();
                        strSQL = "update Command set CommandNum=CommandNum-@commandNum where  CommandNo=@commandNo";
                        cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@commandNum", commandNum);
                        cmd.Parameters.AddWithValue("@commandNo", commandNo);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            con.Close();
                            MessageBox.Show("出库成功");
                            this.Close();
                            return;
                        }
                    }
                    else if (number == commandNum)
                    {
                        reader.Close();
                        strSQL = "delete from Command where CommandNo=@commandNo ";
                        cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@commandNo", commandNo);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            con.Close();
                            MessageBox.Show("出库成功");
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("出库数量不能大于库存量！请重试！");
                    }

                  
                }
            }
        }

        private void txtNo_TextChanged(object sender, EventArgs e)
        {
            this.lblCommandName.Text = "";
            this.lblCommandUnit.Text = "";
            string commandNo = this.txtNo.Text.Trim();
            string strSQL = "select * from Command where CommandNo=@commandNo";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@commandNo", commandNo);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    
                    this.lblCommandName.Text = reader.GetString(reader.GetOrdinal("CommandName"));
                    this.lblCommandUnit.Text = reader.GetInt32(reader.GetOrdinal("CommandNum")).ToString() + "(" + reader.GetString(reader.GetOrdinal("CommandUnit")) + ")";
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
