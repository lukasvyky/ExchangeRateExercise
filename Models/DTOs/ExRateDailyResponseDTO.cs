using System.Text.Json.Serialization;

namespace ExchangeRateApp.Models.DTOs
{
    public class ExRateDailyResponseDTO
    {
        public Int64? Amount { get; set; }
        public string? Country { get; set; }
        public string? Currency { get; set; }
        public required string CurrencyCode { get; set; }
        public int? Order { get; set; }
        public required decimal Rate { get; set; }
        public string? ValidFor { get; set; }
    }
}
