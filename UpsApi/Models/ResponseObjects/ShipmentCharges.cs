using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpsApi.Models.ResponseObjects
{
    public class ShipmentCharges
    {
        public Charges TransportationCharges { get; set; }
        public Charges ServiceOptionsCharges { get; set; }
        public Charges TotalCharges { get; set; }
    }

}
