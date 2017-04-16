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
    public partial class FrmClientDelete : Form
    {
        public FrmClientDelete()
        {
            InitializeComponent();
        }
        public FrmClientDelete(string ClientNo)
        {
            InitializeComponent();
            this.ClientNo = ClientNo;
        }
        //从父窗体把要删除的编号查询出来
        private string ClientNo;
        DBHelper helper = new DBHelper();


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //确定删除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string strSql = "delete Client where ClientNo=@ClientNo";
            int rows = helper.ExecuteNonQuery(strSql,CommandType.Text,new SqlParameter("@ClientNO",ClientNo));
            if(rows>0)
            {
                MessageBox.Show("删除成功！");
                this.Close();
            }
            else
                MessageBox.Show("删除失败！");
        }

        private void FrmClientDelete_Load(object sender, EventArgs e)
        {
            string strSql = "Select ClientNo,ClientName,Sex,TelePhone from Client where ClientNo=@ClientNo";
            SqlDataReader reader = helper.ExecuteReader(strSql, CommandType.Text, new SqlParameter("@ClientNo", ClientNo));
            if (reader.Read())
            {
                this.lblShowNo.Text = ClientNo;
                this.lblShowName.Text = reader.GetString(reader.GetOrdinal("ClientName"));
                this.lblShowSex.Text = reader.GetString(reader.GetOrdinal("Sex"));
                this.lblShowPhone.Text = reader.GetString(reader.GetOrdinal("TelePhone"));
            }
            reader.Close();
        }
    }
}
