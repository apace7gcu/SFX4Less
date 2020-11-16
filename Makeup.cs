using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFX4Less
{
    public class Makeup : Item
    {
        //Attributes 

        public double netWT { get; private set; }

        public string makeupType { get; private set; }

        /// <summary>
        /// Makeup class constructor
        /// </summary>
        /// <param name="colorVal"></param>
        /// <param name="dateVal"></param>
        /// <param name="brandVal"></param>
        /// <param name="itemQtyVal"></param>
        /// <param name="itemDescVal"></param>
        /// <param name="itemComVal"></param>
        /// <param name="inventoryUpVal"></param>
        /// <param name="netWTVal"></param>
        /// <param name="makeupTypeVal"></param>
        public Makeup(string colorVal, string dateVal, string brandVal,
        int itemQtyVal, string itemDescVal, string itemComVal,
        int inventoryUpVal, double netWTVal, string makeupTypeVal) :

            base(colorVal, dateVal, brandVal,
             itemQtyVal, itemDescVal, itemComVal,
             inventoryUpVal)
        {
            //Properties
            netWT = netWTVal; makeupType = makeupTypeVal;
        }
    }

}