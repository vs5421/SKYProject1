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
    public partial class frmClientQuery : Form
    {
        public frmClientQuery()
        {
            InitializeComponent();
        }
        //将Client窗体传入进来，让子窗体能够控制父窗体
        public frmClientQuery(FrmClient frmClient)
        {
            InitializeComponent();
            this.f = frmClient;
        }
        private FrmClient f;
        //建立连接地址
        private string myCon = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        DBHelp helper = new DBHelp();
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
            string strSql = "select ClientNo,ClientName,Sex,Telephone from Client where (ClientNo=@ClientNo or LEN(@ClientNo)=0) and (charIndex(@ClientName,ClientName)>0 or LEN(@CLientName)=0) and (Sex=@Sex or LEN(@Sex)=0 and (Telephone=@TelePhone or LEN(@TelePhone)=0))";
            SqlDataReader reader = helper.ExecuteReader(strSql, CommandType.Text,
                new SqlParameter("@ClientNo", strTxtNo),
                new SqlParameter("@ClientName", strTxtName),
                new SqlParameter("@Sex", strTxtSex),
                new SqlParameter("@TelePhone", strTxtPhone)
                );

            //每次查询前先清空ListView控件里的数据
            f.listView1.Items.Clear();
            //定义一个Flag，当能查到数据的时候关闭窗口，s查询不到数据的时候做出提示
            bool flag = false;
            //将查询到的，导入到父窗体里
            while(reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetString(reader.GetOrdinal("ClientNo")));
                lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("ClientName")));
                lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("Sex")));
                lvi.SubItems.Add(reader.GetString(reader.GetOrdinal("Telephone")));
                f.listView1.Items.Add(lvi);
                flag = true;
            }
            reader.Close();
            if(flag)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("未查询到任何数据，请重试！");
            }
        }
    }
}
