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
    public partial class frmStockAdd : Form
    {
        string strSql = null;
        DBhelper helper = new DBhelper();
        public frmStockAdd(string s)
        {
            InitializeComponent();
            Show();
            cmbUid.Text = s;
        }
        private new void Show()
        {

            strSql = "select SupplierNo from Supplier";
            IDataReader reader = helper.ExecuteReaderAsync(strSql, CommandType.Text).Result;
            while (reader.Read())
            {
                cmbSupplierNo.Items.Add(reader[0]);
            }
            reader.Close();
            strSql = "select Uid from Keeper";
            reader = helper.ExecuteReaderAsync(strSql, CommandType.Text).Result;
            while (reader.Read())
            {
                cmbUid.Items.Add(reader[0]);
            }
            reader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCommandNo.Text == "" || txtCommandNum.Text == "" || txtCommandUnit.Text == "" || txtPurchaseID.Text == "")
            {
                MessageBox.Show("不能为空");
                return;
            }
            strSql = "select * from Purchase where PurchaseID=@PurchaseID";
            IDataReader reader = helper.ExecuteReaderAsync(strSql, CommandType.Text, new SqlParameter("@PurchaseID", txtPurchaseID.Text)).Result;
            if (reader.Read())
            {
                MessageBox.Show("已经存在相同的进货单，请重新输入");
                reader.Close();
                return;
            }
            reader.Close();
            //
            double temp;
            if (double.TryParse(txtCommandNum.Text, out temp))
            {
                if (temp > 0)
                {
                    if (temp % 1 == 0)
                    {
                        bool temp1 = true;
                        strSql = "select count(*) from Command where CommandNo=@CommandNo";
                        reader = helper.ExecuteReaderAsync(strSql, CommandType.Text, new SqlParameter("@CommandNo", txtCommandNo.Text)).Result;
                        if (reader.Read())
                        {
                            if (int.Parse(reader[0].ToString()) == 0)
                            {
                                reader.Close();
                                temp1 = false;
                                strSql = "insert into Command select @CommandNo,@CommandName,@CommandNum,@CommandUnit";
                                helper.ExecuteNonQueryAsync(strSql, CommandType.Text
                           , new System.Data.SqlClient.SqlParameter("@CommandNo", txtCommandNo.Text.Trim())
                           , new System.Data.SqlClient.SqlParameter("@CommandName", txtCommandName.Text.Trim())
                           , new System.Data.SqlClient.SqlParameter("@CommandNum", txtCommandNum.Text.Trim())
                           , new System.Data.SqlClient.SqlParameter("@CommandUnit", txtCommandUnit.Text.Trim()));

                            }
                        }
                        if(temp1)
                            reader.Close();

                        strSql = "insert into Purchase select @PurchaseID,@SupplierNo,@CommandNo,@CommandNum,@CommandUnit,getdate(),@Uid";
                        int row = helper.ExecuteNonQueryAsync(strSql, CommandType.Text
                            , new System.Data.SqlClient.SqlParameter("@PurchaseID", txtPurchaseID.Text.Trim())
                            , new System.Data.SqlClient.SqlParameter("@SupplierNo", cmbSupplierNo.Text.Trim())
                            , new System.Data.SqlClient.SqlParameter("@CommandNo", txtCommandNo.Text.Trim())
                            , new System.Data.SqlClient.SqlParameter("@CommandNum", txtCommandNum.Text.Trim())
                            , new System.Data.SqlClient.SqlParameter("@CommandUnit", txtCommandUnit.Text.Trim())
                            , new System.Data.SqlClient.SqlParameter("@Uid", cmbUid.Text.Trim())).Result;
                        if (row > 0)
                        {
                            MessageBox.Show("进货成功");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("进货失败，请检查是否无误后再次操作");
                        }
                        return;
                    }
                }
            }
            MessageBox.Show("数量输入有误，请输入整数");
        }

        private void txtCommandNo_TextChanged(object sender, EventArgs e)
        {
            strSql = "select CommandUnit from Command where CommandNo=@CommandNo";
            IDataReader reader = helper.ExecuteReaderAsync(strSql, CommandType.Text, new SqlParameter("@CommandNo", txtCommandNo.Text)).Result;
            if (reader.Read())
            {
                txtCommandUnit.Text = reader[0].ToString();
                reader.Close();
                label7.Visible = false;
                txtCommandName.Visible = false;
                return;
            }
            reader.Close();
            label7.Visible = true;
            txtCommandName.Visible = true;
        }
    }
}
