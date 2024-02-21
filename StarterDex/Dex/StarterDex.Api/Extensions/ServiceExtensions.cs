using Microsoft.Extensions.Configuration;
using StarterDex.Domain.Settings;

namespace StarterDex.Server.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            var identitySettingsSection = configuration.GetSection("Moralis");
            services.Configure<MoralisSettings>(identitySettingsSection);

        }
    }
}
