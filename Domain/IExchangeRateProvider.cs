using ExchangeRateApp.Models.Domain;

namespace ExchangeRateApp.Domain
{
    public interface IExchangeRateProvider
    {
        Task<IEnumerable<ExchangeRate>> GetExchangeRatesAsync(IEnumerable<Currency> currencies);
    }
}