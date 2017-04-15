namespace SKYProject1
{
    partial class frmStockAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPurchaseID = new System.Windows.Forms.TextBox();
            this.txtCommandNo = new System.Windows.Forms.TextBox();
            this.txtCommandNum = new System.Windows.Forms.TextBox();
            this.txtCommandUnit = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbSupplierNo = new System.Windows.Forms.ComboBox();
            this.cmbUid = new System.Windows.Forms.ComboBox();
            this.txtCommandName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "进货";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "进货单编号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "供应商编号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "商品编号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "商品数量：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "商品规格（单位）：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "仓管员编号：";
            // 
            // txtPurchaseID
            // 
            this.txtPurchaseID.Location = new System.Drawing.Point(132, 65);
            this.txtPurchaseID.Name = "txtPurchaseID";
            this.txtPurchaseID.Size = new System.Drawing.Size(286, 21);
            this.txtPurchaseID.TabIndex = 8;
            // 
            // txtCommandNo
            // 
            this.txtCommandNo.Location = new System.Drawing.Point(132, 165);
            this.txtCommandNo.Name = "txtCommandNo";
            this.txtCommandNo.Size = new System.Drawing.Size(286, 21);
            this.txtCommandNo.TabIndex = 10;
            this.txtCommandNo.TextChanged += new System.EventHandler(this.txtCommandNo_TextChanged);
            // 
            // txtCommandNum
            // 
            this.txtCommandNum.Location = new System.Drawing.Point(132, 259);
            this.txtCommandNum.Name = "txtCommandNum";
            this.txtCommandNum.Size = new System.Drawing.Size(286, 21);
            this.txtCommandNum.TabIndex = 11;
            // 
            // txtCommandUnit
            // 
            this.txtCommandUnit.Location = new System.Drawing.Point(132, 309);
            this.txtCommandUnit.Name = "txtCommandUnit";
            this.txtCommandUnit.Size = new System.Drawing.Size(286, 21);
            this.txtCommandUnit.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "确认进货";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(329, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbSupplierNo
            // 
            this.cmbSupplierNo.FormattingEnabled = true;
            this.cmbSupplierNo.Location = new System.Drawing.Point(132, 115);
            this.cmbSupplierNo.Name = "cmbSupplierNo";
            this.cmbSupplierNo.Size = new System.Drawing.Size(286, 20);
            this.cmbSupplierNo.TabIndex = 17;
            // 
            // cmbUid
            // 
            this.cmbUid.FormattingEnabled = true;
            this.cmbUid.Location = new System.Drawing.Point(132, 362);
            this.cmbUid.Name = "cmbUid";
            this.cmbUid.Size = new System.Drawing.Size(286, 20);
            this.cmbUid.TabIndex = 18;
            // 
            // txtCommandName
            // 
            this.txtCommandName.Location = new System.Drawing.Point(266, 212);
            this.txtCommandName.Name = "txtCommandName";
            this.txtCommandName.Size = new System.Drawing.Size(152, 21);
            this.txtCommandName.TabIndex = 19;
            this.txtCommandName.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "请输入新物品的商品名称：";
            this.label7.Visible = false;
            // 
            // frmStockAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 482);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCommandName);
            this.Controls.Add(this.cmbUid);
            this.Controls.Add(this.cmbSupplierNo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCommandUnit);
            this.Controls.Add(this.txtCommandNum);
            this.Controls.Add(this.txtCommandNo);
            this.Controls.Add(this.txtPurchaseID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmStockAdd";
            this.Text = "进货单";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPurchaseID;
        private System.Windows.Forms.TextBox txtCommandNo;
        private System.Windows.Forms.TextBox txtCommandNum;
        private System.Windows.Forms.TextBox txtCommandUnit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbSupplierNo;
        private System.Windows.Forms.ComboBox cmbUid;
        private System.Windows.Forms.TextBox txtCommandName;
        private System.Windows.Forms.Label label7;
    }
}