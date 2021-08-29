using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameInventory
{
    public partial class AddItem : Form
    {


        public AddItem()
        {
            InitializeComponent();
        }

        private void addItemConfirmBtn_Click(object sender, EventArgs e)
        {
            String itemName = itemNameTxtBx.Text;
            String desc = descTxtBx.Text;
            String effect = effectTxtBx.Text;


            List<Item> items = GameDb.GetAllItems();

                for (int i = 0; i < items.Count; i++)
                {
                    if (itemName == items[i].ItemName)
                    {
                        itemNameTxtBx.Text = "";
                        return;
                    }
                }

            if (!int.TryParse(ItemValueTxtBx.Text, out int value))
            {
                valueTxtBx.Text = "";
                return;
            }

            Item item = new Item();
            item.ItemName = itemName;
            item.Description = desc;
            item.Effect = effect;
            item.Value = value;

            GameDb.Add(item);

            this.Close();
        }
    }
}
