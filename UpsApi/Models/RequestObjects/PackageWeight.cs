using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpsApi.Models.RequestObjects
{
    public class PackageWeight
    {
        public UnitOfMeasurement UnitOfMeasurement { get; set; }
        public string Weight { get; set; }

        public PackageWeight()
        {
            UnitOfMeasurement = new UnitOfMeasurement();
        }
    }
}
