using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpsApi.Models.RequestObjects;

namespace UpsApi.Models.Tradeability
{
    public class SilicoLandedCostRequest
    {
        public AccessRequest AccessRequest { get; set; }
        public LandedCostRequest LandedCostRequest { get; set; }

        public SilicoLandedCostRequest(AuthenticationConfig authConfig)
        {
            AccessRequest = new AccessRequest();
            AccessRequest.UserId = authConfig.UserName;
            AccessRequest.Password = authConfig.Password;
            AccessRequest.AccessLicenseNumber = authConfig.AccessLicenseNumber;

            LandedCostRequest = new LandedCostRequest();

        }
    }

    public class LandedCostRequest
    {
        public Request Request { get; set; }
        public EstimateRequest EstimateRequest { get; set; } 

        public LandedCostRequest()
        {
            Request = new Request();
            EstimateRequest = new EstimateRequest();
        }
    }



    public class AccessRequest
    {
        public string UserId { get; set; }
        public string Password { get; set; }
        public string AccessLicenseNumber { get; set; }
    }

    public class Request
    {
        public string RequestAction { get; set; }
    }

    public class Quantity
    {
        public string Value { get; set; }
    }

    public class UnitOfMeasure
    {
        public string UnitCode { get; set; }
    }


    public class UnitPrice
    {
        public string MonetaryValue { get; set; }
        public string CurrencyCode { get; set; }
    }

    public class Question
    {
        public string Name { get; set; }
        public string Answer { get; set; }
    }

    public class Weight
    {
        public string Value { get; set; }
        public UnitOfMeasure UnitOfMeasure { get; set; } 

        public Weight()
        {
            UnitOfMeasure = new UnitOfMeasure();
        }
    }

    public class Product
    {
        public string TariffCode { get; set; }
        public string ProductCountryCodeOfOrigin { get; set; }
        public Quantity Quantity { get; set; }
        public Weight Weight { get; set; }
        public UnitPrice UnitPrice { get; set; }
        public Question Question { get; set; } 

        public Product()
        {
            Quantity = new Quantity();
            Weight = new Weight();
            UnitPrice = new UnitPrice();
            Question = new Question();
        }
    }

    public class Shipment
    {
        public Product Product { get; set; } 

        public Shipment()
        {
            Product = new Product();
        }
    }

    public class EstimateRequest
    {
        public Shipment Shipment { get; set; }
        public string TransactionDigest { get; set; } 

        public EstimateRequest()
        {
            Shipment = new Shipment();
        }
    }
}
