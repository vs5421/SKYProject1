namespace SKYProject1
{
    partial class SuppliersDelete
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
            this.cmbSuppliersDelete = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnnodo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "删除一个供应商信息";
            // 
            // cmbSuppliersDelete
            // 
            this.cmbSuppliersDelete.FormattingEnabled = true;
            this.cmbSuppliersDelete.Location = new System.Drawing.Point(130, 72);
            this.cmbSuppliersDelete.Name = "cmbSuppliersDelete";
            this.cmbSuppliersDelete.Size = new System.Drawing.Size(166, 20);
            this.cmbSuppliersDelete.TabIndex = 1;
            this.cmbSuppliersDelete.TextChanged += new System.EventHandler(this.cmbSuppliersDelete_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "物品详细信息如下：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(82, 288);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnnodo
            // 
            this.btnnodo.Location = new System.Drawing.Point(292, 288);
            this.btnnodo.Name = "btnnodo";
            this.btnnodo.Size = new System.Drawing.Size(75, 23);
            this.btnnodo.TabIndex = 4;
            this.btnnodo.Text = "取消";
            this.btnnodo.UseVisualStyleBackColor = true;
            this.btnnodo.Click += new System.EventHandler(this.btnnodo_Click);
            // 
            // SuppliersDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 374);
            this.Controls.Add(this.btnnodo);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSuppliersDelete);
            this.Controls.Add(this.label1);
            this.Name = "SuppliersDelete";
            this.Text = "SuppliersDelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSuppliersDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnnodo;
    }
}