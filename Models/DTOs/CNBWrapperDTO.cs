using ExchangeRateApp.Models.Domain;

namespace ExchangeRateApp.Models.DTOs
{
    public class CNBWrapperDTO
    {
        public required CNBRateResponseDTO[] Rates { get; init; }

        public IEnumerable<ExchangeRate> ConvertToDomainModel()
        {
            return Rates.Select(r => new ExchangeRate
            {
                SourceCurrency = new Currency(r.CurrencyCode),
                TargetCurrency = new Currency("CZK"),
                Value = r.Rate
            }) ;
        }
    }
}
