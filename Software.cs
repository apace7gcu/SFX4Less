using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFX4Less
{
    public class Software : Item
    {
        //Attributes 

        public string specReq { get; private set; }

        public string os { get; private set; }

        /// <summary>
        /// Software class constructor
        /// </summary>
        /// <param name="colorVal"></param>
        /// <param name="dateVal"></param>
        /// <param name="brandVal"></param>
        /// <param name="itemQtyVal"></param>
        /// <param name="itemDescVal"></param>
        /// <param name="itemComVal"></param>
        /// <param name="inventoryUpVal"></param>
        /// <param name="specReqVal"></param>
        /// <param name="osVal"></param>
        public Software(string colorVal, string dateVal, string brandVal,
        int itemQtyVal, string itemDescVal, string itemComVal,
        int inventoryUpVal, string specReqVal, string osVal) :

            base(colorVal, dateVal, brandVal,
             itemQtyVal, itemDescVal, itemComVal,
             inventoryUpVal)
        {
            //Properties
            specReq = specReqVal; os = osVal;
        }
    }
}
