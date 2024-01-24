using System.Text.Json.Serialization;

namespace ExchangeRateApp.Models.DTOs
{
    public class ExRateWrapperDTO
    {
        public required ExRateDailyResponseDTO[] Rates { get; set; }
    }
}
