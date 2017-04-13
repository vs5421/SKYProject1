namespace SKYProject1
{
    partial class FrmKeeper
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
            this.components = new System.ComponentModel.Container();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblKeeperName = new System.Windows.Forms.Label();
            this.txtKeeperName = new System.Windows.Forms.TextBox();
            this.livShow = new System.Windows.Forms.ListView();
            this.Uid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KeeperName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telephone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UpdateTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.CmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(326, 10);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "增加";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(223, 12);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblKeeperName
            // 
            this.lblKeeperName.AutoSize = true;
            this.lblKeeperName.Location = new System.Drawing.Point(12, 15);
            this.lblKeeperName.Name = "lblKeeperName";
            this.lblKeeperName.Size = new System.Drawing.Size(77, 12);
            this.lblKeeperName.TabIndex = 5;
            this.lblKeeperName.Text = "按姓名查询：";
            // 
            // txtKeeperName
            // 
            this.txtKeeperName.Location = new System.Drawing.Point(95, 12);
            this.txtKeeperName.Name = "txtKeeperName";
            this.txtKeeperName.Size = new System.Drawing.Size(108, 21);
            this.txtKeeperName.TabIndex = 6;
            // 
            // livShow
            // 
            this.livShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Uid,
            this.KeeperName,
            this.Sex,
            this.Telephone,
            this.IDNumber,
            this.Address});
            this.livShow.ContextMenuStrip = this.CmsMenu;
            this.livShow.FullRowSelect = true;
            this.livShow.GridLines = true;
            this.livShow.Location = new System.Drawing.Point(12, 41);
            this.livShow.MultiSelect = false;
            this.livShow.Name = "livShow";
            this.livShow.Size = new System.Drawing.Size(387, 271);
            this.livShow.TabIndex = 7;
            this.livShow.UseCompatibleStateImageBehavior = false;
            this.livShow.View = System.Windows.Forms.View.Details;
            // 
            // Uid
            // 
            this.Uid.Text = "用户名";
            this.Uid.Width = 49;
            // 
            // KeeperName
            // 
            this.KeeperName.Text = "姓名";
            this.KeeperName.Width = 48;
            // 
            // Sex
            // 
            this.Sex.Text = "性别";
            this.Sex.Width = 54;
            // 
            // Telephone
            // 
            this.Telephone.Text = "电话";
            this.Telephone.Width = 66;
            // 
            // IDNumber
            // 
            this.IDNumber.Text = "身份证";
            this.IDNumber.Width = 88;
            // 
            // Address
            // 
            this.Address.Text = "家庭住址";
            this.Address.Width = 110;
            // 
            // CmsMenu
            // 
            this.CmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateTSMI,
            this.DeleteTSMI});
            this.CmsMenu.Name = "CmsMenu";
            this.CmsMenu.Size = new System.Drawing.Size(101, 48);
            // 
            // UpdateTSMI
            // 
            this.UpdateTSMI.Name = "UpdateTSMI";
            this.UpdateTSMI.Size = new System.Drawing.Size(100, 22);
            this.UpdateTSMI.Text = "编辑";
            this.UpdateTSMI.Click += new System.EventHandler(this.UpdateTSMI_Click);
            // 
            // DeleteTSMI
            // 
            this.DeleteTSMI.Name = "DeleteTSMI";
            this.DeleteTSMI.Size = new System.Drawing.Size(100, 22);
            this.DeleteTSMI.Text = "删除";
            this.DeleteTSMI.Click += new System.EventHandler(this.DeleteTSMI_Click);
            // 
            // FrmKeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 324);
            this.Controls.Add(this.livShow);
            this.Controls.Add(this.txtKeeperName);
            this.Controls.Add(this.lblKeeperName);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnInsert);
            this.Name = "FrmKeeper";
            this.Text = "仓库管理员界面";
            this.Activated += new System.EventHandler(this.FrmWHKeeper_Activated);
            this.Load += new System.EventHandler(this.FrmWHKeeper_Load);
            this.CmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblKeeperName;
        private System.Windows.Forms.TextBox txtKeeperName;
        private System.Windows.Forms.ListView livShow;
        private System.Windows.Forms.ColumnHeader Uid;
        private System.Windows.Forms.ColumnHeader KeeperName;
        private System.Windows.Forms.ColumnHeader Sex;
        private System.Windows.Forms.ColumnHeader Telephone;
        private System.Windows.Forms.ColumnHeader IDNumber;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ContextMenuStrip CmsMenu;
        private System.Windows.Forms.ToolStripMenuItem UpdateTSMI;
        private System.Windows.Forms.ToolStripMenuItem DeleteTSMI;
    }
}