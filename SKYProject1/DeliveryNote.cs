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
    public partial class DeliveryNote : Form
    {
        string strSql = null;
        DBhelper helper = new DBhelper();
        public DeliveryNote()
        {
            InitializeComponent();
            SuppliersShowID();
        }
        //显示出供应商ID
        private void SuppliersShowID()
        {
            strSql = "select SupplierNo from Supplier";
            IDataReader reader = helper.ExecuteReaderAsync(strSql, CommandType.Text).Result;
            while (reader.Read())
            {
                cmbSuppliersID.Items.Add(reader[0].ToString());
            }
            reader.Close();
        }
        private void cmbSuppliersID_TextChanged(object sender, EventArgs e)
        {
            string strSql = "select * from Supplier where SupplierNo=@SupplierNo";
            IDataReader reader = helper.ExecuteReaderAsync(strSql, CommandType.Text, new System.Data.SqlClient.SqlParameter("@SupplierNo", cmbSuppliersID.Text)).Result;
            if (reader.Read())
            {
                label3.Text = "供货商编号：" + reader["SupplierNo"] + "\n" + "联系人姓名：" + reader["SupplierName"] + "\n" + "联系电话：" + reader["Telephone"];
            }
            reader.Close();

            lvwShow.Items.Clear();
            strSql = "select * from Purchase where SupplierNo = @SupplierNo or @SupplierNo = ''";
            reader = helper.ExecuteReaderAsync(strSql, CommandType.Text
                , new System.Data.SqlClient.SqlParameter("@SupplierNo", cmbSuppliersID.Text.Trim())).Result;
            while (reader.Read())
            {
                ListViewItem i = new ListViewItem(reader["PurchaseID"].ToString());
                i.SubItems.Add(reader["SupplierNo"].ToString());
                i.SubItems.Add(reader["CommandNo"].ToString());
                i.SubItems.Add(reader["CommandNum"].ToString());
                i.SubItems.Add(reader["CommandUnit"].ToString());
                i.SubItems.Add(reader["PurchaseDate"].ToString());
                i.SubItems.Add(reader["Uid"].ToString());
                lvwShow.Items.Add(i);
            }
            reader.Close();
        }
    }
}
