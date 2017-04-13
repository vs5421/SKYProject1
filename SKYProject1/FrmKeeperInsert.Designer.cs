namespace SKYProject1
{
    partial class FrmKeeperInsert
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
            this.lblUid = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblKeeperName = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblIDNumber = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtKeeperName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtIDNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.erpTest = new System.Windows.Forms.ErrorProvider(this.components);
            this.rboMale = new System.Windows.Forms.RadioButton();
            this.rboFeMale = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.erpTest)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUid
            // 
            this.lblUid.AutoSize = true;
            this.lblUid.Location = new System.Drawing.Point(32, 40);
            this.lblUid.Name = "lblUid";
            this.lblUid.Size = new System.Drawing.Size(53, 12);
            this.lblUid.TabIndex = 0;
            this.lblUid.Text = "用户名：";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(32, 72);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(41, 12);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "密码：";
            // 
            // lblKeeperName
            // 
            this.lblKeeperName.AutoSize = true;
            this.lblKeeperName.Location = new System.Drawing.Point(32, 105);
            this.lblKeeperName.Name = "lblKeeperName";
            this.lblKeeperName.Size = new System.Drawing.Size(41, 12);
            this.lblKeeperName.TabIndex = 2;
            this.lblKeeperName.Text = "姓名：";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(32, 138);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(41, 12);
            this.lblSex.TabIndex = 3;
            this.lblSex.Text = "性别：";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(32, 174);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(65, 12);
            this.lblTelephone.TabIndex = 4;
            this.lblTelephone.Text = "电话号码：";
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.AutoSize = true;
            this.lblIDNumber.Location = new System.Drawing.Point(32, 212);
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(53, 12);
            this.lblIDNumber.TabIndex = 5;
            this.lblIDNumber.Text = "身份证：";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(32, 250);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(65, 12);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "家庭住址：";
            // 
            // txtUid
            // 
            this.txtUid.Location = new System.Drawing.Point(113, 31);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(140, 21);
            this.txtUid.TabIndex = 7;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(113, 171);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(140, 21);
            this.txtTelephone.TabIndex = 9;
            // 
            // txtKeeperName
            // 
            this.txtKeeperName.Location = new System.Drawing.Point(113, 102);
            this.txtKeeperName.Name = "txtKeeperName";
            this.txtKeeperName.Size = new System.Drawing.Size(140, 21);
            this.txtKeeperName.TabIndex = 11;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(113, 69);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(140, 21);
            this.txtPassword.TabIndex = 12;
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.Location = new System.Drawing.Point(113, 209);
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Size = new System.Drawing.Size(140, 21);
            this.txtIDNumber.TabIndex = 13;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(113, 247);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(140, 21);
            this.txtAddress.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(113, 292);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // erpTest
            // 
            this.erpTest.ContainerControl = this;
            // 
            // rboMale
            // 
            this.rboMale.AutoSize = true;
            this.rboMale.Location = new System.Drawing.Point(113, 138);
            this.rboMale.Name = "rboMale";
            this.rboMale.Size = new System.Drawing.Size(35, 16);
            this.rboMale.TabIndex = 16;
            this.rboMale.TabStop = true;
            this.rboMale.Text = "男";
            this.rboMale.UseVisualStyleBackColor = true;
            // 
            // rboFeMale
            // 
            this.rboFeMale.AutoSize = true;
            this.rboFeMale.Location = new System.Drawing.Point(187, 138);
            this.rboFeMale.Name = "rboFeMale";
            this.rboFeMale.Size = new System.Drawing.Size(35, 16);
            this.rboFeMale.TabIndex = 17;
            this.rboFeMale.TabStop = true;
            this.rboFeMale.Text = "女";
            this.rboFeMale.UseVisualStyleBackColor = true;
            // 
            // FrmKeeperInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 327);
            this.Controls.Add(this.rboFeMale);
            this.Controls.Add(this.rboMale);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtIDNumber);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtKeeperName);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtUid);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblIDNumber);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblKeeperName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUid);
            this.Name = "FrmKeeperInsert";
            this.Text = "增加仓管员";
            this.Load += new System.EventHandler(this.FrmAddWHKeeper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUid;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblKeeperName;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblIDNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtUid;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtKeeperName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtIDNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider erpTest;
        private System.Windows.Forms.RadioButton rboFeMale;
        private System.Windows.Forms.RadioButton rboMale;
    }
}