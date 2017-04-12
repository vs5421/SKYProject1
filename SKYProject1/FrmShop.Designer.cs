namespace SKYProject1
{
    partial class FrmShop
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
            this.btnClerk = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClerk
            // 
            this.btnClerk.Location = new System.Drawing.Point(32, 96);
            this.btnClerk.Name = "btnClerk";
            this.btnClerk.Size = new System.Drawing.Size(75, 23);
            this.btnClerk.TabIndex = 0;
            this.btnClerk.Text = "店员管理";
            this.btnClerk.UseVisualStyleBackColor = true;
            this.btnClerk.Click += new System.EventHandler(this.btnClerk_Click);
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(296, 96);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(75, 23);
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "客户管理";
            this.btnClient.UseVisualStyleBackColor = true;
            // 
            // FrmShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 350);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnClerk);
            this.Name = "FrmShop";
            this.Text = "FrmShop";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClerk;
        private System.Windows.Forms.Button btnClient;
    }
}