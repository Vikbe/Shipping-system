using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpsApi.Models.RequestObjects;

namespace UpsApi.Models
{
    //Represents the JSON object used to send a request for negotiated rate request
    public class NegotiatedRateRequest : BaseRequest
    {
    
        public ShipmentRequest ShipmentRequest { get; set; } 

        public NegotiatedRateRequest(AuthenticationConfig authConfig) : base(authConfig)
        {
           

            ShipmentRequest = new ShipmentRequest();
        }
    }


    public class ShipmentRequest
    {
        public Request Request { get; set; }
        public Shipment Shipment { get; set; }
        public LabelSpecification LabelSpecification { get; set; } 

        public ShipmentRequest()
        {
            Request = new Request();
            Shipment = new Shipment();
            LabelSpecification = new LabelSpecification();
        }
    }

 
}
