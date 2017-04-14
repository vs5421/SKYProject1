namespace SKYProject1
{
    partial class FrmWareHouse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CommodityManageTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertCommodityTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.OutCommodityTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectCommodityTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonnelMaanageTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.KeeperTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageKeeperTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdatePasswordTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SupplierTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageSupplierTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.RecordsManageTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CommodityManageTSMI,
            this.PersonnelMaanageTSMI,
            this.RecordsManageTSMI});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(526, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CommodityManageTSMI
            // 
            this.CommodityManageTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InsertCommodityTSMI,
            this.OutCommodityTSMI,
            this.SelectCommodityTSMI});
            this.CommodityManageTSMI.Name = "CommodityManageTSMI";
            this.CommodityManageTSMI.Size = new System.Drawing.Size(68, 21);
            this.CommodityManageTSMI.Text = "商品管理";
            // 
            // InsertCommodityTSMI
            // 
            this.InsertCommodityTSMI.Name = "InsertCommodityTSMI";
            this.InsertCommodityTSMI.Size = new System.Drawing.Size(152, 22);
            this.InsertCommodityTSMI.Text = "商品入库";
            this.InsertCommodityTSMI.Click += new System.EventHandler(this.入库ToolStripMenuItem_Click);
            // 
            // OutCommodityTSMI
            // 
            this.OutCommodityTSMI.Name = "OutCommodityTSMI";
            this.OutCommodityTSMI.Size = new System.Drawing.Size(152, 22);
            this.OutCommodityTSMI.Text = "商品出库";
            this.OutCommodityTSMI.Click += new System.EventHandler(this.OutCommodityTSMI_Click);
            // 
            // SelectCommodityTSMI
            // 
            this.SelectCommodityTSMI.Name = "SelectCommodityTSMI";
            this.SelectCommodityTSMI.Size = new System.Drawing.Size(152, 22);
            this.SelectCommodityTSMI.Text = "商品查询";
            this.SelectCommodityTSMI.Click += new System.EventHandler(this.SelectCommodityTSMI_Click);
            // 
            // PersonnelMaanageTSMI
            // 
            this.PersonnelMaanageTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KeeperTSMI,
            this.SupplierTSMI});
            this.PersonnelMaanageTSMI.Name = "PersonnelMaanageTSMI";
            this.PersonnelMaanageTSMI.Size = new System.Drawing.Size(68, 21);
            this.PersonnelMaanageTSMI.Text = "人员管理";
            // 
            // KeeperTSMI
            // 
            this.KeeperTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManageKeeperTSMI,
            this.UpdatePasswordTSMI});
            this.KeeperTSMI.Name = "KeeperTSMI";
            this.KeeperTSMI.Size = new System.Drawing.Size(152, 22);
            this.KeeperTSMI.Text = "仓管员";
            // 
            // ManageKeeperTSMI
            // 
            this.ManageKeeperTSMI.Name = "ManageKeeperTSMI";
            this.ManageKeeperTSMI.Size = new System.Drawing.Size(152, 22);
            this.ManageKeeperTSMI.Text = "仓管员管理";
            this.ManageKeeperTSMI.Click += new System.EventHandler(this.ManageKeeperTSMI_Click);
            // 
            // UpdatePasswordTSMI
            // 
            this.UpdatePasswordTSMI.Name = "UpdatePasswordTSMI";
            this.UpdatePasswordTSMI.Size = new System.Drawing.Size(152, 22);
            this.UpdatePasswordTSMI.Text = "修改密码";
            this.UpdatePasswordTSMI.Click += new System.EventHandler(this.UpdatePasswordTSMI_Click);
            // 
            // SupplierTSMI
            // 
            this.SupplierTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManageSupplierTSMI});
            this.SupplierTSMI.Name = "SupplierTSMI";
            this.SupplierTSMI.Size = new System.Drawing.Size(152, 22);
            this.SupplierTSMI.Text = "供应商";
            // 
            // ManageSupplierTSMI
            // 
            this.ManageSupplierTSMI.Name = "ManageSupplierTSMI";
            this.ManageSupplierTSMI.Size = new System.Drawing.Size(136, 22);
            this.ManageSupplierTSMI.Text = "供应商管理";
            // 
            // RecordsManageTSMI
            // 
            this.RecordsManageTSMI.Name = "RecordsManageTSMI";
            this.RecordsManageTSMI.Size = new System.Drawing.Size(68, 21);
            this.RecordsManageTSMI.Text = "记录管理";
            // 
            // FrmWareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 419);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmWareHouse";
            this.Text = "仓库管理";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CommodityManageTSMI;
        private System.Windows.Forms.ToolStripMenuItem InsertCommodityTSMI;
        private System.Windows.Forms.ToolStripMenuItem OutCommodityTSMI;
        private System.Windows.Forms.ToolStripMenuItem SelectCommodityTSMI;
        private System.Windows.Forms.ToolStripMenuItem PersonnelMaanageTSMI;
        private System.Windows.Forms.ToolStripMenuItem KeeperTSMI;
        private System.Windows.Forms.ToolStripMenuItem ManageKeeperTSMI;
        private System.Windows.Forms.ToolStripMenuItem UpdatePasswordTSMI;
        private System.Windows.Forms.ToolStripMenuItem SupplierTSMI;
        private System.Windows.Forms.ToolStripMenuItem ManageSupplierTSMI;
        private System.Windows.Forms.ToolStripMenuItem RecordsManageTSMI;
    }
}