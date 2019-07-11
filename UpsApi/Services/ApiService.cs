﻿using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using UpsApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace UpsApi.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;
        private readonly IOptions<AuthenticationConfig> _config;
        public ApiService(HttpClient httpClient, IOptions<AuthenticationConfig> config)
        {
            _httpClient = httpClient;
            _config = config;
        }

   

        public async Task<NegotiatedRateResponse> MakeNegotiatedRateRequest(NegotiatedRateRequest req)
        {
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };


            var json = JsonConvert.SerializeObject(req);

            var response = await _httpClient.PostAsync("Ship", new StringContent(json, Encoding.UTF8, "application/json"));

            if (!response.IsSuccessStatusCode)
            {

              
            }

            var one = await response.Content.ReadAsStringAsync();

            var responseData = JsonConvert.DeserializeObject<NegotiatedRateResponse>(await response.Content.ReadAsStringAsync(), settings);


            return responseData;

        }

    }
}