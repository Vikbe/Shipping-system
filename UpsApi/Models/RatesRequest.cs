using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpsApi.Models.RequestObjects;

namespace UpsApi.Models
{
    public class RatesRequest : BaseRequest
    {
        public RateRequest RateRequest { get; set; }

        public RatesRequest(AuthenticationConfig authConfig) : base(authConfig)
        {


            RateRequest = new RateRequest();
        }
    }




    public class RateRequest
    {
        public Request Request { get; set; }
        public Shipment Shipment { get; set; }

        public RateRequest()
        {
            Request = new Request();
            Shipment = new Shipment();
        }
    }


}
