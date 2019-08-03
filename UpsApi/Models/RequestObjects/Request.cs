using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpsApi.Models.RequestObjects
{
    public class Request
    {
        public string RequestOption { get; set; }
        public TransactionReference TransactionReference { get; set; }
        public Request()
        {
            TransactionReference = new TransactionReference();
        }
    }

    public class TransactionReference
    {
        public string CustomerContext { get; set; }
    }
}
