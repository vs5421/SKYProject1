namespace SKYProject1
{
    partial class FrmShop
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
            this.PersonnelManaGementTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ClerkTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SalesTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SalesListTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.BillOfLadingTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeThePasswordTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ClerkManagementTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientManagementTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMLRecoRdsOfTheQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SalesTSMI,
            this.PersonnelManaGementTSMI,
            this.TSMLRecoRdsOfTheQuery});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(430, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // PersonnelManaGementTSMI
            // 
            this.PersonnelManaGementTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClerkTSMI,
            this.ClientTSMI});
            this.PersonnelManaGementTSMI.Name = "PersonnelManaGementTSMI";
            this.PersonnelManaGementTSMI.Size = new System.Drawing.Size(68, 21);
            this.PersonnelManaGementTSMI.Text = "人员管理";
            // 
            // ClerkTSMI
            // 
            this.ClerkTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeThePasswordTSMI,
            this.ClerkManagementTSMI});
            this.ClerkTSMI.Name = "ClerkTSMI";
            this.ClerkTSMI.Size = new System.Drawing.Size(152, 22);
            this.ClerkTSMI.Text = "店员";
            // 
            // ClientTSMI
            // 
            this.ClientTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientManagementTSMI});
            this.ClientTSMI.Name = "ClientTSMI";
            this.ClientTSMI.Size = new System.Drawing.Size(152, 22);
            this.ClientTSMI.Text = "客户";
            // 
            // SalesTSMI
            // 
            this.SalesTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SalesListTSMI,
            this.BillOfLadingTSMI});
            this.SalesTSMI.Name = "SalesTSMI";
            this.SalesTSMI.Size = new System.Drawing.Size(44, 21);
            this.SalesTSMI.Text = "销售";
            // 
            // SalesListTSMI
            // 
            this.SalesListTSMI.Name = "SalesListTSMI";
            this.SalesListTSMI.Size = new System.Drawing.Size(152, 22);
            this.SalesListTSMI.Text = "销售单";
            // 
            // BillOfLadingTSMI
            // 
            this.BillOfLadingTSMI.Name = "BillOfLadingTSMI";
            this.BillOfLadingTSMI.Size = new System.Drawing.Size(152, 22);
            this.BillOfLadingTSMI.Text = "提货单";
            // 
            // ChangeThePasswordTSMI
            // 
            this.ChangeThePasswordTSMI.Name = "ChangeThePasswordTSMI";
            this.ChangeThePasswordTSMI.Size = new System.Drawing.Size(152, 22);
            this.ChangeThePasswordTSMI.Text = "修改密码";
            // 
            // ClerkManagementTSMI
            // 
            this.ClerkManagementTSMI.Name = "ClerkManagementTSMI";
            this.ClerkManagementTSMI.Size = new System.Drawing.Size(152, 22);
            this.ClerkManagementTSMI.Text = "店员管理";
            // 
            // ClientManagementTSMI
            // 
            this.ClientManagementTSMI.Name = "ClientManagementTSMI";
            this.ClientManagementTSMI.Size = new System.Drawing.Size(152, 22);
            this.ClientManagementTSMI.Text = "客户管理";
            // 
            // TSMLRecoRdsOfTheQuery
            // 
            this.TSMLRecoRdsOfTheQuery.Name = "TSMLRecoRdsOfTheQuery";
            this.TSMLRecoRdsOfTheQuery.Size = new System.Drawing.Size(68, 21);
            this.TSMLRecoRdsOfTheQuery.Text = "记录查询";
            // 
            // FrmShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 350);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmShop";
            this.Text = "FrmShop";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SalesTSMI;
        private System.Windows.Forms.ToolStripMenuItem SalesListTSMI;
        private System.Windows.Forms.ToolStripMenuItem BillOfLadingTSMI;
        private System.Windows.Forms.ToolStripMenuItem PersonnelManaGementTSMI;
        private System.Windows.Forms.ToolStripMenuItem ClerkTSMI;
        private System.Windows.Forms.ToolStripMenuItem ClientTSMI;
        private System.Windows.Forms.ToolStripMenuItem ChangeThePasswordTSMI;
        private System.Windows.Forms.ToolStripMenuItem ClerkManagementTSMI;
        private System.Windows.Forms.ToolStripMenuItem ClientManagementTSMI;
        private System.Windows.Forms.ToolStripMenuItem TSMLRecoRdsOfTheQuery;
    }
}