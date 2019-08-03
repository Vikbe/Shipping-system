using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpsApi.Models.ResponseObjects
{
    public class ShipmentResults
    {
        public ShipmentCharges ShipmentCharges { get; set; }
        public NegotiatedRateCharges NegotiatedRateCharges { get; set; }
        public BillingWeight BillingWeight { get; set; }
        public string ShipmentIdentificationNumber { get; set; }
        public PackageResults PackageResults { get; set; }
    }
}
