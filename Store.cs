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
            Refresh();
            setDataSource();
        }

        private void deleteItemBtn_Click(object sender, EventArgs e)
        {
            int toDelete = (int)storeLstBx.SelectedValue;

            storeLstBx.DataSource = null;
            setDataSource();
            DialogResult confirmDelete = MessageBox.Show("Delete this item?",
                                     "Confirm",
                                     MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
               GameDb.Delete(toDelete);

                storeLstBx.DataSource = null;
                setDataSource();
            }
            else
            {
                setDataSource();
            }

            
        }

        private void setDataSource()
        {
            List<Item> items = GameDb.GetAllItems();

            storeLstBx.DataSource = items;
            storeLstBx.DisplayMember = "ItemName";
            storeLstBx.ValueMember = "ItemId";
        }

        private void editItemBtn_Click(object sender, EventArgs e)
        {
            int itemID = int.Parse(storeLstBx.SelectedValue.ToString());
            EditItem editForm = new EditItem(itemID);
            editForm.Show();
        }
    }
}
