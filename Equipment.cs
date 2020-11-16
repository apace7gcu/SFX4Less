using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFX4Less
{
    public class Equipment : Item
    {
        //Attributes 

        public int equipWeight { get; private set; }

        public int equipSize { get; private set; }

        public Equipment(string colorVal, string dateVal, string brandVal,
        int itemQtyVal, string itemDescVal, string itemComVal,
        int inventoryUpVal, int equipWeightVal, int equipSizeVal) :

            base(colorVal, dateVal, brandVal,
             itemQtyVal, itemDescVal, itemComVal,
             inventoryUpVal)
        {
            //Properties
            equipWeight = equipWeightVal; equipSize = equipSizeVal;
        }
    }
}
