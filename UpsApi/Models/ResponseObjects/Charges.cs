using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpsApi.Models.ResponseObjects
{
    public class Charges
    {
        public string CurrencyCode { get; set; }
        public string MonetaryValue { get; set; }
    }
}
