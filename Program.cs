using ExchangeRateApp.Setup;
using Microsoft.Extensions.DependencyInjection;

namespace ExchangeRateApp
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            var application = AppSetup.ConfigureServices().GetService<IApp>();
            await application.RunAsync();
        }
    }
}
