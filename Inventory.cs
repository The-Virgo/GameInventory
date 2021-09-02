using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory
{
    public class Inventory
    {

        public List<Item> InvItems;

        public void addItem(Item item)
        {
            InvItems.Add(item);
        }

    }
}
