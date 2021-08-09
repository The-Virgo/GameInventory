
namespace GameInventory
{
    partial class AddItem
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
            this.itemNameTxtBx = new System.Windows.Forms.TextBox();
            this.descTxtBx = new System.Windows.Forms.TextBox();
            this.effectTxtBx = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.valueTxtBx = new System.Windows.Forms.Label();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.effectLbl = new System.Windows.Forms.Label();
            this.valueLbl = new System.Windows.Forms.Label();
            this.addItemConfirmBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemNameTxtBx
            // 
            this.itemNameTxtBx.Location = new System.Drawing.Point(135, 30);
            this.itemNameTxtBx.Name = "itemNameTxtBx";
            this.itemNameTxtBx.Size = new System.Drawing.Size(100, 20);
            this.itemNameTxtBx.TabIndex = 0;
            // 
            // descTxtBx
            // 
            this.descTxtBx.Location = new System.Drawing.Point(135, 69);
            this.descTxtBx.Name = "descTxtBx";
            this.descTxtBx.Size = new System.Drawing.Size(100, 20);
            this.descTxtBx.TabIndex = 1;
            // 
            // effectTxtBx
            // 
            this.effectTxtBx.Location = new System.Drawing.Point(135, 108);
            this.effectTxtBx.Name = "effectTxtBx";
            this.effectTxtBx.Size = new System.Drawing.Size(100, 20);
            this.effectTxtBx.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(135, 147);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // valueTxtBx
            // 
            this.valueTxtBx.AutoSize = true;
            this.valueTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueTxtBx.Location = new System.Drawing.Point(21, 30);
            this.valueTxtBx.Name = "valueTxtBx";
            this.valueTxtBx.Size = new System.Drawing.Size(91, 20);
            this.valueTxtBx.TabIndex = 4;
            this.valueTxtBx.Text = "Item Name:";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLbl.Location = new System.Drawing.Point(21, 69);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(93, 20);
            this.descriptionLbl.TabIndex = 5;
            this.descriptionLbl.Text = "Description:";
            // 
            // effectLbl
            // 
            this.effectLbl.AutoSize = true;
            this.effectLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effectLbl.Location = new System.Drawing.Point(21, 108);
            this.effectLbl.Name = "effectLbl";
            this.effectLbl.Size = new System.Drawing.Size(108, 20);
            this.effectLbl.TabIndex = 6;
            this.effectLbl.Text = "Affected Stat:";
            // 
            // valueLbl
            // 
            this.valueLbl.AutoSize = true;
            this.valueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueLbl.Location = new System.Drawing.Point(21, 147);
            this.valueLbl.Name = "valueLbl";
            this.valueLbl.Size = new System.Drawing.Size(54, 20);
            this.valueLbl.TabIndex = 7;
            this.valueLbl.Text = "Value:";
            // 
            // addItemConfirmBtn
            // 
            this.addItemConfirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemConfirmBtn.Location = new System.Drawing.Point(88, 193);
            this.addItemConfirmBtn.Name = "addItemConfirmBtn";
            this.addItemConfirmBtn.Size = new System.Drawing.Size(75, 36);
            this.addItemConfirmBtn.TabIndex = 8;
            this.addItemConfirmBtn.Text = "Add";
            this.addItemConfirmBtn.UseVisualStyleBackColor = true;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 248);
            this.Controls.Add(this.addItemConfirmBtn);
            this.Controls.Add(this.valueLbl);
            this.Controls.Add(this.effectLbl);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.valueTxtBx);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.effectTxtBx);
            this.Controls.Add(this.descTxtBx);
            this.Controls.Add(this.itemNameTxtBx);
            this.Name = "AddItem";
            this.Text = "AddItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itemNameTxtBx;
        private System.Windows.Forms.TextBox descTxtBx;
        private System.Windows.Forms.TextBox effectTxtBx;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label valueTxtBx;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.Label effectLbl;
        private System.Windows.Forms.Label valueLbl;
        private System.Windows.Forms.Button addItemConfirmBtn;
    }
}