﻿using System;
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
    public partial class FrmWareHouse : Form
    {
        public FrmWareHouse()
        {
            InitializeComponent();
        }

        private void 入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void OutCommodityTSMI_Click(object sender, EventArgs e)
        {

        }

        private void SelectCommodityTSMI_Click(object sender, EventArgs e)
        {

        }

        private void ManageKeeperTSMI_Click(object sender, EventArgs e)
        {
            FrmKeeper fk = new FrmKeeper();
            fk.MdiParent = this;
            fk.Show();
        }

        private void UpdatePasswordTSMI_Click(object sender, EventArgs e)
        {
            FrmPasswordUpdate fpu = new FrmPasswordUpdate();
            fpu.MdiParent = this;
            fpu.Show();
        }
    }
}
