namespace ExchangeRateApp.Models.DTOs
{
    public class ExchangeRateDTO
    {
        public string SourceCurrency {  get; init; }
        public string TargetCurrency { get; init; }
        public decimal Value { get; init; }
    }
}
