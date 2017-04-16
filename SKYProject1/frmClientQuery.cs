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
using System.Configuration;


namespace SKYProject1
{
    public partial class FrmClientQuery : Form
    {
        public FrmClientQuery()
        {
            InitializeComponent();
        }
        public FrmClientQuery(string clientNo)
        {
            InitializeComponent();
            this.clientNo = clientNo;
        }

        private FrmClient f;
        //建立连接地址
        private string myCon = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        DBHelper helper = new DBHelper();
        private string clientNo;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string strTxtNo = this.txtNo.Text;
            string strTxtName = this.txtName.Text;
            string strTxtSex = this.cboSex.Text;
            string strTxtPhone = this.txtPhone.Text;
            string strSql = "update Client set ClientNo=@ClientNo,ClientName=@ClientName,Sex=@Sex,TelePhone=@TelePhone where ClientNo=@NO";
            int rows = helper.ExecuteNonQuery(strSql, CommandType.Text,
                 new SqlParameter("@NO", clientNo),
                new SqlParameter("@ClientNo", strTxtNo),
                new SqlParameter("@ClientName", strTxtName),
                new SqlParameter("@Sex", strTxtSex),
                new SqlParameter("@TelePhone", strTxtPhone)
                );
            if(rows > 0)
            {
                MessageBox.Show("修改成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }

        private void FrmClientQuery_Load(object sender, EventArgs e)
        {
            string strSql = "select ClientName,Sex,TelePhone from Client where ClientNo=@ClientNo";
            SqlDataReader reader = helper.ExecuteReader(strSql, CommandType.Text, new SqlParameter("@ClientNo", clientNo));
            if(reader.Read())
            {
                txtNo.Text = clientNo;
                txtName.Text = reader.GetString(reader.GetOrdinal("ClientName"));
                cboSex.Text= reader.GetString(reader.GetOrdinal("Sex"));
                txtPhone.Text = reader.GetString(reader.GetOrdinal("TelePhone"));
            }
            reader.Close();
        }
    }
}
