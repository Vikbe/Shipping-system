using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpsApi.Models.RequestObjects
{
    public class Shipment
    {
        public string Description { get; set; }
        public Shipper Shipper { get; set; }
        public ShipTo ShipTo { get; set; }
        public ShipFrom ShipFrom { get; set; }
        public PaymentInformation PaymentInformation { get; set; }
        public Service Service { get; set; }
        public ShipmentRatingOptions ShipmentRatingOptions { get; set; }
        public Package Package { get; set; }

        public Shipment()
        {
            Shipper = new Shipper();
            ShipTo = new ShipTo();
            ShipFrom = new ShipFrom();
            PaymentInformation = new PaymentInformation();
            Service = new Service();
            ShipmentRatingOptions = new ShipmentRatingOptions();
            Package = new Package();
        }
    }
}
