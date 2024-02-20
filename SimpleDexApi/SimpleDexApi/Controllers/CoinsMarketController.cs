using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System;
using System.Globalization;
using System.Net;

namespace dexApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoinsMarketController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<CoinsMarketController> _logger;

        public CoinsMarketController(ILogger<CoinsMarketController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetTokenPrices")]
        public async Task<string?> Get()
        {
            var key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJub25jZSI6IjhjOTIxZDI1LTBlODctNDE5NC04OTE4LTAxOWI0MWE2MTkwOCIsIm9yZ0lkIjoiMzY4ODQ2IiwidXNlcklkIjoiMzc5MDgwIiwidHlwZUlkIjoiYWVlNGYzYTMtYTU0ZC00N2NkLTljNDUtYmE5MmY5NDk0NTlhIiwidHlwZSI6IlBST0pFQ1QiLCJpYXQiOjE3MDMwMDAzMjcsImV4cCI6NDg1ODc2MDMyN30.eFTa1gVfh4Tt4e9ab8FVuCos4z3o7US3VEhbH9BGeAQ";

            var client = new RestClient();
            client.AddDefaultHeader("X-API-Key", key);

            var request = new RestRequest("https://deep-index.moralis.io/api/v2.2/erc20/prices", Method.Post);


            string jsonBody = """
            {
                "tokens":
                [
                    {
                        "token_address": "0xdac17f958d2ee523a2206206994597c13d831ec7"
                    },
                    {
                        "token_address": "0xa0b86991c6218b36c1d19d4a2e9eb0ce3606eb48"
                    },
                    {
                        "exchange": "uniswapv2",
                        "token_address": "0xae7ab96520de3a18e5e111b5eaab095312d7fe84",
                        "to_block": "16314545"
                    },
                    {
                        "token_address": "0x7d1afa7b718fb893db30a3abc0cfc608aacfebb0"
                    }
                ]
            }
            """;
            request.AddJsonBody(jsonBody);

            var response = await client.ExecuteAsync(request);
            return response.Content;
        }

    }
}
