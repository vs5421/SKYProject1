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
    public partial class FrmClient : Form
    {
        public FrmClient()
        {
            InitializeComponent();
        }

        private string myCon = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        DBHelper helper = new DBHelper();

        private void FrmClient_Load(object sender, EventArgs e)
        {
            ShowInformation();
        }
        private  void ShowInformation()
        {
            string strSql = "select ClientNo,ClientName,Sex,Telephone from Client";
            SqlDataReader reader = helper.ExecuteReader(strSql, CommandType.Text);
            this.listView1.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetString(reader.GetOrdinal("ClientNo")));
                item.SubItems.Add(reader.GetString(reader.GetOrdinal("ClientName")));
                item.SubItems.Add(reader.GetString(reader.GetOrdinal("Sex")));
                item.SubItems.Add(reader.GetString(reader.GetOrdinal("Telephone")));
                listView1.Items.Add(item);
            }
            reader.Close();
        }
        //查询客户信息
      

        private void btnADDClient_Click(object sender, EventArgs e)
        {
            FrmClientAdd f = new FrmClientAdd();
            f.ShowDialog();
            ShowInformation();
        }

        private void tsmiModify_Click(object sender, EventArgs e)
        {
            string ClientNo = listView1.SelectedItems[0].Text;
            FrmClientQuery f = new FrmClientQuery(ClientNo);
            f.ShowDialog();
            ShowInformation();
        }
        FrmClientDelete fDelete;
        private void tsmiDelete_Click_1(object sender, EventArgs e)
        {
            string ClientNo = listView1.SelectedItems[0].Text;
            fDelete = null;
            fDelete = new FrmClientDelete(ClientNo);
            fDelete.ShowDialog();
            ShowInformation();
        }
    }
}
