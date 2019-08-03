using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpsApi.Models.RequestObjects
{
    public class PaymentInformation
    {
        public ShipmentCharge ShipmentCharge { get; set; }

        public PaymentInformation()
        {
            ShipmentCharge = new ShipmentCharge();
        }
    }
}
