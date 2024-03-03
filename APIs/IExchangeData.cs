using ExchangeRateApp.Models.Domain;

namespace ExchangeRateApp.APIs
{
    public interface IExchangeData
    {
        Task<IEnumerable<ExchangeRate>?> FetchExchangeDataAsync();
    }
}