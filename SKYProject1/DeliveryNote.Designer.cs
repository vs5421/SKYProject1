namespace SKYProject1
{
    partial class DeliveryNote
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSuppliersID = new System.Windows.Forms.ComboBox();
            this.lbxShow = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvwShow = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "供应商：";
            // 
            // cmbSuppliersID
            // 
            this.cmbSuppliersID.FormattingEnabled = true;
            this.cmbSuppliersID.Location = new System.Drawing.Point(89, 13);
            this.cmbSuppliersID.Name = "cmbSuppliersID";
            this.cmbSuppliersID.Size = new System.Drawing.Size(415, 20);
            this.cmbSuppliersID.TabIndex = 1;
            this.cmbSuppliersID.TextChanged += new System.EventHandler(this.cmbSuppliersID_TextChanged);
            // 
            // lbxShow
            // 
            this.lbxShow.AutoSize = true;
            this.lbxShow.Location = new System.Drawing.Point(30, 52);
            this.lbxShow.Name = "lbxShow";
            this.lbxShow.Size = new System.Drawing.Size(65, 12);
            this.lbxShow.TabIndex = 2;
            this.lbxShow.Text = "详细信息：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "送货单列表：";
            // 
            // lvwShow
            // 
            this.lvwShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvwShow.FullRowSelect = true;
            this.lvwShow.GridLines = true;
            this.lvwShow.Location = new System.Drawing.Point(12, 98);
            this.lvwShow.MultiSelect = false;
            this.lvwShow.Name = "lvwShow";
            this.lvwShow.Size = new System.Drawing.Size(610, 272);
            this.lvwShow.TabIndex = 4;
            this.lvwShow.UseCompatibleStateImageBehavior = false;
            this.lvwShow.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "进货单编号";
            this.columnHeader1.Width = 82;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "供应商编号";
            this.columnHeader2.Width = 83;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "商品编号";
            this.columnHeader3.Width = 74;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "商品数量";
            this.columnHeader4.Width = 81;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "商品规格（单位）";
            this.columnHeader5.Width = 109;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "进货日期";
            this.columnHeader6.Width = 84;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "仓管员编号";
            this.columnHeader7.Width = 91;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "无";
            // 
            // DeliveryNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 382);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvwShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxShow);
            this.Controls.Add(this.cmbSuppliersID);
            this.Controls.Add(this.label1);
            this.Name = "DeliveryNote";
            this.Text = "送货单管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSuppliersID;
        private System.Windows.Forms.Label lbxShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvwShow;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label3;
    }
}