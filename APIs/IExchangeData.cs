using ExchangeRateApp.Models.Domain;
using ExchangeRateApp.Models.DTOs;

namespace ExchangeRateApp.APIs
{
    public interface IExchangeData
    {
        Task<IEnumerable<ExRateDailyResponseDTO>> FetchExchangeDataAsync();
    }
}