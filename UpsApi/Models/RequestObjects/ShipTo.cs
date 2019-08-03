using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpsApi.Models.RequestObjects
{
    public class ShipTo
    {
        public string Name { get; set; }
        public string AttentionName { get; set; }
        public Phone Phone { get; set; }
        public ShippingAddress Address { get; set; }

        public ShipTo()
        {
            Phone = new Phone();
            Address = new ShippingAddress();
        }
    }
}
