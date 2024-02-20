using RestSharp;
using StarterDex.Domain.Settings;

namespace StarterDex.Server.Extensions
{
    public class RestSharpExtensions
    {
        public RestClient CreateClient(string key)
        {
            return new RestClient(key);
        }
        public RestRequest MakeRequest(MoralisSettings settings)
        {
            var request = new RestRequest();

            return request; 
        }
    }
}
