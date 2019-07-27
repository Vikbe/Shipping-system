using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpsApi.Models
{
    //Represents the JSON object used to send a request for negotiated rate request
    public class NegotiatedRateRequest
    {
        public UPSSecurity UPSSecurity { get; set; }
        public ShipmentRequest ShipmentRequest { get; set; } 

        public NegotiatedRateRequest(AuthenticationConfig authConfig)
        {
            UPSSecurity = new UPSSecurity();
            UPSSecurity.UsernameToken = new UsernameToken();
            UPSSecurity.UsernameToken.Username = authConfig.UserName;
            UPSSecurity.UsernameToken.Password = authConfig.Password;

            UPSSecurity.ServiceAccessToken = new ServiceAccessToken();
            UPSSecurity.ServiceAccessToken.AccessLicenseNumber = authConfig.AccessLicenseNumber;

            ShipmentRequest = new ShipmentRequest();
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

 
    public class TransactionReference
    {
        public string CustomerContext { get; set; }
    }

    public class Request
    {
        public string RequestOption { get; set; }
        public TransactionReference TransactionReference { get; set; }
        public Request()
        {
            TransactionReference = new TransactionReference();
        }
    }

    public class Phone
    {
        public string Number { get; set; }
        public string Extension { get; set; }
    }

    public class ShippingAddress
    {
        public string AddressLine { get; set; }
        public string City { get; set; }
        public string StateProvinceCode { get; set; }
        public string PostalCode { get; set; }
        public string CountryCode { get; set; }
    }

    public class Shipper
    {
        public string Name { get; set; }
        public string AttentionName { get; set; }
        public string TaxIdentificationNumber { get; set; }
        public Phone Phone { get; set; }
        public string ShipperNumber { get; set; }
        public string FaxNumber { get; set; }
        public ShippingAddress Address { get; set; } 

        public Shipper()
        {
            Phone = new Phone();
            Address = new ShippingAddress();
        }
    }



    public class ShipTo
    {
        public string Name { get; set; }
        public string AttentionName { get; set; }
        public Phone Phone { get; set; }
        public ShippingAddress Address { get; set; } 

        public ShipTo()
        {
            Phone = new Phone();
            Address = new ShippingAddress();
        }
    }


   
    public class ShipFrom
    {
        public string Name { get; set; }
        public string AttentionName { get; set; }
        public Phone Phone { get; set; }
        public string FaxNumber { get; set; }
        public ShippingAddress Address { get; set; }

        public ShipFrom()
        {
            Phone = new Phone();
            Address = new ShippingAddress();
        }
    }

    public class BillShipper
    {
        public string AccountNumber { get; set; }
    }

    public class ShipmentCharge
    {
        public string Type { get; set; }
        public BillShipper BillShipper { get; set; } 

        public ShipmentCharge()
        {
            BillShipper = new BillShipper();
        }
    }

    public class PaymentInformation
    {
        public ShipmentCharge ShipmentCharge { get; set; } 

        public PaymentInformation()
        {
            ShipmentCharge = new ShipmentCharge();
        }
    }

    public class Service
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }

    public class ShipmentRatingOptions
    {
        public string NegotiatedRatesIndicator { get; set; }
    }

    public class Packaging
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }

    public class UnitOfMeasurement
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }

    public class Dimensions
    {
        public UnitOfMeasurement UnitOfMeasurement { get; set; }
        public string Length { get; set; }
        public string Width { get; set; }
        public string Height { get; set; } 

        public Dimensions()
        {
            UnitOfMeasurement = new UnitOfMeasurement();
        }
    }

  

    public class PackageWeight
    {
        public UnitOfMeasurement UnitOfMeasurement { get; set; }
        public string Weight { get; set; } 

        public PackageWeight()
        {
            UnitOfMeasurement = new UnitOfMeasurement();
        }
    }

    public class Package
    {
        public string Description { get; set; }
        public Packaging Packaging { get; set; }
        public Dimensions Dimensions { get; set; }
        public PackageWeight PackageWeight { get; set; } 

        public Package()
        {
            Packaging = new Packaging();
            Dimensions = new Dimensions();
            PackageWeight = new PackageWeight();
        }
    }

    public class Shipment
    {
        public string Description { get; set; }
        public Shipper Shipper { get; set; }
        public ShipTo ShipTo { get; set; }
        public ShipFrom ShipFrom { get; set; }
        public PaymentInformation PaymentInformation { get; set; }
        public Service Service { get; set; }
        public ShipmentRatingOptions ShipmentRatingOptions { get; set; }
        public Package Package { get; set; } 

        public Shipment()
        {
            Shipper = new Shipper();
            ShipTo = new ShipTo();
            ShipFrom = new ShipFrom();
            PaymentInformation = new PaymentInformation();
            Service = new Service();
            ShipmentRatingOptions = new ShipmentRatingOptions();
            Package = new Package();
        }
    }

    public class LabelImageFormat
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }

    public class LabelSpecification
    {
        public LabelImageFormat LabelImageFormat { get; set; }
        public string HTTPUserAgent { get; set; }

        public LabelSpecification()
        {
            LabelImageFormat = new LabelImageFormat();
        }
    }

    public class ShipmentRequest
    {
        public Request Request { get; set; }
        public Shipment Shipment { get; set; }
        public LabelSpecification LabelSpecification { get; set; } 

        public ShipmentRequest()
        {
            Request = new Request();
            Shipment = new Shipment();
            LabelSpecification = new LabelSpecification();
        }
    }

 
}
