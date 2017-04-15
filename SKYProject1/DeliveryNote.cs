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
            Show();
        }
        //显示出供应商ID
        private void SuppliersShowID()
        {
            strSql = "select Uid from Keeper";
            IDataReader reader = helper.ExecuteReaderAsync(strSql, CommandType.Text).Result;
            while (reader.Read())
            {
                cmbSuppliersID.Items.Add(reader[0].ToString());
            }
            reader.Close();
        }
        private void Show()
        {
            lvwShow.Items.Clear();
            strSql = "select * from Purchase where Uid = @Uid or @Uid = ''";
            IDataReader reader = helper.ExecuteReaderAsync(strSql, CommandType.Text
                , new System.Data.SqlClient.SqlParameter("@Uid", cmbSuppliersID.Text.Trim())).Result;
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
        private void cmbSuppliersID_TextChanged(object sender, EventArgs e)
        {
            Show();
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            frmStockAdd frm = new frmStockAdd(cmbSuppliersID.Text);
            frm.ShowDialog();
        }
    }
}
