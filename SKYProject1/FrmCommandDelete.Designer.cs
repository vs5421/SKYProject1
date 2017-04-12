namespace SKYProject1
{
    partial class FrmCommandDelete
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
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblCommandUnit = new System.Windows.Forms.Label();
            this.lblCommandNum = new System.Windows.Forms.Label();
            this.lblCommandName = new System.Windows.Forms.Label();
            this.lblCommandNo = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(34, 171);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(65, 12);
            this.lblUnit.TabIndex = 7;
            this.lblUnit.Text = "商品单位：";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(10, 125);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(89, 12);
            this.lblNum.TabIndex = 6;
            this.lblNum.Text = "商品入库数量：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 68);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 12);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "商品名称：";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(34, 23);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(65, 12);
            this.lblNo.TabIndex = 4;
            this.lblNo.Text = "商品编号：";
            // 
            // lblCommandUnit
            // 
            this.lblCommandUnit.AutoSize = true;
            this.lblCommandUnit.Location = new System.Drawing.Point(135, 171);
            this.lblCommandUnit.Name = "lblCommandUnit";
            this.lblCommandUnit.Size = new System.Drawing.Size(65, 12);
            this.lblCommandUnit.TabIndex = 11;
            this.lblCommandUnit.Text = "商品单位：";
            // 
            // lblCommandNum
            // 
            this.lblCommandNum.AutoSize = true;
            this.lblCommandNum.Location = new System.Drawing.Point(135, 125);
            this.lblCommandNum.Name = "lblCommandNum";
            this.lblCommandNum.Size = new System.Drawing.Size(89, 12);
            this.lblCommandNum.TabIndex = 10;
            this.lblCommandNum.Text = "商品入库数量：";
            // 
            // lblCommandName
            // 
            this.lblCommandName.AutoSize = true;
            this.lblCommandName.Location = new System.Drawing.Point(135, 68);
            this.lblCommandName.Name = "lblCommandName";
            this.lblCommandName.Size = new System.Drawing.Size(65, 12);
            this.lblCommandName.TabIndex = 9;
            this.lblCommandName.Text = "商品名称：";
            // 
            // lblCommandNo
            // 
            this.lblCommandNo.AutoSize = true;
            this.lblCommandNo.Location = new System.Drawing.Point(135, 23);
            this.lblCommandNo.Name = "lblCommandNo";
            this.lblCommandNo.Size = new System.Drawing.Size(65, 12);
            this.lblCommandNo.TabIndex = 8;
            this.lblCommandNo.Text = "商品编号：";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(24, 226);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "确定";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(152, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmCommandDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblCommandUnit);
            this.Controls.Add(this.lblCommandNum);
            this.Controls.Add(this.lblCommandName);
            this.Controls.Add(this.lblCommandNo);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNo);
            this.Name = "FrmCommandDelete";
            this.Text = "删除";
            this.Load += new System.EventHandler(this.FrmCommandDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblCommandUnit;
        private System.Windows.Forms.Label lblCommandNum;
        private System.Windows.Forms.Label lblCommandName;
        private System.Windows.Forms.Label lblCommandNo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
    }
}