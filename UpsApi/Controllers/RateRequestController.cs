using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using UpsApi.Models;
using UpsApi.Services;

namespace UpsApi.Controllers
{
    
    public class RateRequestController : Controller
    {
        private ApiService _apiService;
        private readonly IOptions<AuthenticationConfig> _config;

        public RateRequestController(ApiService apiService, IOptions<AuthenticationConfig> config) : base()
        {
            _apiService = apiService;
            _config = config;

        }

        [HttpPost]
        [Route("api/GetNegotiatedRates")]
        public async Task<ActionResult> GetNegotiatedRates([FromBody]RatesForm form)
        {
            var req = new NegotiatedRateRequest(_config.Value);

            //ShipmentRequest
            req.ShipmentRequest.Request.RequestOption = "validate";
            req.ShipmentRequest.Request.TransactionReference.CustomerContext = "Your Customer Context";

            //Shipment 
            req.ShipmentRequest.Shipment.Description = "Description";
            //req.ShipmentRequest.Shipment.ShipmentRatingOptions.NegotiatedRatesIndicator = null;

            //Shipper
            req.ShipmentRequest.Shipment.Shipper.Name = form.NameFrom;
            req.ShipmentRequest.Shipment.Shipper.AttentionName = form.NameFrom;
            req.ShipmentRequest.Shipment.Shipper.TaxIdentificationNumber = "32132132";
            req.ShipmentRequest.Shipment.Shipper.Phone.Number = form.PhoneFrom;
            req.ShipmentRequest.Shipment.Shipper.Phone.Extension = "1";
            req.ShipmentRequest.Shipment.Shipper.ShipperNumber = _config.Value.ShipperNumber;
            req.ShipmentRequest.Shipment.Shipper.FaxNumber = form.PhoneFrom;

            //Shipper address
            req.ShipmentRequest.Shipment.Shipper.Address.AddressLine = form.AddressFrom;
            req.ShipmentRequest.Shipment.Shipper.Address.City = form.CityFrom;
            req.ShipmentRequest.Shipment.Shipper.Address.StateProvinceCode = form.StateFrom;
            req.ShipmentRequest.Shipment.Shipper.Address.PostalCode = form.ZipFrom;
            req.ShipmentRequest.Shipment.Shipper.Address.CountryCode = form.CountryFrom;

            //Ship to 
            req.ShipmentRequest.Shipment.ShipTo.Name = form.NameTo;
            req.ShipmentRequest.Shipment.ShipTo.AttentionName = form.NameTo;
            req.ShipmentRequest.Shipment.ShipTo.Phone.Number = form.PhoneTo;
            req.ShipmentRequest.Shipment.ShipTo.Phone.Extension = "1";
            req.ShipmentRequest.Shipment.ShipTo.Address.AddressLine = form.AddressTo;
            req.ShipmentRequest.Shipment.ShipTo.Address.City = form.CityTo;
            req.ShipmentRequest.Shipment.ShipTo.Address.StateProvinceCode = form.StateTo;
            req.ShipmentRequest.Shipment.ShipTo.Address.PostalCode = form.ZipTo;
            req.ShipmentRequest.Shipment.ShipTo.Address.CountryCode = form.CountryTo;

            //Ship from 
            req.ShipmentRequest.Shipment.ShipFrom.Name = form.NameFrom;
            req.ShipmentRequest.Shipment.ShipFrom.AttentionName = form.NameFrom;
            req.ShipmentRequest.Shipment.ShipFrom.Phone.Number = form.PhoneFrom;
            req.ShipmentRequest.Shipment.ShipFrom.Phone.Extension = "1";
            req.ShipmentRequest.Shipment.ShipFrom.FaxNumber = form.PhoneFrom;
            req.ShipmentRequest.Shipment.ShipFrom.Address.AddressLine = form.AddressFrom;
            req.ShipmentRequest.Shipment.ShipFrom.Address.City = form.CityFrom;
            req.ShipmentRequest.Shipment.ShipFrom.Address.StateProvinceCode = form.StateFrom;
            req.ShipmentRequest.Shipment.ShipFrom.Address.PostalCode = form.ZipFrom;
            req.ShipmentRequest.Shipment.ShipFrom.Address.CountryCode = form.CountryFrom;

            //PaymentInformation
            req.ShipmentRequest.Shipment.PaymentInformation.ShipmentCharge.Type = "01";
            req.ShipmentRequest.Shipment.PaymentInformation.ShipmentCharge.BillShipper.AccountNumber = _config.Value.ShipperNumber;

            //Service 
            req.ShipmentRequest.Shipment.Service.Description = "Express";
            req.ShipmentRequest.Shipment.Service.Code = "01";

            //Package
            req.ShipmentRequest.Shipment.Package.Description = form.PackageDescription;
            req.ShipmentRequest.Shipment.Package.Packaging.Code = "02";
            req.ShipmentRequest.Shipment.Package.Packaging.Description = "Description";

            req.ShipmentRequest.Shipment.Package.Dimensions.UnitOfMeasurement.Code = "IN";
            req.ShipmentRequest.Shipment.Package.Dimensions.UnitOfMeasurement.Description = "Inches";
            req.ShipmentRequest.Shipment.Package.Dimensions.Length = form.Length;
            req.ShipmentRequest.Shipment.Package.Dimensions.Width = form.Width;
            req.ShipmentRequest.Shipment.Package.Dimensions.Height = form.Height;

            req.ShipmentRequest.Shipment.Package.PackageWeight.UnitOfMeasurement.Code = "LBS";
            req.ShipmentRequest.Shipment.Package.PackageWeight.UnitOfMeasurement.Description = "Pounds";
            req.ShipmentRequest.Shipment.Package.PackageWeight.Weight = form.Weight;

            //LabelSpecification
            req.ShipmentRequest.LabelSpecification.LabelImageFormat.Code = "GIF";
            req.ShipmentRequest.LabelSpecification.LabelImageFormat.Description = "GIF";
            req.ShipmentRequest.LabelSpecification.HTTPUserAgent = "Mozilla/4.5";

            var res = await _apiService.MakeNegotiatedRateRequest(req);

            return Ok(res);
        }


    }
}
