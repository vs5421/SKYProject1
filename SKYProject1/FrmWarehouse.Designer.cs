namespace SKYProject1
{
    partial class FrmWareHouse
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
            this.btnCommand = new System.Windows.Forms.Button();
            this.btnKeeper = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCommand
            // 
            this.btnCommand.Location = new System.Drawing.Point(37, 94);
            this.btnCommand.Name = "btnCommand";
            this.btnCommand.Size = new System.Drawing.Size(75, 23);
            this.btnCommand.TabIndex = 0;
            this.btnCommand.Text = "商品管理";
            this.btnCommand.UseVisualStyleBackColor = true;
            // 
            // btnKeeper
            // 
            this.btnKeeper.Location = new System.Drawing.Point(191, 94);
            this.btnKeeper.Name = "btnKeeper";
            this.btnKeeper.Size = new System.Drawing.Size(75, 23);
            this.btnKeeper.TabIndex = 1;
            this.btnKeeper.Text = "仓管员管理";
            this.btnKeeper.UseVisualStyleBackColor = true;
            // 
            // btnSupplier
            // 
            this.btnSupplier.Location = new System.Drawing.Point(339, 94);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(75, 23);
            this.btnSupplier.TabIndex = 2;
            this.btnSupplier.Text = "供应商管理";
            this.btnSupplier.UseVisualStyleBackColor = true;
            // 
            // FrmWareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 383);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.btnKeeper);
            this.Controls.Add(this.btnCommand);
            this.Name = "FrmWareHouse";
            this.Text = "仓库管理";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCommand;
        private System.Windows.Forms.Button btnKeeper;
        private System.Windows.Forms.Button btnSupplier;
    }
}