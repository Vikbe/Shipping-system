using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpsApi.Models.RequestObjects
{
    public class Shipper
    {
        public string Name { get; set; }
        public string AttentionName { get; set; }
        public string TaxIdentificationNumber { get; set; }
        public Phone Phone { get; set; }
        public string ShipperNumber { get; set; }
        public string FaxNumber { get; set; }
        public ShippingAddress Address { get; set; }

        public Shipper()
        {
            Phone = new Phone();
            Address = new ShippingAddress();
        }
    }
}
