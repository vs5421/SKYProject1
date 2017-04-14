namespace SKYProject1
{
    partial class frmSuppliersModify
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
            this.cbxSuppliersID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSuppliersID = new System.Windows.Forms.TextBox();
            this.txtSuppliersName = new System.Windows.Forms.TextBox();
            this.txtSuppliersphone = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxSuppliersID
            // 
            this.cbxSuppliersID.FormattingEnabled = true;
            this.cbxSuppliersID.Location = new System.Drawing.Point(60, 54);
            this.cbxSuppliersID.Name = "cbxSuppliersID";
            this.cbxSuppliersID.Size = new System.Drawing.Size(355, 20);
            this.cbxSuppliersID.TabIndex = 0;
            this.cbxSuppliersID.TextChanged += new System.EventHandler(this.cbxSuppliersID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "要修改的供应商编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "详细信息：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "新的供应商编号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "新的供应商联系人：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "新的联系电话：";
            // 
            // txtSuppliersID
            // 
            this.txtSuppliersID.Location = new System.Drawing.Point(158, 199);
            this.txtSuppliersID.Name = "txtSuppliersID";
            this.txtSuppliersID.Size = new System.Drawing.Size(257, 21);
            this.txtSuppliersID.TabIndex = 6;
            // 
            // txtSuppliersName
            // 
            this.txtSuppliersName.Location = new System.Drawing.Point(158, 269);
            this.txtSuppliersName.Name = "txtSuppliersName";
            this.txtSuppliersName.Size = new System.Drawing.Size(257, 21);
            this.txtSuppliersName.TabIndex = 7;
            // 
            // txtSuppliersphone
            // 
            this.txtSuppliersphone.Location = new System.Drawing.Point(158, 339);
            this.txtSuppliersphone.Name = "txtSuppliersphone";
            this.txtSuppliersphone.Size = new System.Drawing.Size(257, 21);
            this.txtSuppliersphone.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "确认修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 446);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 532);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSuppliersphone);
            this.Controls.Add(this.txtSuppliersName);
            this.Controls.Add(this.txtSuppliersID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxSuppliersID);
            this.Name = "frmModify";
            this.Text = "修改供应商信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxSuppliersID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSuppliersID;
        private System.Windows.Forms.TextBox txtSuppliersName;
        private System.Windows.Forms.TextBox txtSuppliersphone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}