using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using UpsApi.Models;
using UpsApi.Services;
using IronPdf;
using UpsApi.Models.Tradeability;

namespace UpsApi.Controllers
{
    
    public class TradeabilityController : Controller
    {
        private ApiService _apiService;
        private readonly IOptions<AuthenticationConfig> _config;
        private readonly IOptions<PathConfig> _paths;

        public TradeabilityController(ApiService apiService, IOptions<AuthenticationConfig> config, IOptions<PathConfig> paths) : base()
        {
            _apiService = apiService;
            _config = config;
            _paths = paths;

        }

      

        [HttpPost]
        [Route("api/landedcost")]
        public async Task<ActionResult> GetLandedCost([FromBody]RatesForm form)
        {
            var req = new SilicoLandedCostRequest(_config.Value);

            //This is all going to have less values hardcoded and should probably be moved somewhere else.

            req.LandedCostRequest.Request.RequestAction = "LandedCost";

            //Product
            req.LandedCostRequest.EstimateRequest.Shipment.Product.TariffCode = "8416.90.00.00";
            req.LandedCostRequest.EstimateRequest.Shipment.Product.ProductCountryCodeOfOrigin = "BE";

            req.LandedCostRequest.EstimateRequest.Shipment.Product.Quantity.Value = "5";
            
            req.LandedCostRequest.EstimateRequest.Shipment.Product.Weight.Value = "2";
            req.LandedCostRequest.EstimateRequest.Shipment.Product.Weight.UnitOfMeasure.UnitCode = "KG";
            req.LandedCostRequest.EstimateRequest.Shipment.Product.UnitPrice.MonetaryValue = "5.5";
            req.LandedCostRequest.EstimateRequest.Shipment.Product.UnitPrice.CurrencyCode = "LTL";

            req.LandedCostRequest.EstimateRequest.Shipment.Product.Question.Name = "UOM_REQUIRED_X";
            req.LandedCostRequest.EstimateRequest.Shipment.Product.Question.Answer = "3";

            req.LandedCostRequest.EstimateRequest.TransactionDigest = "...udXBzLnhvbHQudGEubGMuTENSZXN1bHQOqA+6xY5G9QIAFkQAB2ZyZ....";




            var res = await _apiService.MakeLandedCostRequest(req);


            return Ok(res);
        }

   



    }
}
