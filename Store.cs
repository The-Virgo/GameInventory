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
    public partial class Store : Form
    {
        public Store()
        {
            InitializeComponent();
            
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            AddItem newItem = new AddItem();
            newItem.Show();
        }

        protected override void OnActivated(EventArgs e)
        {
            List<Item> items = GameDb.GetAllItems();
            storeLstBx.Items.Clear(); 
            for (int i = 0; i < items.Count; i++)
            {
                storeLstBx.Items.Add(items[i].ItemName);
            }
        }
    }
}
