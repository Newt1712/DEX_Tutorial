using System.Text.Json.Serialization;

namespace StarterDex.Domain.Entities
{
    public class Token
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [JsonPropertyName("tokenAddress")]
        public string TokenAddress { get; set; }

        [JsonPropertyName("tokenLogo")]
        public string TokenLogo { get; set; }

        [JsonPropertyName("tokenName")]
        public string TokenName { get; set; }

        [JsonPropertyName("tokenSymbol")]
        public string TokenSymbol { get; set; }

        [JsonPropertyName("tokenDecimals")]
        public string TokenDecimals { get; set; }

        [JsonPropertyName("usdPrice")]
        public double UsdPrice { get; set; }

        [JsonPropertyName("usdPriceFormatted")]
        public string UsdPriceFormatted { get; set; }

        [JsonPropertyName("exchangeName")]
        public string ExchangeName { get; set; }

        [JsonPropertyName("priceLastChangedAtBlock")]
        public string PriceLastChangedAtBlock { get; set; }

        [JsonPropertyName("verifiedContract")]
        public bool VerifiedContract { get; set; }
    }
}
