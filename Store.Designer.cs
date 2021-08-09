
namespace GameInventory
{
    partial class Store
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
            this.storeLstBx = new System.Windows.Forms.ListBox();
            this.storeLbl = new System.Windows.Forms.Label();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // storeLstBx
            // 
            this.storeLstBx.FormattingEnabled = true;
            this.storeLstBx.Location = new System.Drawing.Point(41, 55);
            this.storeLstBx.Name = "storeLstBx";
            this.storeLstBx.Size = new System.Drawing.Size(263, 303);
            this.storeLstBx.TabIndex = 0;
            // 
            // storeLbl
            // 
            this.storeLbl.AutoSize = true;
            this.storeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeLbl.Location = new System.Drawing.Point(133, 21);
            this.storeLbl.Name = "storeLbl";
            this.storeLbl.Size = new System.Drawing.Size(79, 31);
            this.storeLbl.TabIndex = 1;
            this.storeLbl.Text = "Store";
            // 
            // addItemBtn
            // 
            this.addItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemBtn.Location = new System.Drawing.Point(114, 364);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(113, 59);
            this.addItemBtn.TabIndex = 2;
            this.addItemBtn.Text = "Add an Item to Store";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 450);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.storeLbl);
            this.Controls.Add(this.storeLstBx);
            this.Name = "Store";
            this.Text = "Store";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox storeLstBx;
        private System.Windows.Forms.Label storeLbl;
        private System.Windows.Forms.Button addItemBtn;
    }
}