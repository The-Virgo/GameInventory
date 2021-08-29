
namespace GameInventory
{
    partial class EditItem
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
            this.editItemConfirmBtn = new System.Windows.Forms.Button();
            this.valueEditLbl = new System.Windows.Forms.Label();
            this.effectEditLbl = new System.Windows.Forms.Label();
            this.descriptionEditLbl = new System.Windows.Forms.Label();
            this.nameEditLbl = new System.Windows.Forms.Label();
            this.valueEditTxtBx = new System.Windows.Forms.TextBox();
            this.effectEditTxtBx = new System.Windows.Forms.TextBox();
            this.descEditTxtBx = new System.Windows.Forms.TextBox();
            this.itemNameEditTxtBx = new System.Windows.Forms.TextBox();
            this.itemIdLbl = new System.Windows.Forms.Label();
            this.ItemIdTxtBx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // editItemConfirmBtn
            // 
            this.editItemConfirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editItemConfirmBtn.Location = new System.Drawing.Point(76, 211);
            this.editItemConfirmBtn.Name = "editItemConfirmBtn";
            this.editItemConfirmBtn.Size = new System.Drawing.Size(75, 36);
            this.editItemConfirmBtn.TabIndex = 17;
            this.editItemConfirmBtn.Text = "Edit";
            this.editItemConfirmBtn.UseVisualStyleBackColor = true;
            this.editItemConfirmBtn.Click += new System.EventHandler(this.editItemConfirmBtn_Click);
            // 
            // valueEditLbl
            // 
            this.valueEditLbl.AutoSize = true;
            this.valueEditLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueEditLbl.Location = new System.Drawing.Point(9, 165);
            this.valueEditLbl.Name = "valueEditLbl";
            this.valueEditLbl.Size = new System.Drawing.Size(54, 20);
            this.valueEditLbl.TabIndex = 16;
            this.valueEditLbl.Text = "Value:";
            // 
            // effectEditLbl
            // 
            this.effectEditLbl.AutoSize = true;
            this.effectEditLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effectEditLbl.Location = new System.Drawing.Point(9, 126);
            this.effectEditLbl.Name = "effectEditLbl";
            this.effectEditLbl.Size = new System.Drawing.Size(108, 20);
            this.effectEditLbl.TabIndex = 15;
            this.effectEditLbl.Text = "Affected Stat:";
            // 
            // descriptionEditLbl
            // 
            this.descriptionEditLbl.AutoSize = true;
            this.descriptionEditLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionEditLbl.Location = new System.Drawing.Point(9, 87);
            this.descriptionEditLbl.Name = "descriptionEditLbl";
            this.descriptionEditLbl.Size = new System.Drawing.Size(93, 20);
            this.descriptionEditLbl.TabIndex = 14;
            this.descriptionEditLbl.Text = "Description:";
            // 
            // nameEditLbl
            // 
            this.nameEditLbl.AutoSize = true;
            this.nameEditLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameEditLbl.Location = new System.Drawing.Point(9, 48);
            this.nameEditLbl.Name = "nameEditLbl";
            this.nameEditLbl.Size = new System.Drawing.Size(91, 20);
            this.nameEditLbl.TabIndex = 13;
            this.nameEditLbl.Text = "Item Name:";
            // 
            // valueEditTxtBx
            // 
            this.valueEditTxtBx.Location = new System.Drawing.Point(123, 165);
            this.valueEditTxtBx.Name = "valueEditTxtBx";
            this.valueEditTxtBx.Size = new System.Drawing.Size(100, 20);
            this.valueEditTxtBx.TabIndex = 12;
            // 
            // effectEditTxtBx
            // 
            this.effectEditTxtBx.Location = new System.Drawing.Point(123, 126);
            this.effectEditTxtBx.Name = "effectEditTxtBx";
            this.effectEditTxtBx.Size = new System.Drawing.Size(100, 20);
            this.effectEditTxtBx.TabIndex = 11;
            // 
            // descEditTxtBx
            // 
            this.descEditTxtBx.Location = new System.Drawing.Point(123, 87);
            this.descEditTxtBx.Name = "descEditTxtBx";
            this.descEditTxtBx.Size = new System.Drawing.Size(100, 20);
            this.descEditTxtBx.TabIndex = 10;
            // 
            // itemNameEditTxtBx
            // 
            this.itemNameEditTxtBx.Location = new System.Drawing.Point(123, 48);
            this.itemNameEditTxtBx.Name = "itemNameEditTxtBx";
            this.itemNameEditTxtBx.Size = new System.Drawing.Size(100, 20);
            this.itemNameEditTxtBx.TabIndex = 9;
            // 
            // itemIdLbl
            // 
            this.itemIdLbl.AutoSize = true;
            this.itemIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemIdLbl.Location = new System.Drawing.Point(9, 9);
            this.itemIdLbl.Name = "itemIdLbl";
            this.itemIdLbl.Size = new System.Drawing.Size(66, 20);
            this.itemIdLbl.TabIndex = 18;
            this.itemIdLbl.Text = "Item ID:";
            // 
            // ItemIdTxtBx
            // 
            this.ItemIdTxtBx.Enabled = false;
            this.ItemIdTxtBx.Location = new System.Drawing.Point(123, 12);
            this.ItemIdTxtBx.Name = "ItemIdTxtBx";
            this.ItemIdTxtBx.Size = new System.Drawing.Size(50, 20);
            this.ItemIdTxtBx.TabIndex = 19;
            // 
            // EditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 255);
            this.Controls.Add(this.ItemIdTxtBx);
            this.Controls.Add(this.itemIdLbl);
            this.Controls.Add(this.editItemConfirmBtn);
            this.Controls.Add(this.valueEditLbl);
            this.Controls.Add(this.effectEditLbl);
            this.Controls.Add(this.descriptionEditLbl);
            this.Controls.Add(this.nameEditLbl);
            this.Controls.Add(this.valueEditTxtBx);
            this.Controls.Add(this.effectEditTxtBx);
            this.Controls.Add(this.descEditTxtBx);
            this.Controls.Add(this.itemNameEditTxtBx);
            this.Name = "EditItem";
            this.Text = "EditItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editItemConfirmBtn;
        private System.Windows.Forms.Label valueEditLbl;
        private System.Windows.Forms.Label effectEditLbl;
        private System.Windows.Forms.Label descriptionEditLbl;
        private System.Windows.Forms.Label nameEditLbl;
        private System.Windows.Forms.TextBox valueEditTxtBx;
        private System.Windows.Forms.TextBox effectEditTxtBx;
        private System.Windows.Forms.TextBox descEditTxtBx;
        private System.Windows.Forms.TextBox itemNameEditTxtBx;
        private System.Windows.Forms.Label itemIdLbl;
        private System.Windows.Forms.TextBox ItemIdTxtBx;
    }
}