using ExchangeRateApp.APIs;
using ExchangeRateApp.Models.Domain;

namespace ExchangeRateApp.Domain
{
    public class ExchangeRateProvider(IExchangeData data) : IExchangeRateProvider
    {
        private IExchangeData Data { get; set; } = data;

        public async Task<IEnumerable<ExchangeRate>> GetExchangeRatesAsync(IEnumerable<Currency> currencies)
        {
            var rawData = await Data.FetchExchangeDataAsync();
            var exchangeRates = rawData.Where(d => currencies.Any(c => c.Code == d.CurrencyCode))
                                       .Select(d =>
                                       {
                                           return new ExchangeRate
                                           {
                                               SourceCurrency = new Currency(d.CurrencyCode),
                                               TargetCurrency = new Currency("CZK"),
                                               Value = d.Rate
                                           };

                                       });
            return exchangeRates;
        }
    }
}
