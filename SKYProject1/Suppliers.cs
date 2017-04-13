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
            while(reader.Read())
            {
                ListViewItem i = new ListViewItem();
                i.SubItems.Add(reader["SupplierNo"].ToString());
                i.SubItems.Add(reader["SupplierName"].ToString());
                i.SubItems.Add(reader["Telephone"].ToString());
                lvSupplierShow.Items.Add(i);
            }
            reader.Close();
            
        }

        private void 添加一个新的供应商ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Suppliers_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

    }
}
