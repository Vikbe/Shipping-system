using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpsApi.Models.RequestObjects;

namespace UpsApi.Models.ResponseObjects
{
    public class RatedResponse
    {
        public ResponseStatus ResponseStatus { get; set; }
        public Alert Alert { get; set; }
        public TransactionReference TransactionReference { get; set; }
    }
}
