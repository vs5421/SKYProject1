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
    public partial class frmClientAdd : Form
    {
        public frmClientAdd()
        {
            InitializeComponent();
        }
        private string myCon = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        DBHelp helper = new DBHelp();

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string strSql = "select ClientNo from Client where ClientNo=@ClientNo";
            object obj = helper.ExecuteScalar(strSql, CommandType.Text,
                new SqlParameter("@ClientNo", this.txtNo.Text)
                );
            if (obj != null)
            {
                errorProvider1.SetError(this.txtNo, "已存在相同的编号");
            }
            else
            {
                strSql = "insert into Client(ClientNo,ClientName,Sex,Telephone) values(@ClientNo,@ClientName,@Sex,@TelePhone)";
                //将数据库里受影响的行数返回出来
               int rows = helper.ExecuteNonQuery(strSql, CommandType.Text,
                    new SqlParameter("@ClientNo", this.txtNo.Text),
                    new SqlParameter("@ClientName", this.txtName.Text),
                    new SqlParameter("@Sex", this.cboSex.Text),
                    new SqlParameter("@TelePhone", this.txtPhone.Text)
                    );
                //如果受影响的函数大于0，则显示添加成功
                if (rows > 0)
                {
                    MessageBox.Show("添加成功！");
                    this.Close();
                }
                else
                    MessageBox.Show("添加失败！");
            }
        }

        private void frmClientAdd_Load(object sender, EventArgs e)
        {
            //默认选择性别男
            this.cboSex.SelectedIndex = 0;
        }
    }
}
