using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpsApi.Models.RequestObjects
{
    public class LabelSpecification
    {
        public LabelImageFormat LabelImageFormat { get; set; }
        public string HTTPUserAgent { get; set; }

        public LabelSpecification()
        {
            LabelImageFormat = new LabelImageFormat();
        }
    }
}
