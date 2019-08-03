using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpsApi.Models.RequestObjects;

namespace UpsApi.Models.ResponseObjects
{
    public class RatedShipment
    {
        public Service Service { get; set; }
        public Alert RatedShipmentAlert { get; set; }
        public BillingWeight BillingWeight { get; set; }
        public Charges TransportationCharges { get; set; }
        public Charges ServiceOptionsCharges { get; set; }
        public Charges TotalCharges { get; set; }
        public NegotiatedRateCharges NegotiatedRateCharges { get; set; }
        public RatedPackage RatedPackage { get; set; }
    }
}
