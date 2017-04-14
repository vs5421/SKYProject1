﻿using System;
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
        DBHelp helper = new DBHelp();

        private void FrmClient_Load(object sender, EventArgs e)
        {
            ShowInformation();
        }
        private async void ShowInformation()
        {

            string strSql = "select ClientNo,ClientName,Sex,Telephone from Client";
            SqlDataReader reader = await helper.ExecuteReaderAsync(strSql, CommandType.Text);
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
        frmClientQuery fQuery;
        private void tsmiQuery_Click(object sender, EventArgs e)
        {
            fQuery = null;
            fQuery = new frmClientQuery(this);
            fQuery.Show();
        }

        frmClientAdd fAdd;
        private void tsmiAdd_Click(object sender, EventArgs e)
        {
            fAdd = null;
            fAdd = new frmClientAdd();
            fAdd.Show();
            //添加完数据后重新显示一遍
            ShowInformation();
        }
    }
}
