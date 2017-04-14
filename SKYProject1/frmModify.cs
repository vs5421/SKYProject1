using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKYProject1
{
    public partial class frmModify : Form
    {
        string strSql = null;
        DBhelper helper = new DBhelper();
        public frmModify()
        {
            InitializeComponent();
            SuppliersShowID();
        }
        public frmModify(string id)
        {
            InitializeComponent();
            SuppliersShowID();
            cbxSuppliersID.Text = id;
        }
        //显示出供应商ID
        private void SuppliersShowID()
        {
            strSql = "select SupplierNo from Supplier";
            IDataReader reader = helper.ExecuteReaderAsync(strSql, CommandType.Text).Result;
            while (reader.Read())
            {
                cbxSuppliersID.Items.Add(reader[0].ToString());
            }
            reader.Close();
        }

        private void cbxSuppliersID_TextChanged(object sender, EventArgs e)
        {
            strSql = "select * from Supplier where SupplierNo=@SupplierNo";
            IDataReader reader = helper.ExecuteReaderAsync(strSql, CommandType.Text,new System.Data.SqlClient.SqlParameter("@SupplierNo",cbxSuppliersID.Text)).Result;
            if (reader.Read())
            {
                label2.Text = "供货商编号：" + reader["SupplierNo"] + "\n" + "联系人姓名：" + reader["SupplierName"] + "\n" + "联系电话：" + reader["Telephone"];
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            strSql = "select * from Supplier";
            IDataReader reader = helper.ExecuteReaderAsync(strSql, CommandType.Text).Result;
            while (reader.Read())
            {
                if (reader["SupplierNo"].ToString() == txtSuppliersID.Text &&cbxSuppliersID.Text!=txtSuppliersID.Text)
                {
                    MessageBox.Show("已经存在了相同编号的供应商，请重新修改后操作");
                    reader.Close();
                    return;
                }
            }
            reader.Close();
            strSql = "update Supplier set SupplierNo =@SupplierNo,SupplierName = @SupplierName,Telephone = @Telephone  where SupplierNo=@SupplierNo1";
            int row = helper.ExecuteNonQueryAsync(strSql, CommandType.Text
                , new System.Data.SqlClient.SqlParameter("@SupplierNo1", cbxSuppliersID.Text.Trim())
                , new System.Data.SqlClient.SqlParameter("@SupplierNo", txtSuppliersID.Text.Trim())
                , new System.Data.SqlClient.SqlParameter("@SupplierName", txtSuppliersName.Text.Trim())
                , new System.Data.SqlClient.SqlParameter("@Telephone", txtSuppliersphone.Text.Trim())).Result;
            if (row > 0)
            {
                MessageBox.Show("修改成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("没有做任何的修改");
            }
        }
    }
}
