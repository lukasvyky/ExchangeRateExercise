using ExchangeRateApp.Domain;
using ExchangeRateApp.Models.Domain;
using Microsoft.Extensions.Configuration;


namespace ExchangeRateApp
{
    public class App(IExchangeRateProvider provider, IConfiguration config) : IApp
    {
        public IExchangeRateProvider Provider { get; private set; } = provider;
        public IConfiguration Configuration { get; private set; } = config;

        public async Task RunAsync()
        {
            var inputCurrencies = GetInputCurrencies();

            var exchangeRates = await Provider.GetExchangeRatesAsync(inputCurrencies ?? []);
            
            foreach (var exchangeRate in exchangeRates)
            {
                Console.WriteLine(exchangeRate);
            }

            Console.WriteLine("\nThanks for using our app");
            Thread.Sleep(3000);
        }

        private IEnumerable<Currency>? GetInputCurrencies() // bind this to config?
        {
            var codes = Configuration.GetSection("Currencies").Get<List<string>>();
            return codes?.Select(c => new Currency(c));
        }
    }
}
