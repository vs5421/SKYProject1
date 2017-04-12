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
    public partial class FrmCommandSelect : Form
    {
        public FrmCommandSelect()
        {
            InitializeComponent();
        }
        private string strCon = "server=DESKTOP-HB10IB3;database=SkyProject;uid=sa;password=123;";
        private string commandNo = null;
        private void FrmCommandSelect_Load(object sender, EventArgs e)
        {
            this.lsvShow.Items.Clear();
            string strSQL = "select * from Command";
            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand(strSQL, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string commandNo = reader.GetString(reader.GetOrdinal("CommandNo"));
                    string commandNum = reader.GetInt32(reader.GetOrdinal("CommandNum")).ToString();
                    string commandName = reader.GetString(reader.GetOrdinal("CommandName"));
                    string commandUnit = reader.GetString(reader.GetOrdinal("CommandUnit"));
                    ListViewItem list = new ListViewItem(commandNo);
                    list.SubItems.Add(commandName);
                    list.SubItems.Add(commandNum);
                    list.SubItems.Add(commandUnit);
                    list.Tag = commandNo;
                    this.lsvShow.Items.Add(list);
                }
            }
            }

        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.lsvShow.SelectedItems.Count > 0)
            {
                commandNo = this.lsvShow.SelectedItems[0].Tag.ToString();
                FrmCommandUpdate f = new FrmCommandUpdate(commandNo);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("请选择一项");
            }
            FrmCommandSelect_Load(sender, e);
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.lsvShow.SelectedItems.Count > 0)
            {
                commandNo = this.lsvShow.SelectedItems[0].Tag.ToString();
                FrmCommandDelete f = new SKYProject1.FrmCommandDelete(commandNo);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("请选择一项");
            }
            FrmCommandSelect_Load(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
