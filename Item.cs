using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory
{
    public class Item
    {
        /// <summary>
        /// Auto assigned Id
        /// </summary>
        public int ItemId { get; set; }

        /// <summary>
        /// A brief description of an item
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The name of an individual Item
        /// </summary>
        public string ItemName { get; set; }

        /// <summary>
        /// The player stat that an item affects.
        /// Three stats that can be affected are:
        /// -Damage
        /// -Health
        /// -Armor
        /// 
        /// A sword could boost damage, clothing could boost armor, potions/food could boost health
        /// </summary>
        public string Effect { get; set; }

        /// <summary>
        /// The amount that an item affects a given stat
        /// eg. Sword could give a player +50 damage, Effect would be "Damage" and Value would be "50"
        /// </summary>
        public int Value { get; set; }
    }
}
