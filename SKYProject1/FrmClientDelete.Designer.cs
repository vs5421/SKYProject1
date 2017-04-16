namespace SKYProject1
{
    partial class FrmClientDelete
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblShowNo = new System.Windows.Forms.Label();
            this.lblShowName = new System.Windows.Forms.Label();
            this.lblShowSex = new System.Windows.Forms.Label();
            this.lblShowPhone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(26, 202);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(148, 202);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(15, 160);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(65, 12);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "联系电话：";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(39, 114);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(41, 12);
            this.lblSex.TabIndex = 12;
            this.lblSex.Text = "性别：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(39, 68);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "姓名：";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(39, 19);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(41, 12);
            this.lblNo.TabIndex = 10;
            this.lblNo.Text = "编号：";
            // 
            // lblShowNo
            // 
            this.lblShowNo.AutoSize = true;
            this.lblShowNo.Location = new System.Drawing.Point(86, 19);
            this.lblShowNo.Name = "lblShowNo";
            this.lblShowNo.Size = new System.Drawing.Size(41, 12);
            this.lblShowNo.TabIndex = 14;
            this.lblShowNo.Text = "label1";
            // 
            // lblShowName
            // 
            this.lblShowName.AutoSize = true;
            this.lblShowName.Location = new System.Drawing.Point(86, 68);
            this.lblShowName.Name = "lblShowName";
            this.lblShowName.Size = new System.Drawing.Size(41, 12);
            this.lblShowName.TabIndex = 15;
            this.lblShowName.Text = "label2";
            // 
            // lblShowSex
            // 
            this.lblShowSex.AutoSize = true;
            this.lblShowSex.Location = new System.Drawing.Point(86, 114);
            this.lblShowSex.Name = "lblShowSex";
            this.lblShowSex.Size = new System.Drawing.Size(41, 12);
            this.lblShowSex.TabIndex = 16;
            this.lblShowSex.Text = "label3";
            // 
            // lblShowPhone
            // 
            this.lblShowPhone.AutoSize = true;
            this.lblShowPhone.Location = new System.Drawing.Point(86, 160);
            this.lblShowPhone.Name = "lblShowPhone";
            this.lblShowPhone.Size = new System.Drawing.Size(41, 12);
            this.lblShowPhone.TabIndex = 17;
            this.lblShowPhone.Text = "label4";
            // 
            // FrmClientDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 242);
            this.Controls.Add(this.lblShowPhone);
            this.Controls.Add(this.lblShowSex);
            this.Controls.Add(this.lblShowName);
            this.Controls.Add(this.lblShowNo);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Name = "FrmClientDelete";
            this.Text = "删除客户信息";
            this.Load += new System.EventHandler(this.FrmClientDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblShowNo;
        private System.Windows.Forms.Label lblShowName;
        private System.Windows.Forms.Label lblShowSex;
        private System.Windows.Forms.Label lblShowPhone;
    }
}