namespace ExchangeRateApp.Models.Domain
{
    public class ExchangeRate
    {
        public Currency SourceCurrency { get; init; } 

        public Currency TargetCurrency { get; init; }

        public decimal Value { get; init; }
        public override string ToString()
        {
            return $"{SourceCurrency}/{TargetCurrency}={Value}";
        }
    }
}
