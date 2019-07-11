using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpsApi.Models
{
    public class AuthenticationConfig
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string AccessLicenseNumber { get; set; }
        public string ShipperNumber { get; set; }
    }
}
