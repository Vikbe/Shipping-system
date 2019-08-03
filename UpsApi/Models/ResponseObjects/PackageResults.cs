using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpsApi.Models.ResponseObjects
{
    public class PackageResults
    {
        public string TrackingNumber { get; set; }
        public Charges ServiceOptionsCharges { get; set; }
        public ShippingLabel ShippingLabel { get; set; }
    }
}
