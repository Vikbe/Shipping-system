using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpsApi.Models.RequestObjects;
using UpsApi.Models.ResponseObjects;

namespace UpsApi.Models
{
    //Represents the JSON object received as respone when making a negotiated rate request




    public class Response
    {
        public ResponseStatus ResponseStatus { get; set; }
        public TransactionReference TransactionReference { get; set; }
    }
    public class ShipmentResponse
    {
        public Response Response { get; set; }
        public ShipmentResults ShipmentResults { get; set; }
    }

    public class RootShipmentResponse
    {
        public ShipmentResponse ShipmentResponse { get; set; }
    }
}
