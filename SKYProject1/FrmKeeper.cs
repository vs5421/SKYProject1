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
    public partial class FrmKeeper : Form
    {
        public FrmKeeper()
        {
            InitializeComponent();
        }
        private string strSQL = null;

        private DBHelper helper = new DBHelper();

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //string uid = null;
        //if(this.livShow.SelectedItems.Count>0)
        //{
        //    uid = this.livShow.SelectedItems[0].Text;
        //}
        //MessageBox.Show(uid);
        //FrmKeeperDelect fdk = new FrmKeeperDelect(uid);
        //fdk.Show();
        //}

        private void FrmWHKeeper_Load(object sender, EventArgs e)
        {

        }
        private void FrmWHKeeper_Activated(object sender, EventArgs e)
        {
            //strSQL = "select uid from Keeper";
            //using (SqlConnection con = new SqlConnection(strCon))
            //{
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand(strSQL, con);
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        this.cboUid.Items.Add(reader.GetString(reader.GetOrdinal("Uid")));
            //    }
            //}
        }

        //增加仓管员
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmKeeperInsert fa = new FrmKeeperInsert();
            fa.Show();
        }
        //查询仓管员
        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.livShow.Items.Clear();
            strSQL = "select Uid,KeeperName,Sex,Telephone,IDNumber,Address from Keeper "+
                "where charIndex(@keeperName,KeeperName)>0 or len(@keeperName)=0";
            using (SqlDataReader reader= helper.ExecuteReader(strSQL,CommandType.Text,
                new SqlParameter("@keeperName",this.txtKeeperName.Text.Trim())))
            {
                while (reader.Read())
                {
                    string uid = reader.GetString(reader.GetOrdinal("Uid"));
                    string keeperName = reader.GetString(reader.GetOrdinal("KeeperName"));
                    string sex = reader.GetString(reader.GetOrdinal("Sex"));
                    string telePhone = reader.GetString(reader.GetOrdinal("TelePhone"));
                    string idNumber = reader.GetString(reader.GetOrdinal("IDNumber"));
                    string address = reader.GetString(reader.GetOrdinal("Address"));

                    ListViewItem list = new ListViewItem(uid);
                    list.SubItems.Add(keeperName);
                    list.SubItems.Add(sex);
                    list.SubItems.Add(telePhone);
                    list.SubItems.Add(idNumber);
                    list.SubItems.Add(address);
                    this.livShow.Items.Add(list);
                }
            }
        }
        //编辑仓管员
        private void UpdateTSMI_Click(object sender, EventArgs e)
        {
            string uid = null;
            if (this.livShow.SelectedItems.Count > 0)
            {
                uid = this.livShow.SelectedItems[0].Text;
                FrmKeeperUpdate fku = new FrmKeeperUpdate(uid);
                fku.ShowDialog();
            }
            this.btnSelect.PerformClick();
        }
        //删除仓管员
        private void DeleteTSMI_Click(object sender, EventArgs e)
        {
            string uid = null;
           DialogResult dr= MessageBox.Show("是否删除", "确定", MessageBoxButtons.OKCancel);
            if (dr==DialogResult.OK)
            {
                if (this.livShow.SelectedItems.Count > 0)
                {
                    uid = this.livShow.SelectedItems[0].Text;
                    FrmKeeperDelect fkd = new FrmKeeperDelect(uid);
                    fkd.ShowDialog();
                } 
            }
            this.btnSelect.PerformClick();
        }
    }
}
