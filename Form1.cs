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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void storeBtn_Click(object sender, EventArgs e)
        {
            Store s = new Store();
            s.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Item i = new Item()
            //{
            //    ItemName = "Bronze Sword",
            //    Effect = "Damage",
            //    Value = 50,
            //    Description = "A common and rusty weapon. " +
            //        "It may not be the most powerfull, " +
            //        "but it sure is reliable"
            //};

            //ItemContext dbContext = new ItemContext();
            //dbContext.Items.Add(i);
            //dbContext.SaveChanges();
            //MessageBox.Show("Added");
        }
    }
}
