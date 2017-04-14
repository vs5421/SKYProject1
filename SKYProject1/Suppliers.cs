using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace SKYProject1
{
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
        }
        string strCon = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        string strSql = null;
        DBhelper helper = new DBhelper();
        private void Suppliers_Activated(object sender, EventArgs e)
        {
            lvSupplierShow.Items.Clear();
            strSql = "select * from Supplier";
            IDataReader reader = helper.ExecuteReaderAsync(strSql).Result;
            while (reader.Read())
            {
                ListViewItem i = new ListViewItem(reader["SupplierNo"].ToString());
                i.SubItems.Add(reader["SupplierName"].ToString());
                i.SubItems.Add(reader["Telephone"].ToString());
                i.Tag = reader["SupplierNo"].ToString();
                lvSupplierShow.Items.Add(i);
            }
            reader.Close();

        }

        private void 添加一个新的供应商ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuppliersAdd frm = new SuppliersAdd();
            frm.ShowDialog();
        }

        private void Suppliers_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void 删除一个旧的供应商ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuppliersDelete frm = new SuppliersDelete();
            frm.ShowDialog();
        }

        private void 修改一个旧的供应商ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModify frm = new frmModify();
            frm.ShowDialog();
        }

        private void 增加一个供应商ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuppliersAdd frm = new SuppliersAdd();
            frm.ShowDialog();
        }

        private void 删除供应商ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvSupplierShow.SelectedItems.Count <= 0)
            {
                SuppliersDelete frm = new SuppliersDelete();
                frm.ShowDialog();
            }
            else
            {
                SuppliersDelete frm = new SuppliersDelete(lvSupplierShow.SelectedItems[0].SubItems[0].Text);
                frm.ShowDialog();
            }

        }

        private void 查询一个旧的供应商ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 修改供应商ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvSupplierShow.SelectedItems.Count <= 0)
            {
                frmModify frm = new frmModify();
                frm.ShowDialog();
            }
            else
            {

                frmModify frm = new frmModify(lvSupplierShow.SelectedItems[0].SubItems[0].Text);
                frm.ShowDialog();
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            lvSupplierShow.Items.Clear();
            string strSql = "select * from Supplier where (SupplierNo = @SupplierNo or @SupplierNo = '') and (SupplierName = @SupplierName or @SupplierName='') and (Telephone=@Telephone or @Telephone = '')";
            IDataReader reader = helper.ExecuteReaderAsync(strSql, CommandType.Text
                , new System.Data.SqlClient.SqlParameter("@SupplierNo", txtSuppliersID.Text.Trim())
                , new System.Data.SqlClient.SqlParameter("@SupplierName", txtSuppliersName.Text.Trim())
                , new System.Data.SqlClient.SqlParameter("@Telephone", txtSuppliersphone.Text.Trim())).Result;
            while (reader.Read())
            {
                ListViewItem i = new ListViewItem(reader["SupplierNo"].ToString());
                i.SubItems.Add(reader["SupplierName"].ToString());
                i.SubItems.Add(reader["Telephone"].ToString());
                lvSupplierShow.Items.Add(i);
            }
            reader.Close();

        }

        private void 送货单管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
