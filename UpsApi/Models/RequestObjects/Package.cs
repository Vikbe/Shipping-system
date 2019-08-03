using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpsApi.Models.RequestObjects
{
    public class Package
    {
        public string Description { get; set; }
        public Packaging Packaging { get; set; }
        public Dimensions Dimensions { get; set; }
        public PackageWeight PackageWeight { get; set; }
        public PackagingType PackagingType { get; set; }

        public Package()
        {
            Packaging = new Packaging();
            Dimensions = new Dimensions();
            PackageWeight = new PackageWeight();
            PackagingType = new PackagingType();
        }
    }
}
