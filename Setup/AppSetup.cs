using ExchangeRateApp.APIs;
using ExchangeRateApp.Domain;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;



namespace ExchangeRateApp.Setup
{
    public static class AppSetup
    {
        public static IServiceProvider ConfigureServices() //accept args, decide what provider and whether offline or online
        {
            IConfiguration config = new ConfigurationBuilder()
                                    .AddJsonFile("setup/appsettings.json", optional: false, reloadOnChange: true)
                                    .Build();

            IServiceCollection services = new ServiceCollection();
            services.AddSingleton((_) => config);
            services.AddSingleton<IExchangeRateProvider, ExchangeRateProvider>();
            services.AddSingleton<IApp, App>();
            services.AddSingleton<IExchangeData, CNBExchangeData>();
            services.AddCustomHttpClient(config);


            return services.BuildServiceProvider();
        }

        public static void AddCustomHttpClient(this IServiceCollection services, IConfiguration config)
        {
            var baseUri = "https://" + config.GetSection("cnb").GetChildren().First(e => e.Key.Equals("BaseRoute")).Value;

            services.AddHttpClient("httpClient",(client) =>
            {
                client.BaseAddress = new Uri(baseUri ?? string.Empty);
                client.Timeout = TimeSpan.FromSeconds(5);
            });
        }
    }
}
