using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpsApi.Models.ResponseObjects;

namespace UpsApi.Models
{
    public class RateResponse
    {
        public RatedResponse Response { get; set; }
        public RatedShipment RatedShipment { get; set; }
    }

    public class RootRatedResponse
    {
        public RateResponse RateResponse { get; set; }
    }
}
