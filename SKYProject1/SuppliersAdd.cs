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
    public partial class SuppliersAdd : Form
    {
        public SuppliersAdd()
        {
            InitializeComponent();
        }
        string strSql = null;
        DBhelper helper = new DBhelper();
        private void btnOK_Click(object sender, EventArgs e)
        {
            strSql = "select SupplierNo from Supplier";
            IDataReader reader = helper.ExecuteReaderAsync(strSql,CommandType.Text).Result;
            while(reader.Read())
            {
                if(reader[0].ToString()==txtSupplierName.Text)
                {
                    MessageBox.Show("已经存在了相同的供应商，请确认后操作");
                    reader.Close();
                    return;
                }
            }
            reader.Close();
            strSql = "insert into Supplier select @SupplierNo,@SupplierName,@Telephone";
            int row = helper.ExecuteNonQueryAsync(strSql, CommandType.Text
                    ,new SqlParameter("@SupplierNo", txtSupplierID.Text.Trim())
                    ,new SqlParameter("@SupplierName", txtSupplierName.Text.Trim())
                    ,new SqlParameter("@Telephone", txtSupplierphoe.Text.Trim())
                ).Result;
            if(row>0)
            {
                MessageBox.Show("恭喜添加成功");
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("添加失败，请重新检查后再次操作，如还有问题请联系管理员");
                return;
            }
        }
    }
}
