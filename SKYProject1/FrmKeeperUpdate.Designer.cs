namespace SKYProject1
{
    partial class FrmKeeperUpdate
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtIDNumber = new System.Windows.Forms.TextBox();
            this.txtKeeperName = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblIDNumber = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblKeeperName = new System.Windows.Forms.Label();
            this.lblUid = new System.Windows.Forms.Label();
            this.rboFeMale = new System.Windows.Forms.RadioButton();
            this.rboMale = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(110, 281);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(110, 208);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(140, 21);
            this.txtAddress.TabIndex = 29;
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.Location = new System.Drawing.Point(110, 170);
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Size = new System.Drawing.Size(140, 21);
            this.txtIDNumber.TabIndex = 28;
            // 
            // txtKeeperName
            // 
            this.txtKeeperName.Location = new System.Drawing.Point(110, 63);
            this.txtKeeperName.Name = "txtKeeperName";
            this.txtKeeperName.Size = new System.Drawing.Size(140, 21);
            this.txtKeeperName.TabIndex = 26;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(110, 132);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(140, 21);
            this.txtTelephone.TabIndex = 25;
            // 
            // txtUid
            // 
            this.txtUid.Location = new System.Drawing.Point(110, 23);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(140, 21);
            this.txtUid.TabIndex = 24;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(29, 211);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(65, 12);
            this.lblAddress.TabIndex = 23;
            this.lblAddress.Text = "家庭住址：";
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.AutoSize = true;
            this.lblIDNumber.Location = new System.Drawing.Point(29, 173);
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(53, 12);
            this.lblIDNumber.TabIndex = 22;
            this.lblIDNumber.Text = "身份证：";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(29, 135);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(65, 12);
            this.lblTelephone.TabIndex = 21;
            this.lblTelephone.Text = "电话号码：";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(29, 99);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(41, 12);
            this.lblSex.TabIndex = 20;
            this.lblSex.Text = "性别：";
            // 
            // lblKeeperName
            // 
            this.lblKeeperName.AutoSize = true;
            this.lblKeeperName.Location = new System.Drawing.Point(29, 66);
            this.lblKeeperName.Name = "lblKeeperName";
            this.lblKeeperName.Size = new System.Drawing.Size(41, 12);
            this.lblKeeperName.TabIndex = 19;
            this.lblKeeperName.Text = "姓名：";
            // 
            // lblUid
            // 
            this.lblUid.AutoSize = true;
            this.lblUid.Location = new System.Drawing.Point(29, 32);
            this.lblUid.Name = "lblUid";
            this.lblUid.Size = new System.Drawing.Size(53, 12);
            this.lblUid.TabIndex = 17;
            this.lblUid.Text = "用户名：";
            // 
            // rboFeMale
            // 
            this.rboFeMale.AutoSize = true;
            this.rboFeMale.Location = new System.Drawing.Point(184, 99);
            this.rboFeMale.Name = "rboFeMale";
            this.rboFeMale.Size = new System.Drawing.Size(35, 16);
            this.rboFeMale.TabIndex = 32;
            this.rboFeMale.TabStop = true;
            this.rboFeMale.Text = "女";
            this.rboFeMale.UseVisualStyleBackColor = true;
            // 
            // rboMale
            // 
            this.rboMale.AutoSize = true;
            this.rboMale.Location = new System.Drawing.Point(110, 99);
            this.rboMale.Name = "rboMale";
            this.rboMale.Size = new System.Drawing.Size(35, 16);
            this.rboMale.TabIndex = 31;
            this.rboMale.TabStop = true;
            this.rboMale.Text = "男";
            this.rboMale.UseVisualStyleBackColor = true;
            // 
            // FrmKeeperUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 336);
            this.Controls.Add(this.rboFeMale);
            this.Controls.Add(this.rboMale);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtIDNumber);
            this.Controls.Add(this.txtKeeperName);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtUid);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblIDNumber);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblKeeperName);
            this.Controls.Add(this.lblUid);
            this.Name = "FrmKeeperUpdate";
            this.Text = "编辑界面";
            this.Load += new System.EventHandler(this.FrmUpdateKeeper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtIDNumber;
        private System.Windows.Forms.TextBox txtKeeperName;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtUid;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblIDNumber;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblKeeperName;
        private System.Windows.Forms.Label lblUid;
        private System.Windows.Forms.RadioButton rboFeMale;
        private System.Windows.Forms.RadioButton rboMale;
    }
}