namespace SKYProject1
{
    partial class Suppliers
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.送货单管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加一个供应商ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除供应商ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改供应商ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.添加一个新的供应商ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除一个旧的供应商ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改一个旧的供应商ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvSupplierShow = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSuppliersphone = new System.Windows.Forms.TextBox();
            this.txtSuppliersName = new System.Windows.Forms.TextBox();
            this.txtSuppliersID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.送货单管理ToolStripMenuItem,
            this.增加一个供应商ToolStripMenuItem,
            this.删除供应商ToolStripMenuItem,
            this.修改供应商ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 114);
            // 
            // 送货单管理ToolStripMenuItem
            // 
            this.送货单管理ToolStripMenuItem.Name = "送货单管理ToolStripMenuItem";
            this.送货单管理ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.送货单管理ToolStripMenuItem.Text = "送货单管理";
            this.送货单管理ToolStripMenuItem.Click += new System.EventHandler(this.送货单管理ToolStripMenuItem_Click);
            // 
            // 增加一个供应商ToolStripMenuItem
            // 
            this.增加一个供应商ToolStripMenuItem.Name = "增加一个供应商ToolStripMenuItem";
            this.增加一个供应商ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.增加一个供应商ToolStripMenuItem.Text = "增加一个供应商";
            this.增加一个供应商ToolStripMenuItem.Click += new System.EventHandler(this.增加一个供应商ToolStripMenuItem_Click);
            // 
            // 删除供应商ToolStripMenuItem
            // 
            this.删除供应商ToolStripMenuItem.Name = "删除供应商ToolStripMenuItem";
            this.删除供应商ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.删除供应商ToolStripMenuItem.Text = "删除供应商";
            this.删除供应商ToolStripMenuItem.Click += new System.EventHandler(this.删除供应商ToolStripMenuItem_Click);
            // 
            // 修改供应商ToolStripMenuItem
            // 
            this.修改供应商ToolStripMenuItem.Name = "修改供应商ToolStripMenuItem";
            this.修改供应商ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.修改供应商ToolStripMenuItem.Text = "修改供应商";
            this.修改供应商ToolStripMenuItem.Click += new System.EventHandler(this.修改供应商ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加一个新的供应商ToolStripMenuItem,
            this.删除一个旧的供应商ToolStripMenuItem,
            this.修改一个旧的供应商ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(526, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 添加一个新的供应商ToolStripMenuItem
            // 
            this.添加一个新的供应商ToolStripMenuItem.Name = "添加一个新的供应商ToolStripMenuItem";
            this.添加一个新的供应商ToolStripMenuItem.Size = new System.Drawing.Size(128, 21);
            this.添加一个新的供应商ToolStripMenuItem.Text = "添加一个新的供应商";
            this.添加一个新的供应商ToolStripMenuItem.Click += new System.EventHandler(this.添加一个新的供应商ToolStripMenuItem_Click);
            // 
            // 删除一个旧的供应商ToolStripMenuItem
            // 
            this.删除一个旧的供应商ToolStripMenuItem.Name = "删除一个旧的供应商ToolStripMenuItem";
            this.删除一个旧的供应商ToolStripMenuItem.Size = new System.Drawing.Size(128, 21);
            this.删除一个旧的供应商ToolStripMenuItem.Text = "删除一个旧的供应商";
            this.删除一个旧的供应商ToolStripMenuItem.Click += new System.EventHandler(this.删除一个旧的供应商ToolStripMenuItem_Click);
            // 
            // 修改一个旧的供应商ToolStripMenuItem
            // 
            this.修改一个旧的供应商ToolStripMenuItem.Name = "修改一个旧的供应商ToolStripMenuItem";
            this.修改一个旧的供应商ToolStripMenuItem.Size = new System.Drawing.Size(128, 21);
            this.修改一个旧的供应商ToolStripMenuItem.Text = "修改一个旧的供应商";
            this.修改一个旧的供应商ToolStripMenuItem.Click += new System.EventHandler(this.修改一个旧的供应商ToolStripMenuItem_Click);
            // 
            // lvSupplierShow
            // 
            this.lvSupplierShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvSupplierShow.ContextMenuStrip = this.contextMenuStrip1;
            this.lvSupplierShow.FullRowSelect = true;
            this.lvSupplierShow.Location = new System.Drawing.Point(4, 63);
            this.lvSupplierShow.MultiSelect = false;
            this.lvSupplierShow.Name = "lvSupplierShow";
            this.lvSupplierShow.Size = new System.Drawing.Size(526, 313);
            this.lvSupplierShow.TabIndex = 2;
            this.lvSupplierShow.UseCompatibleStateImageBehavior = false;
            this.lvSupplierShow.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "供应商编号";
            this.columnHeader1.Width = 137;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "供应商负责人姓名";
            this.columnHeader2.Width = 133;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "联系电话";
            this.columnHeader3.Width = 146;
            // 
            // txtSuppliersphone
            // 
            this.txtSuppliersphone.Location = new System.Drawing.Point(241, 36);
            this.txtSuppliersphone.Name = "txtSuppliersphone";
            this.txtSuppliersphone.Size = new System.Drawing.Size(68, 21);
            this.txtSuppliersphone.TabIndex = 11;
            // 
            // txtSuppliersName
            // 
            this.txtSuppliersName.Location = new System.Drawing.Point(410, 36);
            this.txtSuppliersName.Name = "txtSuppliersName";
            this.txtSuppliersName.Size = new System.Drawing.Size(72, 21);
            this.txtSuppliersName.TabIndex = 10;
            // 
            // txtSuppliersID
            // 
            this.txtSuppliersID.Location = new System.Drawing.Point(83, 36);
            this.txtSuppliersID.Name = "txtSuppliersID";
            this.txtSuppliersID.Size = new System.Drawing.Size(69, 21);
            this.txtSuppliersID.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "供应商电话：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "供应商联系人：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "供应商ID：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(488, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "筛选";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 388);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSuppliersphone);
            this.Controls.Add(this.txtSuppliersName);
            this.Controls.Add(this.txtSuppliersID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvSupplierShow);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Suppliers";
            this.Text = "供应商管理界面";
            this.Activated += new System.EventHandler(this.Suppliers_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Suppliers_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 送货单管理ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加一个新的供应商ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除一个旧的供应商ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改一个旧的供应商ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加一个供应商ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除供应商ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改供应商ToolStripMenuItem;
        private System.Windows.Forms.ListView lvSupplierShow;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtSuppliersphone;
        private System.Windows.Forms.TextBox txtSuppliersName;
        private System.Windows.Forms.TextBox txtSuppliersID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}