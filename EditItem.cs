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
    public partial class EditItem : Form
    {
        public EditItem(int id)
        {
            InitializeComponent();
            ItemIdTxtBx.Text = id.ToString();
        }

        private void editItemConfirmBtn_Click(object sender, EventArgs e)
        {
            Item i = GameDb.GetItem(int.Parse(ItemIdTxtBx.Text));

            i.ItemName = itemNameEditTxtBx.Text;
            i.Description = descEditTxtBx.Text;
            i.Effect = effectEditTxtBx.Text;
            i.Value = int.Parse(valueEditTxtBx.Text);

            GameDb.Update(i);

            Close();
        }
    }
}
