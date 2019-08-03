using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpsApi.Models
{
    public class BaseRequest
    {
        public UPSSecurity UPSSecurity { get; set; }
       

        public BaseRequest(AuthenticationConfig authConfig)
        {
            UPSSecurity = new UPSSecurity();
            UPSSecurity.UsernameToken = new UsernameToken();
            UPSSecurity.UsernameToken.Username = authConfig.UserName;
            UPSSecurity.UsernameToken.Password = authConfig.Password;

            UPSSecurity.ServiceAccessToken = new ServiceAccessToken();
            UPSSecurity.ServiceAccessToken.AccessLicenseNumber = authConfig.AccessLicenseNumber;
        }
    }

    public class UPSSecurity
    {
        public UsernameToken UsernameToken { get; set; }
        public ServiceAccessToken ServiceAccessToken { get; set; }
    }

    public class UsernameToken
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class ServiceAccessToken
    {
        public string AccessLicenseNumber { get; set; }
    }




}
