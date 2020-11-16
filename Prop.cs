using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFX4Less
{
        public class Prop: Item
        {
            //Attributes 

            public int propSize { get; private set; }

            public int propWeight { get; private set; }


        /// <summary>
        /// Constructor for Prop class
        /// </summary>
        /// <param name="colorVal"></param>
        /// <param name="dateVal"></param>
        /// <param name="brandVal"></param>
        /// <param name="itemQtyVal"></param>
        /// <param name="itemDescVal"></param>
        /// <param name="itemComVal"></param>
        /// <param name="inventoryUpVal"></param>
        /// <param name="propSizeVal"></param>
        /// <param name="propWeightVal"></param>
        public Prop(string colorVal, string dateVal, string brandVal,
        int itemQtyVal, string itemDescVal, string itemComVal,
        int inventoryUpVal, int propSizeVal, int propWeightVal):

            base( colorVal,  dateVal,  brandVal,
             itemQtyVal,  itemDescVal,  itemComVal,
             inventoryUpVal)
        {
            //Properties
            propSize = propSizeVal;     propWeight = propWeightVal;
        }

        }
   
}
