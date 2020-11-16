using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFX4Less
{
    public class Item
    {
        public int inventoryCurrent;

        //Getters and setters

        public string color { get; private set; }

        public string date { get; private set; }

        public string brand { get; private set; }

        public int itemQty { get; private set; }

        public string itemDesc { get; private set; }

        public string itemCom { get; private set; }

        public int inventoryUpdate { get; private set; }

        //Constructor

        public Item (string  colorVal, string dateVal, string brandVal, 
            int itemQtyVal, string itemDescVal, string itemComVal, int inventoryUpVal)
        {
            //Properties
            color = colorVal;   date = dateVal;     brand = brandVal;
            itemQty = itemQtyVal;   itemDesc = itemDescVal;
            itemCom = itemComVal;   inventoryUpdate = inventoryUpVal;

        }

        //Total Inventory
        public int CallInventory()
        {
            return inventoryUpdate + inventoryCurrent;
        }
    }
}
