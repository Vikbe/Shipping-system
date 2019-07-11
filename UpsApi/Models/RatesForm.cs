using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpsApi.Models
{
    public class RatesForm
    {
        public string NameFrom { get; set; }
        public string AddressFrom { get; set; }
        public string CityFrom { get; set; }
        public string StateFrom { get; set; }
        public string ZipFrom { get; set; }
        public string CountryFrom { get; set; }
        public string PhoneFrom { get; set; }
        public string NameTo { get; set; }
        public string AddressTo { get; set; }
        public string CityTo { get; set; }
        public string StateTo { get; set; }
        public string ZipTo { get; set; }
        public string CountryTo { get; set; }
        public string PhoneTo { get; set; }
        public string Weight { get; set; }
        public string Length { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string PackageDescription { get; set; }
    }
}
