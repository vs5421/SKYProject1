﻿using System;
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
    public partial class SuppliersDelete : Form
    {
        DBhelper helper = new DBhelper();
        string strSql = null;
        public SuppliersDelete()
        {
            InitializeComponent();
        }
        public SuppliersDelete(string ID)
        {
            InitializeComponent();
            cmbSuppliersDelete.Text = ID;
        }

        private void cmbSuppliersDelete_TextChanged(object sender, EventArgs e)
        {
            strSql = "select * from Supplier where SupplierNo=@SupplierNo";
            IDataReader reader = helper.ExecuteReaderAsync(strSql, CommandType.Text, new System.Data.SqlClient.SqlParameter("@SupplierNo", cmbSuppliersDelete.Text.Trim())).Result;
            reader.Read();
            label2.Text = "供货商编号：" + reader["SupplierNo"] + "\n" + "联系人姓名：" + reader["SupplierName"] + "\n" + "联系电话：" + reader["Telephone"];
            reader.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            strSql = "delete Supplier where SupplierNo=@SupplierNo";
            int row = helper.ExecuteNonQueryAsync(strSql, CommandType.Text, new System.Data.SqlClient.SqlParameter("@SupplierNo", cmbSuppliersDelete.Text.Trim())).Result;
            if(row>0)
            {
                MessageBox.Show("删除成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("删除失败，请重新尝试，如有问题，请联系管理员解决");
            }
        }

        private void btnnodo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
