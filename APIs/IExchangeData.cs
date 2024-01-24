using ExchangeRateApp.Models.DTOs;

namespace ExchangeRateApp.APIs
{
    public interface IExchangeData
    {
        Task<IEnumerable<ExchangeRateDTO>> FetchExchangeDataAsync();
    }
}