using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory
{
    static class GameDb
    {
        public static List<Item> GetAllItems()
        {
            using(ItemContext context = new ItemContext())
            {
                List<Item> allItems =
                    (from item in context.Items
                    select item).ToList();
                return allItems;
            }
        }

        /// <summary>
        /// Adds an item to the database. Returns the item
        /// with the ItemId property populated
        /// </summary>
        /// <param name="i">Item to be added</param>
        public static Item Add(Item i) 
        {
            ItemContext context = new ItemContext();
            context.Items.Add(i);
            context.SaveChanges();

            return i;
        }

        public static Item Update(Item i) 
        {
            using (ItemContext context = new ItemContext())
            {
                context.Entry(i).State = EntityState.Modified;
                context.SaveChanges();
            }

            return i;
        }

        public static void Delete(Item i)
        {
            using(ItemContext context = new ItemContext())
            {
                context.Entry(i).State = EntityState.Deleted;
                context.SaveChanges();
            }
            
        }

        public static void Delete(int id)
        {
            using(ItemContext context = new ItemContext())
            {
                Item itemToDelete =
                    (from item in context.Items
                     where item.ItemId == id
                     select item).Single();

                context.Entry(itemToDelete).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}
