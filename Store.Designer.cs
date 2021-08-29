
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
            this.deleteItemBtn = new System.Windows.Forms.Button();
            this.editItemBtn = new System.Windows.Forms.Button();
            this.buyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // storeLstBx
            // 
            this.storeLstBx.FormattingEnabled = true;
            this.storeLstBx.Location = new System.Drawing.Point(12, 55);
            this.storeLstBx.Name = "storeLstBx";
            this.storeLstBx.Size = new System.Drawing.Size(263, 303);
            this.storeLstBx.TabIndex = 0;
            // 
            // storeLbl
            // 
            this.storeLbl.AutoSize = true;
            this.storeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeLbl.Location = new System.Drawing.Point(147, 21);
            this.storeLbl.Name = "storeLbl";
            this.storeLbl.Size = new System.Drawing.Size(79, 31);
            this.storeLbl.TabIndex = 1;
            this.storeLbl.Text = "Store";
            // 
            // addItemBtn
            // 
            this.addItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemBtn.Location = new System.Drawing.Point(281, 315);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(91, 43);
            this.addItemBtn.TabIndex = 2;
            this.addItemBtn.Text = "Add an Item to Store";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // deleteItemBtn
            // 
            this.deleteItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteItemBtn.Location = new System.Drawing.Point(281, 103);
            this.deleteItemBtn.Name = "deleteItemBtn";
            this.deleteItemBtn.Size = new System.Drawing.Size(91, 44);
            this.deleteItemBtn.TabIndex = 3;
            this.deleteItemBtn.Text = "Delete Item";
            this.deleteItemBtn.UseVisualStyleBackColor = true;
            this.deleteItemBtn.Click += new System.EventHandler(this.deleteItemBtn_Click);
            // 
            // editItemBtn
            // 
            this.editItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editItemBtn.Location = new System.Drawing.Point(281, 55);
            this.editItemBtn.Name = "editItemBtn";
            this.editItemBtn.Size = new System.Drawing.Size(91, 42);
            this.editItemBtn.TabIndex = 4;
            this.editItemBtn.Text = "Edit Item";
            this.editItemBtn.UseVisualStyleBackColor = true;
            this.editItemBtn.Click += new System.EventHandler(this.editItemBtn_Click);
            // 
            // buyBtn
            // 
            this.buyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyBtn.Location = new System.Drawing.Point(144, 378);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(91, 42);
            this.buyBtn.TabIndex = 5;
            this.buyBtn.Text = "Buy";
            this.buyBtn.UseVisualStyleBackColor = true;
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 450);
            this.Controls.Add(this.buyBtn);
            this.Controls.Add(this.editItemBtn);
            this.Controls.Add(this.deleteItemBtn);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.storeLbl);
            this.Controls.Add(this.storeLstBx);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Store";
            this.Text = "Store";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox storeLstBx;
        private System.Windows.Forms.Label storeLbl;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Button deleteItemBtn;
        private System.Windows.Forms.Button editItemBtn;
        private System.Windows.Forms.Button buyBtn;
    }
}