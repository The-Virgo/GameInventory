
namespace GameInventory
{
    partial class Form1
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
            this.inventoryLstBx = new System.Windows.Forms.ListBox();
            this.storeBtn = new System.Windows.Forms.Button();
            this.inventoryLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inventoryLstBx
            // 
            this.inventoryLstBx.FormattingEnabled = true;
            this.inventoryLstBx.Location = new System.Drawing.Point(8, 124);
            this.inventoryLstBx.Name = "inventoryLstBx";
            this.inventoryLstBx.Size = new System.Drawing.Size(402, 277);
            this.inventoryLstBx.TabIndex = 0;
            // 
            // storeBtn
            // 
            this.storeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeBtn.Location = new System.Drawing.Point(278, 57);
            this.storeBtn.Name = "storeBtn";
            this.storeBtn.Size = new System.Drawing.Size(132, 41);
            this.storeBtn.TabIndex = 1;
            this.storeBtn.Text = "Go To Store";
            this.storeBtn.UseVisualStyleBackColor = true;
            this.storeBtn.Click += new System.EventHandler(this.storeBtn_Click);
            // 
            // inventoryLbl
            // 
            this.inventoryLbl.AutoSize = true;
            this.inventoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLbl.Location = new System.Drawing.Point(12, 57);
            this.inventoryLbl.Name = "inventoryLbl";
            this.inventoryLbl.Size = new System.Drawing.Size(127, 31);
            this.inventoryLbl.TabIndex = 2;
            this.inventoryLbl.Text = "Inventory";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 450);
            this.Controls.Add(this.inventoryLbl);
            this.Controls.Add(this.storeBtn);
            this.Controls.Add(this.inventoryLstBx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox inventoryLstBx;
        private System.Windows.Forms.Button storeBtn;
        private System.Windows.Forms.Label inventoryLbl;
    }
}

