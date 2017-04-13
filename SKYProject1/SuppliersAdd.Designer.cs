namespace SKYProject1
{
    partial class SuppliersAdd
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
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.txtSupplierphoe = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "添加一个供应商信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "供应商编号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "联系号码：";
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Location = new System.Drawing.Point(145, 119);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(165, 21);
            this.txtSupplierID.TabIndex = 4;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(145, 158);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(165, 21);
            this.txtSupplierName.TabIndex = 5;
            // 
            // txtSupplierphoe
            // 
            this.txtSupplierphoe.Location = new System.Drawing.Point(145, 197);
            this.txtSupplierphoe.Name = "txtSupplierphoe";
            this.txtSupplierphoe.Size = new System.Drawing.Size(165, 21);
            this.txtSupplierphoe.TabIndex = 6;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(81, 293);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "确认添加";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(235, 293);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 8;
            this.btnUndo.Text = "取消";
            this.btnUndo.UseVisualStyleBackColor = true;
            // 
            // SuppliersAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 370);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtSupplierphoe);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.txtSupplierID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SuppliersAdd";
            this.Text = "添加一个供应商";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.TextBox txtSupplierphoe;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnUndo;
    }
}