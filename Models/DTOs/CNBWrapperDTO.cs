using System.Text.Json.Serialization;

namespace ExchangeRateApp.Models.DTOs
{
    public class CNBWrapperDTO
    {
        public required CNBRateResponseDTO[] Rates { get; init; }

        public IEnumerable<ExchangeRateDTO> ConvertToDomainModel()
        {
            return Rates.Select(r => new ExchangeRateDTO
            {
                SourceCurrency = "CZK",
                TargetCurrency = r.CurrencyCode,
                Value = r.Rate
            });
        }
    }
}
