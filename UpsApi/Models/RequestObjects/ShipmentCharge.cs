using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpsApi.Models.RequestObjects
{
    public class ShipmentCharge
    {
        public string Type { get; set; }
        public BillShipper BillShipper { get; set; }

        public ShipmentCharge()
        {
            BillShipper = new BillShipper();
        }
    }
}
