using Microsoft.AspNetCore.Mvc;
using RestSharp;
using StarterDex.Domain;
using StarterDex.Domain.Entities;
using StarterDex.Domain.Settings;
using System;
using System.Globalization;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace dexApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoinsMarketController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        private readonly ILogger<CoinsMarketController> _logger;

        public CoinsMarketController(ILogger<CoinsMarketController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }


        [HttpPost("GetTokensPrice")]
        public async Task<IList<Token>> GetTokensPrice(List<string> tokensAddress)
        {
            var client = new RestClient();

            var moralis = _configuration.GetSection("Moralis");
            var apiKey = moralis.GetValue<string>("Api-Key");
            client.AddDefaultHeader("X-API-Key", apiKey);

            var request = new RestRequest("https://deep-index.moralis.io/api/v2.2/erc20/prices", Method.Post);

            var jsonObj = new
            {
                tokens = tokensAddress.Select(x => new
                {
                    token_address = x
                })
            };

            request.AddJsonBody(jsonObj);

            var response = await client.ExecuteAsync(request);

            var result = new List<Token>();
            if (response.Content != null)
            {
                result = JsonSerializer.Deserialize<List<Token>>(response.Content);
            }
            return result ?? new();
        }

    }
}
