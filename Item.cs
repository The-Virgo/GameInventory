using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory
{
    public class Item
    {
        public int ItemId { get; set; }

        public string Description { get; set; }

        public string ItemName { get; set; }

        public string Effect { get; set; }

        public int Value { get; set; }
    }
}
