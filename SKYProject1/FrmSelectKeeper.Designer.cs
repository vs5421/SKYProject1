namespace SKYProject1
{
    partial class FrmSelectKeeper
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
            this.livShow = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.Uid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KeeperName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telephone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
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
            this.livShow.Location = new System.Drawing.Point(12, 62);
            this.livShow.MultiSelect = false;
            this.livShow.Name = "livShow";
            this.livShow.Size = new System.Drawing.Size(331, 189);
            this.livShow.TabIndex = 0;
            this.livShow.UseCompatibleStateImageBehavior = false;
            this.livShow.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "查询所有：";
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
            this.Sex.Width = 48;
            // 
            // Telephone
            // 
            this.Telephone.Text = "电话";
            this.Telephone.Width = 54;
            // 
            // IDNumber
            // 
            this.IDNumber.Text = "身份证";
            this.IDNumber.Width = 72;
            // 
            // Address
            // 
            this.Address.Text = "家庭住址";
            // 
            // FrmSelectKeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 265);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.livShow);
            this.Name = "FrmSelectKeeper";
            this.Text = "FrmSelectKeeper";
            this.Load += new System.EventHandler(this.FrmSelectKeeper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView livShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Uid;
        private System.Windows.Forms.ColumnHeader KeeperName;
        private System.Windows.Forms.ColumnHeader Sex;
        private System.Windows.Forms.ColumnHeader Telephone;
        private System.Windows.Forms.ColumnHeader IDNumber;
        private System.Windows.Forms.ColumnHeader Address;
    }
}